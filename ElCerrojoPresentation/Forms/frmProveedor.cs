using ElCerrojoPresentation.Utils;
using ElCerrojoServices.DTOs;
using ElCerrojoServices.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElCerrojoPresentation.Forms
{
    public partial class frmProveedor : Form
    {
        public string Name => txbName.Text;
        public string ContactName => txbContactName.Text;
        public long? Phone => long.TryParse(txbPhone.Text, out var e) ? e : null;

        public frmProveedor(string name = "", string contactName = "", long? phone = null)
        {
            InitializeComponent();

            txbName.Text = name;
            txbContactName.Text = contactName;
            txbPhone.Text = phone.ToString();
        }

        private void frmProveedor_Load(object sender, EventArgs e)
        {
            txbPhone.ValidateNumber();
            btnSave.DialogResult = DialogResult.OK;
            btnBack.DialogResult = DialogResult.Cancel;

            this.AcceptButton = btnSave;
            this.CancelButton = btnBack;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
    }
}
