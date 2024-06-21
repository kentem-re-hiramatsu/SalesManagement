using System;

namespace Product.Cores.Model
{
    public class Sale
    {
        public int SaleQuantity { get; private set; }
        public DateTime SaleDateTime { get; private set; }
        public Product Product { get; }

        public Sale(int saleQuantity, DateTime saleDateTime, Product purchase)
        {
            if (saleQuantity > 0 && purchase.StockQuantity >= saleQuantity && saleDateTime >= purchase.PurchaseDateTime)
            {
                SaleQuantity = saleQuantity;
                purchase.StockQuantity -= saleQuantity;
                SaleDateTime = saleDateTime;
            }
            else if (saleQuantity <= 0)
            {
                throw new Exception(Consts.INPUT_ERROR_MESSAGE);
            }
            else if (saleDateTime < purchase.PurchaseDateTime)
            {
                throw new Exception(Consts.LESS_THAN_SALEDAY_ERROR_MESSAGE);
            }
            else
            {
                throw new Exception(Consts.INVENTORY_QUANTITY_ERROR_MESSAGE);
            }
            Product = purchase;
        }

        /// <summary>
        /// 売上金額
        /// </summary>
        public int GetSalesAmount() => Product.SalePrice * SaleQuantity;

        /// <summary>
        /// 利益金額
        /// </summary>
        public int GetIncomeAmount() => GetSalesAmount() - Product.PurchasePrice * SaleQuantity;
    }
}
