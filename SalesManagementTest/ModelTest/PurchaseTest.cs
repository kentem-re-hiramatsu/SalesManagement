using Microsoft.VisualStudio.TestTools.UnitTesting;
using Products.Cores.Models;
using System;

namespace SalesManagementTest.ModelTest
{
    [TestClass]
    public class PurchaseTest
    {
        [TestMethod]
        public void PurchaseConstructorTest()
        {
            var ringo = new Product("りんご");
            var purchase = new Purchase(ringo, 100, 200, 20, new DateTime(2024, 06, 21));
            var purchaseDateTime = (new DateTime(2024, 06, 21));

            Assert.AreEqual("りんご", purchase.Product.Name);
            Assert.AreEqual(100, purchase.PurchasePrice);
            Assert.AreEqual(200, purchase.SalePrice);
            Assert.AreEqual(20, purchase.StockQuantity);
            Assert.AreEqual(purchaseDateTime, purchase.PurchaseDateTime);

            Assert.ThrowsException<Exception>(() => new Purchase(ringo, 0, 200, 20, new DateTime(2024, 06, 21)));
            Assert.ThrowsException<Exception>(() => new Purchase(ringo, -1, 200, 20, new DateTime(2024, 06, 21)));

            Assert.ThrowsException<Exception>(() => new Purchase(ringo, 100, 0, 20, new DateTime(2024, 06, 21)));
            Assert.ThrowsException<Exception>(() => new Purchase(ringo, 100, -1, 20, new DateTime(2024, 06, 21)));

            Assert.ThrowsException<Exception>(() => new Purchase(ringo, 200, 200, 20, new DateTime(2024, 06, 21)));
        }
    }
}