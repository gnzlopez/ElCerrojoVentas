using ElCerrojoPresentation.Utils.Customs;
using ElCerrojoPresentation.ViewModels;
using ElCerrojoServices.Interfaces;

namespace ElCerrojoPresentation.Forms
{
    public partial class frmBuscarProducto : Form
    {
        private IProductService _productoService;
        private IBrandService _marcaService;

        public ProductVM _productoSelec { get; set; }

        public frmBuscarProducto(IProductService productoService, IBrandService marcaService)
        {
            InitializeComponent();
            _productoService = productoService;
            _marcaService = marcaService;
        }

        private async Task ShowProducts(string searchText)
        {
            var productList = await _productoService.GetByText(searchText);

            var listVM = productList.Select(x => new ProductVM
            {
                Id = x.Id,
                Name = x.Name,
                CategoryId = x.CategoryId ?? 0,
                CategoryName = x.CategoryName,
                BrandId = x.BrandId ?? 0,
                BrandName = x.BrandName,
                Price = x.Price,
                BuyPrice = x.BuyPrice,
                BarCode = x.BarCode,
                Stock = x.Stock
            }).ToList();

            dgvProductList.DataSource = listVM;

            dgvProductList.ClearSelection();

            dgvProductList.Columns["Id"].Visible = false;
            dgvProductList.Columns["CategoryId"].Visible = false;
            dgvProductList.Columns["BrandId"].Visible = false;
            dgvProductList.Columns["BuyPrice"].Visible = false;
            dgvProductList.Columns["BarCode"].Visible = false;

        }

        private async void frmBuscarProducto_LoadAsync(object sender, EventArgs e)
        {
            dgvProductList.ImplementConfig();

            await ShowProducts("");
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            await ShowProducts(txbSearch.Text.Trim());
        }

        private void dgvProductList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _productoSelec = (ProductVM)dgvProductList.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private async void txbSearch_TextChanged(object sender, EventArgs e)
        {
            await ShowProducts(txbSearch.Text.Trim());
        }
    }
}
