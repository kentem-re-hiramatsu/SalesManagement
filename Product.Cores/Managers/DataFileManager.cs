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
                    if (product.Name == purchaseData[0])
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
        public void SaveData()
        {
            File.WriteAllText(_productFilePath, "");
            File.WriteAllText(_purchaseFilePath, "");
            File.WriteAllText(_salesHistoryFilePath, "");

            foreach (var product in _productMana.ProductList)
            {
                File.AppendAllText(_productFilePath, product.Name + Environment.NewLine);
            }

            foreach (var purchase in _purchaseMana.PurchaseList)
            {
                File.AppendAllText(_purchaseFilePath, $"{purchase.Product.Name},{purchase.PurchasePrice}," +
                                                      $"{purchase.SalePrice},{purchase.StockQuantity},{purchase.PurchaseDateTime.ToString("yyyy/MM/dd")}" + Environment.NewLine);
            }

            foreach (var sale in _salesHistoryMana.HistoryList)
            {
                File.AppendAllText(_salesHistoryFilePath, $"{sale.SaleQuantity},{sale.SaleDateTime.ToString("yyyy/MM/dd")}," +
                                                          $"{sale.Purchase.Product.Id},{sale.Purchase.PurchaseDateTime.ToString("yyyy/MM/dd")}" + Environment.NewLine);
            }
        }
    }
}