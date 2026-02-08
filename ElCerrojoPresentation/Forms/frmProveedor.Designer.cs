namespace ElCerrojoPresentation.Forms
{
    partial class frmProveedor
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
            txbName = new TextBox();
            lblNewName = new Label();
            txbContactName = new TextBox();
            label2 = new Label();
            txbPhone = new TextBox();
            label3 = new Label();
            btnSave = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 4;
            label1.Text = "Proveedor";
            // 
            // txbName
            // 
            txbName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txbName.Font = new Font("Segoe UI", 10F);
            txbName.Location = new Point(12, 72);
            txbName.Margin = new Padding(5);
            txbName.Name = "txbName";
            txbName.PlaceholderText = "Ingrese un nombre del nuevo producto";
            txbName.Size = new Size(716, 25);
            txbName.TabIndex = 6;
            // 
            // lblNewName
            // 
            lblNewName.AutoSize = true;
            lblNewName.Font = new Font("Segoe UI", 9F);
            lblNewName.Location = new Point(22, 52);
            lblNewName.Margin = new Padding(5);
            lblNewName.Name = "lblNewName";
            lblNewName.Size = new Size(51, 15);
            lblNewName.TabIndex = 5;
            lblNewName.Text = "Nombre";
            // 
            // txbContactName
            // 
            txbContactName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txbContactName.Font = new Font("Segoe UI", 10F);
            txbContactName.Location = new Point(12, 137);
            txbContactName.Margin = new Padding(5);
            txbContactName.Name = "txbContactName";
            txbContactName.Size = new Size(716, 25);
            txbContactName.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(22, 117);
            label2.Margin = new Padding(5);
            label2.Name = "label2";
            label2.Size = new Size(122, 15);
            label2.TabIndex = 7;
            label2.Text = "Nombre del Contacto";
            // 
            // txbPhone
            // 
            txbPhone.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txbPhone.Font = new Font("Segoe UI", 10F);
            txbPhone.Location = new Point(12, 205);
            txbPhone.Margin = new Padding(5);
            txbPhone.Name = "txbPhone";
            txbPhone.Size = new Size(716, 25);
            txbPhone.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.Location = new Point(22, 185);
            label3.Margin = new Padding(5);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 9;
            label3.Text = "Telefono";
            // 
            // btnSave
            // 
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.FromArgb(30, 90, 195);
            btnSave.Location = new Point(653, 333);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 17;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.Cursor = Cursors.Hand;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Location = new Point(12, 333);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 16;
            btnBack.Text = "Volver";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // frmProveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(748, 368);
            Controls.Add(btnSave);
            Controls.Add(btnBack);
            Controls.Add(txbPhone);
            Controls.Add(label3);
            Controls.Add(txbContactName);
            Controls.Add(label2);
            Controls.Add(txbName);
            Controls.Add(lblNewName);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmProveedor";
            Load += frmProveedor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txbName;
        private Label lblNewName;
        private TextBox txbContactName;
        private Label label2;
        private TextBox txbPhone;
        private Label label3;
        private Button btnSave;
        private Button btnBack;
    }
}