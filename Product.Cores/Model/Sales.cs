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

        public int GetSalesAmount()
        {
            return SalesPrice * SalesQuantity;
        }

        public int GetIncomeAmount()
        {
            return GetSalesAmount() - _purchase.PurchasePrice * SalesQuantity;
        }

        public void ProcessSales(int salesQuantity)
        {
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
