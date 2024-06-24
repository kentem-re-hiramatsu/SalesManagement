using Product.Cores.Models;

using System.Collections.Generic;

namespace Product.Cores.Managers
{
    public class PurchaseManager
    {
        private List<Purchase> _purchaseList = new List<Purchase>();

        public IReadOnlyCollection<Purchase> PurchaseList { get { return _purchaseList; } }

        public void Add(Purchase purchase) => _purchaseList.Add(purchase);

        public Purchase GetPurchase(int index) => _purchaseList[index];
    }
}
