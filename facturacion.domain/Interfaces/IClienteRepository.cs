using facturacion.domain.Entidades;

namespace facturacion.domain.Interfaces
{
    public interface IClienteRepository
    {
        public Task<IEnumerable<Cliente>> GetAllAsync();
    }
}
