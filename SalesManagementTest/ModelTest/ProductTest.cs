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
            Assert.AreEqual("りんご", product.Name);
        }
    }
}
