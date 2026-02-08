using AutoMapper;
using ElCerrojoRepository.Entities;
using ElCerrojoRepository.Interfaces;
using ElCerrojoServices.DTOs;
using ElCerrojoServices.Interfaces;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ElCerrojoServices.Implementation
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepo;
        private readonly IBrandService _brandService;
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public ProductService(
            IProductRepository productRepo,
            IBrandService brandService,
            ICategoryService categoryService,
            IMapper mapper)
        {
            _productRepo = productRepo;
            _brandService = brandService;
            _categoryService = categoryService;
            _mapper = mapper;
        }

        public async Task<ProductDto> Add(ProductDto dto)
        {

            await Validate(dto); 
            
            dto.BarCode = string.IsNullOrWhiteSpace(dto.BarCode)
                                ? null
                                : dto.BarCode.Trim();

            var entity = _mapper.Map<Product>(dto);

            var result = await _productRepo.Add(entity);

            return _mapper.Map<ProductDto>(result);
        }

        public async Task Edit(ProductDto dto)
        {
            await Validate(dto);

            var entity = await _productRepo.GetById(dto.Id);
            if (entity == null)
                throw new Exception("Producto no encontrado");

            _mapper.Map(dto, entity);

            await _productRepo.Edit(entity);
        }

        public async Task Delete(int id)
        {
            var entity = await _productRepo.GetById(id);
            if (entity == null)
                throw new Exception("Producto no encontrado");

            await _productRepo.Delete(id);
        }

        public async Task<List<ProductDto>> GetAll()
        {
            var entities = await _productRepo.GetAll();
            return _mapper.Map<List<ProductDto>>(entities);
        }

        public async Task<ProductDto?> GetByCode(string code)
        {
            var entity = await _productRepo.GetByCode(code);

            if (entity == null)
                return null;

            return _mapper.Map<ProductDto>(entity);
        }

        public async Task<List<ProductDto>> GetByText(string searchText, int? brandId = null, int? categId = null)
        {
            var entities = await _productRepo.GetByText(searchText, brandId, categId);
            return _mapper.Map<List<ProductDto>>(entities);
        }

        public async Task AddList(List<ProductDto> dtoList, IProgress<int>? progress = null)
        {
            int total = dtoList.Count;
            int processed = 0;
            int batchSize = 100;

            // Validaciones previas (una sola vez)
            //await ValidateList(dtoList);
            await _productRepo.BeginTransaction();

            try
            {

                // Mapeo una sola vez
                var entities = _mapper.Map<List<Product>>(dtoList);
                var chunkList = entities.Chunk(batchSize);

                foreach (var batch in chunkList)
                {
                    var list = batch.ToList();
                    await _productRepo.AddList(list);
                    processed++;

                    int percent = processed * 100 / chunkList.Count();
                    progress?.Report(percent);

                    await Task.Delay(10); // Simula proceso pesado
                }

                await _productRepo.CommitTransaction();
            }
            catch (Exception ex)
            {
                await _productRepo.RollbackTransaction();
                throw;
            }
        }

        public Task ImportExcel(List<ProductDto> dto)
        {
            throw new NotImplementedException();
        }

        public async Task UpdatePrices(IReadOnlyCollection<int> ids, bool isIncrease, decimal percent)
        {
            if (ids == null || ids.Count == 0)
                return;

            if (percent <= 0)
                throw new ArgumentException("El porcentaje debe ser mayor a 0.");

            decimal factor = percent / 100m;
            decimal multiplier = isIncrease ? (1m + factor) : (1m - factor);

            if (multiplier < 0)
            {
                throw new InvalidOperationException("El porcentaje genera precios negativos.");
            }

            await _productRepo.UpdatePrices(ids, multiplier);
        }

        private async Task Validate(ProductDto dto)
        {
            if (dto.Name.Trim().Length < 1)
                throw new Exception("El nombre no puede estar vacio.");

            if (dto.Price < 0)
                throw new Exception("El precio no puede ser negativo.");

            //var brand = await _brandRepo.GetById(dto.BrandId);
            //if (brand == null)
            //    throw new Exception("La Marca no existe.");

            //var category = await _categoryRepo.GetById(dto.CategoryId);
            //if (category == null)
            //    throw new Exception("La Categoria no existe.");
        }

        private async Task ValidateList(List<ProductDto> dtoList)
        {
            var brandIds = dtoList.Select(d => d.BrandId).Distinct().ToList();
            var categoryIds = dtoList.Select(d => d.CategoryId).Distinct().ToList();

            //if (!await _brandRepo.ExistsAll(brandIds))
            //    throw new Exception("One or more brands do not exist.");

            //if (!await _categoryRepo.ExistsAll(categoryIds))
            //    throw new Exception("One or more categories do not exist.");
        }

    }
}
