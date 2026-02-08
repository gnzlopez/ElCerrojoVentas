using AutoMapper;

namespace ElCerrojoServices.Mappings
{
    public class CommonProfile : Profile
    {
        public CommonProfile()
        {
            // DateOnly -> DateOnly (evita errores en runtime)
            CreateMap<DateOnly, DateOnly>()
                .ConvertUsing(d => d);

            // DateOnly -> DateTime (por si algún DTO usa DateTime)
            CreateMap<DateOnly, DateTime>()
                .ConvertUsing(d => d.ToDateTime(TimeOnly.MinValue));

            // DateTime -> DateOnly
            CreateMap<DateTime, DateOnly>()
                .ConvertUsing(d => DateOnly.FromDateTime(d));
        }
    }
}
