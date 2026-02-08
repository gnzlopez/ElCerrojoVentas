namespace ElCerrojoPresentation.Forms
{
    partial class frmGestion
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
            tabControlMain = new TabControl();
            tabList = new TabPage();
            dgvCategList = new DataGridView();
            btnSearchCateg = new Button();
            txbSearchCateg = new TextBox();
            btnNewCateg = new Button();
            tabNew = new TabPage();
            dgvSuppList = new DataGridView();
            btnSearchSupp = new Button();
            txbSearchSup = new TextBox();
            btnNewSupp = new Button();
            tabEdit = new TabPage();
            dgvBrandList = new DataGridView();
            btnSearchBrand = new Button();
            txbSearchBrand = new TextBox();
            btnNewBrand = new Button();
            tabControlMain.SuspendLayout();
            tabList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategList).BeginInit();
            tabNew.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSuppList).BeginInit();
            tabEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBrandList).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 3;
            label1.Text = "Gestiones";
            // 
            // tabControlMain
            // 
            tabControlMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControlMain.Controls.Add(tabList);
            tabControlMain.Controls.Add(tabNew);
            tabControlMain.Controls.Add(tabEdit);
            tabControlMain.ItemSize = new Size(120, 20);
            tabControlMain.Location = new Point(12, 50);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(740, 345);
            tabControlMain.SizeMode = TabSizeMode.FillToRight;
            tabControlMain.TabIndex = 2;
            // 
            // tabList
            // 
            tabList.Controls.Add(dgvCategList);
            tabList.Controls.Add(btnSearchCateg);
            tabList.Controls.Add(txbSearchCateg);
            tabList.Controls.Add(btnNewCateg);
            tabList.Location = new Point(4, 24);
            tabList.Name = "tabList";
            tabList.Padding = new Padding(3);
            tabList.Size = new Size(732, 317);
            tabList.TabIndex = 0;
            tabList.Text = "Categorias";
            tabList.UseVisualStyleBackColor = true;
            // 
            // dgvCategList
            // 
            dgvCategList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCategList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategList.Location = new Point(6, 35);
            dgvCategList.Name = "dgvCategList";
            dgvCategList.Size = new Size(720, 276);
            dgvCategList.TabIndex = 3;
            dgvCategList.CellContentClick += dgvCategList_CellContentClick;
            dgvCategList.CellPainting += dgvCategList_CellPainting;
            dgvCategList.DataBindingComplete += dgvCategList_DataBindingComplete;
            // 
            // btnSearchCateg
            // 
            btnSearchCateg.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearchCateg.Cursor = Cursors.Hand;
            btnSearchCateg.FlatStyle = FlatStyle.Flat;
            btnSearchCateg.Location = new Point(651, 6);
            btnSearchCateg.Name = "btnSearchCateg";
            btnSearchCateg.Size = new Size(75, 23);
            btnSearchCateg.TabIndex = 2;
            btnSearchCateg.Text = "Buscar";
            btnSearchCateg.UseVisualStyleBackColor = true;
            btnSearchCateg.Click += btnSearchCateg_Click;
            // 
            // txbSearchCateg
            // 
            txbSearchCateg.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txbSearchCateg.Location = new Point(379, 6);
            txbSearchCateg.Name = "txbSearchCateg";
            txbSearchCateg.Size = new Size(266, 23);
            txbSearchCateg.TabIndex = 1;
            // 
            // btnNewCateg
            // 
            btnNewCateg.Cursor = Cursors.Hand;
            btnNewCateg.FlatStyle = FlatStyle.Flat;
            btnNewCateg.Location = new Point(6, 6);
            btnNewCateg.Name = "btnNewCateg";
            btnNewCateg.Size = new Size(75, 23);
            btnNewCateg.TabIndex = 0;
            btnNewCateg.Text = "Nuevo";
            btnNewCateg.UseVisualStyleBackColor = true;
            btnNewCateg.Click += btnNewCateg_Click;
            // 
            // tabNew
            // 
            tabNew.Controls.Add(dgvSuppList);
            tabNew.Controls.Add(btnSearchSupp);
            tabNew.Controls.Add(txbSearchSup);
            tabNew.Controls.Add(btnNewSupp);
            tabNew.Location = new Point(4, 24);
            tabNew.Name = "tabNew";
            tabNew.Padding = new Padding(3);
            tabNew.Size = new Size(732, 317);
            tabNew.TabIndex = 1;
            tabNew.Text = "Proveedores";
            tabNew.UseVisualStyleBackColor = true;
            // 
            // dgvSuppList
            // 
            dgvSuppList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSuppList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSuppList.Location = new Point(6, 35);
            dgvSuppList.Name = "dgvSuppList";
            dgvSuppList.Size = new Size(720, 276);
            dgvSuppList.TabIndex = 7;
            dgvSuppList.CellContentClick += dgvSuppList_CellContentClick;
            dgvSuppList.CellPainting += dgvSuppList_CellPainting;
            dgvSuppList.DataBindingComplete += dgvSuppList_DataBindingComplete;
            // 
            // btnSearchSupp
            // 
            btnSearchSupp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearchSupp.Cursor = Cursors.Hand;
            btnSearchSupp.FlatStyle = FlatStyle.Flat;
            btnSearchSupp.Location = new Point(651, 6);
            btnSearchSupp.Name = "btnSearchSupp";
            btnSearchSupp.Size = new Size(75, 23);
            btnSearchSupp.TabIndex = 6;
            btnSearchSupp.Text = "Buscar";
            btnSearchSupp.UseVisualStyleBackColor = true;
            btnSearchSupp.Click += btnSearchSupp_Click;
            // 
            // txbSearchSup
            // 
            txbSearchSup.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txbSearchSup.Location = new Point(379, 6);
            txbSearchSup.Name = "txbSearchSup";
            txbSearchSup.Size = new Size(266, 23);
            txbSearchSup.TabIndex = 5;
            // 
            // btnNewSupp
            // 
            btnNewSupp.Cursor = Cursors.Hand;
            btnNewSupp.FlatStyle = FlatStyle.Flat;
            btnNewSupp.Location = new Point(6, 6);
            btnNewSupp.Name = "btnNewSupp";
            btnNewSupp.Size = new Size(75, 23);
            btnNewSupp.TabIndex = 4;
            btnNewSupp.Text = "Nuevo";
            btnNewSupp.UseVisualStyleBackColor = true;
            btnNewSupp.Click += btnNewSupp_Click;
            // 
            // tabEdit
            // 
            tabEdit.Controls.Add(dgvBrandList);
            tabEdit.Controls.Add(btnSearchBrand);
            tabEdit.Controls.Add(txbSearchBrand);
            tabEdit.Controls.Add(btnNewBrand);
            tabEdit.Location = new Point(4, 24);
            tabEdit.Name = "tabEdit";
            tabEdit.Padding = new Padding(3);
            tabEdit.Size = new Size(732, 317);
            tabEdit.TabIndex = 2;
            tabEdit.Text = "Marcas";
            tabEdit.UseVisualStyleBackColor = true;
            // 
            // dgvBrandList
            // 
            dgvBrandList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvBrandList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBrandList.Location = new Point(6, 35);
            dgvBrandList.Name = "dgvBrandList";
            dgvBrandList.Size = new Size(720, 276);
            dgvBrandList.TabIndex = 7;
            dgvBrandList.CellContentClick += dgvBrandList_CellContentClick;
            dgvBrandList.CellPainting += dgvBrandList_CellPainting;
            dgvBrandList.DataBindingComplete += dgvBrandList_DataBindingComplete;
            // 
            // btnSearchBrand
            // 
            btnSearchBrand.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearchBrand.Cursor = Cursors.Hand;
            btnSearchBrand.FlatStyle = FlatStyle.Flat;
            btnSearchBrand.Location = new Point(651, 6);
            btnSearchBrand.Name = "btnSearchBrand";
            btnSearchBrand.Size = new Size(75, 23);
            btnSearchBrand.TabIndex = 6;
            btnSearchBrand.Text = "Buscar";
            btnSearchBrand.UseVisualStyleBackColor = true;
            btnSearchBrand.Click += btnSearchBrand_Click;
            // 
            // txbSearchBrand
            // 
            txbSearchBrand.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txbSearchBrand.Location = new Point(379, 6);
            txbSearchBrand.Name = "txbSearchBrand";
            txbSearchBrand.Size = new Size(266, 23);
            txbSearchBrand.TabIndex = 5;
            // 
            // btnNewBrand
            // 
            btnNewBrand.Cursor = Cursors.Hand;
            btnNewBrand.FlatStyle = FlatStyle.Flat;
            btnNewBrand.Location = new Point(6, 6);
            btnNewBrand.Name = "btnNewBrand";
            btnNewBrand.Size = new Size(75, 23);
            btnNewBrand.TabIndex = 4;
            btnNewBrand.Text = "Nuevo";
            btnNewBrand.UseVisualStyleBackColor = true;
            btnNewBrand.Click += btnNewBrand_Click;
            // 
            // frmGestion
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(764, 407);
            Controls.Add(label1);
            Controls.Add(tabControlMain);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmGestion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmGestion";
            Load += frmGestion_Load;
            tabControlMain.ResumeLayout(false);
            tabList.ResumeLayout(false);
            tabList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategList).EndInit();
            tabNew.ResumeLayout(false);
            tabNew.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSuppList).EndInit();
            tabEdit.ResumeLayout(false);
            tabEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBrandList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TabControl tabControlMain;
        private TabPage tabList;
        private DataGridView dgvCategList;
        private Button btnSearchCateg;
        private TextBox txbSearchCateg;
        private Button btnNewCateg;
        private TabPage tabNew;
        private TabPage tabEdit;
        private DataGridView dgvSuppList;
        private Button btnSearchSupp;
        private TextBox txbSearchSup;
        private Button btnNewSupp;
        private DataGridView dgvBrandList;
        private Button btnSearchBrand;
        private TextBox txbSearchBrand;
        private Button btnNewBrand;
    }
}