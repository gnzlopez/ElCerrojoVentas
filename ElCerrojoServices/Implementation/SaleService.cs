using AutoMapper;
using ElCerrojoRepository.Entities;
using ElCerrojoRepository.Interfaces;
using ElCerrojoServices.DTOs;
using ElCerrojoServices.Interfaces;

namespace ElCerrojoServices.Implementation
{
    public class SaleService : ISaleService
    {
        private readonly ISaleRepository _repo;
        private readonly IMapper _mapper;

        public SaleService(ISaleRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<int> Register(SaleDto dto)
        {
            var sale = _mapper.Map<Sale>(dto);
            return await _repo.Register(sale);
        }

        public async Task<SaleDto?> GetSale(int saleId)
        {
            var entity = await _repo.GetSale(saleId);

            if (entity == null)
                return null;

            return _mapper.Map<SaleDto>(entity);
        }

        public async Task<List<SaleDetailDto>> GetDetails(int saleId)
        {
            var entities = await _repo.GetDetails(saleId);
            return _mapper.Map<List<SaleDetailDto>>(entities);
        }

        public async Task<List<SaleDto>> GetSales(DateOnly dateI, DateOnly dateE, string search = "")
        {
            var entities = await _repo.GetSales(dateI, dateE, search);
            return _mapper.Map<List<SaleDto>>(entities);
        }

        public async Task<List<SaleDto>> GetReportDetails(DateOnly dateI, DateOnly dateE)
        {
            var entities = await _repo.GetSales(dateI, dateE, "");
            return _mapper.Map<List<SaleDto>>(entities);
        }
    }
}
