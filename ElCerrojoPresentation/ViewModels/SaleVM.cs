using System.ComponentModel;

namespace ElCerrojoPresentation.ViewModels
{
    public class SaleVM
    {
        [DisplayName("Código")]
        public int Id { get; set; }

        [DisplayName("Nro. Venta")]
        public string SaleNum { get; set; } = "";

        [DisplayName("Cliente")]
        public string ClientName { get; set; } = "";

        [DisplayName("Total")]
        public decimal TotalPrice { get; set; }

        [DisplayName("Pagado")]
        public decimal PayPrice { get; set; }

        [DisplayName("Vuelto")]
        public decimal ChangePrice { get; set; }

        [DisplayName("Fecha")]
        public DateOnly Date { get; set; }
    }
}
