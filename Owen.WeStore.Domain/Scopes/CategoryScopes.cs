using Owen.WebStore.SharedKernel.Validations;
using Owen.WebStore.Domain.Entities;

namespace Owen.WebStore.Domain.Scopes
{
    public static class CategoryScopes
    {
        public static bool CreateCategoryScopeIsValid(this Category category)
        {
            return AssertionConcern.IsSatisfiedBy
            (
                AssertionConcern.AssertNotEmpty(category.Title, "O título é obrigatório"),
                AssertionConcern.AssertLength(category.Title,5, 20, "O tamanho deve ser entre 5 e 20")
            );
        }

        public static bool UpdateCategoryScopeIsValid(this Category category, string title)
        {
            return AssertionConcern.IsSatisfiedBy
            (
                AssertionConcern.AssertNotEmpty(title, "O título é obrigatório")
            );
        }
    }
}
