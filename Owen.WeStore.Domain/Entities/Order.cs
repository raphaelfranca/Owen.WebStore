using Owen.WebStore.Domain.Enums;
using Owen.WebStore.Domain.Scopes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Owen.WebStore.Domain.Entities
{
    public class Order
    {
        private IList<OrderItem> _orderItems;

        public Order(IList<OrderItem> orderItems, int userId)
        {
            this.Date = DateTime.Now;
            this._orderItems = new List<OrderItem>();
            orderItems.ToList().ForEach(x => AddItem(x));
            this.UserId = userId;
            this.Status = EOrderStatus.Created;
        }

        public int Id { get; private set; }
        public DateTime Date { get; private set; }
        public ICollection<OrderItem> OrderItems
        {
            get { return _orderItems; }
            private set { _orderItems = new List<OrderItem>(value); }
        }
        public int UserId { get; private set; }
        public User User { get; private set; }
        public decimal Total
        {
            get
            {
                decimal total = 0;
                foreach (var item in _orderItems)
                    total += (item.Price * item.Quantity);

                return total;
            }
        }
        public EOrderStatus Status { get; set; }

        public void AddItem(OrderItem item)
        {
            if (item.Register())
                _orderItems.Add(item);
        }

        public void Place()
        {
            this.PlaceOrderScopeIsValid();              
        }

        public void MarkAsPaid()
        {
            // Dá baixa no estoque
            this.Status = EOrderStatus.Paid;
        }

        public void MarkAsDelivered()
        {
            this.Status = EOrderStatus.Delivered;
        }

        public void Cancel()
        {
            // Estorna os produtos

            this.Status = EOrderStatus.Canceled;
        }
    }
    
}
