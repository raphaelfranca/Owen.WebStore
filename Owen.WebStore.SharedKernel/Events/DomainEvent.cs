﻿using Owen.WebStore.SharedKernel.Events.Contracts;

namespace Owen.WebStore.SharedKernel.Events
{
    public static class DomainEvent
    {
        public static IContainer Container { get; set; } 

        public static void Raise<T>(T args) where T : IDomainEvent
        {
            try
            {
                if (Container != null)
                {
                    var obj = Container.GetService(typeof(IHandler<T>));
                    ((IHandler<T>)obj).Handle(args);
                }
            }
            catch
            {
                //throw;
            }
        }
    }
}