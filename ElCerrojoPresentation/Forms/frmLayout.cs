using ElCerrojoPresentation.Utils;
using Microsoft.Extensions.DependencyInjection;

namespace ElCerrojoPresentation.Forms
{
    public partial class frmLayout : Form
    {
        private readonly IServiceProvider _serviceProvider;

        public frmLayout(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }

        private void ShowForm<TForm>() where TForm : Form
        {
            if (pnlMain.Controls.Count > 0)
            {
                pnlMain.Controls[0].Dispose();
            }

            var newForm = _serviceProvider.GetRequiredService<TForm>();

            newForm.TopLevel = false;
            newForm.TopMost = false;
            newForm.FormBorderStyle = FormBorderStyle.None;
            newForm.Dock = DockStyle.Fill;

            pnlMain.Controls.Add(newForm);
            newForm.Show();
        }

        private void frmLayout_Load(object sender, EventArgs e)
        {
            msMenu.Renderer = new CustomToolStripRenderer();

            var menues = new ToolStripMenuItem[] { mnSales, mnProducts, mnCateg, mnHisto, mnReports, mnConfig };


        }

        private void mnSales_Click(object sender, EventArgs e)
        {
            ShowForm<frmVenta>();
        }

        private void mnProducts_Click(object sender, EventArgs e)
        {
            ShowForm<frmProducto>();
        }

        private void mnCateg_Click(object sender, EventArgs e)
        {
            ShowForm<frmGestion>();
        }

        private void mnHisto_Click(object sender, EventArgs e)
        {
            ShowForm<frmHistorialVenta>();
        }

        private void mnReports_Click(object sender, EventArgs e)
        {
            ShowForm<frmReporteVenta>();
        }

        private void mnConfig_Click(object sender, EventArgs e)
        {
            ShowForm<frmConfiguracion>();
        }
    }
}
