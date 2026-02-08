using AutoMapper;
using ElCerrojoRepository.Entities;
using ElCerrojoServices.DTOs;

namespace ElCerrojoServices.Mappings
{
    public class SaleDetailProfile : Profile
    {
        public SaleDetailProfile()
        {
            CreateMap<SaleDetail, SaleDetailDto>()
                .ForMember(d => d.ProductName, o => o.MapFrom(s => s.Product.Name))
                .ForMember(d => d.CategoryName, o => o.MapFrom(s => s.Product.Category.Name));

            CreateMap<SaleDetailDto, SaleDetail>()
                .ForMember(d => d.Product, o => o.Ignore())
                .ForMember(d => d.Sale, o => o.Ignore());
        }
    }

}
