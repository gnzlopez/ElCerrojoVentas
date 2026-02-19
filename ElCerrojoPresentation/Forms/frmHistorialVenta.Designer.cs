namespace ElCerrojoPresentation.Forms
{
    partial class frmHistorialVenta
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
            label1 = new Label();
            lblSaleProd = new Label();
            dateHistoI = new DateTimePicker();
            dateHistoE = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            txbSearch = new TextBox();
            btnSearch = new Button();
            dgvSaleDetail = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvSaleDetail).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 3;
            label1.Text = "Historial";
            // 
            // lblSaleProd
            // 
            lblSaleProd.AutoSize = true;
            lblSaleProd.Location = new Point(22, 50);
            lblSaleProd.Margin = new Padding(5);
            lblSaleProd.Name = "lblSaleProd";
            lblSaleProd.Size = new Size(75, 15);
            lblSaleProd.TabIndex = 4;
            lblSaleProd.Text = "Fecha desde:";
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
            dateHistoI.TabIndex = 5;
            dateHistoI.Value = new DateTime(2025, 12, 1, 0, 0, 0, 0);
            // 
            // dateHistoE
            // 
            dateHistoE.CustomFormat = "";
            dateHistoE.Font = new Font("Segoe UI", 10F);
            dateHistoE.Format = DateTimePickerFormat.Custom;
            dateHistoE.Location = new Point(228, 70);
            dateHistoE.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            dateHistoE.MinDate = new DateTime(2020, 1, 1, 0, 0, 0, 0);
            dateHistoE.Name = "dateHistoE";
            dateHistoE.Size = new Size(200, 25);
            dateHistoE.TabIndex = 7;
            dateHistoE.Value = new DateTime(2025, 1, 1, 0, 0, 0, 0);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(228, 50);
            label2.Margin = new Padding(5);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 6;
            label2.Text = "Fecha desde:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(436, 50);
            label3.Margin = new Padding(5);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 8;
            label3.Text = "Encontrar:";
            // 
            // txbSearch
            // 
            txbSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txbSearch.Font = new Font("Segoe UI", 10F);
            txbSearch.Location = new Point(436, 70);
            txbSearch.Name = "txbSearch";
            txbSearch.Size = new Size(228, 25);
            txbSearch.TabIndex = 9;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Location = new Point(670, 70);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 25);
            btnSearch.TabIndex = 15;
            btnSearch.Text = "Buscar";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvSaleDetail
            // 
            dgvSaleDetail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSaleDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSaleDetail.Location = new Point(20, 105);
            dgvSaleDetail.Name = "dgvSaleDetail";
            dgvSaleDetail.Size = new Size(725, 290);
            dgvSaleDetail.TabIndex = 16;
            dgvSaleDetail.CellContentClick += dgvSaleDetail_CellContentClick;
            // 
            // frmHistorialVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(764, 407);
            Controls.Add(dgvSaleDetail);
            Controls.Add(btnSearch);
            Controls.Add(txbSearch);
            Controls.Add(label3);
            Controls.Add(dateHistoE);
            Controls.Add(label2);
            Controls.Add(dateHistoI);
            Controls.Add(lblSaleProd);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmHistorialVenta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmHistorialVenta";
            Load += frmHistorialVenta_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSaleDetail).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblSaleProd;
        private DateTimePicker dateHistoI;
        private DateTimePicker dateHistoE;
        private Label label2;
        private Label label3;
        private TextBox txbSearch;
        private Button btnSearch;
        private DataGridView dgvSaleDetail;
    }
}