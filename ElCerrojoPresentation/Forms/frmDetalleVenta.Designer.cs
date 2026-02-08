namespace ElCerrojoPresentation.Forms
{
    partial class frmDetalleVenta
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
            dgvSaleDetail = new DataGridView();
            btnViewPDF = new Button();
            label1 = new Label();
            lblSaleNum = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSaleDetail).BeginInit();
            SuspendLayout();
            // 
            // dgvSaleDetail
            // 
            dgvSaleDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSaleDetail.Location = new Point(11, 37);
            dgvSaleDetail.Name = "dgvSaleDetail";
            dgvSaleDetail.Size = new Size(720, 275);
            dgvSaleDetail.TabIndex = 8;
            // 
            // btnViewPDF
            // 
            btnViewPDF.Cursor = Cursors.Hand;
            btnViewPDF.FlatStyle = FlatStyle.Flat;
            btnViewPDF.Location = new Point(656, 8);
            btnViewPDF.Name = "btnViewPDF";
            btnViewPDF.Size = new Size(75, 23);
            btnViewPDF.TabIndex = 7;
            btnViewPDF.Text = "Ver PDF";
            btnViewPDF.UseVisualStyleBackColor = true;
            btnViewPDF.Click += btnViewPDF_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 12);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 9;
            label1.Text = "Número de Venta:";
            // 
            // lblSaleNum
            // 
            lblSaleNum.AutoSize = true;
            lblSaleNum.Location = new Point(119, 12);
            lblSaleNum.Name = "lblSaleNum";
            lblSaleNum.Size = new Size(0, 15);
            lblSaleNum.TabIndex = 10;
            // 
            // frmDetalleVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(743, 321);
            Controls.Add(lblSaleNum);
            Controls.Add(label1);
            Controls.Add(dgvSaleDetail);
            Controls.Add(btnViewPDF);
            MaximizeBox = false;
            MaximumSize = new Size(759, 360);
            MinimizeBox = false;
            MinimumSize = new Size(759, 360);
            Name = "frmDetalleVenta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmDetalleVenta";
            Load += frmDetalleVenta_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSaleDetail).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvSaleDetail;
        private Button btnViewPDF;
        private Label label1;
        private Label lblSaleNum;
    }
}