using Microsoft.VisualStudio.TestTools.UnitTesting;
using Product.Cores.Model;
using System;

namespace SalesManagementTest.ModelTest
{
    [TestClass]
    public class SalesTest
    {
        Purchase purchase = new Purchase("ばなな", "06/20", 8, 100);

        [TestMethod]
        public void SalesConstructorTest()
        {
            var sales = new Sales(200, purchase);

            Assert.AreEqual(200, sales.SalesPrice);
            Assert.AreEqual(8, sales.StockQuantity);

            Assert.ThrowsException<Exception>(() => new Sales(0, purchase));
            Assert.ThrowsException<Exception>(() => new Sales(-1, purchase));

            //仕入価格が販売価格が同じまたは下回っていないか
            Assert.ThrowsException<Exception>(() => new Sales(100, purchase));
        }

        /// <summary>
        /// 販売処理テスト
        /// </summary>
        [TestMethod]
        public void ProcessSalesTest()
        {
            var sales = new Sales(200, purchase);
            Assert.AreEqual(8, sales.StockQuantity);

            sales.ProcessSale(3, "06/19");
            Assert.AreEqual(3, sales.SalesQuantity);
            Assert.AreEqual(5, sales.StockQuantity);
            Assert.AreEqual("06/19", sales.SalesDataTime);
        }

        /// <summary>
        /// 販売数が在庫数を上回ったときエラーテスト
        /// </summary>
        [TestMethod]
        public void OverProcessSalesTest()
        {
            var sales = new Sales(200, purchase);
            Assert.AreEqual(8, sales.StockQuantity);

            Assert.ThrowsException<Exception>(() => sales.ProcessSale(9, "06/19"));
            Assert.ThrowsException<Exception>(() => sales.ProcessSale(0, "06/19"));
            Assert.ThrowsException<Exception>(() => sales.ProcessSale(-1, "06/19"));
        }

        /// <summary>
        /// 売上金額と利益金額のテスト
        /// </summary>
        [TestMethod]
        public void TotaltSalesAmountAndTotalIncomeAmountTest()
        {
            var sales = new Sales(200, purchase);
            sales.ProcessSale(3, "06/19");

            var salesPrice = 200;
            var salesQuantity = 3;
            var salesAmount = salesPrice * salesQuantity;

            Assert.AreEqual(salesAmount, sales.GetSalesAmount());

            var purchasePrice = purchase.PurchasePrice;
            var costPrice = purchasePrice * salesQuantity;
            var incomeAmount = salesAmount - costPrice;

            Assert.AreEqual(incomeAmount, sales.GetIncomeAmount());
        }
    }
}
