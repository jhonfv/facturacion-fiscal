using facturacion.domain.Interfaces;
using Microsoft.Data.SqlClient;
using System.Data;

namespace facturacion.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbConnection _connection;
        private IDbTransaction _transaction;
        private bool _disposed;

        public UnitOfWork(string connectionString)
        {
            _connection = new SqlConnection(connectionString);
            _connection.Open();
        }

        public IDbTransaction Transaction => _transaction;

        public void Begin()
        {
            _transaction = _connection.BeginTransaction();
        }

        public void Commit()
        {
            try
            {
                _transaction?.Commit();
            }
            catch
            {
                _transaction?.Rollback();
                throw;
            }
            finally
            {
                _transaction?.Dispose();
                _transaction = null;
            }
        }

        public void Rollback()
        {
            _transaction?.Rollback();
            _transaction?.Dispose();
            _transaction = null;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _transaction?.Dispose();
                    _connection?.Dispose();
                }

                _disposed = true;
            }
        }
    }

}
