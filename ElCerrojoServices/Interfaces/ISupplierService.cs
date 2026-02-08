using ElCerrojoServices.DTOs;

namespace ElCerrojoServices.Interfaces
{
    public interface ISupplierService
    {
        Task<int> Add(SupplierDto brand);
        Task Edit(SupplierDto brand);
        Task Delete(int id);
        Task<List<SupplierDto>> GetByText(string searchText);
        Task<List<SupplierDto>> GetAll();
    }
}
