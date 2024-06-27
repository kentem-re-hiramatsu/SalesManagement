using Microsoft.VisualStudio.TestTools.UnitTesting;
using Products.Cores.Managers;
using Products.Cores.Models;
using System;

namespace SalesManagementTest.ManagerTest
{
    [TestClass]
    public class ProductManagerTest
    {
        [TestMethod]
        public void ProductManaTest()
        {
            var productMana = new ProductManager();
            Assert.AreEqual(0, productMana.ProductList.Count);

            productMana.Add(new Product("バナナ"));
            productMana.Add(new Product("みかん"));

            Assert.AreEqual(2, productMana.ProductList.Count);
            Assert.AreEqual("バナナ", productMana.GetProduct(0).Name);
            Assert.AreEqual("みかん", productMana.GetProduct(1).Name);
        }

        [TestMethod]
        public void SameProductErrorTest()
        {
            var productMana = new ProductManager();
            productMana.Add(new Product("バナナ"));

            Assert.ThrowsException<Exception>(() => productMana.Add(new Product("バナナ")));
        }
    }
}