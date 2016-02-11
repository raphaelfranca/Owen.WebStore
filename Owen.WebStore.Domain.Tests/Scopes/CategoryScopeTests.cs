using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Owen.WebStore.Domain.Entities;
using Owen.WebStore.Domain.Scopes;

namespace Owen.WebStore.Domain.Tests.Scopes
{
    [TestClass]
    public class CategoryScopeTests
    {
        [TestMethod]
        [TestCategory("Category")]
        public void RegistrarCategoria()
        {
            var category = new Category("Placa Mãe");     
            Assert.AreEqual(true, CategoryScopes.CreateCategoryScopeIsValid(category));
        }

        [TestMethod]
        [TestCategory("Category")]
        public void AlterarCategoria()
        {
            var category = new Category("Placa Mâe");
            Assert.AreEqual(true, CategoryScopes.UpdateCategoryScopeIsValid(category, "Modtherboard"));
        }
    }
}
