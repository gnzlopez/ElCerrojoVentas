using ElCerrojoRepository.DB;
using ElCerrojoRepository.Interfaces;
using ElCerrojoRepository.Entities;
using Microsoft.EntityFrameworkCore;

namespace ElCerrojoRepository.Repositories
{
    public class SaleRepository : ISaleRepository
    {
        private readonly AppDbContext _context;

        public SaleRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<int> Register(Sale sale)
        {
            _context.Sales.Add(sale);

            foreach (var det in sale.SaleDetails)
            {
                var stock = _context.Products.FirstOrDefault(p => p.Id == det.ProductId).Stock;

                if (stock > det.Quantity) 
                { 
                    stock -= det.Quantity;
                }
                else
                {
                    stock = 0;
                }

                _context.Products.FirstOrDefault(p => p.Id == det.ProductId).Stock = stock;
            }

            await _context.SaveChangesAsync();
            return sale.Id;
        }

        public Task<Sale?> GetSale(int saleId)
        {
            return _context.Sales
                            .Include(s => s.SaleDetails)
                                .ThenInclude(d => d.Product)
                                .ThenInclude(p => p.Category)
                            .FirstOrDefaultAsync(x => x.Id == saleId);
        }

        public Task<List<SaleDetail>> GetDetails(int saleId)
        {
            return _context.DetailSale
                            .Include(d => d.Sale)
                            .Include(s => s.Product)
                            .Where(x => x.SaleId == saleId)
                            .ToListAsync();
        }

        public Task<List<Sale>> GetSales(DateOnly dateI, DateOnly dateE, string search = "")
        {
            return _context.Sales
                            .Include(s => s.SaleDetails)
                                .ThenInclude(d => d.Product)
                                .ThenInclude(p => p.Category)
                            .Where(x => x.Date >= dateI && x.Date <= dateE &&
                                   (x.Id.ToString().Contains(search) ||
                                    x.ClientName.Contains(search)))
                            .ToListAsync();
        }

        public Task<List<SaleDetail>> GetReportDetails(DateOnly dateI, DateOnly dateE)
        {
            return _context.DetailSale
                            .Include(d => d.Sale)
                            .Include(s => s.Product)
                            .Where(x => x.Sale.Date >= dateI && x.Sale.Date <= dateE)
                            .ToListAsync();
        }
    }
}
