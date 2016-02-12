﻿using Owen.WebStore.Domain.Entities;
using Owen.WebStore.Infraestructure.Persistence;
using Owen.WeStore.Domain.Commands.ProductCommands;
using Owen.WeStore.Domain.Repositories;
using Owen.WeStore.Domain.Services;
using System.Collections.Generic;

namespace Owen.WebStore.ApplicationService
{
    public class ProductApplicationService : ApplicationService, IProductApplicationService
    {
        private IProductRepository _repository;

        public ProductApplicationService(IProductRepository repository, IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
            this._repository = repository;
        }

        public Product Create(CreateProductCommand command)
        {
            var product = new Product(command.Title, command.Description, command.Price, command.QuantityOnHand, command.CategoryId);
            product.Register();
            _repository.Create(product);

            if (Commit())
                return product;

            return null;
        }

        public Product Delete(int id)
        {
            var product = _repository.Get(id);
            _repository.Delete(product);

            if (Commit())
                return product;

            return null;
        }

        public List<Product> Get()
        {
            return _repository.GetProductsInStock();
        }

        public Product Get(int id)
        {
            return _repository.Get(id);
        }

        public List<Product> Get(int skip, int take)
        {
            return _repository.Get(skip, take);
        }

        public List<Product> GetOutOfStock()
        {
            return _repository.GetProductsOutOfStock();
        }

        public Product UpdateBasicInformation(UpdateProductInfoCommand command)
        {
            var product = _repository.Get(command.Id);
            product.UpdateInfo(command.Title, command.Description, command.CategoryId);
            _repository.Update(product);

            if (Commit())
                return product;

            return null;
        }
    }
}
