using Products.Cores.Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace Products.Cores.Managers
{
    public class DataFileManager
    {
        private ProductManager _productMana;
        private PurchaseManager _purchaseMana;
        private SalesHistoryManager _salesHistoryMana;

        private string _productFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../../Product.Cores/Data/ProductsData.csv");
        private string _purchaseFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../../Product.Cores/Data/PurchasesData.csv");
        private string _salesHistoryFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../../Product.Cores/Data/SalesData.csv");

        public DataFileManager(ProductManager productMana, PurchaseManager purchaseMana, SalesHistoryManager salesHistoryMana)
        {
            _productMana = productMana;
            _purchaseMana = purchaseMana;
            _salesHistoryMana = salesHistoryMana;
        }

        public void DataLoad()
        {
            var purchaseList = new List<string>();
            var saleList = new List<string>();

            using (StreamReader streamReader = new StreamReader(_productFilePath, System.Text.Encoding.UTF8))
            {
                //一行ずつ読み取りリストに追加処理
                while (streamReader.EndOfStream == false)
                {
                    _productMana.Add(new Product(streamReader.ReadLine()));
                }
            }

            using (StreamReader streamReader = new StreamReader(_purchaseFilePath, System.Text.Encoding.UTF8))
            {
                //一行ずつ読み取りリストに追加処理
                while (streamReader.EndOfStream == false)
                {
                    purchaseList.Add(streamReader.ReadLine());
                }
            }

            for (int i = 0; purchaseList.Count > i; i++)
            {
                string[] purchaseData = purchaseList[i].Split(',');

                foreach (var product in _productMana.ProductList)
                {
                    if (product.Id == int.Parse(purchaseData[0]))
                    {
                        var purchase = new Purchase(product, int.Parse(purchaseData[1]), int.Parse(purchaseData[2]),
                                            int.Parse(purchaseData[3]), DateTime.Parse(purchaseData[4]));
                        _purchaseMana.Add(purchase);
                    }
                }
            }

            using (StreamReader streamReader = new StreamReader(_salesHistoryFilePath, System.Text.Encoding.UTF8))
            {
                //一行ずつ読み取りリストに追加処理
                while (streamReader.EndOfStream == false)
                {
                    saleList.Add(streamReader.ReadLine());
                }
            }

            for (int i = 0; saleList.Count > i; i++)
            {
                string[] saleData = saleList[i].Split(',');

                foreach (var purchase in _purchaseMana.PurchaseList)
                {
                    if (purchase.Product.Id == int.Parse(saleData[2]) && purchase.PurchaseDateTime == DateTime.Parse(saleData[3]))
                    {
                        var sale = new Sale(int.Parse(saleData[0]), DateTime.Parse(saleData[1]), purchase);
                        _salesHistoryMana.Add(sale);
                    }
                }
            }
        }
    }
}
