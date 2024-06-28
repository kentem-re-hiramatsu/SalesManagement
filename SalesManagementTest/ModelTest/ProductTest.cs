using Microsoft.VisualStudio.TestTools.UnitTesting;
using Products.Cores.Models;

namespace SalesManagementTest.ModelTest
{
    [TestClass]
    public class ProductTest
    {
        [TestMethod]
        public void ProductGetTest()
        {
            var product = new Product("りんご");
            product.Id = 0;

            Assert.AreEqual("りんご", product.Name);
            Assert.AreEqual(0, product.Id);
        }
    }
}
