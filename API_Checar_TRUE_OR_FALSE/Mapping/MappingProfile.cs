using API_Checar_TRUE_OR_FALSE.Entidade;
using API_Checar_TRUE_OR_FALSE.Models;
using AutoMapper;

namespace API_Checar_TRUE_OR_FALSE.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Cliente, ClienteViewModel>()
                .ForMember(destino => destino.Liberado, src => src.MapFrom(src => src.Idade < 18 ? false : true))
                .ReverseMap();

        }
    }
}
