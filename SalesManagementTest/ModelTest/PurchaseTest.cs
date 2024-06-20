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
            var purchase = new Purchase("りんご", "06/20", 5, 80);
            var nowDateTime = ("06/20");

            Assert.AreEqual("りんご", purchase.ProductName);
            Assert.AreEqual(5, purchase.PurchaseQuantity);
            Assert.AreEqual(80, purchase.PurchasePrice);
            Assert.AreEqual(nowDateTime, purchase.PurchaseDateTime);

            Assert.ThrowsException<Exception>(() => new Purchase("みかん", "06/20", 0, 90));
            Assert.ThrowsException<Exception>(() => new Purchase("みかん", "06/20", -1, 90));

            Assert.ThrowsException<Exception>(() => new Purchase("みかん", "06/20", 5, 0));
            Assert.ThrowsException<Exception>(() => new Purchase("みかん", "06/20", 5, -1));
        }
    }
}