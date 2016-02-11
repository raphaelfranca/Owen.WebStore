using Owen.WebStore.SharedKernel.Events.Contracts;
using System;
using System.Collections.Generic;

namespace Owen.WebStore.SharedKernel 
{
    public interface IHandler<T> : IDisposable where T : IDomainEvent
    {
        void Handle(T args);
        IEnumerable<T> Notify();
        bool HasNotifications();
    }
}
