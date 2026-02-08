using AutoMapper;
using ElCerrojoRepository.Entities;
using ElCerrojoRepository.Interfaces;
using ElCerrojoServices.DTOs;
using ElCerrojoServices.Interfaces;

namespace ElCerrojoServices.Implementation
{
    public class SupplierService : ISupplierService
    {
        private readonly ISupplierRepository _repo;
        private readonly IMapper _mapper;

        public SupplierService(ISupplierRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<int> Add(SupplierDto dto)
        {
            var entity = _mapper.Map<Supplier>(dto);

            return await _repo.Add(entity);
        }

        public async Task Edit(SupplierDto dto)
        {
            var entity = _mapper.Map<Supplier>(dto);

            await _repo.Edit(entity);
        }

        public async Task Delete(int id)
        {
            await _repo.Delete(id);
        }

        public async Task<List<SupplierDto>> GetByText(string searchText)
        {
            var entities = await _repo.GetByText(searchText);
            return _mapper.Map<List<SupplierDto>>(entities);
        }

        public async Task<List<SupplierDto>> GetAll()
        {
            var entities = await _repo.GetAll();
            return _mapper.Map<List<SupplierDto>>(entities);
        }
    }
}
