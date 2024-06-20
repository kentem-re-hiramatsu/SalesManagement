using Microsoft.VisualStudio.TestTools.UnitTesting;
using Product.Cores.Manager;
using Product.Cores.Model;

namespace SalesManagementTest.ManagerTest
{
    [TestClass]
    public class PurchaseManagerTest
    {
        PurchaseManager purchase = new PurchaseManager();

        [TestMethod]
        public void AddTest()
        {
            var cherry = new Purchase("さくらんぼ", "06/20", 5, 100);
            var banana = new Purchase("バナナ", "06/20", 3, 150);

            Assert.AreEqual(0, purchase.PurchaseList.Count);

            purchase.Add(cherry);
            purchase.Add(banana);

            Assert.AreEqual(2, purchase.PurchaseList.Count);
            Assert.AreEqual("さくらんぼ", purchase.GetPurchase(0).ProductName);
            Assert.AreEqual("バナナ", purchase.GetPurchase(1).ProductName);
        }
    }
}
