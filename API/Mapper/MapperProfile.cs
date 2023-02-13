using API.Dtos;
using AutoMapper;
using Domain.Core.Entity;

namespace API.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<tbl_Clientes_Contacto, ClienteContactoDto>().ReverseMap();
            CreateMap<tbl_Clientes, ClienteDto>().ReverseMap();
        }
    }
}
