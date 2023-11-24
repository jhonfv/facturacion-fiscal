using AutoMapper;
using facturacion.application.Common;
using facturacion.application.DTOs;
using facturacion.application.Interfaces;
using facturacion.domain.Interfaces;

namespace facturacion.application.Services
{
    public class ProductoService : IProductoService
    {
        private readonly IProductoRepository _productoRepository;
        private readonly IMapper _mapper;

        public ProductoService(IProductoRepository productoRepository, IMapper mapper)
        {
            _productoRepository = productoRepository;
            _mapper = mapper;
        }

        public async Task<Result<IEnumerable<ProductoDTO>>> getAllAsync()
        {
            var productosEntity = await _productoRepository.GetAllAsync();
            if (productosEntity == null)
            {
                return new Result<IEnumerable<ProductoDTO>>().Failed(new List<string> { "Error al consultar la DB." });
            }
            else
            {
                var productoDTOs = _mapper.Map<IEnumerable<ProductoDTO>>(productosEntity);
                return new Result<IEnumerable<ProductoDTO>>().Success(productoDTOs);
            }
        }
    }
}
