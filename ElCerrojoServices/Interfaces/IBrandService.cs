using ElCerrojoServices.DTOs;

namespace ElCerrojoServices.Interfaces
{
    public interface IBrandService
    {
        Task<int> Add(BrandDto brand);
        Task Edit(BrandDto brand);
        Task Delete(int id);
        Task<List<BrandDto>>GetByText(string searchText);
        Task<List<BrandDto>> GetAll();
    }
}
