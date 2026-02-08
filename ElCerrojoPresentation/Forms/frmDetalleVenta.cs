
using ElCerrojoPresentation.Utils;
using ElCerrojoPresentation.ViewModels;
using ElCerrojoServices.Interfaces;
using System.Diagnostics;

namespace ElCerrojoPresentation.Forms
{
    public partial class frmDetalleVenta : Form
    {
        private readonly ISaleService _saleService;
        public int _ventaId { get; set; }

        public frmDetalleVenta(ISaleService saleService)
        {
            InitializeComponent();
            _saleService = saleService;
        }

        private async void frmDetalleVenta_Load(object sender, EventArgs e)
        {
            dgvSaleDetail.ImplementConfig();
            dgvSaleDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            var saleDetails = await _saleService.GetDetails(_ventaId);

            var detailVM = saleDetails.Select(x => new SaleDetailVM()
            {   
                ProductId = x.ProductId,
                ProductName = x.ProductName,
                SalePrice = x.SalePrice,
                Quantity = x.Quantity,
                TotalPrice = x.TotalPrice
            }).ToList();

            lblSaleNum.Text = _ventaId.ToString("00000000");

            dgvSaleDetail.DataSource = detailVM;
            dgvSaleDetail.Columns["ProductId"].Visible = false;
            dgvSaleDetail.ClearSelection();
        }

        private async void btnViewPDF_Click(object sender, EventArgs e)
        {

            var oSale = await _saleService.GetSale(_ventaId);

            if (oSale == null)
            {
                MessageBox.Show("No se pudo generar el PDF");
                return;
            }

            var arrayPDF = Util.GenerateSalePDF(oSale, Stream.Null);

            var tempFile = Path.Combine(Path.GetTempPath(), $"{ oSale.Id:00000000}-{ oSale.Date.ToString("yyMMdd")}.pdf");
            File.WriteAllBytes(tempFile, arrayPDF);

            Process.Start(new ProcessStartInfo(tempFile) { UseShellExecute = true });

            File.Decrypt(tempFile);
        }
    }
}
