using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElCerrojoPresentation.ViewModels
{
    public class ProductVM
    {
        [DisplayName("ID")]
        public int Id { get; set; }

        [DisplayName("Nombre")]
        public string Name { get; set; } = "";

        [DisplayName("Categoría")]
        public string CategoryName { get; set; } = "";

        [DisplayName("Marca")]
        public string BrandName { get; set; } = "";

        [DisplayName("Proveedor")]
        public string SupplierName { get; set; } = "";

        [DisplayName("Precio")]
        public decimal Price { get; set; }

        [DisplayName("Precio Compra")]
        public decimal BuyPrice { get; set; }

        [DisplayName("Código")]
        public string BarCode { get; set; } = "";

        [DisplayName("Stock")]
        public int Stock { get; set; }

        public int CategoryId { get; set; }
        public int BrandId { get; set; }
        public int SupplierId { get; set; }
    }
}
