using ElCerrojoServices.DTOs;

namespace ElCerrojoServices.Interfaces
{
    public interface ISupplierService
    {
        Task<int> Add(SupplierDto supplier);
        Task Edit(SupplierDto supplier);
        Task Delete(int id);
        Task<List<SupplierDto>> GetByText(string searchText);
        Task<List<SupplierDto>> GetAll();
    }
}
