using Microsoft.VisualStudio.TestTools.UnitTesting;
using Product.Cores.Model;
using System;

namespace SalesManagementTest.ModelTest
{
    [TestClass]
    public class PurchaseTest
    {
        [TestMethod]
        public void PurchaseConstructorTest()
        {
            var purchase = new Purchase("りんご", 100, 200, 20, new DateTime(2024, 06, 21));
            var purchaseDateTime = (new DateTime(2024, 06, 21));

            Assert.AreEqual("りんご", purchase.ProductName);
            Assert.AreEqual(100, purchase.PurchasePrice);
            Assert.AreEqual(200, purchase.SalePrice);
            Assert.AreEqual(20, purchase.StockQuantity);
            Assert.AreEqual(purchaseDateTime, purchase.PurchaseDateTime);

            Assert.ThrowsException<Exception>(() => new Purchase("りんご", 0, 200, 20, new DateTime(2024, 06, 21)));
            Assert.ThrowsException<Exception>(() => new Purchase("りんご", -1, 200, 20, new DateTime(2024, 06, 21)));

            Assert.ThrowsException<Exception>(() => new Purchase("りんご", 100, 0, 20, new DateTime(2024, 06, 21)));
            Assert.ThrowsException<Exception>(() => new Purchase("りんご", 100, -1, 20, new DateTime(2024, 06, 21)));

            Assert.ThrowsException<Exception>(() => new Purchase("りんご", 100, 200, 0, new DateTime(2024, 06, 21)));
            Assert.ThrowsException<Exception>(() => new Purchase("りんご", 100, 200, -1, new DateTime(2024, 06, 21)));

            Assert.ThrowsException<Exception>(() => new Purchase("りんご", 200, 200, 20, new DateTime(2024, 06, 21)));
        }
    }
}