using Microsoft.VisualStudio.TestTools.UnitTesting;
using Product.Cores.Manager;
using Product.Cores.Model;
using System;

namespace SalesManagementTest.ManagerTest
{
    [TestClass]
    public class SaleManagerTest
    {
        SalesHistoryManager salesmana = new SalesHistoryManager();

        [TestMethod]
        public void AddTest()
        {
            var cherry = new Product.Cores.Model.Product("さくらんぼ", 100, 200, 10, new DateTime(2024, 06, 21));
            var firstSale = new Sale(3, new DateTime(2024, 06, 22), cherry);
            var secondSale = new Sale(5, new DateTime(2024, 06, 23), cherry);

            Assert.AreEqual(0, salesmana.HistoryList.Count);

            salesmana.Add(firstSale);
            salesmana.Add(secondSale);

            Assert.AreEqual(2, salesmana.HistoryList.Count);
            Assert.AreEqual(3, salesmana.GetSale(0).SaleQuantity);
            Assert.AreEqual(5, salesmana.GetSale(1).SaleQuantity);
        }

        /// <summary>
        /// 売上合計金額と利益合計金額のテスト
        /// </summary>
        [TestMethod]
        public void TotalSalesAndTotalIncomeAmountTest()
        {
            var cherry = new Product.Cores.Model.Product("さくらんぼ", 100, 200, 10, new DateTime(2024, 06, 21));
            var firstSale = new Sale(3, new DateTime(2024, 06, 22), cherry);
            var secondSale = new Sale(5, new DateTime(2024, 06, 23), cherry);

            salesmana.Add(firstSale);
            salesmana.Add(secondSale);

            var cherryPuchasePrice = 100;
            var cherrySalesPrice = 200;

            var cherryFirstSaleQuantity = 3;
            var cherrySecondQuantity = 5;

            var totalSalesAmount = (cherryFirstSaleQuantity + cherrySecondQuantity) * cherrySalesPrice;
            var totalIncomeAmount = totalSalesAmount - ((cherryFirstSaleQuantity + cherrySecondQuantity) * cherryPuchasePrice);

            Assert.AreEqual(totalSalesAmount, salesmana.GetTotalSalesAmount());
            Assert.AreEqual(totalIncomeAmount, salesmana.GetTotalIncomeAmount());
        }
    }
}
