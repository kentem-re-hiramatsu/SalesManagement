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
            var _purchaseMana = new PurchaseManager();
            var mikanPurchase = new Product.Cores.Model.Purchase("みかん", 100, 200, 10, new DateTime(2024, 06, 21));
            var bananaPurchase = new Product.Cores.Model.Purchase("ばなな", 150, 300, 10, new DateTime(2024, 06, 25));

            Assert.AreEqual(0, _purchaseMana.PurchaseList.Count);

            _purchaseMana.Add(mikanPurchase);
            _purchaseMana.Add(bananaPurchase);

            Assert.AreEqual(2, _purchaseMana.PurchaseList.Count);
            Assert.AreEqual("みかん", _purchaseMana.GetProduct(0).ProductName);
            Assert.AreEqual("ばなな", _purchaseMana.GetProduct(1).ProductName);

            Assert.AreEqual(100, _purchaseMana.GetProduct(0).PurchasePrice);
            Assert.AreEqual(150, _purchaseMana.GetProduct(1).PurchasePrice);

            Assert.AreEqual(200, _purchaseMana.GetProduct(0).SalePrice);
            Assert.AreEqual(300, _purchaseMana.GetProduct(1).SalePrice);

            Assert.AreEqual(new DateTime(2024, 06, 21), _purchaseMana.GetProduct(0).PurchaseDateTime);
            Assert.AreEqual(new DateTime(2024, 06, 25), _purchaseMana.GetProduct(1).PurchaseDateTime);
        }
    }
}
