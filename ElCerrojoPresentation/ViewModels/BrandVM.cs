using System.ComponentModel;

namespace ElCerrojoPresentation.ViewModels
{
    public class BrandVM
    {
        [DisplayName("Código")]
        public int Id { get; set; }

        [DisplayName("Nombre")]
        public string Name { get; set; } = "";
    }
}
