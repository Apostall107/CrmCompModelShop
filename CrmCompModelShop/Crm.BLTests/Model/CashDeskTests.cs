using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Crm.BL.Model.Tests
{
    [TestClass()]
    public class CashDeskTests
    {
        [TestMethod()]
        public void CashDeskTest()
        {
            //Arrange
            var customer1 = new Customer()
            {
                Name = "TestCustomer",
                Id = 1
            };

            var customer2 = new Customer()
            {
                Name = "TestCustomer2",
                Id = 2
            };

            var seller = new Seller()
            {
                Name = "TestSeller",
                Id = 1
            };

            Product product1 = new Product()
            {
                Id = 1,
                Name = "product1",
                Price = 100,
                QuantityAvaliable = 11
            };
            Product product2 = new Product()
            {
                Id = 2,
                Name = "product2",
                Price = 200,
                QuantityAvaliable = 22
            };

            ShoppingCart cart1 = new ShoppingCart(customer1);
            cart1.Add(product1);
            cart1.Add(product1);
            cart1.Add(product2);

            ShoppingCart cart2 = new ShoppingCart(customer2);
            cart2.Add(product1);
            cart2.Add(product2);
            cart2.Add(product2);

            CashDesk cashdesk = new CashDesk(1, seller);
            cashdesk.MaxQueueLenght = 10;
            cashdesk.Enqueue(cart1);
            cashdesk.Enqueue(cart2);

            decimal cart1ExpectedResult = 400;
            decimal cart2ExpectedResult = 500;

            // Act

            decimal cart1ActualResult = cashdesk.Dequeue();
            decimal cart2ActualResult = cashdesk.Dequeue();

            // Assert

            Assert.AreEqual(cart1ExpectedResult, cart1ActualResult);
            Assert.AreEqual(cart2ExpectedResult, cart2ActualResult);
            Assert.AreEqual(8, product1.QuantityAvaliable);
            Assert.AreEqual(19, product2.QuantityAvaliable);
        }
    }
}