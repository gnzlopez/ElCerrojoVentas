using ElCerrojoPresentation.Utils;
using ElCerrojoPresentation.Utils.Customs;
using ElCerrojoPresentation.Utils.Objects;
using ElCerrojoPresentation.ViewModels;
using ElCerrojoServices.DTOs;
using ElCerrojoServices.Implementation;
using ElCerrojoServices.Interfaces;
using System.Data;
using System.Numerics;
using System.Windows.Forms;
using static ElCerrojoPresentation.Utils.UiTheme;

namespace ElCerrojoPresentation.Forms
{
    public partial class frmProducto : Form
    {
        private IProductService _productService;
        private IBrandService _brandService;
        private ICategoryService _categoryService;
        private ISupplierService _supplierService;
        private ProductVM selectedProd;

        public frmProducto(IProductService productService, IBrandService brandService, ICategoryService categoryService, ISupplierService supplierService)
        {
            InitializeComponent();
            _productService = productService;
            _brandService = brandService;
            _categoryService = categoryService;
            _supplierService = supplierService;

            dgvProductList.EditMode = DataGridViewEditMode.EditOnEnter;

            dgvProductList.CurrentCellDirtyStateChanged += dgvProductList_CurrentCellDirtyStateChanged;
            dgvProductList.CellValueChanged += dgvProductList_CellValueChanged;
            dgvProductList.CellClick += dgvProductList_CellClick;

            dgvProductList.CurrentCellDirtyStateChanged += (s, e) =>
            {
                if (dgvProductList.IsCurrentCellDirty)
                    dgvProductList.CommitEdit(DataGridViewDataErrorContexts.Commit);
            };
            _supplierService = supplierService;
        }

        public void ShowTab(string tabName)
        {
            var tabsMenu = new TabPage[] { tabList, tabNew, tabEdit };

            foreach (var tab in tabsMenu)
            {
                if (tab.Name != tabName)
                {
                    tab.Parent = null;
                }
                else
                {
                    tab.Parent = tabControlMain;
                }
            }
        }

        private async Task ShowProducts()
        {
            string searchText = txbSearch.Text;
            int? searchBrandId = ((ComboOption)cboListBrand.SelectedItem!) == null ? null : ((ComboOption)cboListBrand.SelectedItem!).Value;
            int? searchCategId = ((ComboOption)cboListCateg.SelectedItem!) == null ? null : ((ComboOption)cboListCateg.SelectedItem!).Value;
            int? searchSuppId = ((ComboOption)cboListSupp.SelectedItem!) == null ? null : ((ComboOption)cboListSupp.SelectedItem!).Value;

            var productList = await _productService.GetByText(searchText, searchBrandId, searchCategId, searchSuppId);

            var listVM = productList.Select(x => new ProductVM
            {
                Id = x.Id,
                Name = x.Name,
                CategoryId = x.CategoryId ?? 0,
                CategoryName = x.CategoryName,
                BrandId = x.BrandId ?? 0,
                BrandName = x.BrandName,
                SupplierId = x.SupplierId ?? 0,
                SupplierName = x.SupplierName,
                Price = x.Price,
                BuyPrice = x.BuyPrice,
                BarCode = x.BarCode ?? "",
                Stock = x.Stock
            }).ToList();

            dgvProductList.DataSource = listVM;

            //
            dgvProductList.ImplementConfigTwoBtn(); ;

            // Configs de columnas
            dgvProductList.Columns["Id"].Visible = false;
            dgvProductList.Columns["CategoryId"].Visible = false;
            dgvProductList.Columns["BrandId"].Visible = false;
            dgvProductList.Columns["SupplierId"].Visible = false;
            dgvProductList.Columns["BuyPrice"].Visible = false;
            dgvProductList.Columns["BarCode"].Visible = false;

            dgvProductList.Columns["Stock"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvProductList.Columns["Stock"].Width = 80;
            dgvProductList.Columns["Price"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvProductList.Columns["Price"].Width = 80;
            dgvProductList.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvProductList.Columns["Name"].Width = 250;

            UiPolish.StyleGrid(dgvProductList);

            _headerCheckBox.Checked = false;
            //PositionHeaderCheckBox();
        }

        private void AddHeaderCheckBox()
        {
            dgvProductList.Controls.Add(_headerCheckBox);

            _headerCheckBox.CheckedChanged += HeaderCheckBox_CheckedChanged;
        }

        private void PositionHeaderCheckBox()
        {
            if (_headerCheckBox == null || dgvProductList.Columns.Count == 0)
                return;

            var rect = dgvProductList.GetCellDisplayRectangle(0, -1, true);

            _headerCheckBox.Location = new Point(
                rect.X + (rect.Width - _headerCheckBox.Width) / 2,
                rect.Y + (rect.Height - _headerCheckBox.Height) / 2
            );
        }

        private async void frmProducto_Load(object sender, EventArgs e)
        {
            ShowTab(tabList.Name);
            dgvProductList.Columns.Insert(0, chkCol);
            dgvProductList.Columns[0].Width = 20;
            dgvProductList.Columns[0].MinimumWidth = 20;
            dgvProductList.Columns[0].Resizable = DataGridViewTriState.False;
            dgvProductList.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            AddHeaderCheckBox();
            //dgvProductList.DataSource = new List<ProductVM>();


            // Cargo los dropdown

            // Cargo las listas de marcas
            var brandsList = await _brandService.GetByText("");

            ComboOption[] brandItems = [new ComboOption() { Value = 0, Text = "Sin Marca" }];
            brandItems =
            [
                .. brandItems,
                .. brandsList.Select(x => new ComboOption { Text = $"{x.Name}", Value = x.Id }).ToArray()
,
            ];

            cboListBrand.InsertItems(brandItems);
            cboNewBrand.InsertItems(brandItems);
            cboEditBrand.InsertItems(brandItems);
            cboListBrand.SelectedIndex = 0;

            // Cargo las listas de categorias
            var categList = await _categoryService.GetByText("");

            ComboOption[] categItems = [new ComboOption() { Value = 0, Text = "Sin Categoria" }];

            categItems =
            [
                .. categItems,
                .. categList.Select(x => new ComboOption { Text = $"{x.Name}", Value = x.Id })
            ];

            cboListCateg.InsertItems(categItems);
            cboNewCateg.InsertItems(categItems);
            cboEditCateg.InsertItems(categItems);
            cboListCateg.SelectedIndex = 0;

            // Cargo las listas de proveedoress
            var suppList = await _supplierService.GetByText("");

            ComboOption[] suppItems = [new ComboOption() { Value = 0, Text = "Sin Proveedor" }];

            suppItems =
            [
                .. suppItems,
                .. suppList.Select(x => new ComboOption { Text = $"{x.Name}", Value = x.Id })
            ];

            cboListSupp.InsertItems(suppItems);
            cboNewSupp.InsertItems(suppItems);
            cboEditSupp.InsertItems(suppItems);
            cboListSupp.SelectedIndex = 0;

            await ShowProducts();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            await ShowProducts();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txbNewName.Text = "";
            cboNewBrand.SelectedIndex = 0;
            cboNewCateg.SelectedIndex = 0;
            cboNewSupp.SelectedIndex = 0;
            numNewPrice.Value = 0;
            numNewBuyPrice.Value = 0;
            numNewStock.Value = 0;

            ShowTab(tabNew.Name);
        }

        private void btnNewBack_Click(object sender, EventArgs e)
        {
            ShowTab(tabList.Name);
        }

        private async void btnNewSave_Click(object sender, EventArgs e)
        {
            if (txbNewName.Text.Trim().Length < 1)
            {
                MessageBox.Show("Debe ingresar un nombre de Producto");
                return;
            }

            var brandId = ((ComboOption)cboNewBrand.SelectedItem!).Value;
            var categId = ((ComboOption)cboNewCateg.SelectedItem!).Value;
            var suppId = ((ComboOption)cboNewSupp.SelectedItem!).Value;

            var newProduct = new ProductDto
            {
                Name = txbNewName.Text.Trim(),
                BrandId = brandId == 0 ? null : brandId,
                CategoryId = categId == 0 ? null : categId,
                SupplierId = suppId == 0 ? null : suppId,
                Price = numNewPrice.Value,
                BuyPrice = numNewBuyPrice.Value,
                BarCode = txbNewCode.Text.Trim(),
                Stock = (int)numNewStock.Value
            };

            await _productService.Add(newProduct);

            ShowTab(tabList.Name);
            btnSearch_Click(sender, e);
        }

        private async void dgvProductList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var actionName = dgvProductList.Columns[e.ColumnIndex].Name;
            selectedProd = (ProductVM)dgvProductList.CurrentRow.DataBoundItem;

            if (actionName == CustomDataGridView.ActionNameEdit)
            {
                txbEditName.Text = selectedProd.Name;
                cboEditBrand.SetValue(selectedProd.BrandId);
                cboEditCateg.SetValue(selectedProd.CategoryId);
                cboEditSupp.SetValue(selectedProd.SupplierId);
                numEditPrice.Value = selectedProd.Price;
                numEditBuyPrice.Value = selectedProd.BuyPrice;
                txbEditCode.Text = selectedProd.BarCode;
                numEditStock.Value = selectedProd.Stock;

                ShowTab(tabEdit.Name);

                txbEditName.SelectionStart = txbEditName.Text.Length;
                txbEditName.SelectionLength = 0;

                txbEditName.Select();
            }
            else if (actionName == CustomDataGridView.ActionNameDelete)
            {
                DialogResult result = MessageBox.Show(
                        $"Desea eliminar el Producto {selectedProd.Name}?",
                        "Eliminar Producto",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    await _productService.Delete(selectedProd.Id);

                    MessageBox.Show($"Producto {selectedProd.Name} eliminado");
                }


                await ShowProducts();
            }
            else if (e.RowIndex >= 0 && actionName == "chkCol")
            {
                dgvProductList.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void btnEditBack_Click(object sender, EventArgs e)
        {
            ShowTab(tabList.Name);
        }

        private async void btnEditSave_Click(object sender, EventArgs e)
        {
            if (txbEditName.Text.Trim().Length < 1)
            {
                MessageBox.Show("Debe ingresar un nombre de Producto");
                return;
            }

            var brandId = ((ComboOption)cboEditBrand.SelectedItem!).Value;
            var categId = ((ComboOption)cboEditCateg.SelectedItem!).Value;
            var suppId = ((ComboOption)cboEditSupp.SelectedItem!).Value;

            var editProduct = new ProductDto
            {
                Id = selectedProd.Id,
                Name = txbEditName.Text.Trim(),
                BrandId = brandId == 0 ? null : brandId,
                CategoryId = categId == 0 ? null : categId,
                SupplierId = suppId == 0 ? null : suppId,
                Price = numEditPrice.Value,
                BuyPrice = numEditBuyPrice.Value,
                BarCode = txbEditCode.Text.Trim(),
                Stock = (int)numEditStock.Value
            };

            await _productService.Edit(editProduct);

            ShowTab(tabList.Name);
            btnSearch_Click(sender, e);

        }

        private void cboNewBrand_DrawItem(object sender, DrawItemEventArgs e)
        {
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.Yellow), e.Bounds);
            }
            else
            {
                e.Graphics.FillRectangle(new SolidBrush(SystemColors.Window), e.Bounds);
            }

            e.Graphics.DrawString(cboNewBrand.Items[e.Index].ToString(),
                                          e.Font,
                                          new SolidBrush(Color.Black),
                                          new Point(e.Bounds.X, e.Bounds.Y));
        }

        private void dgvProductList_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e != null)
            {
                e.ImplementIconButtons();
            }

            if (e.RowIndex == -1 && e.ColumnIndex == 0)
            {
                PositionHeaderCheckBox();
            }
        }

        private void dgvProductList_Scroll(object sender, ScrollEventArgs e)
        {
            //PositionHeaderCheckBox();
        }

        private void dgvProductList_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            //PositionHeaderCheckBox();
        }

        private void HeaderCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            dgvProductList.EndEdit();
            var isChecked = _headerCheckBox.Checked;

            foreach (DataGridViewRow row in dgvProductList.Rows)
            {
                row.Cells["chkCol"].Value = isChecked;
            }
        }

        private async void cboListBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            await ShowProducts();
        }

        private async void cboListCateg_SelectedIndexChanged(object sender, EventArgs e)
        {
            await ShowProducts();
        }

        private async void cboListProv_SelectedIndexChanged(object sender, EventArgs e)
        {
            await ShowProducts();
        }

        private void dgvProductList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                bool allChecked = true;

                foreach (DataGridViewRow row in dgvProductList.Rows)
                {
                    if (!(bool?)row.Cells["chkCol"].Value == true)
                    {
                        allChecked = false;
                        break;
                    }
                }

                _headerCheckBox.CheckedChanged -= HeaderCheckBox_CheckedChanged;
                _headerCheckBox.Checked = allChecked;
                _headerCheckBox.CheckedChanged += HeaderCheckBox_CheckedChanged;
            }
        }

        private void dgvProductList_SizeChanged(object sender, EventArgs e)
        {
            //PositionHeaderCheckBox();
        }

        private void dgvProductList_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvProductList.IsCurrentCellDirty)
            {
                dgvProductList.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dgvProductList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvProductList.Columns[e.ColumnIndex].Name != "chkCol") return;

            var cell = dgvProductList.Rows[e.RowIndex].Cells["chkCol"];
            bool current = (bool?)cell.Value == true;
            cell.Value = !current;
        }

        private async void btnUpdatePrices_Click(object sender, EventArgs e)
        {
            var prodQty = dgvProductList.Rows
                                        .Cast<DataGridViewRow>()
                                        .Where(r => (bool?)r.Cells["chkCol"].Value == true).Count();

            if (prodQty < 1) { return; }

            using (var frm = new frmPrecios(prodQty))
            {
                if (frm.ShowDialog(this) != DialogResult.OK) { return; }

                var selectedIds = dgvProductList.Rows
                                                    .Cast<DataGridViewRow>()
                                                    .Where(r => (bool?)r.Cells["chkCol"].Value == true)
                                                    .Select(r => (int)r.Cells["Id"].Value)
                                                    .ToList();

                await _productService.UpdatePrices(selectedIds, frm.IsIncrease, frm.Percent);
            }

            await ShowProducts();
        }

        private void splitContainer1_Resize(object sender, EventArgs e)
        {
            splitContainer1.SplitterDistance = splitContainer1.Width / 2;
        }

        private void dgvProductList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var dgv = sender as DataGridView;

            if (dgv.Rows[e.RowIndex].DataBoundItem is ProductVM item)
            {
                if (item.Stock == 0)
                {
                    dgv.Rows[e.RowIndex].Cells["Stock"].Style.BackColor = Color.Red;
                    dgv.Rows[e.RowIndex].Cells["Stock"].Style.ForeColor = Color.White;
                }
                else
                {
                    // Opcional: restaurar color normal
                    dgv.Rows[e.RowIndex].Cells["Stock"].Style.BackColor = Color.White;
                    dgv.Rows[e.RowIndex].Cells["Stock"].Style.ForeColor = Color.Black;
                }
            }
        }

        private void dgvProductList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvProductList.ClearSelection();
            dgvProductList.CurrentCell = null;
        }

        private void cboListBrand_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            if (e.Index < 0) return;

            var cb = (ComboBox)sender!;
            bool selected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;

            var back = selected ? ColorTranslator.FromHtml(Util.resColor) : cb.BackColor; // tu "primary"
            var fore = selected ? Color.White : cb.ForeColor;

            using var b = new SolidBrush(back);
            e.Graphics.FillRectangle(b, e.Bounds);

            TextRenderer.DrawText(
                e.Graphics,
                cb.GetItemText(cb.Items[e.Index]),
                cb.Font,
                e.Bounds,
                fore,
                TextFormatFlags.Left | TextFormatFlags.VerticalCenter);

            e.DrawFocusRectangle();
        }
    }
}
