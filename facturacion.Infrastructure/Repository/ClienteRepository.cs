using Dapper;
using facturacion.domain.Entidades;
using facturacion.domain.Interfaces;
using System.Data;

namespace facturacion.Infrastructure.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly IDbConnection _dbConnection;

        public ClienteRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public async Task<IEnumerable<Cliente>> GetAllAsync()
        {
            var clientes = await _dbConnection.QueryAsync<Cliente>("spObtenerTodosLosClientes", commandType: CommandType.StoredProcedure);
            return clientes;
        }
    }
}
