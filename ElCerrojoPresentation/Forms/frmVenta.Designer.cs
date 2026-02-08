using ElCerrojoPresentation.Utils;

namespace ElCerrojoPresentation.Forms
{
    partial class frmVenta
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
            txbSaleProd = new TextBox();
            lblSaleProd = new Label();
            txbSaleClient = new TextBox();
            lblSaleClient = new Label();
            txbSellPay = new TextBox();
            lblSalePay = new Label();
            txbSellChange = new TextBox();
            lblSellChange = new Label();
            label5 = new Label();
            label6 = new Label();
            lblTotal = new Label();
            btnSearch = new Button();
            dgvSaleDetail = new DataGridView();
            btnSaleSave = new Button();
            splitContainer1 = new SplitContainer();
            ((System.ComponentModel.ISupportInitialize)dgvSaleDetail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 2;
            label1.Text = "Nueva Venta";
            // 
            // txbSaleProd
            // 
            txbSaleProd.Dock = DockStyle.Fill;
            txbSaleProd.Font = new Font("Segoe UI", 10F);
            txbSaleProd.Location = new Point(0, 0);
            txbSaleProd.Margin = new Padding(5);
            txbSaleProd.Name = "txbSaleProd";
            txbSaleProd.PlaceholderText = "Ingrese el codigo de producto o presione Buscar";
            txbSaleProd.Size = new Size(382, 25);
            txbSaleProd.TabIndex = 4;
            txbSaleProd.KeyDown += txbSaleProd_KeyDown;
            // 
            // lblSaleProd
            // 
            lblSaleProd.AutoSize = true;
            lblSaleProd.Location = new Point(22, 50);
            lblSaleProd.Margin = new Padding(5);
            lblSaleProd.Name = "lblSaleProd";
            lblSaleProd.Size = new Size(59, 15);
            lblSaleProd.TabIndex = 3;
            lblSaleProd.Text = "Producto:";
            // 
            // txbSaleClient
            // 
            txbSaleClient.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txbSaleClient.Font = new Font("Segoe UI", 10F);
            txbSaleClient.Location = new Point(12, 120);
            txbSaleClient.Margin = new Padding(5);
            txbSaleClient.Name = "txbSaleClient";
            txbSaleClient.PlaceholderText = "Ingrese el nombre de cliente";
            txbSaleClient.Size = new Size(481, 25);
            txbSaleClient.TabIndex = 6;
            // 
            // lblSaleClient
            // 
            lblSaleClient.AutoSize = true;
            lblSaleClient.Location = new Point(22, 100);
            lblSaleClient.Margin = new Padding(5);
            lblSaleClient.Name = "lblSaleClient";
            lblSaleClient.Size = new Size(47, 15);
            lblSaleClient.TabIndex = 5;
            lblSaleClient.Text = "Cliente:";
            // 
            // txbSellPay
            // 
            txbSellPay.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txbSellPay.Font = new Font("Segoe UI", 10F);
            txbSellPay.Location = new Point(273, 354);
            txbSellPay.Margin = new Padding(5);
            txbSellPay.Name = "txbSellPay";
            txbSellPay.PlaceholderText = "Monto del pago";
            txbSellPay.Size = new Size(155, 25);
            txbSellPay.TabIndex = 8;
            txbSellPay.TextChanged += txbSellPay_TextChanged;
            // 
            // lblSalePay
            // 
            lblSalePay.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblSalePay.AutoSize = true;
            lblSalePay.Location = new Point(203, 359);
            lblSalePay.Margin = new Padding(5);
            lblSalePay.Name = "lblSalePay";
            lblSalePay.Size = new Size(60, 15);
            lblSalePay.TabIndex = 7;
            lblSalePay.Text = "Pago con:";
            // 
            // txbSellChange
            // 
            txbSellChange.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txbSellChange.Font = new Font("Segoe UI", 10F);
            txbSellChange.Location = new Point(492, 354);
            txbSellChange.Margin = new Padding(5);
            txbSellChange.Name = "txbSellChange";
            txbSellChange.ReadOnly = true;
            txbSellChange.Size = new Size(162, 25);
            txbSellChange.TabIndex = 10;
            // 
            // lblSellChange
            // 
            lblSellChange.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblSellChange.AutoSize = true;
            lblSellChange.Location = new Point(438, 359);
            lblSellChange.Margin = new Padding(5);
            lblSellChange.Name = "lblSellChange";
            lblSellChange.Size = new Size(44, 15);
            lblSellChange.TabIndex = 9;
            lblSellChange.Text = "Vuelto:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.BackColor = Color.FromArgb(255, 196, 0);
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label5.Location = new Point(592, 50);
            label5.Name = "label5";
            label5.Size = new Size(145, 95);
            label5.TabIndex = 11;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.BackColor = Color.FromArgb(255, 196, 0);
            label6.Font = new Font("Segoe UI", 18F);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(629, 50);
            label6.Margin = new Padding(5);
            label6.Name = "label6";
            label6.Size = new Size(70, 32);
            label6.TabIndex = 12;
            label6.Text = "Total:";
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTotal.BackColor = Color.FromArgb(255, 196, 0);
            lblTotal.Font = new Font("Segoe UI", 18F);
            lblTotal.ForeColor = Color.Black;
            lblTotal.Location = new Point(592, 92);
            lblTotal.Margin = new Padding(5);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(145, 32);
            lblTotal.TabIndex = 13;
            lblTotal.Text = "0";
            lblTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSearch
            // 
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.Dock = DockStyle.Fill;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Location = new Point(0, 0);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(95, 25);
            btnSearch.TabIndex = 14;
            btnSearch.Text = "Buscar";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvSaleDetail
            // 
            dgvSaleDetail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSaleDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSaleDetail.Location = new Point(12, 153);
            dgvSaleDetail.Name = "dgvSaleDetail";
            dgvSaleDetail.Size = new Size(725, 193);
            dgvSaleDetail.TabIndex = 15;
            dgvSaleDetail.CellContentClick += dgvSaleDetail_CellContentClick;
            // 
            // btnSaleSave
            // 
            btnSaleSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSaleSave.Cursor = Cursors.Hand;
            btnSaleSave.FlatStyle = FlatStyle.Flat;
            btnSaleSave.ForeColor = Color.FromArgb(30, 90, 195);
            btnSaleSave.Location = new Point(662, 354);
            btnSaleSave.Name = "btnSaleSave";
            btnSaleSave.Size = new Size(75, 25);
            btnSaleSave.TabIndex = 16;
            btnSaleSave.Text = "Registrar";
            btnSaleSave.UseVisualStyleBackColor = true;
            btnSaleSave.Click += btnSaleSave_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            splitContainer1.FixedPanel = FixedPanel.Panel2;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(12, 70);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(txbSaleProd);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(btnSearch);
            splitContainer1.Size = new Size(481, 25);
            splitContainer1.SplitterDistance = 382;
            splitContainer1.TabIndex = 17;
            // 
            // frmVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(764, 407);
            Controls.Add(splitContainer1);
            Controls.Add(btnSaleSave);
            Controls.Add(dgvSaleDetail);
            Controls.Add(lblTotal);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txbSellChange);
            Controls.Add(lblSellChange);
            Controls.Add(txbSellPay);
            Controls.Add(lblSalePay);
            Controls.Add(txbSaleClient);
            Controls.Add(lblSaleClient);
            Controls.Add(lblSaleProd);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmVenta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmVenta";
            Load += frmVenta_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSaleDetail).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txbSaleProd;
        private Label lblSaleProd;
        private TextBox txbSaleClient;
        private Label lblSaleClient;
        private TextBox txbSellPay;
        private Label lblSalePay;
        private TextBox txbSellChange;
        private Label lblSellChange;
        private Label label5;
        private Label label6;
        private Label lblTotal;
        private Button btnSearch;
        private DataGridView dgvSaleDetail;
        private Button btnSaleSave;
        private SplitContainer splitContainer1;
    }
}