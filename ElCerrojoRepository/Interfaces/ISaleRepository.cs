using ElCerrojoRepository.Entities;

namespace ElCerrojoRepository.Interfaces
{
    public interface ISaleRepository
    {
        Task<int> Register(Sale sale);
        Task<Sale?> GetSale(int saleId);
        Task<List<SaleDetail>> GetDetails(int saleId);
        Task<List<Sale>> GetSales(DateOnly dateI, DateOnly dateE, string search = "");
        Task<List<SaleDetail>> GetReportDetails(DateOnly dateI, DateOnly dateE);
    }
}
