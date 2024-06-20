using System;

namespace Product.Cores.Model
{
    public class Purchase
    {
        public string ProductName { get; }
        public int PurchaseQuantity { get; }
        public int PurchasePrice { get; }
        public string PurchaseDateTime { get; }

        public Purchase(string name, string purchaseDateTime, int purchaseQuantity, int price)
        {
            ProductName = name;
            PurchaseDateTime = purchaseDateTime;

            if (purchaseQuantity > 0 && price > 0)
            {
                PurchaseQuantity = purchaseQuantity;
                PurchasePrice = price;
            }
            else
            {
                throw new Exception(Consts.INPUT_ERROR_MESSAGE);
            }
        }
    }
}
