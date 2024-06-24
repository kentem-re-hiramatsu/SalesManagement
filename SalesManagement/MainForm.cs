﻿using Product.Cores.Manager;
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
        private PurchaseManager _purchaseManager = new PurchaseManager();
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
                var purchase = sale.Purchase;
                SalesListView.Items.Add(new ListViewItem(new string[]
                {
                    "",
                    purchase.ProductName,
                    purchase.SalePrice.ToString("#,0円"),
                    purchase.PurchaseDateTime.ToString("yyyy/MM/dd"),
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
            var salesOrderForm = new SalesForm(_salesMana, _purchaseManager);
            if (salesOrderForm.ShowDialog() == DialogResult.OK && _stockForm != null)
            {
                _stockForm.UpdateScreen();
            }
            UpdateScreen();
        }

        private void PurchaseProcessingButton_Click(object sender, EventArgs e)
        {
            var orderForm = new OrderForm(_purchaseManager);

            if (DialogResult.OK == orderForm.ShowDialog() && _stockForm != null)
            {
                _stockForm.UpdateScreen();
            }
        }

        private void InventoryListButton_Click(object sender, EventArgs e)
        {
            _stockForm = new StockForm(_purchaseManager);
            _stockForm.FormClosed += new FormClosedEventHandler((object sen, FormClosedEventArgs ex) => { InventoryListButton.Enabled = true; });
            _stockForm.Show();
            InventoryListButton.Enabled = false;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FilterTodaySales()
        {
            SalesListView.Items.Clear();

            IEnumerable<Sale> todaySaleList = new List<Sale>();
            todaySaleList = _salesMana.HistoryList.Where(x => x.SaleDateTime == DateTime.Today);

            foreach (var TodaySale in todaySaleList)
            {
                var purchase = TodaySale.Purchase;
                SalesListView.Items.Add(new ListViewItem(new string[]
                {
                    "",
                    purchase.ProductName,
                    purchase.SalePrice.ToString("#,0円"),
                    purchase.PurchaseDateTime.ToString("yyyy/MM/dd"),
                    TodaySale.SaleDateTime.ToString("yyyy/MM/dd"),
                    TodaySale.SaleQuantity.ToString(),
                    TodaySale.GetSalesAmount().ToString("#,0円")
                }));
            }
            TotaltSalesAmountLabel.Text = $"売上合計金額：{todaySaleList.Sum(x => x.GetSalesAmount()).ToString("#,0円")}";
            TotalIncomeAmountLabel.Text = $"利益合計金額：{todaySaleList.Sum(x => x.GetIncomeAmount()).ToString("#,0円")}";
        }

        private void FilterSelectedSales()
        {
            foreach (ListViewItem item in SalesListView.Items)
            {
                if (!item.Checked)
                {
                    item.ListView.Items.RemoveAt(item.Index);
                }
            }
        }

        private void TodaySalesButton_Click(object sender, EventArgs e)
        {
            TodaySalesButton.Enabled = false;
            ClearFilterButtonChanged();
            FilterTodaySales();
        }

        private void SelectProductFilterButton_Click(object sender, EventArgs e)
        {
            SelectProductFilterButton.Enabled = false;
            FilterSelectedSales();
            ClearFilterButtonChanged();
        }
        private void ClearFilterButton_Click(object sender, EventArgs e)
        {
            TodaySalesButton.Enabled = true;
            SelectProductFilterButton.Enabled = true;
            ClearFilterButtonChanged();
            UpdateScreen();
        }

        private void ClearFilterButtonChanged()
        {
            ClearFilterButton.Enabled = !TodaySalesButton.Enabled || !SelectProductFilterButton.Enabled;
        }
    }
}
