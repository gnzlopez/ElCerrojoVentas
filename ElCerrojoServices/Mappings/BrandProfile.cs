using AutoMapper;
using ElCerrojoRepository.Entities;
using ElCerrojoServices.DTOs;

namespace ElCerrojoServices.Mappings
{
    public class BrandProfile : Profile
    {
        public BrandProfile()
        {
            CreateMap<Brand, BrandDto>();
            CreateMap<BrandDto, Brand>()
            .ForMember(dest => dest.Products, opt => opt.Ignore()); 
        }
    }
}
