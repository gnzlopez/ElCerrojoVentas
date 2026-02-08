using System.Windows.Forms;

namespace ElCerrojoPresentation.Utils
{
    public class CustomToolStripRenderer : ToolStripProfessionalRenderer
    {
        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            if (e.Item.Selected)
            {
                Color hoverColor = Color.White;
                e.Graphics.FillRectangle(new SolidBrush(hoverColor), e.Item.ContentRectangle);
                e.Item.ForeColor = Color.Black;
            }
            else
            {
                Color hoverColor = ColorTranslator.FromHtml(Util.resColor);
                e.Graphics.FillRectangle(new SolidBrush(hoverColor), e.Item.ContentRectangle);
                e.Item.ForeColor = Color.Black;
            }
        }
    }
}
