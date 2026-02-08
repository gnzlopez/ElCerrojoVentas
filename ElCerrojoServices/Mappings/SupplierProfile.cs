using AutoMapper;
using ElCerrojoRepository.Entities;
using ElCerrojoServices.DTOs;

namespace ElCerrojoServices.Mappings
{
    public class SupplierProfile : Profile
    {
        public SupplierProfile()
        {
            CreateMap<Supplier, SupplierDto>();
            CreateMap<SupplierDto, Supplier>()
            .ForMember(dest => dest.Products, opt => opt.Ignore());
        }
    }
}
