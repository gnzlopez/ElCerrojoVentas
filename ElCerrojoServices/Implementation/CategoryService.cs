using AutoMapper;
using ElCerrojoRepository.Entities;
using ElCerrojoRepository.Interfaces;
using ElCerrojoServices.DTOs;
using ElCerrojoServices.Interfaces;

namespace ElCerrojoServices.Implementation
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepo;
        private readonly IMapper _mapper;

        public CategoryService(ICategoryRepository categoryRepo, IMapper mapper)
        {
            _categoryRepo = categoryRepo;
            _mapper = mapper;
        }

        public async Task<int> Add(CategoryDto dto)
        {
            var entity = _mapper.Map<Category>(dto);

            var newId = await _categoryRepo.Add(entity);

            return newId;
        }

        public async Task Edit(CategoryDto dto)
        {
            var entity = _mapper.Map<Category>(dto);
            await _categoryRepo.Edit(entity);
        }

        public async Task Delete(int categoryId)
        {
            await _categoryRepo.Delete(categoryId);
        }

        public async Task<List<CategoryDto>> GetByText(string categoryName)
        {
            var entities = await _categoryRepo.GetByText(categoryName);
            return _mapper.Map<List<CategoryDto>>(entities);
        }
    }
}
