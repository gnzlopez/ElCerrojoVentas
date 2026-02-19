using ElCerrojoPresentation.Utils;
using System.ComponentModel;
using System.Drawing.Drawing2D;

namespace ElCerrojoPresentation.Controls
{
    /// <summary>
    /// Clase para los botones redondeados - IA
    /// </summary>
    public class RoundedButton : Button
    {
        [Category("Appearance")]
        public int CornerRadius { get; set; } = 4;

        [Category("Appearance")]
        public int BorderThickness { get; set; } = 0;

        [Category("Appearance")]
        public Color BorderColor { get; set; } = Color.Black;

        [Category("Appearance")]
        public Color FillColor { get; set; } = ColorTranslator.FromHtml(Util.resColor);

        [Category("Appearance")]
        public Color HoverFillColor { get; set; } = Color.FromArgb(0, 102, 184);

        [Category("Appearance")]
        public Color PressedFillColor { get; set; } = Color.FromArgb(0, 84, 153);

        [Category("Appearance")]
        public Color TextColor { get; set; } = Color.Black;

        private bool _hovered;
        private bool _pressed;

        public RoundedButton()
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;

            // mejora visual y reduce parpadeo
            SetStyle(ControlStyles.UserPaint |
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw, true);

            ForeColor = TextColor;
            TextAlign = ContentAlignment.MiddleCenter;
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            UpdateRegion();
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            UpdateRegion();
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            _hovered = true;
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            _hovered = false;
            _pressed = false;
            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            base.OnMouseDown(mevent);
            if (mevent.Button == MouseButtons.Left)
            {
                _pressed = true;
                Invalidate();
            }
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            base.OnMouseUp(mevent);
            _pressed = false;
            Invalidate();
        }

        protected override void OnEnabledChanged(EventArgs e)
        {
            base.OnEnabledChanged(e);
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

            int border = Math.Max(0, BorderThickness);

            // Rect externo (para el relleno)
            var outer = new RectangleF(0, 0, Width - 1, Height - 1);

            // Color por estado
            Color fill =
                !Enabled ? ControlPaint.Light(FillColor) :
                _pressed ? PressedFillColor :
                _hovered ? HoverFillColor :
                FillColor;

            // Relleno
            using (var fillPath = GetRoundedPath(outer, CornerRadius))
            using (var brush = new SolidBrush(fill))
                e.Graphics.FillPath(brush, fillPath);

            // Borde (dibujado hacia adentro)
            if (border > 0)
            {
                // Si el borde es 1, el “truco” es dibujar a 0.5 para que se vea parejo
                float inset = border == 1 ? 0.5f : border / 2f;

                var borderRect = new RectangleF(
                    inset, inset,
                    (Width - 1) - (inset * 2),
                    (Height - 1) - (inset * 2));

                float borderRadius = Math.Max(1, CornerRadius - inset);

                using var borderPath = GetRoundedPath(borderRect, borderRadius);
                using var pen = new Pen(BorderColor, border);
                pen.Alignment = PenAlignment.Inset; // clave: siempre “para adentro”
                e.Graphics.DrawPath(pen, borderPath);
            }

            // Texto
            var textColor = !Enabled ? ControlPaint.Dark(TextColor) : TextColor;
            TextRenderer.DrawText(
                e.Graphics,
                Text,
                Font,
                ClientRectangle,
                textColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis);
        }


        private void UpdateRegion()
        {
            if (Width <= 0 || Height <= 0) return;

            var outer = new RectangleF(0, 0, Width - 1, Height - 1);
            using var path = GetRoundedPath(outer, CornerRadius);
            Region = new Region(path);
        }

        private static GraphicsPath GetRoundedPath(RectangleF rect, float radius)
        {
            float r = Math.Max(1, radius);
            float d = r * 2;

            var path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }

    }

}
