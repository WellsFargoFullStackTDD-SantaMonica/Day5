using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventureWorksDAL.MSTests
{
    [TestClass]
    public class MicrosoftUnitTests
    {
        [TestMethod]
        [TestCategory("Empty")]
        [Owner("Jeff")]
        [Priority(2)]
        [TestProperty("Duration", "Long")]
        public void MicrosoftEmptyUnitTestMethod()
        {
        }


        // TDD Example of Iterative Test / Code Development
        [TestMethod]
        public void ProductCalculateSalesTax_PositiveValue_CalculatedCorrectly()
        {
            // Arrange
            var price = 49.99M;
            var expectedSalesTax = price * .10M;
            var product = new Product { ListPrice = price };

            // Act
            Decimal result = product.CalculateSalesTax();

            // Assert
            Assert.AreEqual(expectedSalesTax, result);
            //Assert.IsTrue(expectedSalesTax == result);
            //Assert.AreNotEqual(expectedSalesTax, result, "Fail Message");
            //Assert.AreSame(expectedSalesTax, result);
            //Assert.AreNotSame(expectedSalesTax, result);
            //Assert.Fail("Fail {0} vs {1}", expectedSalesTax, result);
            //Assert.Inconclusive("Inconclusive");
            //Assert.IsNotNull(product);        
        }


        // Parameterized Tests
        [TestMethod]
        public void ProductCalculateSalesTax_PriceIs1_CalculatedCorrectly()
        {
            ProductCalculateSalesTax_GiveAValue_CalculatedCorrectly(1);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ProductCalculateSalesTax_PriceIsNegative1_CalculatedCorrectly()
        {
            ProductCalculateSalesTax_GiveAValue_CalculatedCorrectly(-1);
        }
        [TestMethod]
        public void ProductCalculateSalesTax_PriceIs0_CalculatedCorrectly()
        {
            ProductCalculateSalesTax_GiveAValue_CalculatedCorrectly(0);
        }
        
        public void ProductCalculateSalesTax_GiveAValue_CalculatedCorrectly(Decimal price)
        {
            // Arrange
            var expectedSalesTax = price * .10M;
            //var product = new Product { ListPrice = price };
            var product = this.ProductFactory(price);

            // Act
            Decimal result = product.CalculateSalesTax();

            // Assert
            Assert.AreEqual(expectedSalesTax, result);
        }

        [TestInitialize]
        public void TestInitialize()
        {
            System.Diagnostics.Debug.WriteLine("TestInitialize");
        }

        [TestCleanup]
        public void TestCleanup()
        {
            System.Diagnostics.Debug.WriteLine("TestCleanup");
        }

        public Product ProductFactory(Decimal Price)
        {
            return new Product { ListPrice = Price };
        }
    }
}
