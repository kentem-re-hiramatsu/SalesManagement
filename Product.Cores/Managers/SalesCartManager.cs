using Product.Cores.Models;
using System.Collections.Generic;

namespace Product.Cores.Managers
{
    public class SalesCartManager
    {
        private List<Sale> _cartList = new List<Sale>();

        public IReadOnlyCollection<Sale> CartList { get { return _cartList; } }

        public void Add(Sale sale) => _cartList.Add(sale);

        public Sale GetSale(int index) => _cartList[index];
    }
}
