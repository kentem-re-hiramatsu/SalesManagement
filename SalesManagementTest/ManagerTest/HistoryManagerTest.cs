using Microsoft.VisualStudio.TestTools.UnitTesting;
using Product.Cores.Manager;
using Product.Cores.Model;

namespace SalesManagementTest.ManagerTest
{
    [TestClass]
    public class HistoryManagerTest
    {
        [TestMethod]
        public void HistoryTest()
        {
            var _historyMana = new HistoryManager();
            var mikanPurchase = new Purchase("みかん", "6/24", 5, 100);
            var bananaPurchase = new Purchase("ばなな", "6/24", 5, 100);
            var mikanSale = new Sale(200, mikanPurchase);
            var bananaSale = new Sale(200, bananaPurchase);

            Assert.AreEqual(0, _historyMana.HistoryList.Count);

            _historyMana.Add(mikanSale);
            _historyMana.Add(bananaSale);

            Assert.AreEqual(2, _historyMana.HistoryList.Count);
            Assert.AreEqual("みかん", _historyMana.GetSale(0).Purchase.ProductName);
            Assert.AreEqual("ばなな", _historyMana.GetSale(1).Purchase.ProductName);
        }
    }
}
