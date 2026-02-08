using AutoMapper;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Wordprocessing;
using ElCerrojoServices.DTOs;
using ElCerrojoServices.Interfaces;
using System.IO;
using System.Xml.Linq;

namespace ElCerrojoServices.Implementation
{
    public class CommonService : ICommonService
    {
        private readonly IProductService _productService;
        private readonly IBrandService _brandService;
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public CommonService(
            IProductService productService,
            IBrandService brandService,
            ICategoryService categoryService,
            IMapper mapper)
        {
            _productService = productService;
            _brandService = brandService;
            _categoryService = categoryService;
            _mapper = mapper;
        }

        public async Task ImportExcel(string filePath, IProgress<int>? progress = null, CancellationToken cancellationToken = default)
        {
            progress?.Report(10);

            using (var workbook = new XLWorkbook(filePath))
            {
                var productList = new List<ProductDto>();
                var productListWithoutCat = new List<ProductDto>();
                int? categId = null;
                int MarcaId;

                var products = await _productService.GetAll();
                var prodNames = products.Select(p => p.Name.ToLower())
                                        .ToHashSet();

                var categs = await _categoryService.GetByText("");
                var categsNames = categs.Select(c => c.Name.ToLower())
                                        .ToHashSet();

                var hoja = workbook.Worksheet(1); // Primera hoja
                var rows = hoja.RangeUsed().RowsUsed().Skip(1); // Saltear encabezado

                MarcaId = await _brandService.Add(new BrandDto() { Name = hoja.Name });

                progress?.Report(20);
                int processed = 0;

                foreach (var row in rows)
                {
                    string name = row.Cell(1).GetString();
                    decimal precio;
                    var boolDecim = decimal.TryParse(row.Cell(3).GetString(), out precio);

                    if (!boolDecim && !string.IsNullOrEmpty(name))
                    {
                        if (!categsNames.Contains(name.ToLower()))
                        {
                            categId = await _categoryService.Add(new CategoryDto() { Name = name });
                        }
                        else
                        {
                            categId = categs.First(c => c.Name == name).Id;
                        }
                    }
                    else if (string.IsNullOrEmpty(name))
                    {
                        categId = null;
                    }
                    else
                    {
                        if (!prodNames.Contains(name.ToLower()))
                        {
                            productList.Add(new ProductDto()
                            {
                                Name = name,
                                Price = precio,
                                CategoryId = categId,
                                BrandId = MarcaId

                            });
                        }
                    }
                    processed++;
                    progress?.Report(20 + (int)(70m/rows.Count() * processed));
                }

                await _productService.AddList(productList);
                progress?.Report(100);
            }
        }
    }
}
