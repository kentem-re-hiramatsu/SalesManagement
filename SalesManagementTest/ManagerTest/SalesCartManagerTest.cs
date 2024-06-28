using Microsoft.VisualStudio.TestTools.UnitTesting;
using Products.Cores.Managers;
using Products.Cores.Models;
using System;

namespace SalesManagementTest.ManagerTest
{
    [TestClass]
    public class SalesCartManagerTest
    {
        SalesCartManager CartMana = new SalesCartManager();

        [TestMethod]
        public void AddTest()
        {
            Assert.AreEqual(0, CartMana.CartList.Count);

            var banana = new Purchase(new Product("ばなな"), 100, 200, 10, new DateTime(2024, 06, 21));
            CartMana.Add(new Sale(2, new DateTime(2024, 06, 22), banana));
            CartMana.Add(new Sale(3, new DateTime(2024, 06, 21), banana));

            Assert.AreEqual(2, CartMana.CartList.Count);
            Assert.AreEqual(new DateTime(2024, 06, 22), CartMana.GetSale(0).SaleDateTime);
            Assert.AreEqual(new DateTime(2024, 06, 21), CartMana.GetSale(1).SaleDateTime);
        }

        [TestMethod]
        public void SameAddTest()
        {
            Assert.AreEqual(0, CartMana.CartList.Count);

            var banana = new Purchase(new Product("ばなな"), 100, 200, 10, new DateTime(2024, 06, 21));
            CartMana.Add(new Sale(2, new DateTime(2024, 06, 22), banana));
            CartMana.Add(new Sale(3, new DateTime(2024, 06, 21), banana));
            CartMana.Add(new Sale(3, new DateTime(2024, 06, 22), banana));

            Assert.AreEqual(2, CartMana.CartList.Count);
            Assert.AreEqual(5, CartMana.GetSale(0).SaleQuantity);
        }

        [TestMethod]
        public void Remove()
        {
            var banana = new Purchase(new Product("ばなな"), 100, 200, 10, new DateTime(2024, 06, 21));
            CartMana.Add(new Sale(2, new DateTime(2024, 06, 22), banana));
            CartMana.Add(new Sale(3, new DateTime(2024, 06, 21), banana));

            Assert.AreEqual(2, CartMana.CartList.Count);

            CartMana.Remove(0);

            Assert.AreEqual(1, CartMana.CartList.Count);
            Assert.AreEqual(new DateTime(2024, 06, 21), CartMana.GetSale(0).SaleDateTime);
        }
    }
}
