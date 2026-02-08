namespace ElCerrojoRepository.Entities
{
    public class Sale
    {
        public int Id { get; set; }    
        public string SaleNum { get; set; } = "";
        public string ClientName { get; set; } = "";
        public decimal TotalPrice { get; set; }
        public decimal PayPrice { get; set; }
        public decimal ChangePrice { get; set; }
        public DateOnly Date { get; set; }
        public List<SaleDetail> SaleDetails { get; set; } = new();
    }
}
