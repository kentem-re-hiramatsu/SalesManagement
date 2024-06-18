using System;

namespace Product.Cores.Model
{
    public class Sales
    {
        public int SalesPrice { get; }
        public int SalesQuantity { get; private set; }
        public DateTime SalesDataTime { get; }
        public int StockQuantity { get; private set; }
        private Purchase _purchase;

        public Sales(int price, Purchase purchase)
        {
            if (price > 0)
            {
                SalesPrice = price;
            }
            else
            {
                throw new Exception(Consts.INPUT_ERROR_MESSAGE);
            }

            StockQuantity = purchase.PurchaseQuantity;
            _purchase = purchase;
            SalesDataTime = DateTime.Now;
        }

        /// <summary>
        /// 売上金額
        /// </summary>
        public int GetSalesAmount() => SalesPrice * SalesQuantity;

        /// <summary>
        /// 利益金額
        /// </summary>
        public int GetIncomeAmount() => GetSalesAmount() - _purchase.PurchasePrice * SalesQuantity;

        /// <summary>
        /// 販売処理
        /// </summary>
        public void ProcessSales(int salesQuantity)
        {
            //0以上かつ在庫数以下
            if (salesQuantity > 0 && StockQuantity >= salesQuantity)
            {
                SalesQuantity += salesQuantity;
                StockQuantity -= salesQuantity;
            }
            else
            {
                throw new Exception(Consts.INPUT_ERROR_MESSAGE);
            }
        }
    }
}
