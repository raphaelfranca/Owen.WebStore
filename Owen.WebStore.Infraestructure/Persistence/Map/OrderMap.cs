﻿using Owen.WebStore.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Owen.WebStore.Infraestructure.Persistence.Map
{
    public class OrderMap : EntityTypeConfiguration<Order>
    {
        public OrderMap()
        {
            ToTable("Order");

            HasKey(x => x.Id);

            Property(x => x.Date).IsRequired();
            Property(x => x.Status).IsRequired();
            Ignore(x => x.Total);

            HasRequired(x => x.User);
            HasMany(x => x.OrderItems)
                .WithRequired(x => x.Order);
        }
    }
}
