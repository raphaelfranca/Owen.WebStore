using Owen.WebStore.Domain.Entities;
using Owen.WeStore.Domain.Commands.CategoryCommands;
using System.Collections.Generic;

namespace Owen.WeStore.Domain.Services
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
