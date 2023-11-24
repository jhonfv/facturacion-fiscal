using AutoMapper;
using facturacion.application.DTOs;
using facturacion.domain.Entidades;

namespace facturacion.application.Mappers
{
    public class Profiles : Profile
    {
        public Profiles() { 
            CreateMap<Cliente, ClienteDTO>();
            CreateMap<ClienteDTO, Cliente>();

            CreateMap<Producto, ProductoDTO>();
            CreateMap<ProductoDTO, Producto>();
        }
    }
}
