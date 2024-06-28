using Microsoft.VisualStudio.TestTools.UnitTesting;
using Products.Cores.Models;
using System;

namespace SalesManagementTest.ModelTest
{
    [TestClass]
    public class SalesTest
    {
        Purchase purchase = new Purchase(new Product("ばなな"), 100, 200, 20, new DateTime(2024, 06, 20));

        [TestMethod]
        public void SalesConstructorTest()
        {
            var sale = new Sale(10, new DateTime(2024, 06, 20), purchase);
            DateTime saleDateTime = new DateTime(2024, 06, 20);

            Assert.AreEqual(10, sale.SaleQuantity);
            Assert.AreEqual(saleDateTime, sale.SaleDateTime);

            Assert.ThrowsException<Exception>(() => new Sale(0, new DateTime(2024, 06, 20), purchase));
            Assert.ThrowsException<Exception>(() => new Sale(-1, new DateTime(2024, 06, 20), purchase));

            //仕入数が販売数と同じまたは下回っていないか
            Assert.ThrowsException<Exception>(() => new Sale(30, new DateTime(2024, 06, 20), purchase).UpdateInventory(30));
            //購入日が仕入日より下回っていないか。
            Assert.ThrowsException<Exception>(() => new Sale(10, new DateTime(2024, 06, 19), purchase));
        }

        /// <summary>
        /// 売上金額と利益金額のテスト
        /// </summary>
        [TestMethod]
        public void TotaltSalesAmountAndTotalIncomeAmountTest()
        {
            var sales = new Sale(10, new DateTime(2024, 06, 22), purchase);

            var salesPrice = 200;
            var salesQuantity = 10;
            var salesAmount = salesPrice * salesQuantity;

            Assert.AreEqual(salesAmount, sales.GetSalesAmount());

            var purchasePrice = purchase.PurchasePrice;
            var costPrice = purchasePrice * salesQuantity;
            var incomeAmount = salesAmount - costPrice;

            Assert.AreEqual(incomeAmount, sales.GetIncomeAmount());
        }
    }
}