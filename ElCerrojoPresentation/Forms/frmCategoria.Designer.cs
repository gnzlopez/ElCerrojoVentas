namespace ElCerrojoPresentation.Forms
{
    partial class frmCategoria
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
            dgvCategList = new DataGridView();
            btnSearch = new Button();
            txbSearch = new TextBox();
            btnNew = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCategList).BeginInit();
            SuspendLayout();
            // 
            // dgvCategList
            // 
            dgvCategList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategList.Location = new Point(12, 79);
            dgvCategList.Name = "dgvCategList";
            dgvCategList.Size = new Size(740, 316);
            dgvCategList.TabIndex = 8;
            dgvCategList.CellContentClick += dgvCategList_CellContentClick;
            dgvCategList.CellPainting += dgvCategList_CellPainting;
            // 
            // btnSearch
            // 
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Location = new Point(677, 49);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 7;
            btnSearch.Text = "Buscar";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txbSearch
            // 
            txbSearch.Location = new Point(385, 50);
            txbSearch.Name = "txbSearch";
            txbSearch.Size = new Size(286, 23);
            txbSearch.TabIndex = 5;
            // 
            // btnNew
            // 
            btnNew.Cursor = Cursors.Hand;
            btnNew.FlatStyle = FlatStyle.Flat;
            btnNew.Location = new Point(12, 50);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(75, 23);
            btnNew.TabIndex = 4;
            btnNew.Text = "Nuevo";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 6;
            label1.Text = "Categoria";
            // 
            // frmCategoria
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSize = true;
            ClientSize = new Size(764, 407);
            Controls.Add(dgvCategList);
            Controls.Add(btnSearch);
            Controls.Add(txbSearch);
            Controls.Add(btnNew);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCategoria";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCategoria";
            Load += frmCategoria_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCategList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCategList;
        private Button btnSearch;
        private TextBox txbSearch;
        private Button btnNew;
        private Label label1;
    }
}