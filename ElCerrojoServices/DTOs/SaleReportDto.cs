namespace ElCerrojoServices.DTOs
{
    public class SaleReportDto
    {
        public string SaleNumber { get; set; } = "";
        public DateOnly Date { get; set; }

        public string ProductName { get; set; } = "";
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
