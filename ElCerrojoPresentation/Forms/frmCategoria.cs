using ElCerrojoPresentation.Utils.Customs;
using ElCerrojoPresentation.ViewModels;
using ElCerrojoServices.DTOs;
using ElCerrojoServices.Interfaces;
using Microsoft.VisualBasic;

namespace ElCerrojoPresentation.Forms
{
    public partial class frmCategoria : Form
    {
        private ICategoryService _categotyService;
        //private BindingList<SimpleVM> _categoriaList = new BindingList<SimpleVM>();

        public frmCategoria(ICategoryService categotyService)
        {
            InitializeComponent();
            _categotyService = categotyService;
        }

        private async Task ShowProductsCategs(string searchText)
        {
            var cateList = await _categotyService.GetByText(searchText);

            var listVM = cateList.Select(x => new SimpleVM
                                                {   
                                                    Id = x.Id,
                                                    Nombre = x.Name,
                                                }).ToList();

            dgvCategList.Columns["Id"].Visible = false;

            dgvCategList.DataSource = listVM;
        }

        private async void frmCategoria_Load(object sender, EventArgs e)
        {
            dgvCategList.DataSource = new List<SimpleVM>();
            dgvCategList.ImplementConfigTwoBtn();

            await ShowProductsCategs("");
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            string name = Interaction.InputBox("Ingrese el nombre de la categoria:", "Nueva Categoria", "1");

            _categotyService.Add(new CategoryDto() { Name = name });
        }

        private void dgvCategList_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            e.ImplementIconButtons();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            await ShowProductsCategs(txbSearch.Text);
        }

        private async void dgvCategList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCategList.Columns[e.ColumnIndex].Tag == null) return;

            var boundItem = (SimpleVM)dgvCategList.Rows[e.RowIndex].DataBoundItem;
            var cateName = boundItem.Nombre;

            if (dgvCategList.Columns[e.ColumnIndex].Tag.ToString() == CustomDataGridView.ActionColumnTag)
            {
                var colName = dgvCategList.Columns[e.ColumnIndex].Name;
                
                if(colName == CustomDataGridView.ActionNameEdit)
                {
                    string qtyString = Interaction.InputBox("Ingrese el nuevo nombre de la categoria:", "Editar Categoria", cateName);

                    if (string.IsNullOrEmpty(qtyString))
                    {
                        return;
                    }

                    await _categotyService.Edit(new CategoryDto() { Id = boundItem.Id, Name = qtyString });
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
                        await _categotyService.Delete(boundItem.Id); 
                        
                        MessageBox.Show($"Categoria {cateName} eliminada");
                    }

                }
            }

            await ShowProductsCategs(txbSearch.Text);
        }
    }
}
