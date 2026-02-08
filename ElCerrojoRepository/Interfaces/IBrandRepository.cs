using ElCerrojoRepository.Entities;

namespace ElCerrojoRepository.Interfaces
{
    public interface IBrandRepository
    {
        Task<int> Add(Brand brand);
        Task Edit(Brand brand);
        Task Delete(int id);
        Task<List<Brand>> GetByText(string searchText);
        Task<List<Brand>> GetAll();
    }
}
