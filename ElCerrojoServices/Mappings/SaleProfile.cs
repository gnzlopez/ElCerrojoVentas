using AutoMapper;
using ElCerrojoRepository.Entities;
using ElCerrojoServices.DTOs;

namespace ElCerrojoServices.Mappings
{
    public class SaleProfile : Profile
    {
        public SaleProfile()
        {
            CreateMap<Sale, SaleDto>()
                .ForMember(d => d.Details, o => o.MapFrom(s => s.SaleDetails));

            CreateMap<SaleDto, Sale>()
                .ForMember(d => d.SaleDetails, o => o.MapFrom(s => s.Details));
        }
    }
}
