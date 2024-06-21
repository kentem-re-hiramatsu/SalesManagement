using System.Collections.Generic;

namespace Product.Cores.Manager
{
    public class ProductManager
    {
        private List<Model.Product> _productList = new List<Model.Product>();

        public IReadOnlyCollection<Model.Product> ProductList { get { return _productList; } }

        public void Add(Model.Product purchase) => _productList.Add(purchase);

        public Model.Product GetProduct(int index) => _productList[index];
    }
}
