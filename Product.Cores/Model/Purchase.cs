using System;

namespace Product.Cores.Model
{
    public class Purchase
    {
        public string ProductName { get; }
        public int PurchasePrice { get; }
        public int SalePrice { get; }
        public int StockQuantity { get; set; }
        public DateTime PurchaseDateTime { get; }

        public Purchase(string name, int purchasePrice, int salePrice, int stockQuantity, DateTime purchaseDateTime)
        {
            ProductName = name;
            if (purchasePrice > 0 && salePrice > 0 && salePrice > purchasePrice && stockQuantity > 0)
            {
                PurchasePrice = purchasePrice;
                SalePrice = salePrice;
                StockQuantity = stockQuantity;
            }
            else if (purchasePrice <= 0 || salePrice <= 0 || stockQuantity <= 0)
            {
                throw new Exception(Consts.INPUT_ERROR_MESSAGE);
            }
            else
            {
                throw new Exception(Consts.PURCHASE_OVER_PRICE_ERROR_MESSAGE);
            }
            PurchaseDateTime = purchaseDateTime;
        }
    }
}
