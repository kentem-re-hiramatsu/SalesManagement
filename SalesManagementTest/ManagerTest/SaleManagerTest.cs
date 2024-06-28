using Microsoft.VisualStudio.TestTools.UnitTesting;
using Products.Cores;
using Products.Cores.Managers;
using Products.Cores.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesManagementTest.ManagerTest
{
    [TestClass]
    public class SaleManagerTest
    {
        SalesHistoryManager historyMana = new SalesHistoryManager();

        [TestMethod]
        public void AddTest()
        {
            var cherry = new Purchase(new Product("さくらんぼ"), 100, 200, 10, new DateTime(2024, 06, 21));
            var firstSale = new Sale(3, new DateTime(2024, 06, 22), cherry);
            var secondSale = new Sale(5, new DateTime(2024, 06, 23), cherry);

            Assert.AreEqual(0, historyMana.HistoryList.Count);

            historyMana.Add(firstSale);
            historyMana.Add(secondSale);

            Assert.AreEqual(2, historyMana.HistoryList.Count);
            Assert.AreEqual(3, historyMana.GetSale(0).SaleQuantity);
            Assert.AreEqual(5, historyMana.GetSale(1).SaleQuantity);
        }

        [TestMethod]
        public void SortTest()
        {
            var cherry = new Purchase(new Product("さくらんぼ"), 100, 200, 10, new DateTime(2024, 06, 21));
            var cherrySale = new Sale(3, new DateTime(2024, 06, 22), cherry);

            var banana = new Purchase(new Product("ばなな"), 200, 400, 10, new DateTime(2024, 07, 01));
            var bananaSale = new Sale(6, new DateTime(2024, 07, 02), banana);

            var apple = new Purchase(new Product("りんご"), 150, 300, 10, new DateTime(2024, 06, 01));
            var appleSale = new Sale(1, new DateTime(2024, 07, 03), apple);

            historyMana.Add(cherrySale);
            historyMana.Add(appleSale);
            historyMana.Add(bananaSale);

            Assert.AreEqual("さくらんぼ", historyMana.GetSale(0).Purchase.Product.Name);
            Assert.AreEqual("りんご", historyMana.GetSale(1).Purchase.Product.Name);
            Assert.AreEqual("ばなな", historyMana.GetSale(2).Purchase.Product.Name);

            //名前の昇順
            IEnumerable<Sale> sortList = historyMana.SalesColumSort(Consts.PRODUCT_NAME_COLUMN, true);

            Assert.AreEqual("さくらんぼ", sortList.ElementAt(0).Purchase.Product.Name);
            Assert.AreEqual("ばなな", sortList.ElementAt(1).Purchase.Product.Name);
            Assert.AreEqual("りんご", sortList.ElementAt(2).Purchase.Product.Name);

            //名前の降順
            sortList = historyMana.SalesColumSort(Consts.PRODUCT_NAME_COLUMN, false);

            Assert.AreEqual("りんご", sortList.ElementAt(0).Purchase.Product.Name);
            Assert.AreEqual("ばなな", sortList.ElementAt(1).Purchase.Product.Name);
            Assert.AreEqual("さくらんぼ", sortList.ElementAt(2).Purchase.Product.Name);

            //販売価格の昇順
            sortList = historyMana.SalesColumSort(Consts.SALE_PRICE_COLUMN, true);

            Assert.AreEqual("さくらんぼ", sortList.ElementAt(0).Purchase.Product.Name);
            Assert.AreEqual("りんご", sortList.ElementAt(1).Purchase.Product.Name);
            Assert.AreEqual("ばなな", sortList.ElementAt(2).Purchase.Product.Name);

            //販売価格の降順
            sortList = historyMana.SalesColumSort(Consts.SALE_PRICE_COLUMN, false);

            Assert.AreEqual("ばなな", sortList.ElementAt(0).Purchase.Product.Name);
            Assert.AreEqual("りんご", sortList.ElementAt(1).Purchase.Product.Name);
            Assert.AreEqual("さくらんぼ", sortList.ElementAt(2).Purchase.Product.Name);

            //仕入日の昇順
            sortList = historyMana.SalesColumSort(Consts.PURCHASE_DAY_COLUMN, true);

            Assert.AreEqual("りんご", sortList.ElementAt(0).Purchase.Product.Name);
            Assert.AreEqual("さくらんぼ", sortList.ElementAt(1).Purchase.Product.Name);
            Assert.AreEqual("ばなな", sortList.ElementAt(2).Purchase.Product.Name);

            //仕入日の降順
            sortList = historyMana.SalesColumSort(Consts.PURCHASE_DAY_COLUMN, false);

            Assert.AreEqual("ばなな", sortList.ElementAt(0).Purchase.Product.Name);
            Assert.AreEqual("さくらんぼ", sortList.ElementAt(1).Purchase.Product.Name);
            Assert.AreEqual("りんご", sortList.ElementAt(2).Purchase.Product.Name);

            //販売日の昇順
            sortList = historyMana.SalesColumSort(Consts.SALE_DAY_COLUMN, true);

            Assert.AreEqual("さくらんぼ", sortList.ElementAt(0).Purchase.Product.Name);
            Assert.AreEqual("ばなな", sortList.ElementAt(1).Purchase.Product.Name);
            Assert.AreEqual("りんご", sortList.ElementAt(2).Purchase.Product.Name);

            //販売日の降順
            sortList = historyMana.SalesColumSort(Consts.SALE_DAY_COLUMN, false);

            Assert.AreEqual("りんご", sortList.ElementAt(0).Purchase.Product.Name);
            Assert.AreEqual("ばなな", sortList.ElementAt(1).Purchase.Product.Name);
            Assert.AreEqual("さくらんぼ", sortList.ElementAt(2).Purchase.Product.Name);

            //販売数の昇順
            sortList = historyMana.SalesColumSort(Consts.SALE_QUANTITY_COLUMN, true);

            Assert.AreEqual("りんご", sortList.ElementAt(0).Purchase.Product.Name);
            Assert.AreEqual("さくらんぼ", sortList.ElementAt(1).Purchase.Product.Name);
            Assert.AreEqual("ばなな", sortList.ElementAt(2).Purchase.Product.Name);

            //販売数の降順
            sortList = historyMana.SalesColumSort(Consts.SALE_QUANTITY_COLUMN, false);

            Assert.AreEqual("ばなな", sortList.ElementAt(0).Purchase.Product.Name);
            Assert.AreEqual("さくらんぼ", sortList.ElementAt(1).Purchase.Product.Name);
            Assert.AreEqual("りんご", sortList.ElementAt(2).Purchase.Product.Name);

            //売上金額の昇順
            sortList = historyMana.SalesColumSort(Consts.SALE_AMOUNT_COLUMN, true);

            Assert.AreEqual("りんご", sortList.ElementAt(0).Purchase.Product.Name);
            Assert.AreEqual("さくらんぼ", sortList.ElementAt(1).Purchase.Product.Name);
            Assert.AreEqual("ばなな", sortList.ElementAt(2).Purchase.Product.Name);

            //売上金額の降順
            sortList = historyMana.SalesColumSort(Consts.SALE_AMOUNT_COLUMN, false);

            Assert.AreEqual("ばなな", sortList.ElementAt(0).Purchase.Product.Name);
            Assert.AreEqual("さくらんぼ", sortList.ElementAt(1).Purchase.Product.Name);
            Assert.AreEqual("りんご", sortList.ElementAt(2).Purchase.Product.Name);
        }

        /// <summary>
        /// 売上合計金額と利益合計金額のテスト
        /// </summary>
        [TestMethod]
        public void TotalSalesAndTotalIncomeAmountTest()
        {
            var cherry = new Purchase(new Product("さくらんぼ"), 100, 200, 10, new DateTime(2024, 06, 21));
            var firstSale = new Sale(3, new DateTime(2024, 06, 22), cherry);
            var secondSale = new Sale(5, new DateTime(2024, 06, 23), cherry);

            historyMana.Add(firstSale);
            historyMana.Add(secondSale);

            var cherryPuchasePrice = 100;
            var cherrySalesPrice = 200;

            var cherryFirstSaleQuantity = 3;
            var cherrySecondQuantity = 5;

            var totalSalesAmount = (cherryFirstSaleQuantity + cherrySecondQuantity) * cherrySalesPrice;
            var totalIncomeAmount = totalSalesAmount - ((cherryFirstSaleQuantity + cherrySecondQuantity) * cherryPuchasePrice);

            Assert.AreEqual(totalSalesAmount, historyMana.GetTotalSalesAmount());
            Assert.AreEqual(totalIncomeAmount, historyMana.GetTotalIncomeAmount());
        }
    }
}