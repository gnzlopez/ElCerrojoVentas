using ElCerrojoRepository.Entities;

namespace ElCerrojoRepository.Interfaces
{
    public interface ICategoryRepository
    {
        Task<int> Add(Category categ);
        Task Edit(Category categ);
        Task Delete(int categID);
        Task<List<Category>> GetByText(string cateName);
    }
}
