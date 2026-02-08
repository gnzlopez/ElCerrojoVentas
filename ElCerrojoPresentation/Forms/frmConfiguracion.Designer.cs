namespace ElCerrojoPresentation.Forms
{
    partial class frmConfiguracion
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
            label2 = new Label();
            btnInExcel = new Button();
            btnOutExcel = new Button();
            progressBar = new ProgressBar();
            lblProgress = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(12, 250);
            label1.Name = "label1";
            label1.Size = new Size(137, 15);
            label1.TabIndex = 0;
            label1.Text = "Administracion de Datos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(12, 290);
            label2.Name = "label2";
            label2.Size = new Size(122, 15);
            label2.TabIndex = 1;
            label2.Text = "Productos/Categorias";
            // 
            // btnInExcel
            // 
            btnInExcel.Location = new Point(140, 286);
            btnInExcel.Name = "btnInExcel";
            btnInExcel.Size = new Size(90, 25);
            btnInExcel.TabIndex = 2;
            btnInExcel.Text = "Ingresar Excel";
            btnInExcel.UseVisualStyleBackColor = true;
            btnInExcel.Click += btnInExcel_Click;
            // 
            // btnOutExcel
            // 
            btnOutExcel.Location = new Point(236, 286);
            btnOutExcel.Name = "btnOutExcel";
            btnOutExcel.Size = new Size(90, 25);
            btnOutExcel.TabIndex = 3;
            btnOutExcel.Text = "Exportar Excel";
            btnOutExcel.UseVisualStyleBackColor = true;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(341, 286);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(411, 23);
            progressBar.Style = ProgressBarStyle.Continuous;
            progressBar.TabIndex = 4;
            // 
            // lblProgress
            // 
            lblProgress.AutoSize = true;
            lblProgress.Location = new Point(507, 291);
            lblProgress.Name = "lblProgress";
            lblProgress.Size = new Size(0, 15);
            lblProgress.TabIndex = 5;
            // 
            // frmConfiguracion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(764, 407);
            Controls.Add(lblProgress);
            Controls.Add(progressBar);
            Controls.Add(btnOutExcel);
            Controls.Add(btnInExcel);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmConfiguracion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmConfiguracion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnInExcel;
        private Button btnOutExcel;
        private ProgressBar progressBar;
        private Label lblProgress;
    }
}