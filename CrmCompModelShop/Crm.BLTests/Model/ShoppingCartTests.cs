using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Crm.BL.Model.Tests
{
    [TestClass()]
    public class ShoppingCartTests
    {
        [TestMethod()]
        public void ShoppingCartTest()
        {
            // arrange
            Customer customer = new Customer()
            {
                Id = 1,
                Name = "tester"
            };
            Product product1 = new Product()
            {
                Id = 1,
                Name = "product1",
                Price = 123,
                Quantity = 11
            };
            Product product2 = new Product()
            {
                Id = 2,
                Name = "product2",
                Price = 456,
                Quantity = 22
            };
            ShoppingCart cart = new ShoppingCart(customer);

            List<Product> expectedResult = new List<Product>()
            {
                product1,
                product1,
                product1,
                product1,
                product1,

                product2,
                product2
            };

            // act

            cart.Add(product1);
            cart.Add(product1);
            cart.Add(product1);
            cart.Add(product1);
            cart.Add(product1);

            cart.Add(product2);
            cart.Add(product2);

            List<Product> actualResult = cart.GetAll();

            // asserts

            Assert.AreEqual(expectedResult.Count, actualResult.Count);

            for (int i = 0; i < expectedResult.Count; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }
        }
    }
}