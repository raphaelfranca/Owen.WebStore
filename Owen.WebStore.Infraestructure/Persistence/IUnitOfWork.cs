using System;

namespace Owen.WebStore.Infraestructure.Persistence
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
    }
}
