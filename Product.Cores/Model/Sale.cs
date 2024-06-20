using System;

namespace Product.Cores.Model
{
    public class Sale
    {
        public int SalePrice { get; }
        public int SaleQuantity { get; private set; }
        public string SalesDataTime { get; private set; }
        public int StockQuantity { get; private set; }
        public Purchase Purchase { get; }

        public Sale(int price, Purchase purchase)
        {
            if (price > 0 && price > purchase.PurchasePrice)
            {
                SalePrice = price;
            }
            else if (price <= 0)
            {
                throw new Exception(Consts.INPUT_ERROR_MESSAGE);
            }
            else
            {
                throw new Exception(Consts.PURCHASE_OVER_PRICE_ERROR_MESSAGE);
            }

            StockQuantity = purchase.PurchaseQuantity;
            Purchase = purchase;
        }

        public Sale CloneSale() => (Sale)MemberwiseClone();

        /// <summary>
        /// 売上金額
        /// </summary>
        public int GetSalesAmount() => SalePrice * SaleQuantity;

        /// <summary>
        /// 利益金額
        /// </summary>
        public int GetIncomeAmount() => GetSalesAmount() - Purchase.PurchasePrice * SaleQuantity;

        /// <summary>
        /// 販売処理
        /// </summary>
        public void ProcessSale(int salesQuantity, string salesDataTime)
        {
            //0以上かつ在庫数以下
            if (salesQuantity > 0 && StockQuantity >= salesQuantity)
            {
                SaleQuantity = salesQuantity;
                StockQuantity -= salesQuantity;
                SalesDataTime = salesDataTime;
            }
            else if (salesQuantity <= 0)
            {
                throw new Exception(Consts.INPUT_ERROR_MESSAGE);
            }
            else
            {
                throw new Exception(Consts.INVENTORY_QUANTITY_ERROR_MESSAGE);
            }
        }
    }
}
