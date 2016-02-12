using Owen.WebStore.Domain.Entities;
using Owen.WebStore.Domain.Commands.ProductCommands;
using System.Collections.Generic;

namespace Owen.WebStore.Domain.Services
{
    public interface IProductApplicationService
    {
        List<Product> Get();
        List<Product> Get(int skip, int take);
        List<Product> GetOutOfStock();
        Product Get(int id);
        Product Create(CreateProductCommand command);
        Product UpdateBasicInformation(UpdateProductInfoCommand command);
        Product Delete(int id);
    }
}
