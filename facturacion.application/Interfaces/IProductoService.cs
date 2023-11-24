using facturacion.application.Common;
using facturacion.application.DTOs;

namespace facturacion.application.Interfaces
{
    public interface IProductoService
    {
        /// <summary>
        /// Obtener el listado de productos registrados en la db.
        /// </summary>
        /// <returns>
        /// Listado de clientes <see cref="Result"/>
        /// </returns>
        Task<Result<IEnumerable<ProductoDTO>>> getAllAsync();
    }
}
