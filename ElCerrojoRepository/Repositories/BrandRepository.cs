using ElCerrojoRepository.DB;
using ElCerrojoRepository.Interfaces;
using ElCerrojoRepository.Entities;
using Microsoft.EntityFrameworkCore;

namespace ElCerrojoRepository.Repositories
{
    public class BrandRepository : IBrandRepository
    {
        private readonly AppDbContext _context;

        public BrandRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<int> Add(Brand brand)
        {
            _context.Brands.Add(brand);
            return await _context.SaveChangesAsync();
        }

        public async Task Edit(Brand brand)
        {
            var oldBrand = _context.Brands.Find(brand.Id);

            if (oldBrand != null)
            {
                oldBrand.Name = brand.Name;
                await _context.SaveChangesAsync();
            }
        }

        public async Task Delete(int id)
        {
            var entity = await _context.Brands.FindAsync(id);
            if (entity != null)
            {
                _context.Brands.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }

        public Task<List<Brand>> GetByText(string searchText)
        {
            return _context.Brands.Where(x => x.Name.ToUpper().Contains(searchText.ToUpper())).AsNoTracking().ToListAsync();
        }

        public Task<List<Brand>> GetAll()
        {
            return _context.Brands.AsNoTracking().ToListAsync();
        }
    }
}
