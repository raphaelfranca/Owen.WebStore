﻿using Owen.WebStore.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Owen.WebStore.Infraestructure.Persistence.Map
{
    public class CategoryMap : EntityTypeConfiguration<Category>
    {
        public CategoryMap()
        {
            ToTable("Category");

            HasKey(x => x.Id);

            Property(x => x.Title)
                .HasMaxLength(60)
                .IsRequired();
        }
    }
}
