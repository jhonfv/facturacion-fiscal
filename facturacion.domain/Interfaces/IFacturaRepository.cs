using facturacion.domain.Entidades;

namespace facturacion.domain.Interfaces
{
    public interface IFacturaRepository
    {
        Task<Factura> verificarExistenciaAsync(int numeroFactura);
    }
}
