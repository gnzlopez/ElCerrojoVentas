namespace ElCerrojoServices.DTOs
{
    public class SaleDetailDto
    {
        public int Id { get; set; }
        public int SaleId { get; set; }
        public int ProductId { get; set; }

        public int Quantity { get; set; }
        public decimal SalePrice { get; set; }
        public decimal TotalPrice { get; set; }

        // Extra fields (flattened)
        public string ProductName { get; set; } = "";
        public string CategoryName { get; set; } = "";
    }
}
