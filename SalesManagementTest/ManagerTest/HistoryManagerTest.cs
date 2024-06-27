using Microsoft.VisualStudio.TestTools.UnitTesting;
using Products.Cores.Managers;
using Products.Cores.Models;
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
            var mikanPurchase = new Purchase(new Product("みかん"), 100, 200, 10, new DateTime(2024, 06, 21));
            var bananaPurchase = new Purchase(new Product("ばなな"), 150, 300, 10, new DateTime(2024, 06, 25));

            Assert.AreEqual(0, _purchaseMana.PurchaseList.Count);

            _purchaseMana.Add(mikanPurchase);
            _purchaseMana.Add(bananaPurchase);

            Assert.AreEqual(2, _purchaseMana.PurchaseList.Count);
            Assert.AreEqual("みかん", _purchaseMana.GetPurchase(0).Product.Name);
            Assert.AreEqual("ばなな", _purchaseMana.GetPurchase(1).Product.Name);

            Assert.AreEqual(100, _purchaseMana.GetPurchase(0).PurchasePrice);
            Assert.AreEqual(150, _purchaseMana.GetPurchase(1).PurchasePrice);

            Assert.AreEqual(200, _purchaseMana.GetPurchase(0).SalePrice);
            Assert.AreEqual(300, _purchaseMana.GetPurchase(1).SalePrice);

            Assert.AreEqual(new DateTime(2024, 06, 21), _purchaseMana.GetPurchase(0).PurchaseDateTime);
            Assert.AreEqual(new DateTime(2024, 06, 25), _purchaseMana.GetPurchase(1).PurchaseDateTime);
        }
    }
}
