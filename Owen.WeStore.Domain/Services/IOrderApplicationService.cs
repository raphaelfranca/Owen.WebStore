﻿using Owen.WebStore.Domain.Entities;
using Owen.WeStore.Domain.Commands.OrderCommands;
using System.Collections.Generic;

namespace Owen.WeStore.Domain.Services
{
    public interface IOrderApplicationService
    {
        List<Order> Get(string email, int skip, int take);
        List<Order> GetCreated(string email);
        List<Order> GetPaid(string email);
        List<Order> GetDelivered(string email);
        List<Order> GetCanceled(string email);
        Order GetDetails(int id, string email);
        Order Create(CreateOrderCommand command, string email);
        void Pay(int id, string email);
        void Delivery(int id, string email);
        void Cancel(int id, string email);
    }
}
