using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventureWorksWebAPI.Controllers;
using NSubstitute;
using AdventureWorksDAL;
using System.Collections.Generic;
using System.Data.Entity;

namespace AdventureWorksWebAPI.Tests
{
    [TestClass]
    public class ProductsControllerTests
    {
        [TestMethod]
        public void ProductsController_SentProducts_ReturnsCorrectCount()
        {
            // Arrange
            var data = new List<Product> 
            {
                new Product { ProductID = 1, Name = "Demo1", ListPrice = 30 },
                new Product { ProductID = 2, Name = "Demo2", ListPrice = 20 },
                new Product { ProductID = 3, Name = "Demo3", ListPrice = 10 },
            }.AsQueryable();

            var productsSub = Substitute.For<DbSet<Product>, IQueryable<Product>>();
            ((IQueryable<Product>)productsSub).Provider.Returns(data.Provider);
            ((IQueryable<Product>)productsSub).Expression.Returns(data.Expression);
            ((IQueryable<Product>)productsSub).ElementType.Returns(data.ElementType);
            ((IQueryable<Product>)productsSub).GetEnumerator().Returns(data.GetEnumerator());

            var contextSub = Substitute.For<AdventureWorksContext>();
            contextSub.Products = productsSub;
            var controller = new ProductsController(contextSub);

            // Act
            var results = controller.GetProducts();
            var rowsInResults = results.Count<Product>();
            var rowsSent = data.Count<Product>();

            // Assert
            Assert.AreEqual(rowsSent, rowsInResults);
        }
    }
}
