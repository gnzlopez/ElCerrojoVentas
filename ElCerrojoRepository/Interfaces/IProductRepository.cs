using ElCerrojoRepository.Entities;

namespace ElCerrojoRepository.Interfaces
{
    public interface IProductRepository : IRepositoryTransaction
    {
        Task<Product> Add(Product product);
        Task Edit(Product product);
        Task Delete(int id);
        Task<List<Product>> GetAll();
        Task<Product?> GetById(int id);
        Task<Product?> GetByCode(string productCode);
        Task<List<Product>> GetByText(string searchText, int? brandId = null, int? categId = null);
        Task AddList(List<Product> products);
        Task ImportExcel(IEnumerable<Product> products);
        Task UpdatePrices(IReadOnlyCollection<int> ids, decimal multiplier);
    }
}
