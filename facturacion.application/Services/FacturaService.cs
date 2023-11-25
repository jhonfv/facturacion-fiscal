using AutoMapper;
using facturacion.application.DTOs;
using facturacion.application.Interfaces;
using facturacion.domain.Interfaces;

namespace facturacion.application.Services
{
    public class FacturaService : IFacturaService
    {
        IFacturaRepository _facturaRepository;
        IUnitOfWork _unitOfWork;
        IMapper _mapper;

        public FacturaService(IFacturaRepository facturaRepository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _facturaRepository = facturaRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public Task<IEnumerable<FacturaDTO>> getByClientIdAsync(int clienteId)
        {
            throw new NotImplementedException();
        }
    }
}
