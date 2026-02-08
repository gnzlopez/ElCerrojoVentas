using ElCerrojoPresentation.Utils;
using ElCerrojoPresentation.ViewModels;
using ElCerrojoServices.DTOs;
using ElCerrojoServices.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualBasic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;

namespace ElCerrojoPresentation.Forms
{
    public partial class frmVenta : Form
    {
        private readonly IProductService _productService;
        private readonly ISaleService _saleService;
        private readonly IServiceProvider _serviceProvider;
        private BindingList<SaleDetailVM> _saleDetail = new BindingList<SaleDetailVM>();

        public frmVenta(IProductService productService,
                        ISaleService saleService,
                        IServiceProvider serviceProvider
            )
        {
            InitializeComponent();

            _productService = productService;
            _saleService = saleService;
            _serviceProvider = serviceProvider;
        }

        private void frmVenta_Load(object sender, EventArgs e)
        {
            txbSellChange.Text = "0,00";

            dgvSaleDetail.DataSource = _saleDetail;
            dgvSaleDetail.ImplementConfig("Eliminar");
            dgvSaleDetail.Columns["Id"].Visible = false;
            dgvSaleDetail.Columns["SaleId"].Visible = false;
            dgvSaleDetail.Columns["ProductId"].Visible = false;
            dgvSaleDetail.Columns["ProductName"].FillWeight = 350;
            dgvSaleDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            txbSellPay.ValidateDecimalNumber();

            txbSaleProd.Focus();
        }

        private async Task AddProduct(string prodCode)
        {
            var prod = await _productService.GetByCode(prodCode);
            if (prod == null || prod.Id < 1)
            {
                txbSaleProd.BackColor = Color.Red;
                return;
            }

            txbSaleProd.BackColor = SystemColors.Window;

            StringBuilder sb = new StringBuilder();
            sb.AppendLine(prod.Name);
            sb.AppendLine("Marca: " + prod.BrandName);
            sb.AppendLine("Precio: " + prod.Price.ToString("0.00"));
            sb.AppendLine();
            sb.AppendLine("Ingrese la cantidad: ");

            string qtyString = Interaction.InputBox(sb.ToString(), "Producto", "1");

            if (string.IsNullOrEmpty(qtyString))
            {
                return;
            }

            int qty;

            if (!int.TryParse(qtyString, out qty))
            {
                MessageBox.Show("El valor ingresado no es un numero");
                return;
            }

            var find = _saleDetail.FirstOrDefault(x => x.Id == prod.Id);

            if (find == null)
            {
                decimal totalPrice = qty * prod.Price;

                _saleDetail.Add(new SaleDetailVM()
                {
                    ProductId = prod.Id,
                    ProductName = prod.Name,
                    SalePrice = prod.Price,
                    Quantity = qty,
                    TotalPrice = totalPrice
                });
            }
            else
            {
                int index = _saleDetail.IndexOf(find);
                int totalQty = find.Quantity + qty;

                if (totalQty > prod.Stock)
                {
                    MessageBox.Show("La cantidad ingresada no puede ser mayor que el stock disponible");
                    return;
                }

                decimal totalPrice = totalQty * prod.Price;

                find.Quantity = totalQty;
                find.TotalPrice = totalPrice;

                _saleDetail[index] = find;
            }

            decimal saleTotal = _saleDetail.Sum(x => x.TotalPrice);
            lblTotal.Text = saleTotal.ToString("0.00");
            txbSaleProd.Text = "";

            txbSaleProd.Focus();
        }

        private async void txbSaleProd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                await AddProduct(txbSaleProd.Text);
            }
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            var formSearch = _serviceProvider.GetRequiredService<frmBuscarProducto>();
            var resultSearch = formSearch.ShowDialog();

            if (resultSearch == DialogResult.OK)
            {
                var selectedProd = formSearch._productoSelec;
                txbSaleProd.Text = selectedProd.BarCode;

                await AddProduct(selectedProd.BarCode);
                UpdateChange();
            }
        }

        private void dgvSaleDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSaleDetail.Columns[e.ColumnIndex].Name == CustomDataGridView.ActionNameSimple)
            {
                var selecteRow = (SaleDetailVM)dgvSaleDetail.CurrentRow.DataBoundItem;

                var index = _saleDetail.IndexOf(selecteRow);
                _saleDetail.RemoveAt(index);

                decimal saleTotal = _saleDetail.Sum(x => x.TotalPrice);
                lblTotal.Text = saleTotal.ToString("0.00");
                UpdateChange();
            }
        }

        private async void btnSaleSave_Click(object sender, EventArgs e)
        {
            if (_saleDetail.Count == 0)
            {
                MessageBox.Show("No hay productos");
                txbSaleProd.Focus();
                return;
            }

            decimal tempTotal = _saleDetail.Sum(x => x.TotalPrice);

            var totalPrice = Convert.ToDecimal(tempTotal.ToString("0.00"));

            var sellPay = txbSellPay.Text.Trim() == "" ? totalPrice : Convert.ToDecimal(txbSellPay.Text.Trim());
            var change = txbSellChange.Text.Trim() == "" ? 0 : Convert.ToDecimal(txbSellChange.Text.Trim());

            var newSale = new SaleDto()
            {
                ClientName = txbSaleClient.Text.Trim(),
                TotalPrice = totalPrice,
                PayPrice = sellPay,
                ChangePrice = change,
                Date = DateOnly.FromDateTime(DateTime.Now),
                Details = _saleDetail.Select(x => new SaleDetailDto()
                {
                    ProductId = x.ProductId,
                    Quantity = x.Quantity,
                    SalePrice = x.SalePrice,
                    TotalPrice = x.TotalPrice
                }).ToList()
            };

            var saleId = await _saleService.Register(newSale);

            if (saleId < 1)
            {
                MessageBox.Show("No se pudo guardar la venta correctamente");
                return;
            }

            txbSaleProd.Text = "";
            txbSaleClient.Text = "";
            _saleDetail.Clear();
            txbSellPay.Text = "";
            txbSellChange.Text = "";
            txbSaleProd.Select();

            DialogResult result = MessageBox.Show(
                $"Venta numero {saleId:00000000}. Desea visualizar el documento?",
                "Registrado correctamente",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information);

            var oSale = await _saleService.GetSale(saleId);

            if (oSale == null)
            {
                MessageBox.Show("No se pudo generar el PDF");
                return;
            }

            var arrayPDF = Util.GenerateSalePDF(oSale, Stream.Null);

            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/VentasSistema/";

            // Si no existe, creo la carpeta de documentos de ventas
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            var fileName = $"{path}{oSale.Id:00000000}-{oSale.Date.ToString("yyMMdd")}.pdf";

            await File.WriteAllBytesAsync(fileName, arrayPDF);

            if (result == DialogResult.Yes)
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = fileName,
                    UseShellExecute = true
                });
            }
        }

        private void txbSellPay_TextChanged(object sender, EventArgs e)
        {
            UpdateChange();
        }

        private void UpdateChange()
        {
            decimal pay;
            decimal total = _saleDetail.Sum(x => x.TotalPrice);

            if (txbSellPay.Text.Trim() != "")
            {
                if (decimal.TryParse(txbSellPay.Text.Trim(), out pay))
                {
                    if (pay < total || _saleDetail.Count() == 0)
                    {
                        txbSellChange.Text = "0,00";
                    }
                    else
                    {
                        txbSellChange.Text = (pay - total).ToString("0.00");
                    }
                }
            }

            txbSaleProd.Focus();
        }
    }
}
