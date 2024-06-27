using System;

namespace Products.Cores.Models
{
    public class Purchase
    {
        public Product Product { get; }
        public int PurchasePrice { get; }
        public int SalePrice { get; }
        public int StockQuantity { get; set; }
        public DateTime PurchaseDateTime { get; }

        public Purchase(Product product, int purchasePrice, int salePrice, int purchaseQuantity, DateTime purchaseDateTime)
        {
            Product = product;

            if (purchasePrice > 0 && salePrice > 0 && salePrice > purchasePrice && purchaseQuantity > 0)
            {
                PurchasePrice = purchasePrice;
                SalePrice = salePrice;
                StockQuantity = purchaseQuantity;
            }
            else if (purchasePrice <= 0 || salePrice <= 0 || purchaseQuantity <= 0)
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