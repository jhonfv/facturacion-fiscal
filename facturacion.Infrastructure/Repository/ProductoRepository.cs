using Dapper;
using facturacion.domain.Entidades;
using facturacion.domain.Interfaces;
using System.Data;

namespace facturacion.Infrastructure.Repository
{
    public class ProductoRepository : IProductoRepository
    {
        private readonly IDbConnection _dbConnection;

        public ProductoRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public async Task<IEnumerable<Producto>> GetAllAsync()
        {
            var productos = await _dbConnection.QueryAsync<Producto>("spObtenerTodosLosProductos", commandType: CommandType.StoredProcedure);
            return productos;
        }
    }
}
