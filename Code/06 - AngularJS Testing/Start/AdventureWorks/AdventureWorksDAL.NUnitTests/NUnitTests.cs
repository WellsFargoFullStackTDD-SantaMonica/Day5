using System;
using NUnit.Framework;

namespace AdventureWorksDAL.NUnitTests
{
    [TestFixture]
    public class NUnitTests
    {
        [Test]
        [Category("Empty")]
        [Property("Owner", "Jeff")]
        [Property("Priority", 2)]
        [Property("Duration", "Long")]
        public void NUnitEmptyTestMethod()
        {

        }

        [Test]
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

        [TestCase(1)]
        [TestCase(0)]
        public void ProductCalculateSalesTax_GiveAValue_CalculatedCorrectly(Decimal price)
        {
            // Arrange
            var expectedSalesTax = price * .10M;
            var product = new Product { ListPrice = price };

            // Act
            Decimal result = product.CalculateSalesTax();

            // Assert
            Assert.AreEqual(expectedSalesTax, result);
        }

        [TestCase(-1)]
        //[ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ProductCalculateSalesTax_GiveANegativeValue_CalculatedCorrectly(Decimal price)
        {
            // Arrange
            var expectedSalesTax = price * .10M;
            var product = new Product { ListPrice = price };

            // Act
            TestDelegate testMethod= () => product.CalculateSalesTax();

            // Assert
            Assert.Throws<ArgumentOutOfRangeException>(testMethod);
        }

        [SetUp]
        public void TestInitialize()
        {
            System.Diagnostics.Debug.WriteLine("SetUp");
        }

        [TearDown]
        public void TestCleanup()
        {
            System.Diagnostics.Debug.WriteLine("TearDown");
        }
    }
}
