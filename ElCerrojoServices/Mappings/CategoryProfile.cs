using AutoMapper;
using ElCerrojoRepository.Entities;
using ElCerrojoServices.DTOs;

namespace ElCerrojoServices.Mappings
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<Category, CategoryDto>();
            CreateMap<CategoryDto, Category>()
            .ForMember(dest => dest.Products, opt => opt.Ignore()); 
        }
    }
}
