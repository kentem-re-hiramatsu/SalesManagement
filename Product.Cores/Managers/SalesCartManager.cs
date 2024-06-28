using Products.Cores.Models;
using System.Collections.Generic;
using System.Linq;

namespace Products.Cores.Managers
{
    public class SalesCartManager
    {
        private List<Sale> _cartList = new List<Sale>();

        public IReadOnlyCollection<Sale> CartList { get { return _cartList; } }

        public void Add(Sale sale)
        {
            var sameSale = _cartList.FirstOrDefault(x => x.Purchase.Product.Name == sale.Purchase.Product.Name &&
                                                x.Purchase.PurchaseDateTime == sale.Purchase.PurchaseDateTime &&
                                                x.SaleDateTime == sale.SaleDateTime);
            if (sameSale != null)
            {
                sameSale.SaleQuantity += sale.SaleQuantity;
            }
            else
            {
                _cartList.Add(sale);
            }
        }

        public Sale GetSale(int index) => _cartList[index];

        public void Remove(int index) => _cartList.RemoveAt(index);
    }
}
