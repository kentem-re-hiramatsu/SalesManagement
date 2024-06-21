using Product.Cores.Model;
using System.Collections.Generic;

namespace Product.Cores.Manager
{
    public class ProductManager
    {
        private List<Purchase> _productList = new List<Purchase>();

        public IReadOnlyCollection<Purchase> ProductList { get { return _productList; } }

        public void Add(Purchase purchase) => _productList.Add(purchase);

        public Purchase GetPurchase(int index) => _productList[index];
    }
}
