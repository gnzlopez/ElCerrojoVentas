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
    public partial class frmPrecios : Form
    {
        public decimal Percent => numPercent.Value;
        public bool IsIncrease => rbInc.Checked;

        public frmPrecios(int prodQty)
        {
            InitializeComponent();

            lblTitle.Text = $"Se modificara el precio de {prodQty} producto{(prodQty > 1 ? 's' : string.Empty)}";

            btnOk.DialogResult = DialogResult.OK;
            btnCancel.DialogResult = DialogResult.Cancel;
        }
    }
}
