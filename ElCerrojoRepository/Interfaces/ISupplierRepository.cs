using ElCerrojoRepository.Entities;

namespace ElCerrojoRepository.Interfaces
{
    public interface ISupplierRepository
    {
        Task<int> Add(Supplier brand);
        Task Edit(Supplier brand);
        Task Delete(int id);
        Task<List<Supplier>> GetByText(string searchText);
        Task<List<Supplier>> GetAll();
    }
}
