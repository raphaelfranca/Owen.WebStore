﻿using Owen.WebStore.Domain.Entities;
using System.Collections.Generic;

namespace Owen.WeStore.Domain.Repositories
{
    public interface IProductRepository
    {
        List<Product> Get();
        List<Product> Get(int skip, int take);
        List<Product> GetProductsInStock();
        List<Product> GetProductsOutOfStock();
        Product Get(int id);
        void Create(Product product);
        void Update(Product product);
        void Delete(Product product);
    }
}
