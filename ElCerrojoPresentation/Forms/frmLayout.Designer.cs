using ElCerrojoPresentation.Utils;

namespace ElCerrojoPresentation.Forms
{
    partial class frmLayout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            msMenu = new MenuStrip();
            mnSales = new ToolStripMenuItem();
            mnProducts = new ToolStripMenuItem();
            mnCateg = new ToolStripMenuItem();
            mnHisto = new ToolStripMenuItem();
            mnReports = new ToolStripMenuItem();
            mnConfig = new ToolStripMenuItem();
            pnlMain = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            msMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 196, 0);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(919, 91);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LogoPNG;
            pictureBox1.Location = new Point(30, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 82);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 196, 0);
            panel2.Controls.Add(msMenu);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 91);
            panel2.Name = "panel2";
            panel2.Size = new Size(155, 407);
            panel2.TabIndex = 1;
            // 
            // msMenu
            // 
            msMenu.BackColor = Color.FromArgb(255, 196, 0);
            msMenu.Items.AddRange(new ToolStripItem[] { mnSales, mnProducts, mnCateg, mnHisto, mnReports, mnConfig });
            msMenu.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
            msMenu.Location = new Point(0, 0);
            msMenu.Name = "msMenu";
            msMenu.Size = new Size(155, 385);
            msMenu.TabIndex = 0;
            msMenu.Text = "menuStrip1";
            // 
            // mnSales
            // 
            mnSales.AutoSize = false;
            mnSales.Margin = new Padding(5, 0, 5, 0);
            mnSales.Name = "mnSales";
            mnSales.Padding = new Padding(5, 0, 5, 0);
            mnSales.Size = new Size(148, 60);
            mnSales.Text = "Ventas";
            mnSales.Click += mnSales_Click;
            // 
            // mnProducts
            // 
            mnProducts.AutoSize = false;
            mnProducts.Margin = new Padding(5, 0, 5, 0);
            mnProducts.Name = "mnProducts";
            mnProducts.Padding = new Padding(5, 0, 5, 0);
            mnProducts.Size = new Size(148, 60);
            mnProducts.Text = "Productos";
            mnProducts.Click += mnProducts_Click;
            // 
            // mnCateg
            // 
            mnCateg.AutoSize = false;
            mnCateg.Name = "mnCateg";
            mnCateg.Size = new Size(148, 60);
            mnCateg.Text = "Gestiones";
            mnCateg.Click += mnCateg_Click;
            // 
            // mnHisto
            // 
            mnHisto.AutoSize = false;
            mnHisto.Name = "mnHisto";
            mnHisto.Size = new Size(148, 60);
            mnHisto.Text = "Historial";
            mnHisto.Click += mnHisto_Click;
            // 
            // mnReports
            // 
            mnReports.AutoSize = false;
            mnReports.Margin = new Padding(5, 0, 5, 0);
            mnReports.Name = "mnReports";
            mnReports.Padding = new Padding(5, 0, 5, 0);
            mnReports.Size = new Size(148, 60);
            mnReports.Text = "Reportes";
            mnReports.Click += mnReports_Click;
            // 
            // mnConfig
            // 
            mnConfig.AutoSize = false;
            mnConfig.Enabled = false;
            mnConfig.Margin = new Padding(5, 0, 5, 0);
            mnConfig.Name = "mnConfig";
            mnConfig.Padding = new Padding(5, 0, 5, 0);
            mnConfig.ShowShortcutKeys = false;
            mnConfig.Size = new Size(148, 60);
            mnConfig.Text = "Configuración";
            mnConfig.Click += mnConfig_Click;
            // 
            // pnlMain
            // 
            pnlMain.AutoSize = true;
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(155, 91);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(764, 407);
            pnlMain.TabIndex = 2;
            // 
            // frmLayout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(919, 498);
            Controls.Add(pnlMain);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MainMenuStrip = msMenu;
            MinimumSize = new Size(935, 537);
            Name = "frmLayout";
            Text = "frmLayout";
            Load += frmLayout_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            msMenu.ResumeLayout(false);
            msMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private MenuStrip msMenu;
        private ToolStripMenuItem mnSales;
        private ToolStripMenuItem mnProducts;
        private ToolStripMenuItem mnReports;
        private Panel pnlMain;
        private ToolStripMenuItem mnConfig;
        private ToolStripMenuItem mnCateg;
        private ToolStripMenuItem mnHisto;
        private PictureBox pictureBox1;
    }
}