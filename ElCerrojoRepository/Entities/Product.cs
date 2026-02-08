using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ElCerrojoRepository.Entities
{
    public class Product
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

        // Navigation properties
        public Category? Category { get; set; }
        public Supplier? Supplier { get; set; }
        public Brand? Brand { get; set; }
    }
}
