namespace ElCerrojoPresentation.Forms
{
    partial class frmReporteVenta
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
            dgvSaleExcel = new DataGridView();
            btnExcel = new Button();
            dateHistoE = new DateTimePicker();
            label2 = new Label();
            dateHistoI = new DateTimePicker();
            lblSaleProd = new Label();
            label1 = new Label();
            btnSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSaleExcel).BeginInit();
            SuspendLayout();
            // 
            // dgvSaleExcel
            // 
            dgvSaleExcel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSaleExcel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSaleExcel.Location = new Point(20, 105);
            dgvSaleExcel.Name = "dgvSaleExcel";
            dgvSaleExcel.Size = new Size(725, 290);
            dgvSaleExcel.TabIndex = 25;
            // 
            // btnExcel
            // 
            btnExcel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExcel.Cursor = Cursors.Hand;
            btnExcel.FlatStyle = FlatStyle.Flat;
            btnExcel.Location = new Point(665, 70);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(75, 23);
            btnExcel.TabIndex = 24;
            btnExcel.Text = "Excel";
            btnExcel.UseVisualStyleBackColor = true;
            btnExcel.Click += btnExcel_Click;
            // 
            // dateHistoE
            // 
            dateHistoE.CustomFormat = "";
            dateHistoE.Font = new Font("Segoe UI", 10F);
            dateHistoE.Format = DateTimePickerFormat.Short;
            dateHistoE.Location = new Point(228, 70);
            dateHistoE.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            dateHistoE.MinDate = new DateTime(2020, 1, 1, 0, 0, 0, 0);
            dateHistoE.Name = "dateHistoE";
            dateHistoE.Size = new Size(200, 25);
            dateHistoE.TabIndex = 21;
            dateHistoE.Value = new DateTime(2025, 12, 9, 21, 44, 1, 0);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(228, 50);
            label2.Margin = new Padding(5);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 20;
            label2.Text = "Fecha desde:";
            // 
            // dateHistoI
            // 
            dateHistoI.CustomFormat = "";
            dateHistoI.Font = new Font("Segoe UI", 10F);
            dateHistoI.Format = DateTimePickerFormat.Short;
            dateHistoI.Location = new Point(22, 70);
            dateHistoI.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            dateHistoI.MinDate = new DateTime(2020, 1, 1, 0, 0, 0, 0);
            dateHistoI.Name = "dateHistoI";
            dateHistoI.Size = new Size(200, 25);
            dateHistoI.TabIndex = 19;
            dateHistoI.Value = new DateTime(2025, 12, 9, 21, 43, 44, 0);
            // 
            // lblSaleProd
            // 
            lblSaleProd.AutoSize = true;
            lblSaleProd.Location = new Point(22, 50);
            lblSaleProd.Margin = new Padding(5);
            lblSaleProd.Name = "lblSaleProd";
            lblSaleProd.Size = new Size(75, 15);
            lblSaleProd.TabIndex = 18;
            lblSaleProd.Text = "Fecha desde:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 17;
            label1.Text = "Reporte de Venta";
            // 
            // btnSearch
            // 
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Location = new Point(438, 70);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 26;
            btnSearch.Text = "Buscar";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // frmReporteVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(764, 407);
            Controls.Add(btnSearch);
            Controls.Add(dgvSaleExcel);
            Controls.Add(btnExcel);
            Controls.Add(dateHistoE);
            Controls.Add(label2);
            Controls.Add(dateHistoI);
            Controls.Add(lblSaleProd);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmReporteVenta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmReporteVenta";
            Load += frmReporteVenta_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSaleExcel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvSaleExcel;
        private Button btnExcel;
        private DateTimePicker dateHistoE;
        private Label label2;
        private DateTimePicker dateHistoI;
        private Label lblSaleProd;
        private Label label1;
        private Button btnSearch;
    }
}