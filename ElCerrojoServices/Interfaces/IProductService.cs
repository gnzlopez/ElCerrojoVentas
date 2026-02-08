using ElCerrojoServices.DTOs;

namespace ElCerrojoServices.Interfaces
{
    public interface IProductService
    {
        Task<ProductDto> Add(ProductDto dto);
        Task Edit(ProductDto dto);
        Task Delete(int id);
        Task<List<ProductDto>> GetAll();
        Task<ProductDto?> GetByCode(string code);
        Task<List<ProductDto>> GetByText(string searchText, int? brandId = null, int? categId = null);
        Task AddList(List<ProductDto> dtoList, IProgress<int>? progress = null);
        Task ImportExcel(List<ProductDto> dto);
        Task UpdatePrices(IReadOnlyCollection<int> ids, bool isIncrease, decimal multiplier);
    }
}
