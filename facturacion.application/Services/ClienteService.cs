using AutoMapper;
using facturacion.application.Common;
using facturacion.application.DTOs;
using facturacion.application.Interfaces;
using facturacion.domain.Interfaces;

namespace facturacion.application.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ClienteService(IClienteRepository clienteRepository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _clienteRepository = clienteRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Result<IEnumerable<ClienteDTO>>> getAllAsync()
        {            
            var clientesEntity =await _clienteRepository.GetAllAsync();
            if(clientesEntity == null)
            {
                return new Result<IEnumerable<ClienteDTO>>().Failed(new List<string> { "Error al consultar la DB."});
            }
            else
            {
                var clientes = _mapper.Map<IEnumerable<ClienteDTO>>(clientesEntity);
                return new Result<IEnumerable<ClienteDTO>>().Success(clientes);
            }
        }
    }
}
