using Products.Cores.Models;
using System;
using System.Collections.Generic;

namespace Products.Cores.Managers
{
    public class ProductManager
    {
        private List<Product> _productList = new List<Product>();

        public IReadOnlyCollection<Product> ProductList { get { return _productList; } }

        public void Add(Product product)
        {
            foreach (var productItem in _productList)
            {
                if (product.Name == productItem.Name)
                    throw new Exception(Consts.SAME_PRODUCT_NAME_ERROR_MESSAGE);
            }

            product.Id = _productList.Count;
            _productList.Add(product);
        }

        public Product GetProduct(int index)
        {
            return _productList[index];
        }
    }
}