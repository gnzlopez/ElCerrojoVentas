using AutoMapper;
using ElCerrojoServices.DTOs;
using ElCerrojoRepository.Entities;

namespace ElCerrojoServices.Mappings
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            // Entity -> DTO (lectura)
            CreateMap<Product, ProductDto>()
                .ForMember(dest => dest.BrandName, opt => opt.MapFrom(src => src.Brand.Name))
                .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.Name));

            // DTO -> Entity
            CreateMap<ProductDto, Product>()
                .ForMember(dest => dest.Brand, opt => opt.Ignore())
                .ForMember(dest => dest.Category, opt => opt.Ignore());
        }
    }
}
