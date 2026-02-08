using ElCerrojoServices.DTOs;

namespace ElCerrojoServices.Interfaces
{
    public interface ICategoryService
    {
        Task<int> Add(CategoryDto dto);
        Task Edit(CategoryDto dto);
        Task Delete(int categoryId);
        Task<List<CategoryDto>> GetByText(string categoryName);
    }
}
