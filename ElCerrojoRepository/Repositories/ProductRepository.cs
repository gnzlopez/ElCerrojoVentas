using ElCerrojoRepository.DB;
using ElCerrojoRepository.Interfaces;
using ElCerrojoRepository.Entities;
using Microsoft.EntityFrameworkCore;

namespace ElCerrojoRepository.Repositories
{
    public class ProductRepository : RepositoryBase, IProductRepository
    {
        public ProductRepository(AppDbContext context)
            : base(context) { }

        public async Task<Product> Add(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return product;
        }

        public async Task Edit(Product product)
        {
            var oldProd = _context.Products.Find(product.Id);

            if (oldProd != null)
            {
                oldProd.Name = product.Name;
                oldProd.BrandId = product.BrandId;
                oldProd.Price = product.Price;
                oldProd.BuyPrice = product.BuyPrice;
                oldProd.BarCode = product.BarCode;
                oldProd.Stock = product.Stock;
                await _context.SaveChangesAsync();
            }
        }
        public async Task Delete(int id)
        {
            var entity = await _context.Products.FindAsync(id);
            if (entity != null)
            {
                _context.Products.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }

        public Task<List<Product>> GetAll()
        {
            return _context.Products
                            .Include(p => p.Category)
                            .Include(p => p.Brand)
                            .AsNoTracking().ToListAsync();
        }

        public async Task<Product?> GetById(int id)
        {
            return await _context.Products
                .Include(p => p.Brand)
                .Include(p => p.Category)
                .FirstOrDefaultAsync(p => p.Id == id);
        }

        public Task<Product?> GetByCode(string productCode)
        {
            return _context.Products
                            .Include(p => p.Category)
                            .Include(p => p.Brand)
                            .Include(p => p.Supplier)
                            .FirstOrDefaultAsync(x => x.BarCode == productCode);
        }

        public Task<List<Product>> GetByText(string searchText, int? brandId = null, int? categId = null, int? suppId = null)
        {
            return _context.Products
                            .Include(p => p.Category)
                            .Include(p => p.Brand)
                            .Include(p => p.Supplier)
                            .Where(x => (x.Name.ToUpper().Contains(searchText.ToUpper())
                                     || x.Category.Name.ToUpper().Contains(searchText.ToUpper())
                                     || x.Brand.Name.ToUpper().Contains(searchText.ToUpper())
                                     || x.Supplier.Name.ToUpper().Contains(searchText.ToUpper()))
                                     && (categId == null || categId == 0 || x.CategoryId == categId)
                                     && (brandId == null || brandId == 0 || x.BrandId == brandId)
                                     && (suppId == null || suppId == 0 || x.SupplierId == suppId))
                            .AsNoTracking().ToListAsync();
        }

        public async Task AddList(List<Product> products)
        {
            _context.ChangeTracker.AutoDetectChangesEnabled = false;

            _context.Products.AddRange(products);
            await _context.SaveChangesAsync();

            _context.ChangeTracker.AutoDetectChangesEnabled = true;
        }

        public async Task ImportExcel(IEnumerable<Product> products)
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    _context.Products.AddRange(products);
                    _context.SaveChanges();

                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                    throw; // se lo devolvés al servicio
                }
            }
        }

        public async Task UpdatePrices(IReadOnlyCollection<int> ids, decimal multiplier)
        {
            await _context.Products
                .Where(p => ids.Contains(p.Id))
                .ExecuteUpdateAsync(setters => setters
                    .SetProperty(p => p.Price, p => p.Price * multiplier));
        }
    }
}
