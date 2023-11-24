using facturacion.application.Common;
using facturacion.application.DTOs;

namespace facturacion.application.Interfaces
{
    public interface IClienteService
    {
        /// <summary>
        /// Obtener el listado de clientes registrados en la db.
        /// </summary>
        /// <returns>
        /// Listado de clientes <see cref="Result"/>
        /// </returns>
        Task<Result<IEnumerable<ClienteDTO>>> getAllAsync();
    }
}
