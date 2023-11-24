using facturacion.domain.Entidades;

namespace facturacion.domain.Interfaces
{
    public interface IProductoRepository
    {
        public Task<IEnumerable<Producto>> GetAllAsync();
    }
}
