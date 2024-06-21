using Microsoft.VisualStudio.TestTools.UnitTesting;
using Product.Cores.Manager;
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
            var mikanPurchase = new Product.Cores.Model.Product("みかん", 100, 200, 10, new DateTime(2024, 06, 21));
            var bananaPurchase = new Product.Cores.Model.Product("ばなな", 150, 300, 10, new DateTime(2024, 06, 25));

            Assert.AreEqual(0, _productyMana.ProductList.Count);

            _productyMana.Add(mikanPurchase);
            _productyMana.Add(bananaPurchase);

            Assert.AreEqual(2, _productyMana.ProductList.Count);
            Assert.AreEqual("みかん", _productyMana.GetProduct(0).ProductName);
            Assert.AreEqual("ばなな", _productyMana.GetProduct(1).ProductName);

            Assert.AreEqual(100, _productyMana.GetProduct(0).PurchasePrice);
            Assert.AreEqual(150, _productyMana.GetProduct(1).PurchasePrice);

            Assert.AreEqual(200, _productyMana.GetProduct(0).SalePrice);
            Assert.AreEqual(300, _productyMana.GetProduct(1).SalePrice);

            Assert.AreEqual(new DateTime(2024, 06, 21), _productyMana.GetProduct(0).PurchaseDateTime);
            Assert.AreEqual(new DateTime(2024, 06, 25), _productyMana.GetProduct(1).PurchaseDateTime);
        }
    }
}
