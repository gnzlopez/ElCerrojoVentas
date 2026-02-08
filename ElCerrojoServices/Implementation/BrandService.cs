using AutoMapper;
using ElCerrojoRepository.Entities;
using ElCerrojoRepository.Interfaces;
using ElCerrojoServices.DTOs;
using ElCerrojoServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElCerrojoServices.Implementation
{
    public class BrandService : IBrandService
    {
        private readonly IBrandRepository _repo;
        private readonly IMapper _mapper;

        public BrandService(IBrandRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<int> Add(BrandDto dto)
        {
            var entity = _mapper.Map<Brand>(dto);

            return await _repo.Add(entity);
        }

        public async Task Edit(BrandDto dto)
        {
            var entity = _mapper.Map<Brand>(dto);

            await _repo.Edit(entity);
        }

        public async Task Delete(int id)
        {
            await _repo.Delete(id);
        }

        public async Task<List<BrandDto>> GetByText(string searchText)
        {
            var entities = await _repo.GetByText(searchText);
            return _mapper.Map<List<BrandDto>>(entities);
        }

        public async Task<List<BrandDto>> GetAll()
        {
            var entities = await _repo.GetAll();
            return _mapper.Map<List<BrandDto>>(entities);
        }
    }
}
