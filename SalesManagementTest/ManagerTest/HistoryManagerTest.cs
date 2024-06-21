using Microsoft.VisualStudio.TestTools.UnitTesting;
using Product.Cores.Manager;
using Product.Cores.Model;
using System;

namespace SalesManagementTest.ManagerTest
{
    [TestClass]
    public class HistoryManagerTest
    {
        [TestMethod]
        public void HistoryTest()
        {
            var _productyMana = new ProductManager();
            var mikanPurchase = new Purchase("みかん", 100, 200, 10, new DateTime(2024, 06, 21));
            var bananaPurchase = new Purchase("ばなな", 150, 300, 10, new DateTime(2024, 06, 25));

            Assert.AreEqual(0, _productyMana.ProductList.Count);

            _productyMana.Add(mikanPurchase);
            _productyMana.Add(bananaPurchase);

            Assert.AreEqual(2, _productyMana.ProductList.Count);
            Assert.AreEqual("みかん", _productyMana.GetPurchase(0).ProductName);
            Assert.AreEqual("みかん", _productyMana.GetPurchase(1).ProductName);

            Assert.AreEqual(100, _productyMana.GetPurchase(0).PurchasePrice);
            Assert.AreEqual(150, _productyMana.GetPurchase(1).PurchasePrice);

            Assert.AreEqual(200, _productyMana.GetPurchase(0).SalePrice);
            Assert.AreEqual(300, _productyMana.GetPurchase(1).SalePrice);

            Assert.AreEqual(new DateTime(2024, 06, 21), _productyMana.GetPurchase(0).PurchaseDateTime);
            Assert.AreEqual(new DateTime(2024, 06, 25), _productyMana.GetPurchase(1).PurchaseDateTime);
        }
    }
}
