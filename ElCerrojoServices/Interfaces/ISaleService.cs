using ElCerrojoServices.DTOs;

namespace ElCerrojoServices.Interfaces
{
    public interface ISaleService
    {
        Task<int> Register(SaleDto sale);
        Task<SaleDto?> GetSale(int saleId);
        Task<List<SaleDetailDto>> GetDetails(int saleId);
        Task<List<SaleDto>> GetSales(DateOnly dateI, DateOnly dateE, string search = "");
        Task<List<SaleDto>> GetReportDetails(DateOnly dateI, DateOnly dateE);
    }
}
