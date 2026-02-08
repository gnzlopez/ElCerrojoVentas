namespace ElCerrojoServices.DTOs
{
    public class SupplierDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string ContactName { get; set; } = "";
        public long? Phone { get; set; }
    }
}
