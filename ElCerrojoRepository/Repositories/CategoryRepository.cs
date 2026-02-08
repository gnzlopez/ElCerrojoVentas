using ElCerrojoRepository.DB;
using ElCerrojoRepository.Entities;
using ElCerrojoRepository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ElCerrojoRepository.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _context;

        public CategoryRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<int> Add(Category categ)
        {
            _context.Categories.Add(categ);
            await _context.SaveChangesAsync();
            return categ.Id;
        }

        public async Task Edit(Category categ)
        {
            var oldCate = _context.Categories.Find(categ.Id);

            if (oldCate != null)
            {
                oldCate.Name = categ.Name;
                await _context.SaveChangesAsync();
            }
        }

        public async Task Delete(int categID)
        {
            await _context.Categories.Where(e => e.Id == categID)
                                .ExecuteDeleteAsync();
        }

        public Task<List<Category>> GetByText(string cateName)
        {
            return _context.Categories
                            .Include(p => p.Products)
                            .Where(x => x.Name.ToUpper().Contains(cateName.ToUpper()))
                            .AsNoTracking().ToListAsync(); ;
        }
    }
}
