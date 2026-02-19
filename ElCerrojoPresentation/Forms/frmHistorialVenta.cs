using ElCerrojoPresentation.Utils.Customs;
using ElCerrojoPresentation.ViewModels;
using ElCerrojoServices.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace ElCerrojoPresentation.Forms
{
    public partial class frmHistorialVenta : Form
    {
        private readonly ISaleService _saleService;
        private readonly IServiceProvider _serviceProvider;

        public frmHistorialVenta(ISaleService saleService, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _saleService = saleService;
            _serviceProvider = serviceProvider;
        }

        private async Task ShowSales()
        {
            var saleList = await _saleService.GetSales(
                DateOnly.FromDateTime(dateHistoI.Value),
                DateOnly.FromDateTime(dateHistoE.Value),
                txbSearch.Text.Trim());

            var saleListVM = saleList.Select(x => new SaleVM()
            {
                Id = x.Id,
                Date = x.Date,
                SaleNum = x.Id.ToString("00000000"),
                ClientName = x.ClientName,
                TotalPrice = x.TotalPrice
            }).ToList();

            dgvSaleDetail.DataSource = saleListVM;
            dgvSaleDetail.ClearSelection();
        }

        private void frmHistorialVenta_Load(object sender, EventArgs e)
        {
            var dateToday = DateTime.Today;
            var month = dateToday.Month;
            var year = dateToday.Year;
            var lastDay = DateTime.DaysInMonth(year, month);

            dateHistoI.Value = new DateTime(year, month, 1);
            dateHistoE.Value = new DateTime(year, month, lastDay);

            dgvSaleDetail.DataSource = new List<SaleVM>();
            dgvSaleDetail.Columns["Id"].Visible = false;
            dgvSaleDetail.ImplementConfig("Ver");
            dgvSaleDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvSaleDetail.ClearSelection();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            await ShowSales();
        }

        private void dgvSaleDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSaleDetail.Columns[e.ColumnIndex].Name == CustomDataGridView.ActionNameSimple)
            {
                var selectedRow = (SaleVM)dgvSaleDetail.CurrentRow.DataBoundItem;

                var frmDetail = _serviceProvider.GetRequiredService<frmDetalleVenta>();
                frmDetail._ventaId = selectedRow.Id;
                frmDetail.ShowDialog();
            }
        }
    }
}
