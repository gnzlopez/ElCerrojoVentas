using DocumentFormat.OpenXml.Spreadsheet;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.AxHost;
using Color = System.Drawing.Color;

namespace ElCerrojoPresentation.Utils.Customs
{
    public class TwoButtonsColumn : DataGridViewColumn
    {
        public TwoButtonsColumn() : base(new TwoButtonsCell())
        {
            this.Width = 20;
            this.Resizable = DataGridViewTriState.True;
        }
    }

    public class TwoButtonsCell : DataGridViewCell
    {
        private Button _button1;
        private Button _button2;

        public TwoButtonsCell()
        {
        }
        public override Type FormattedValueType
        {
            get { return typeof(string); }
        }

        public override Type ValueType
        {
            get { return typeof(string); }
        }

        protected override void Paint(Graphics graphics, Rectangle clipBounds, Rectangle cellBounds, int rowIndex, DataGridViewElementStates cellState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts)
        {
            base.Paint(graphics, clipBounds, cellBounds, rowIndex, cellState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts);

            // Calculate button positions and sizes within the cell
            //Rectangle button1Rect = new Rectangle(cellBounds.X + 2, cellBounds.Y + 2, cellBounds.Width / 2 - 4, cellBounds.Height - 4);
            //Rectangle button2Rect = new Rectangle(cellBounds.X + cellBounds.Width / 2 + 2, cellBounds.Y + 2, cellBounds.Width / 2 - 4, cellBounds.Height - 4);

            int buttonWidth = cellBounds.Width / 2;
            int buttonHeight = cellBounds.Height - 6;
            Rectangle editRect = new Rectangle(cellBounds.X + 3, cellBounds.Y + 3, buttonWidth, buttonHeight);
            Rectangle deleteRect = new Rectangle(cellBounds.X + 5 + buttonWidth, cellBounds.Y + 3, buttonWidth, buttonHeight);

            DrawButton(graphics, editRect, Properties.Resources.EditIcon);
            //(graphics, deleteRect, Properties.Resources.DeleteIcon);

        }

        private void DrawButton(Graphics g, Rectangle rect, Image icon)
        {
            ButtonRenderer.DrawButton(g, rect, PushButtonState.Normal);

            // Dibujar icono
            int iconSize = 16;
            int iconX = rect.X + 6;
            int iconY = rect.Y + (rect.Height - iconSize) / 2;
            g.DrawImage(icon, new Rectangle(iconX, iconY, iconSize, iconSize));
        }

        protected override void OnMouseClick(DataGridViewCellMouseEventArgs e)
        {
            base.OnMouseClick(e);

            Rectangle cellBounds = this.DataGridView.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);

            Rectangle button1Rect = new Rectangle(cellBounds.X + 2, cellBounds.Y + 2, cellBounds.Width / 2 - 4, cellBounds.Height - 4);
            Rectangle button2Rect = new Rectangle(cellBounds.X + cellBounds.Width / 2 + 2, cellBounds.Y + 2, cellBounds.Width / 2 - 4, cellBounds.Height - 4);

            if (button1Rect.Contains(e.Location))
            {
                DataGridView.Tag = "Editar";
            }
            else if (button2Rect.Contains(e.Location))
            {
                DataGridView.Tag = "Borrar";
            }
        }
    }
}
