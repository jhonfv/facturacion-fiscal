using Dapper;
using facturacion.domain.Entidades;
using facturacion.domain.Interfaces;
using System.Data;

namespace facturacion.Infrastructure.Repository
{
    public class FacturaRepository : IFacturaRepository
    {
        private readonly IDbConnection _dbConnection;

        public FacturaRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public async Task<Factura> verificarExistenciaAsync(int numeroFactura)
        {
            var factura = await _dbConnection.QueryFirstOrDefaultAsync<Factura>("---", commandType: CommandType.StoredProcedure);
            return factura;
        }
    }
}
