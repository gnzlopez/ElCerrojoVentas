using ClosedXML.Excel;
using ElCerrojoServices.DTOs;
using ElCerrojoServices.Interfaces;

namespace ElCerrojoPresentation.Forms
{
    public partial class frmConfiguracion : Form
    {
        private readonly IProductService _productoService;
        private readonly IBrandService _brandService;
        private readonly ICategoryService _categoryService;
        private readonly ICommonService _commonService;

        public frmConfiguracion(IProductService productoService, IBrandService brandService, ICategoryService categoryService, ICommonService commonService)
        {
            InitializeComponent();
            _productoService = productoService;
            _brandService = brandService;
            _categoryService = categoryService;
            _commonService = commonService;
        }

        private void btnInExcel_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Archivos Excel (*.xlsx)|*.xlsx";
                ofd.Title = "Seleccionar archivo Excel";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string rutaArchivo = ofd.FileName;

                    // Llamamos al método que lee el Excel
                    ReadExcel(rutaArchivo);
                }
            }
        }

        private async void ReadExcel(string path)
        {
            var progress = new Progress<int>(value =>
            {
                progressBar.Value = value;
                lblProgress.Text = $"Procesando {value}%";
            });

            btnInExcel.Enabled = false;
            btnOutExcel.Enabled = false;

            try
            {
                await _commonService.ImportExcel(path, progress);

                MessageBox.Show("Excel leído correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer el archivo: " + ex.Message);
            }
            finally
            {
                progressBar.Value = 0;
                lblProgress.Text = string.Empty;
                btnInExcel.Enabled = true;
                btnOutExcel.Enabled = true;
            }
        }
    }
}
