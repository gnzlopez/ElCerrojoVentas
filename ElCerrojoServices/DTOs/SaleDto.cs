namespace ElCerrojoServices.DTOs
{
    public class SaleDto
    {
        public int Id { get; set; }
        public string SaleNum { get; set; } = "";
        public string ClientName { get; set; } = "";
        public decimal TotalPrice { get; set; }
        public decimal PayPrice { get; set; }
        public decimal ChangePrice { get; set; }
        public DateOnly Date { get; set; }

        public List<SaleDetailDto> Details { get; set; } = new();
    }
}
