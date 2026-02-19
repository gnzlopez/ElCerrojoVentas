using ElCerrojoPresentation.Utils.Customs;
using ElCerrojoPresentation.ViewModels;
using ElCerrojoServices.DTOs;
using ElCerrojoServices.Implementation;
using ElCerrojoServices.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualBasic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElCerrojoPresentation.Forms
{
    public partial class frmGestion : Form
    {
        private readonly ICategoryService _categoryService;
        private readonly IBrandService _brandService;
        private readonly ISupplierService _supplierService;

        public frmGestion(ICategoryService categoryService, IBrandService brandService, ISupplierService supplierService)
        {
            InitializeComponent();
            _categoryService = categoryService;
            _brandService = brandService;
            _supplierService = supplierService;
        }

        private async Task ShowCategs(string searchText)
        {
            var cateList = await _categoryService.GetByText(searchText);

            var listVM = cateList.Select(x => new SimpleVM
            {
                Id = x.Id,
                Nombre = x.Name,
            }).ToList();

            dgvCategList.Columns["Id"].Visible = false;

            dgvCategList.DataSource = listVM;
        }

        private async Task ShowBrands(string searchText)
        {
            var cateList = await _brandService.GetByText(searchText);

            var listVM = cateList.Select(x => new SimpleVM
            {
                Id = x.Id,
                Nombre = x.Name,
            }).ToList();

            dgvBrandList.Columns["Id"].Visible = false;

            dgvBrandList.DataSource = listVM;
        }

        private async Task ShowSupplies(string searchText)
        {
            var suppList = await _supplierService.GetByText(searchText);

            var listVM = suppList.Select(x => new SupplierVM
            {
                Id = x.Id,
                Name = x.Name,
                ContactName = x.ContactName,
                Phone = x.Phone
            }).ToList();

            dgvSuppList.Columns["Id"].Visible = false;

            dgvSuppList.DataSource = listVM;
        }

        private async void frmGestion_Load(object sender, EventArgs e)
        {
            dgvCategList.DataSource = new List<SimpleVM>();
            dgvCategList.ImplementConfigTwoBtn();

            await ShowCategs("");

            dgvSuppList.DataSource = new List<SupplierVM>();
            dgvSuppList.ImplementConfigTwoBtn();

            await ShowSupplies("");

            dgvBrandList.DataSource = new List<SimpleVM>();
            dgvBrandList.ImplementConfigTwoBtn();

            await ShowBrands("");
        }

        private async void btnNewCateg_Click(object sender, EventArgs e)
        {
            string name = Interaction.InputBox("Ingrese el nombre de la categoria:", "Nueva Categoria", "");

            if (string.IsNullOrEmpty(name))
            {
                return;
            }

            await _categoryService.Add(new CategoryDto() { Name = name });
            await ShowCategs(txbSearchCateg.Text);

        }

        private void dgvCategList_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            e.ImplementIconButtons();
        }

        private async void dgvCategList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCategList.Columns[e.ColumnIndex].Tag == null) return;

            var boundItem = (SimpleVM)dgvCategList.Rows[e.RowIndex].DataBoundItem;
            var cateName = boundItem.Nombre;

            if (dgvCategList.Columns[e.ColumnIndex].Tag.ToString() == CustomDataGridView.ActionColumnTag)
            {
                var colName = dgvCategList.Columns[e.ColumnIndex].Name;

                if (colName == CustomDataGridView.ActionNameEdit)
                {
                    string qtyString = Interaction.InputBox("Ingrese el nuevo nombre de la categoria:", "Editar Categoria", cateName);

                    if (string.IsNullOrEmpty(qtyString))
                    {
                        return;
                    }

                    await _categoryService.Edit(new CategoryDto() { Id = boundItem.Id, Name = qtyString });
                }

                if (colName == CustomDataGridView.ActionNameDelete)
                {
                    DialogResult result = MessageBox.Show(
                            $"Desea eliminar la categoria {cateName}?",
                            "Eliminar Categoria",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Information);

                    if (result == DialogResult.Yes)
                    {
                        await _categoryService.Delete(boundItem.Id);

                        MessageBox.Show($"Categoria {cateName} eliminada");
                    }

                }
            }

            await ShowCategs(txbSearchCateg.Text);
        }

        private async void btnSearchCateg_Click(object sender, EventArgs e)
        {
            await ShowCategs(txbSearchCateg.Text);
        }

        private async void btnNewBrand_Click(object sender, EventArgs e)
        {
            string name = Interaction.InputBox("Ingrese el nombre de la marca:", "Nueva Marca", "");

            if (string.IsNullOrEmpty(name))
            {
                return;
            }

            await _brandService.Add(new BrandDto() { Name = name });
            await ShowBrands(txbSearchBrand.Text);
        }

        private async void btnSearchBrand_Click(object sender, EventArgs e)
        {

            await ShowBrands(txbSearchBrand.Text);
        }

        private void dgvBrandList_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            e.ImplementIconButtons();
        }

        private async void dgvBrandList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvBrandList.Columns[e.ColumnIndex].Tag == null) return;

            var boundItem = (SimpleVM)dgvBrandList.Rows[e.RowIndex].DataBoundItem;
            var brandName = boundItem.Nombre;

            if (dgvBrandList.Columns[e.ColumnIndex].Tag.ToString() == CustomDataGridView.ActionColumnTag)
            {
                var colName = dgvBrandList.Columns[e.ColumnIndex].Name;

                if (colName == CustomDataGridView.ActionNameEdit)
                {
                    string qtyString = Interaction.InputBox("Ingrese el nuevo nombre de la marca:", "Editar Marca", brandName);

                    if (string.IsNullOrEmpty(qtyString))
                    {
                        return;
                    }

                    await _brandService.Edit(new BrandDto() { Id = boundItem.Id, Name = qtyString });
                }

                if (colName == CustomDataGridView.ActionNameDelete)
                {
                    DialogResult result = MessageBox.Show(
                            $"Desea eliminar la marca {brandName}?",
                            "Eliminar Marca",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Information);

                    if (result == DialogResult.Yes)
                    {
                        await _brandService.Delete(boundItem.Id);

                        MessageBox.Show($"Marca {brandName} eliminada");
                    }

                }
            }

            await ShowBrands(txbSearchBrand.Text);
        }

        private async void btnNewSupp_Click(object sender, EventArgs e)
        {
            using (var frm = new frmProveedor())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    var name = frm.Name;
                    var contactName = frm.ContactName;
                    var phone = frm.Phone;

                    if (string.IsNullOrEmpty(name))
                    {
                        MessageBox.Show("El proveedor debe tener al menos un nombre");
                        return;
                    }

                    await _supplierService.Add(new SupplierDto()
                    {
                        Name = name,
                        ContactName = contactName,
                        Phone = phone
                    });

                    txbSearchSup.Text = "";
                    await ShowSupplies("");
                }
            }
        }

        private async void btnSearchSupp_Click(object sender, EventArgs e)
        {
            await ShowSupplies(txbSearchSup.Text);
        }

        private void dgvSuppList_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            e.ImplementIconButtons();
        }

        private async void dgvSuppList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSuppList.Columns[e.ColumnIndex].Tag == null) return;

            var boundItem = (SupplierVM)dgvSuppList.Rows[e.RowIndex].DataBoundItem;
            var suppName = boundItem.Name;

            if (dgvSuppList.Columns[e.ColumnIndex].Tag.ToString() == CustomDataGridView.ActionColumnTag)
            {
                var colName = dgvSuppList.Columns[e.ColumnIndex].Name;

                if (colName == CustomDataGridView.ActionNameEdit)
                {
                    using (var frm = new frmProveedor(suppName, boundItem.ContactName, boundItem.Phone))
                    {
                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            var name = frm.Name;
                            var contactName = frm.ContactName;
                            var phone = frm.Phone;

                            if (string.IsNullOrEmpty(name))
                            {
                                MessageBox.Show("El proveedor debe tener al menos un nombre");
                                return;
                            }

                            await _supplierService.Edit(new SupplierDto()
                            {
                                Id = boundItem.Id,
                                Name = name,
                                ContactName = contactName,
                                Phone = phone
                            });
                        }
                    }
                }

                if (colName == CustomDataGridView.ActionNameDelete)
                {
                    DialogResult result = MessageBox.Show(
                            $"Desea eliminar el proveedor {suppName}?",
                            "Eliminar Proveedor",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Information);

                    if (result == DialogResult.Yes)
                    {
                        await _supplierService.Delete(boundItem.Id);

                        MessageBox.Show($"Proveedor {suppName} eliminado");
                    }

                }
            }

            txbSearchSup.Text = "";
            await ShowSupplies("");
        }

        private void dgvCategList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvCategList.ClearSelection();
            dgvCategList.CurrentCell = null;
        }

        private void dgvSuppList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvSuppList.ClearSelection();
            dgvSuppList.CurrentCell = null;
        }

        private void dgvBrandList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvBrandList.ClearSelection();
            dgvBrandList.CurrentCell = null;
        }
    }
}
