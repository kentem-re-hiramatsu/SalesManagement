using Microsoft.VisualStudio.TestTools.UnitTesting;
using Product.Cores.Managers;
using Product.Cores.Models;
using System;

namespace SalesManagementTest.ManagerTest
{
    [TestClass]
    public class SalesCartManagerTest
    {
        SalesCartManager salesmana = new SalesCartManager();

        [TestMethod]
        public void AddTest()
        {
            Assert.AreEqual(0, salesmana.CartList.Count);

            var banana = new Purchase("ばなな", 100, 200, 10, new DateTime(2024, 06, 21));
            salesmana.Add(new Sale(2, new DateTime(2024, 06, 22), banana));
            salesmana.Add(new Sale(3, new DateTime(2024, 06, 21), banana));

            Assert.AreEqual(2, salesmana.CartList.Count);
            Assert.AreEqual(new DateTime(2024, 06, 22), salesmana.GetSale(0).SaleDateTime);
            Assert.AreEqual(new DateTime(2024, 06, 21), salesmana.GetSale(1).SaleDateTime);
        }

        [TestMethod]
        public void Remove()
        {
            var banana = new Purchase("ばなな", 100, 200, 10, new DateTime(2024, 06, 21));
            salesmana.Add(new Sale(2, new DateTime(2024, 06, 22), banana));
            salesmana.Add(new Sale(3, new DateTime(2024, 06, 21), banana));

            Assert.AreEqual(2, salesmana.CartList.Count);

            salesmana.Remove(0);

            Assert.AreEqual(1, salesmana.CartList.Count);
            Assert.AreEqual(new DateTime(2024, 06, 21), salesmana.GetSale(0).SaleDateTime);
        }
    }
}
