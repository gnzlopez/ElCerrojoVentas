using System.Windows.Forms;

namespace ElCerrojoPresentation.Forms
{
    partial class frmProducto
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
            components = new System.ComponentModel.Container();
            printDialog1 = new PrintDialog();
            contextMenuStrip1 = new ContextMenuStrip(components);
            _headerCheckBox = new CheckBox();
            chkCol = new DataGridViewCheckBoxColumn();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tabControlMain = new TabControl();
            tabList = new TabPage();
            splitContainer3 = new SplitContainer();
            splitContainer4 = new SplitContainer();
            label6 = new Label();
            label5 = new Label();
            label7 = new Label();
            splitContainer2 = new SplitContainer();
            splitContainer1 = new SplitContainer();
            cboListBrand = new ComboBox();
            cboListCateg = new ComboBox();
            cboListSupp = new ComboBox();
            btnUpdatePrices = new Button();
            dgvProductList = new DataGridView();
            btnSearch = new Button();
            txbSearch = new TextBox();
            btnNew = new Button();
            tabNew = new TabPage();
            cboNewSupp = new ComboBox();
            label8 = new Label();
            cboNewCateg = new ComboBox();
            label3 = new Label();
            numNewStock = new NumericUpDown();
            lblNewStock = new Label();
            txbNewCode = new TextBox();
            lblNewCode = new Label();
            numNewBuyPrice = new NumericUpDown();
            lblNewBuyPrice = new Label();
            cboNewBrand = new ComboBox();
            lblNewMarca = new Label();
            numNewPrice = new NumericUpDown();
            btnNewSave = new Button();
            btnNewBack = new Button();
            lblNewPrice = new Label();
            txbNewName = new TextBox();
            lblNewName = new Label();
            tabEdit = new TabPage();
            cboEditSupp = new ComboBox();
            label9 = new Label();
            cboEditCateg = new ComboBox();
            label4 = new Label();
            numEditStock = new NumericUpDown();
            lblEditStock = new Label();
            txbEditCode = new TextBox();
            lblEditCode = new Label();
            numEditBuyPrice = new NumericUpDown();
            lblEditBuyPrice = new Label();
            cboEditBrand = new ComboBox();
            label2 = new Label();
            numEditPrice = new NumericUpDown();
            btnEditSave = new Button();
            btnEditBack = new Button();
            lblEditPrice = new Label();
            txbEditName = new TextBox();
            lblEditName = new Label();
            tabControlMain.SuspendLayout();
            tabList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer4).BeginInit();
            splitContainer4.Panel1.SuspendLayout();
            splitContainer4.Panel2.SuspendLayout();
            splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductList).BeginInit();
            tabNew.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numNewStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numNewBuyPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numNewPrice).BeginInit();
            tabEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numEditStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numEditBuyPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numEditPrice).BeginInit();
            SuspendLayout();
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // _headerCheckBox
            // 
            _headerCheckBox.Location = new Point(0, 0);
            _headerCheckBox.Name = "_headerCheckBox";
            _headerCheckBox.Size = new Size(15, 15);
            _headerCheckBox.TabIndex = 0;
            // 
            // chkCol
            // 
            chkCol.HeaderText = "";
            chkCol.Name = "chkCol";
            chkCol.Width = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(120, 15);
            label1.TabIndex = 1;
            label1.Text = "Inventario / Producto";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 385F));
            tableLayoutPanel1.Location = new Point(417, 119);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.31941F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 89.68059F));
            tableLayoutPanel1.Size = new Size(764, 348);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // tabControlMain
            // 
            tabControlMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControlMain.Controls.Add(tabList);
            tabControlMain.Controls.Add(tabNew);
            tabControlMain.Controls.Add(tabEdit);
            tabControlMain.ItemSize = new Size(80, 20);
            tabControlMain.Location = new Point(12, 50);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(740, 345);
            tabControlMain.SizeMode = TabSizeMode.FillToRight;
            tabControlMain.TabIndex = 3;
            // 
            // tabList
            // 
            tabList.Controls.Add(splitContainer3);
            tabList.Controls.Add(splitContainer2);
            tabList.Controls.Add(btnUpdatePrices);
            tabList.Controls.Add(dgvProductList);
            tabList.Controls.Add(btnSearch);
            tabList.Controls.Add(txbSearch);
            tabList.Controls.Add(btnNew);
            tabList.Location = new Point(4, 24);
            tabList.Name = "tabList";
            tabList.Padding = new Padding(3);
            tabList.Size = new Size(732, 317);
            tabList.TabIndex = 0;
            tabList.Text = "Lista";
            tabList.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            splitContainer3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            splitContainer3.Location = new Point(8, 35);
            splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(splitContainer4);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(label7);
            splitContainer3.Size = new Size(720, 16);
            splitContainer3.SplitterDistance = 349;
            splitContainer3.TabIndex = 15;
            // 
            // splitContainer4
            // 
            splitContainer4.Dock = DockStyle.Fill;
            splitContainer4.Location = new Point(0, 0);
            splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            splitContainer4.Panel1.Controls.Add(label6);
            // 
            // splitContainer4.Panel2
            // 
            splitContainer4.Panel2.Controls.Add(label5);
            splitContainer4.Size = new Size(349, 16);
            splitContainer4.SplitterDistance = 172;
            splitContainer4.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Location = new Point(0, 0);
            label6.Margin = new Padding(5);
            label6.Name = "label6";
            label6.Size = new Size(40, 15);
            label6.TabIndex = 6;
            label6.Text = "Marca";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(0, 0);
            label5.Margin = new Padding(5);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 8;
            label5.Text = "Categoria";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.Location = new Point(0, 0);
            label7.Margin = new Padding(5);
            label7.Name = "label7";
            label7.Size = new Size(61, 15);
            label7.TabIndex = 12;
            label7.Text = "Proveedor";
            // 
            // splitContainer2
            // 
            splitContainer2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            splitContainer2.Location = new Point(8, 56);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(splitContainer1);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(cboListSupp);
            splitContainer2.Size = new Size(720, 26);
            splitContainer2.SplitterDistance = 348;
            splitContainer2.TabIndex = 14;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Bottom;
            splitContainer1.Location = new Point(0, 1);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(cboListBrand);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(cboListCateg);
            splitContainer1.Size = new Size(348, 25);
            splitContainer1.SplitterDistance = 171;
            splitContainer1.TabIndex = 11;
            splitContainer1.Resize += splitContainer1_Resize;
            // 
            // cboListBrand
            // 
            cboListBrand.Dock = DockStyle.Fill;
            cboListBrand.DropDownStyle = ComboBoxStyle.DropDownList;
            cboListBrand.Font = new Font("Segoe UI", 10F);
            cboListBrand.FormattingEnabled = true;
            cboListBrand.Location = new Point(0, 0);
            cboListBrand.Margin = new Padding(5);
            cboListBrand.Name = "cboListBrand";
            cboListBrand.Size = new Size(171, 25);
            cboListBrand.TabIndex = 7;
            cboListBrand.DrawItem += cboListBrand_DrawItem;
            cboListBrand.SelectedIndexChanged += cboListBrand_SelectedIndexChanged;
            // 
            // cboListCateg
            // 
            cboListCateg.Dock = DockStyle.Fill;
            cboListCateg.DropDownStyle = ComboBoxStyle.DropDownList;
            cboListCateg.Font = new Font("Segoe UI", 10F);
            cboListCateg.FormattingEnabled = true;
            cboListCateg.Location = new Point(0, 0);
            cboListCateg.Margin = new Padding(5);
            cboListCateg.Name = "cboListCateg";
            cboListCateg.Size = new Size(173, 25);
            cboListCateg.TabIndex = 9;
            cboListCateg.SelectedIndexChanged += cboListCateg_SelectedIndexChanged;
            // 
            // cboListSupp
            // 
            cboListSupp.Dock = DockStyle.Bottom;
            cboListSupp.DropDownStyle = ComboBoxStyle.DropDownList;
            cboListSupp.Font = new Font("Segoe UI", 10F);
            cboListSupp.FormattingEnabled = true;
            cboListSupp.Location = new Point(0, 1);
            cboListSupp.Margin = new Padding(5);
            cboListSupp.Name = "cboListSupp";
            cboListSupp.Size = new Size(368, 25);
            cboListSupp.TabIndex = 13;
            cboListSupp.SelectedIndexChanged += cboListProv_SelectedIndexChanged;
            // 
            // btnUpdatePrices
            // 
            btnUpdatePrices.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnUpdatePrices.Cursor = Cursors.Hand;
            btnUpdatePrices.FlatStyle = FlatStyle.Flat;
            btnUpdatePrices.Location = new Point(565, 287);
            btnUpdatePrices.Name = "btnUpdatePrices";
            btnUpdatePrices.Size = new Size(161, 23);
            btnUpdatePrices.TabIndex = 10;
            btnUpdatePrices.Text = "Actualizar Precios";
            btnUpdatePrices.UseVisualStyleBackColor = true;
            btnUpdatePrices.Click += btnUpdatePrices_Click;
            // 
            // dgvProductList
            // 
            dgvProductList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductList.EditMode = DataGridViewEditMode.EditOnEnter;
            dgvProductList.Location = new Point(6, 88);
            dgvProductList.MultiSelect = false;
            dgvProductList.Name = "dgvProductList";
            dgvProductList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductList.Size = new Size(720, 193);
            dgvProductList.TabIndex = 3;
            dgvProductList.CellContentClick += dgvProductList_CellContentClick;
            dgvProductList.CellFormatting += dgvProductList_CellFormatting;
            dgvProductList.CellPainting += dgvProductList_CellPainting;
            dgvProductList.ColumnWidthChanged += dgvProductList_ColumnWidthChanged;
            dgvProductList.DataBindingComplete += dgvProductList_DataBindingComplete;
            dgvProductList.Scroll += dgvProductList_Scroll;
            dgvProductList.SizeChanged += dgvProductList_SizeChanged;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Location = new Point(651, 6);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Buscar";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txbSearch
            // 
            txbSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txbSearch.Location = new Point(155, 6);
            txbSearch.Name = "txbSearch";
            txbSearch.Size = new Size(491, 23);
            txbSearch.TabIndex = 1;
            // 
            // btnNew
            // 
            btnNew.Cursor = Cursors.Hand;
            btnNew.FlatStyle = FlatStyle.Flat;
            btnNew.Location = new Point(6, 6);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(75, 23);
            btnNew.TabIndex = 0;
            btnNew.Text = "Nuevo";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // tabNew
            // 
            tabNew.Controls.Add(cboNewSupp);
            tabNew.Controls.Add(label8);
            tabNew.Controls.Add(cboNewCateg);
            tabNew.Controls.Add(label3);
            tabNew.Controls.Add(numNewStock);
            tabNew.Controls.Add(lblNewStock);
            tabNew.Controls.Add(txbNewCode);
            tabNew.Controls.Add(lblNewCode);
            tabNew.Controls.Add(numNewBuyPrice);
            tabNew.Controls.Add(lblNewBuyPrice);
            tabNew.Controls.Add(cboNewBrand);
            tabNew.Controls.Add(lblNewMarca);
            tabNew.Controls.Add(numNewPrice);
            tabNew.Controls.Add(btnNewSave);
            tabNew.Controls.Add(btnNewBack);
            tabNew.Controls.Add(lblNewPrice);
            tabNew.Controls.Add(txbNewName);
            tabNew.Controls.Add(lblNewName);
            tabNew.Location = new Point(4, 24);
            tabNew.Name = "tabNew";
            tabNew.Padding = new Padding(3);
            tabNew.Size = new Size(732, 317);
            tabNew.TabIndex = 1;
            tabNew.Text = "Nuevo";
            tabNew.UseVisualStyleBackColor = true;
            // 
            // cboNewSupp
            // 
            cboNewSupp.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNewSupp.Font = new Font("Segoe UI", 10F);
            cboNewSupp.FormattingEnabled = true;
            cboNewSupp.Location = new Point(8, 92);
            cboNewSupp.Margin = new Padding(5);
            cboNewSupp.Name = "cboNewSupp";
            cboNewSupp.Size = new Size(353, 25);
            cboNewSupp.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(21, 75);
            label8.Margin = new Padding(5);
            label8.Name = "label8";
            label8.Size = new Size(61, 15);
            label8.TabIndex = 16;
            label8.Text = "Proveedor";
            // 
            // cboNewCateg
            // 
            cboNewCateg.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNewCateg.Font = new Font("Segoe UI", 10F);
            cboNewCateg.FormattingEnabled = true;
            cboNewCateg.Location = new Point(374, 137);
            cboNewCateg.Margin = new Padding(5);
            cboNewCateg.Name = "cboNewCateg";
            cboNewCateg.Size = new Size(353, 25);
            cboNewCateg.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(374, 120);
            label3.Margin = new Padding(5);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 4;
            label3.Text = "Categoria";
            // 
            // numNewStock
            // 
            numNewStock.Font = new Font("Segoe UI", 10F);
            numNewStock.Location = new Point(474, 243);
            numNewStock.Margin = new Padding(5);
            numNewStock.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            numNewStock.Name = "numNewStock";
            numNewStock.Size = new Size(250, 25);
            numNewStock.TabIndex = 13;
            numNewStock.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblNewStock
            // 
            lblNewStock.AutoSize = true;
            lblNewStock.Location = new Point(487, 223);
            lblNewStock.Margin = new Padding(5);
            lblNewStock.Name = "lblNewStock";
            lblNewStock.Size = new Size(36, 15);
            lblNewStock.TabIndex = 12;
            lblNewStock.Text = "Stock";
            // 
            // txbNewCode
            // 
            txbNewCode.Font = new Font("Segoe UI", 10F);
            txbNewCode.Location = new Point(8, 243);
            txbNewCode.Margin = new Padding(5);
            txbNewCode.Name = "txbNewCode";
            txbNewCode.Size = new Size(456, 25);
            txbNewCode.TabIndex = 11;
            // 
            // lblNewCode
            // 
            lblNewCode.AutoSize = true;
            lblNewCode.Location = new Point(21, 223);
            lblNewCode.Margin = new Padding(5);
            lblNewCode.Name = "lblNewCode";
            lblNewCode.Size = new Size(46, 15);
            lblNewCode.TabIndex = 10;
            lblNewCode.Text = "Codigo";
            // 
            // numNewBuyPrice
            // 
            numNewBuyPrice.DecimalPlaces = 2;
            numNewBuyPrice.Font = new Font("Segoe UI", 10F);
            numNewBuyPrice.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            numNewBuyPrice.Location = new Point(264, 189);
            numNewBuyPrice.Margin = new Padding(5);
            numNewBuyPrice.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            numNewBuyPrice.Name = "numNewBuyPrice";
            numNewBuyPrice.Size = new Size(250, 25);
            numNewBuyPrice.TabIndex = 9;
            numNewBuyPrice.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblNewBuyPrice
            // 
            lblNewBuyPrice.AutoSize = true;
            lblNewBuyPrice.Location = new Point(277, 172);
            lblNewBuyPrice.Margin = new Padding(5);
            lblNewBuyPrice.Name = "lblNewBuyPrice";
            lblNewBuyPrice.Size = new Size(102, 15);
            lblNewBuyPrice.TabIndex = 8;
            lblNewBuyPrice.Text = "Precio de Compra";
            // 
            // cboNewBrand
            // 
            cboNewBrand.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNewBrand.Font = new Font("Segoe UI", 10F);
            cboNewBrand.FormattingEnabled = true;
            cboNewBrand.Location = new Point(8, 137);
            cboNewBrand.Margin = new Padding(5);
            cboNewBrand.Name = "cboNewBrand";
            cboNewBrand.Size = new Size(353, 25);
            cboNewBrand.TabIndex = 3;
            // 
            // lblNewMarca
            // 
            lblNewMarca.AutoSize = true;
            lblNewMarca.Location = new Point(18, 120);
            lblNewMarca.Margin = new Padding(5);
            lblNewMarca.Name = "lblNewMarca";
            lblNewMarca.Size = new Size(40, 15);
            lblNewMarca.TabIndex = 2;
            lblNewMarca.Text = "Marca";
            // 
            // numNewPrice
            // 
            numNewPrice.DecimalPlaces = 2;
            numNewPrice.Font = new Font("Segoe UI", 10F);
            numNewPrice.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            numNewPrice.Location = new Point(8, 189);
            numNewPrice.Margin = new Padding(5);
            numNewPrice.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            numNewPrice.Name = "numNewPrice";
            numNewPrice.Size = new Size(250, 25);
            numNewPrice.TabIndex = 7;
            numNewPrice.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnNewSave
            // 
            btnNewSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNewSave.Cursor = Cursors.Hand;
            btnNewSave.FlatStyle = FlatStyle.Flat;
            btnNewSave.ForeColor = Color.FromArgb(30, 90, 195);
            btnNewSave.Location = new Point(649, 287);
            btnNewSave.Name = "btnNewSave";
            btnNewSave.Size = new Size(75, 23);
            btnNewSave.TabIndex = 15;
            btnNewSave.Text = "Guardar";
            btnNewSave.UseVisualStyleBackColor = true;
            btnNewSave.Click += btnNewSave_Click;
            // 
            // btnNewBack
            // 
            btnNewBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnNewBack.Cursor = Cursors.Hand;
            btnNewBack.FlatStyle = FlatStyle.Flat;
            btnNewBack.Location = new Point(8, 287);
            btnNewBack.Name = "btnNewBack";
            btnNewBack.Size = new Size(75, 23);
            btnNewBack.TabIndex = 14;
            btnNewBack.Text = "Volver";
            btnNewBack.UseVisualStyleBackColor = true;
            btnNewBack.Click += btnNewBack_Click;
            // 
            // lblNewPrice
            // 
            lblNewPrice.AutoSize = true;
            lblNewPrice.Location = new Point(21, 172);
            lblNewPrice.Margin = new Padding(5);
            lblNewPrice.Name = "lblNewPrice";
            lblNewPrice.Size = new Size(88, 15);
            lblNewPrice.TabIndex = 6;
            lblNewPrice.Text = "Precio de Venta";
            // 
            // txbNewName
            // 
            txbNewName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txbNewName.Font = new Font("Segoe UI", 10F);
            txbNewName.Location = new Point(8, 40);
            txbNewName.Margin = new Padding(5);
            txbNewName.Name = "txbNewName";
            txbNewName.PlaceholderText = "Ingrese un nombre del nuevo producto";
            txbNewName.Size = new Size(716, 25);
            txbNewName.TabIndex = 1;
            // 
            // lblNewName
            // 
            lblNewName.AutoSize = true;
            lblNewName.Font = new Font("Segoe UI", 9F);
            lblNewName.Location = new Point(21, 23);
            lblNewName.Margin = new Padding(5);
            lblNewName.Name = "lblNewName";
            lblNewName.Size = new Size(51, 15);
            lblNewName.TabIndex = 0;
            lblNewName.Text = "Nombre";
            // 
            // tabEdit
            // 
            tabEdit.Controls.Add(cboEditSupp);
            tabEdit.Controls.Add(label9);
            tabEdit.Controls.Add(cboEditCateg);
            tabEdit.Controls.Add(label4);
            tabEdit.Controls.Add(numEditStock);
            tabEdit.Controls.Add(lblEditStock);
            tabEdit.Controls.Add(txbEditCode);
            tabEdit.Controls.Add(lblEditCode);
            tabEdit.Controls.Add(numEditBuyPrice);
            tabEdit.Controls.Add(lblEditBuyPrice);
            tabEdit.Controls.Add(cboEditBrand);
            tabEdit.Controls.Add(label2);
            tabEdit.Controls.Add(numEditPrice);
            tabEdit.Controls.Add(btnEditSave);
            tabEdit.Controls.Add(btnEditBack);
            tabEdit.Controls.Add(lblEditPrice);
            tabEdit.Controls.Add(txbEditName);
            tabEdit.Controls.Add(lblEditName);
            tabEdit.Location = new Point(4, 24);
            tabEdit.Name = "tabEdit";
            tabEdit.Padding = new Padding(3);
            tabEdit.Size = new Size(732, 317);
            tabEdit.TabIndex = 2;
            tabEdit.Text = "Editar";
            tabEdit.UseVisualStyleBackColor = true;
            // 
            // cboEditSupp
            // 
            cboEditSupp.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEditSupp.Font = new Font("Segoe UI", 10F);
            cboEditSupp.FormattingEnabled = true;
            cboEditSupp.Location = new Point(9, 92);
            cboEditSupp.Margin = new Padding(5);
            cboEditSupp.Name = "cboEditSupp";
            cboEditSupp.Size = new Size(353, 25);
            cboEditSupp.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(22, 75);
            label9.Margin = new Padding(5);
            label9.Name = "label9";
            label9.Size = new Size(61, 15);
            label9.TabIndex = 18;
            label9.Text = "Proveedor";
            // 
            // cboEditCateg
            // 
            cboEditCateg.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEditCateg.Font = new Font("Segoe UI", 10F);
            cboEditCateg.FormattingEnabled = true;
            cboEditCateg.Location = new Point(371, 138);
            cboEditCateg.Margin = new Padding(5);
            cboEditCateg.Name = "cboEditCateg";
            cboEditCateg.Size = new Size(353, 25);
            cboEditCateg.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(371, 121);
            label4.Margin = new Padding(5);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 4;
            label4.Text = "Categoria";
            // 
            // numEditStock
            // 
            numEditStock.Font = new Font("Segoe UI", 10F);
            numEditStock.Location = new Point(474, 243);
            numEditStock.Margin = new Padding(5);
            numEditStock.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            numEditStock.Name = "numEditStock";
            numEditStock.Size = new Size(250, 25);
            numEditStock.TabIndex = 13;
            numEditStock.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblEditStock
            // 
            lblEditStock.AutoSize = true;
            lblEditStock.Location = new Point(487, 223);
            lblEditStock.Margin = new Padding(5);
            lblEditStock.Name = "lblEditStock";
            lblEditStock.Size = new Size(36, 15);
            lblEditStock.TabIndex = 12;
            lblEditStock.Text = "Stock";
            // 
            // txbEditCode
            // 
            txbEditCode.Font = new Font("Segoe UI", 10F);
            txbEditCode.Location = new Point(8, 243);
            txbEditCode.Margin = new Padding(5);
            txbEditCode.Name = "txbEditCode";
            txbEditCode.Size = new Size(456, 25);
            txbEditCode.TabIndex = 11;
            // 
            // lblEditCode
            // 
            lblEditCode.AutoSize = true;
            lblEditCode.Location = new Point(21, 223);
            lblEditCode.Margin = new Padding(5);
            lblEditCode.Name = "lblEditCode";
            lblEditCode.Size = new Size(46, 15);
            lblEditCode.TabIndex = 10;
            lblEditCode.Text = "Codigo";
            // 
            // numEditBuyPrice
            // 
            numEditBuyPrice.DecimalPlaces = 2;
            numEditBuyPrice.Font = new Font("Segoe UI", 10F);
            numEditBuyPrice.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            numEditBuyPrice.Location = new Point(278, 190);
            numEditBuyPrice.Margin = new Padding(5);
            numEditBuyPrice.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            numEditBuyPrice.Name = "numEditBuyPrice";
            numEditBuyPrice.Size = new Size(250, 25);
            numEditBuyPrice.TabIndex = 9;
            numEditBuyPrice.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblEditBuyPrice
            // 
            lblEditBuyPrice.AutoSize = true;
            lblEditBuyPrice.Location = new Point(291, 173);
            lblEditBuyPrice.Margin = new Padding(5);
            lblEditBuyPrice.Name = "lblEditBuyPrice";
            lblEditBuyPrice.Size = new Size(102, 15);
            lblEditBuyPrice.TabIndex = 8;
            lblEditBuyPrice.Text = "Precio de Compra";
            // 
            // cboEditBrand
            // 
            cboEditBrand.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEditBrand.Font = new Font("Segoe UI", 10F);
            cboEditBrand.FormattingEnabled = true;
            cboEditBrand.Location = new Point(8, 138);
            cboEditBrand.Name = "cboEditBrand";
            cboEditBrand.Size = new Size(353, 25);
            cboEditBrand.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 121);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 2;
            label2.Text = "Marca";
            // 
            // numEditPrice
            // 
            numEditPrice.DecimalPlaces = 2;
            numEditPrice.Font = new Font("Segoe UI", 10F);
            numEditPrice.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            numEditPrice.Location = new Point(8, 190);
            numEditPrice.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            numEditPrice.Name = "numEditPrice";
            numEditPrice.Size = new Size(250, 25);
            numEditPrice.TabIndex = 7;
            numEditPrice.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnEditSave
            // 
            btnEditSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEditSave.Cursor = Cursors.Hand;
            btnEditSave.FlatStyle = FlatStyle.Flat;
            btnEditSave.ForeColor = Color.FromArgb(30, 90, 195);
            btnEditSave.Location = new Point(649, 287);
            btnEditSave.Name = "btnEditSave";
            btnEditSave.Size = new Size(75, 23);
            btnEditSave.TabIndex = 15;
            btnEditSave.Text = "Guardar";
            btnEditSave.UseVisualStyleBackColor = true;
            btnEditSave.Click += btnEditSave_Click;
            // 
            // btnEditBack
            // 
            btnEditBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEditBack.Cursor = Cursors.Hand;
            btnEditBack.FlatStyle = FlatStyle.Flat;
            btnEditBack.Location = new Point(8, 287);
            btnEditBack.Name = "btnEditBack";
            btnEditBack.Size = new Size(75, 23);
            btnEditBack.TabIndex = 14;
            btnEditBack.Text = "Volver";
            btnEditBack.UseVisualStyleBackColor = true;
            btnEditBack.Click += btnEditBack_Click;
            // 
            // lblEditPrice
            // 
            lblEditPrice.AutoSize = true;
            lblEditPrice.Location = new Point(21, 173);
            lblEditPrice.Name = "lblEditPrice";
            lblEditPrice.Size = new Size(88, 15);
            lblEditPrice.TabIndex = 6;
            lblEditPrice.Text = "Precio de Venta";
            // 
            // txbEditName
            // 
            txbEditName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txbEditName.Font = new Font("Segoe UI", 10F);
            txbEditName.Location = new Point(8, 40);
            txbEditName.Margin = new Padding(5);
            txbEditName.Name = "txbEditName";
            txbEditName.PlaceholderText = "Ingrese un nombre del nuevo producto";
            txbEditName.Size = new Size(716, 25);
            txbEditName.TabIndex = 1;
            // 
            // lblEditName
            // 
            lblEditName.AutoSize = true;
            lblEditName.Location = new Point(21, 23);
            lblEditName.Name = "lblEditName";
            lblEditName.Size = new Size(51, 15);
            lblEditName.TabIndex = 0;
            lblEditName.Text = "Nombre";
            // 
            // frmProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(764, 407);
            Controls.Add(tabControlMain);
            Controls.Add(label1);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmProducto";
            Load += frmProducto_Load;
            tabControlMain.ResumeLayout(false);
            tabList.ResumeLayout(false);
            tabList.PerformLayout();
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel2.ResumeLayout(false);
            splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            splitContainer4.Panel1.ResumeLayout(false);
            splitContainer4.Panel1.PerformLayout();
            splitContainer4.Panel2.ResumeLayout(false);
            splitContainer4.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer4).EndInit();
            splitContainer4.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProductList).EndInit();
            tabNew.ResumeLayout(false);
            tabNew.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numNewStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)numNewBuyPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numNewPrice).EndInit();
            tabEdit.ResumeLayout(false);
            tabEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numEditStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)numEditBuyPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numEditPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PrintDialog printDialog1;
        private ContextMenuStrip contextMenuStrip1;
        private CheckBox _headerCheckBox;
        private DataGridViewCheckBoxColumn chkCol;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private TabControl tabControlMain;
        private TabPage tabList;
        private Button btnUpdatePrices;
        private ComboBox cboListCateg;
        private Label label5;
        private ComboBox cboListBrand;
        private Label label6;
        private DataGridView dgvProductList;
        private Button btnSearch;
        private TextBox txbSearch;
        private Button btnNew;
        private TabPage tabNew;
        private ComboBox cboNewCateg;
        private Label label3;
        private NumericUpDown numNewStock;
        private Label lblNewStock;
        private TextBox txbNewCode;
        private Label lblNewCode;
        private NumericUpDown numNewBuyPrice;
        private Label lblNewBuyPrice;
        private ComboBox cboNewBrand;
        private Label lblNewMarca;
        private NumericUpDown numNewPrice;
        private Button btnNewSave;
        private Button btnNewBack;
        private Label lblNewPrice;
        private TextBox txbNewName;
        private Label lblNewName;
        private TabPage tabEdit;
        private ComboBox cboEditCateg;
        private Label label4;
        private NumericUpDown numEditStock;
        private Label lblEditStock;
        private TextBox txbEditCode;
        private Label lblEditCode;
        private NumericUpDown numEditBuyPrice;
        private Label lblEditBuyPrice;
        private ComboBox cboEditBrand;
        private Label label2;
        private NumericUpDown numEditPrice;
        private Button btnEditSave;
        private Button btnEditBack;
        private Label lblEditPrice;
        private TextBox txbEditName;
        private Label lblEditName;
        private SplitContainer splitContainer1;
        private Label label7;
        private ComboBox cboListSupp;
        private SplitContainer splitContainer2;
        private SplitContainer splitContainer3;
        private SplitContainer splitContainer4;
        private ComboBox cboNewSupp;
        private Label label8;
        private ComboBox cboEditSupp;
        private Label label9;
    }
}