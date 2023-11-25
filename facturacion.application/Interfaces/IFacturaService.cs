using facturacion.application.DTOs;

namespace facturacion.application.Interfaces
{
    public interface IFacturaService
    {
        public Task<IEnumerable<FacturaDTO>> getByClientIdAsync(int clienteId);
    }
}
