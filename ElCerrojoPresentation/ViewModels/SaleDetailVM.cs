using System.ComponentModel;

namespace ElCerrojoPresentation.ViewModels
{
    public class SaleDetailVM
    {
        public int Id { get; set; }

        [DisplayName("Venta N°")]
        public int SaleId { get; set; }

        [DisplayName("ID Producto")]
        public int ProductId { get; set; }

        [DisplayName("Producto")]
        public string ProductName { get; set; } = "";

        [DisplayName("Categoría")]
        public string CategoryName { get; set; } = "";

        [DisplayName("Cantidad")]
        public int Quantity { get; set; }

        [DisplayName("Precio Unit.")]
        public decimal SalePrice { get; set; }

        [DisplayName("Total")]
        public decimal TotalPrice { get; set; }
    }
}
