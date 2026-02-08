using System.ComponentModel;

namespace ElCerrojoPresentation.ViewModels
{
    public class SaleReportVM
    {
        [DisplayName("N° Venta")]
        public string SaleNumber { get; set; } = "";

        [DisplayName("Fecha")]
        public DateOnly Date { get; set; }

        [DisplayName("Producto")]
        public string ProductName { get; set; } = "";

        [DisplayName("Precio Unit.")]
        public decimal UnitPrice { get; set; }

        [DisplayName("Cantidad")]
        public int Quantity { get; set; }

        [DisplayName("Total")]
        public decimal TotalPrice { get; set; }
    }
}
