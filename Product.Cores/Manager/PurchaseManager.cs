using Product.Cores.Model;

using System.Collections.Generic;

namespace Product.Cores.Manager
{
    public class PurchaseManager
    {
        private List<Purchase> _purchaseList = new List<Purchase>();

        public IReadOnlyCollection<Purchase> ProductList { get { return _purchaseList; } }

        public void Add(Purchase purchase) => _purchaseList.Add(purchase);

        public Purchase GetProduct(int index) => _purchaseList[index];
    }
}
