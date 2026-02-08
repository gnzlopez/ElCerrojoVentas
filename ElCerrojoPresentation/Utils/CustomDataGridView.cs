namespace ElCerrojoPresentation.Utils
{
    public static class CustomDataGridView
    {
        public static readonly string ActionColumnTag = "Action";
        public static readonly string ActionNameSimple = "ActionColumn";
        public static readonly string ActionNameEdit = "ActionEditColumn";
        public static readonly string ActionNameDelete = "ActionDeleteColumn";

        public static void ImplementConfig(this DataGridView datagrid)
        {
            var color = ColorTranslator.FromHtml(Util.resColor);
            datagrid.AllowUserToAddRows = false;
            datagrid.AllowUserToDeleteRows = false;
            datagrid.AllowUserToResizeColumns = true;
            datagrid.AllowUserToResizeRows = false;
            datagrid.AllowUserToOrderColumns = false;
            datagrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            datagrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datagrid.FirstDisplayedCell = null;
            datagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datagrid.MultiSelect = false;
            datagrid.RowHeadersVisible = false;
            datagrid.ReadOnly = true;
            datagrid.BackgroundColor = Color.White;
            datagrid.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = color,
                SelectionBackColor = color
            };
            datagrid.DefaultCellStyle = new DataGridViewCellStyle
            {
                SelectionBackColor = Color.FromArgb(237, 212, 112),
                SelectionForeColor = Color.FromArgb(0, 0, 0),
            };
            datagrid.ColumnHeadersHeight = 30;
            datagrid.EnableHeadersVisualStyles = false;
            datagrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
        }

        public static void ImplementConfig(this DataGridView datagrid, string btnTxt = "")
        {
            ImplementConfig(datagrid);

            if (btnTxt != "")
            {
                var btnColumn = new DataGridViewButtonColumn();
                btnColumn.Text = btnTxt;
                btnColumn.Tag = ActionColumnTag;
                btnColumn.Name = ActionNameSimple;
                btnColumn.HeaderText = "";
                btnColumn.UseColumnTextForButtonValue = true;
                btnColumn.Width = 50;
                btnColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;


                datagrid.Columns.Add(btnColumn);
            }
        }

        public static void ImplementConfigTwoBtn(this DataGridView datagrid)
        {
            ImplementConfig(datagrid);

            var btnEdit = new DataGridViewButtonColumn();
            btnEdit.Text = "";
            btnEdit.Tag = ActionColumnTag;
            btnEdit.Name = ActionNameEdit;
            btnEdit.HeaderText = "Editar";
            btnEdit.UseColumnTextForButtonValue = true;
            btnEdit.Width = 50;
            btnEdit.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            btnEdit.FlatStyle = FlatStyle.Flat;

            DataGridViewCellStyle editStyle = new DataGridViewCellStyle();
            editStyle.BackColor = Color.White;
            editStyle.Tag = "EditCell";
            btnEdit.DefaultCellStyle = editStyle;

            datagrid.Columns.Add(btnEdit);

            var btnDelete = new DataGridViewButtonColumn();
            btnDelete.Text = "";
            btnDelete.Tag = ActionColumnTag;
            btnDelete.Name = ActionNameDelete;
            btnDelete.HeaderText = "Eliminar";
            btnDelete.UseColumnTextForButtonValue = true;
            btnDelete.Width = 50;
            btnDelete.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            btnDelete.FlatStyle = FlatStyle.Flat;

            DataGridViewCellStyle delStyle = new DataGridViewCellStyle();
            delStyle.BackColor = Color.White;
            delStyle.Tag = "DeleteCell";
            btnDelete.DefaultCellStyle = delStyle;

            datagrid.Columns.Add(btnDelete);
        }

        public static void ImplementIconButtons(this DataGridViewCellPaintingEventArgs e)
        {
            if (e.Graphics == null || e.CellStyle == null || e.CellStyle.Tag == null || String.IsNullOrEmpty(e.CellStyle.Tag.ToString()))
                return;

            var tag = e.CellStyle.Tag.ToString();

            if (tag == "EditCell" || tag == "DeleteCell")
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = e.CellBounds.Height - 5;
                var h = w;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                var icon = tag == "EditCell" ? Properties.Resources.EditIcon : Properties.Resources.DeleteIcon;

                e.Graphics.DrawImage(icon, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }
    }
}
