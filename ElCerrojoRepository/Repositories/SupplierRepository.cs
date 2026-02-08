using ElCerrojoRepository.DB;
using ElCerrojoRepository.Entities;
using ElCerrojoRepository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ElCerrojoRepository.Repositories
{
    public class SupplierRepository : ISupplierRepository
    {
        private readonly AppDbContext _context;

        public SupplierRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<int> Add(Supplier supplier)
        {
            _context.Suppliers.Add(supplier);
            return await _context.SaveChangesAsync();
        }

        public async Task Edit(Supplier supplier)
        {
            var oldSupplier = _context.Suppliers.Find(supplier.Id);

            if (oldSupplier != null)
            {
                oldSupplier.Name = supplier.Name;
                await _context.SaveChangesAsync();
            }
        }

        public async Task Delete(int id)
        {
            var entity = await _context.Suppliers.FindAsync(id);
            if (entity != null)
            {
                _context.Suppliers.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }

        public Task<List<Supplier>> GetByText(string searchText)
        {
            return _context.Suppliers.Where(x => x.Name.ToUpper().Contains(searchText.ToUpper())
                                              || x.ContactName.ToUpper().Contains(searchText.ToUpper())).AsNoTracking().ToListAsync();
        }

        public Task<List<Supplier>> GetAll()
        {
            return _context.Suppliers.AsNoTracking().ToListAsync();
        }
    }
}
