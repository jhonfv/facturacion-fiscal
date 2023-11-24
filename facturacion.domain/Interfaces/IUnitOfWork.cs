using System.Data;

namespace facturacion.domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IDbTransaction Transaction { get; }
        void Begin();
        void Commit();
        void Rollback();
    }
}
