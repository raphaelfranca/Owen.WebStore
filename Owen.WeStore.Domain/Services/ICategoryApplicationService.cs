using Owen.WebStore.Domain.Entities;
using Owen.WebStore.Domain.Commands.CategoryCommands;
using System.Collections.Generic;

namespace Owen.WebStore.Domain.Services
{
    public interface ICategoryApplicationService
    {
        List<Category> Get();
        List<Category> Get(int skip, int take);
        Category Get(int id);
        Category Create(CreateCategoryCommand command);
        Category Update(EditCategoryCommand command);
        Category Delete(int id);
    }
}
