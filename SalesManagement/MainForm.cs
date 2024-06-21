using Product.Cores.Manager;
using Product.Cores.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp1;
using WindowsFormsApp2;

namespace SalesManagement
{
    public partial class MainForm : Form
    {
        private SalesHistoryManager _salesMana = new SalesHistoryManager();
        private ProductManager _productManager = new ProductManager();
        private StockForm _stockForm;

        public MainForm()
        {
            InitializeComponent();
        }

        private void UpdateScreen()
        {
            SalesListView.Items.Clear();
            foreach (var sale in _salesMana.HistoryList)
            {
                var product = sale.Product;
                SalesListView.Items.Add(new ListViewItem(new string[]
                {
                    product.ProductName,
                    product.SalePrice.ToString("#,0円"),
                    product.PurchaseDateTime.ToString("yyyy/MM/dd"),
                    sale.SaleDateTime.ToString("yyyy/MM/dd"),
                    sale.SaleQuantity.ToString(),
                    sale.GetSalesAmount().ToString("#,0円")
                }));
            }

            TotaltSalesAmountLabel.Text = $"売上合計金額：{_salesMana.HistoryList.Sum(x => x.GetSalesAmount()).ToString("#,0円")}";
            TotalIncomeAmountLabel.Text = $"利益合計金額：{_salesMana.HistoryList.Sum(x => x.GetIncomeAmount()).ToString("#,0円")}";
        }

        private void SalesProcessingButton_Click(object sender, EventArgs e)
        {
            var salesOrderForm = new SalesForm(_salesMana, _productManager, _stockForm);
            if (DialogResult.OK == salesOrderForm.ShowDialog())
            {
                UpdateScreen();
            }
        }

        private void PurchaseProcessingButton_Click(object sender, EventArgs e)
        {
            var orderForm = new OrderForm(_productManager, _stockForm);
            orderForm.ShowDialog();
        }

        private void InventoryListButton_Click(object sender, EventArgs e)
        {
            _stockForm = new StockForm(_productManager);

            _stockForm.FormClosed += StockForm_FormClosed;
            _stockForm.Show();
            InventoryListButton.Enabled = false;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void StockForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            InventoryListButton.Enabled = true;
        }

        public void TodaySalesFiltering()
        {
            SalesListView.Items.Clear();

            IEnumerable<Sale> todaySaleList = new List<Sale>();
            todaySaleList = _salesMana.HistoryList.Where(x => x.SaleDateTime == DateTime.Today);

            foreach (var TodaySale in todaySaleList)
            {
                var product = TodaySale.Product;
                SalesListView.Items.Add(new ListViewItem(new string[]
                {
                    product.ProductName,
                    product.SalePrice.ToString("#,0円"),
                    product.PurchaseDateTime.ToString("yyyy/MM/dd"),
                    TodaySale.SaleDateTime.ToString("yyyy/MM/dd"),
                    TodaySale.SaleQuantity.ToString(),
                    TodaySale.GetSalesAmount().ToString("#,0円")
                }));
            }
            TotaltSalesAmountLabel.Text = $"売上合計金額：{todaySaleList.Sum(x => x.GetSalesAmount()).ToString("#,0円")}";
            TotalIncomeAmountLabel.Text = $"利益合計金額：{todaySaleList.Sum(x => x.GetIncomeAmount()).ToString("#,0円")}";
        }

        private void TodaySalesButton_Click(object sender, EventArgs e)
        {

            TodaySalesButton.Enabled = false;
            ClearFilterButton.Enabled = true;
            TodaySalesFiltering();
        }

        private void SelectProductFilterButton_Click(object sender, EventArgs e)
        {
            SelectProductFilterButton.Enabled = false;
            ClearFilterButton.Enabled = true;
        }
        private void ClearFilterButton_Click(object sender, EventArgs e)
        {
            TodaySalesButton.Enabled = true;
            SelectProductFilterButton.Enabled = true;
            UpdateScreen();
        }
    }
}
