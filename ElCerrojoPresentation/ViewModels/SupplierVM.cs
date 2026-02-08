using System.ComponentModel;

namespace ElCerrojoPresentation.ViewModels
{
    internal class SupplierVM
    {
        public int Id { get; set; }

        [DisplayName("Nombre")]
        public string Name { get; set; } = "";

        [DisplayName("Contacto")]
        public string ContactName { get; set; } = "";

        [DisplayName("Teléfono")]
        public long? Phone { get; set; }
    }
}
