namespace ElCerrojoPresentation.Forms
{
    partial class frmPrecios
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
            rbInc = new RadioButton();
            btnOk = new Button();
            btnCancel = new Button();
            numPercent = new NumericUpDown();
            rbDec = new RadioButton();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            lblTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)numPercent).BeginInit();
            SuspendLayout();
            // 
            // rbInc
            // 
            rbInc.AutoSize = true;
            rbInc.Checked = true;
            rbInc.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            rbInc.Location = new Point(12, 69);
            rbInc.Name = "rbInc";
            rbInc.Size = new Size(37, 23);
            rbInc.TabIndex = 0;
            rbInc.TabStop = true;
            rbInc.Text = "+";
            rbInc.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            btnOk.Cursor = Cursors.Hand;
            btnOk.FlatStyle = FlatStyle.Flat;
            btnOk.ForeColor = Color.FromArgb(30, 90, 195);
            btnOk.Location = new Point(277, 106);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 16;
            btnOk.Text = "Guardar";
            btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Location = new Point(12, 106);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 17;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // numPercent
            // 
            numPercent.DecimalPlaces = 2;
            numPercent.Font = new Font("Segoe UI", 10F);
            numPercent.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            numPercent.InterceptArrowKeys = false;
            numPercent.Location = new Point(193, 72);
            numPercent.Name = "numPercent";
            numPercent.Size = new Size(159, 25);
            numPercent.TabIndex = 18;
            // 
            // rbDec
            // 
            rbDec.AutoSize = true;
            rbDec.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            rbDec.Location = new Point(50, 69);
            rbDec.Name = "rbDec";
            rbDec.Size = new Size(33, 23);
            rbDec.TabIndex = 19;
            rbDec.TabStop = true;
            rbDec.Text = "-";
            rbDec.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 10F);
            lblTitle.Location = new Point(12, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(245, 19);
            lblTitle.TabIndex = 20;
            lblTitle.Text = "Se modificara el precio de X productos:";
            // 
            // frmPrecios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            ClientSize = new Size(364, 141);
            Controls.Add(lblTitle);
            Controls.Add(rbDec);
            Controls.Add(numPercent);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(rbInc);
            MaximumSize = new Size(380, 180);
            MinimumSize = new Size(380, 180);
            Name = "frmPrecios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmPrecios";
            ((System.ComponentModel.ISupportInitialize)numPercent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rbInc;
        private Button btnOk;
        private Button btnCancel;
        private NumericUpDown numPercent;
        private RadioButton rbDec;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label lblTitle;
    }
}