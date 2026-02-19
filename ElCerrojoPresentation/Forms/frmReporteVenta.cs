using ClosedXML.Excel;
using ElCerrojoPresentation.Utils.Customs;
using ElCerrojoPresentation.ViewModels;
using ElCerrojoServices.Interfaces;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace ElCerrojoPresentation.Forms
{
    public partial class frmReporteVenta : Form
    {
        private readonly ISaleService _saleService;

        public frmReporteVenta(ISaleService saleService)
        {
            InitializeComponent();
            _saleService = saleService;
        }

        private void frmReporteVenta_Load(object sender, EventArgs e)
        {
            var dateToday = DateTime.Today;
            var month = dateToday.Month;
            var year = dateToday.Year;
            var lastDay = DateTime.DaysInMonth(year, month);

            dateHistoI.Value = new DateTime(year, month, 1);
            dateHistoE.Value = new DateTime(year, month, lastDay);

            dgvSaleExcel.ImplementConfig();
            dgvSaleExcel.DataSource = new List<SaleReportVM>();
            dgvSaleExcel.Columns["ProductName"].FillWeight = 350;
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            var saleList = await _saleService.GetReportDetails(
                DateOnly.FromDateTime(dateHistoI.Value),
                DateOnly.FromDateTime(dateHistoE.Value));

            var listVM = saleList.SelectMany(s => s.Details.Select(x => new SaleReportVM()
                                                                    {
                                                                        SaleNumber = s.SaleNum,
                                                                        Date = s.Date,
                                                                        ProductName = x.ProductName,
                                                                        Quantity = x.Quantity,
                                                                        TotalPrice = x.TotalPrice
                                                                    })).ToList();

            dgvSaleExcel.DataSource = listVM;
            dgvSaleExcel.ClearSelection();
            dgvSaleExcel.Columns["ProductName"].FillWeight = 350;
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (dgvSaleExcel.Rows.Count == 0)
            {
                MessageBox.Show("No hay resultados");
                return;
            }

            DataTable table = new DataTable();
            var listDetail = (List<SaleReportVM>)dgvSaleExcel.DataSource;

            foreach (DataGridViewColumn column in dgvSaleExcel.Columns)
            {
                table.Columns.Add(column.HeaderText, typeof(string));
            }

            foreach (var item in listDetail)
            {
                table.Rows.Add(
                    item.SaleNumber,
                    item.Date,
                    item.ProductName,
                    item.UnitPrice,
                    item.Quantity,
                    item.TotalPrice
                    );
            }

            using (SaveFileDialog saveFile = new SaveFileDialog())
            {
                saveFile.FileName = $"ReporteVenta-{DateTime.Now.ToString("ddMMyyyyHHmmss")}.xlsx";
                saveFile.Filter = "Excel files|*.xlsx";

                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        XLWorkbook wb = new XLWorkbook();
                        var sheet = wb.Worksheets.Add(table, "Reporte");

                        sheet.ColumnsUsed().AdjustToContents();
                        wb.SaveAs(saveFile.FileName);

                        MessageBox.Show("Reporte generado", "Mensaje", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                    }
                    catch
                    {
                        MessageBox.Show("Error al generar reporte", "Mensaje", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                    }
                }
            }
        }
    }
}
