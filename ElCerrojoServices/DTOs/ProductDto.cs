namespace ElCerrojoServices.DTOs
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public int? CategoryId { get; set; }
        public int? SupplierId { get; set; }
        public int? BrandId { get; set; }
        public decimal Price { get; set; }
        public decimal BuyPrice { get; set; }
        public string? BarCode { get; set; }
        public int Stock { get; set; }

        // Opcional nombres ya resueltos
        public string CategoryName { get; set; } = "";
        public string SupplierName { get; set; } = "";
        public string BrandName { get; set; } = "";
    }
}
