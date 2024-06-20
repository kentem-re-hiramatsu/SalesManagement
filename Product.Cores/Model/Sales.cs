using System;

namespace Product.Cores.Model
{
    public class Sales
    {
        public int SalesPrice { get; }
        public int SalesQuantity { get; private set; }
        public string SalesDataTime { get; private set; }
        public int StockQuantity { get; private set; }
        public Purchase Purchase { get; }

        public Sales(int price, Purchase purchase)
        {
            if (price > 0 && price > purchase.PurchasePrice)
            {
                SalesPrice = price;
            }
            else
            {
                throw new Exception(Consts.INPUT_ERROR_MESSAGE);
            }

            StockQuantity = purchase.PurchaseQuantity;
            Purchase = purchase;
        }

        /// <summary>
        /// 売上金額
        /// </summary>
        public int GetSalesAmount() => SalesPrice * SalesQuantity;

        /// <summary>
        /// 利益金額
        /// </summary>
        public int GetIncomeAmount() => GetSalesAmount() - Purchase.PurchasePrice * SalesQuantity;

        /// <summary>
        /// 販売処理
        /// </summary>
        public void ProcessSale(int salesQuantity, string salesDataTime)
        {
            //0以上かつ在庫数以下
            if (salesQuantity > 0 && StockQuantity >= salesQuantity)
            {
                SalesQuantity += salesQuantity;
                StockQuantity -= salesQuantity;
                SalesDataTime = salesDataTime;
            }
            else
            {
                throw new Exception(Consts.INPUT_ERROR_MESSAGE);
            }
        }
    }
}
