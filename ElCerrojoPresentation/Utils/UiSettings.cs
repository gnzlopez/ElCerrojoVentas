using ElCerrojoPresentation.Properties;
using System.Collections.Generic;
using System.Drawing.Drawing2D;

namespace ElCerrojoPresentation.Utils
{
    public static class UiTheme
    {
        private static Dictionary<Type, int> typeDict = new Dictionary<Type, int>
                                        {
                                            {typeof(Button), 1},
                                            {typeof(DataGridView), 2},
                                            {typeof(ComboBox), 3}
                                        };

        public static Font GetAppFont()
        {
            var name = Properties.Settings.Default.UiFontName ?? "Segoe UI";
            var size = (float)Properties.Settings.Default.UiFontSize;
            var style = Properties.Settings.Default.UiFontBold ? FontStyle.Bold : FontStyle.Regular;

            return new Font(name, size, style);
        }

        public static class UiPolish
        {
            public static void ApplyStandardSpacing(Control root, int pad = 8)
            {
                //root.Padding = new Padding(pad);

                foreach (Control c in root.Controls)
                {
                    // margen típico entre controles
                    //c.Margin = new Padding(pad);
                    var value = 0;
                    typeDict.TryGetValue(c.GetType(), out value);
                    switch (value)
                    {
                        case 1:
                            StyleButton((Button)c);
                            break;
                        case 2:
                            StyleGrid((DataGridView)c);
                            break;
                        //case 3:
                        //    StyleComboBox((ComboBox)c);
                        //    break;
                        default:
                            break;
                    }

                    if (c.HasChildren)
                        ApplyStandardSpacing(c, pad);
                }
            }
            
            public static void StyleButton(Button b)
            {
                b.FlatStyle = FlatStyle.Flat;
                b.FlatAppearance.BorderSize = 1;
                //b.Height = Math.Max(b.Height, 36);
                b.TextAlign = ContentAlignment.MiddleCenter;
                b.UseCompatibleTextRendering = false;
                b.BackColor = ColorTranslator.FromHtml(Util.resColor);
                b.ForeColor = Color.Black;

                b.Resize += (s, e) =>
                {
                    var path = GetRoundedPath(
                        b.ClientRectangle,
                        10);

                    b.Region = new Region(path);
                };
            }

            public static void StyleGrid(DataGridView g)
            {
                g.BorderStyle = BorderStyle.None;
                g.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                g.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                g.RowHeadersVisible = false;
                g.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                g.MultiSelect = false;
                g.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                g.RowTemplate.Height = 32;

                g.EnableHeadersVisualStyles = false;
                g.ColumnHeadersDefaultCellStyle.Font = new Font(g.Font, FontStyle.Bold);
            }

            public static GraphicsPath GetRoundedPath(Rectangle rect, int radius)
            {
                int d = radius * 2;
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
}
