﻿using Product.Cores.Managers;
using Product.Cores.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SalesManagement
{
    public partial class MainForm : Form
    {
        private SalesHistoryManager _salesMana = new SalesHistoryManager();
        private PurchaseManager _purchaseMana = new PurchaseManager();
        private StockForm _stockForm;
        private int _columnNum;
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
            var salesOrderForm = new SalesForm(_salesMana, _purchaseMana);
            if (salesOrderForm.ShowDialog() == DialogResult.OK && _stockForm != null)
            {
                _stockForm.UpdateScreen();
            }
            UpdateScreen();
        }

        private void PurchaseProcessingButton_Click(object sender, EventArgs e)
        {
            var orderForm = new OrderForm(_purchaseMana);

            if (orderForm.ShowDialog() == DialogResult.OK && _stockForm != null)
            {
                _stockForm.UpdateScreen();
            }
        }

        private void InventoryListButton_Click(object sender, EventArgs e)
        {
            _stockForm = new StockForm(_purchaseMana);
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

        private void SalesListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            var columnNum = e.Column;
            IEnumerable<Sale> sortList = null;

            switch (e.Column)
            {
                case 1:
                    sortList = !AscendingButton.Enabled ? _salesMana.HistoryList.OrderBy(x => x.Purchase.ProductName)
                                                        : _salesMana.HistoryList.OrderByDescending(x => x.Purchase.ProductName);
                    break;
                case 2:
                    sortList = !AscendingButton.Enabled ? _salesMana.HistoryList.OrderBy(x => x.Purchase.SalePrice)
                                                        : _salesMana.HistoryList.OrderByDescending(x => x.Purchase.SalePrice);
                    break;
                case 3:
                    sortList = !AscendingButton.Enabled ? _salesMana.HistoryList.OrderBy(x => x.Purchase.PurchaseDateTime) :
                                                          _salesMana.HistoryList.OrderByDescending(x => x.Purchase.PurchaseDateTime);
                    break;
                case 4:
                    sortList = !AscendingButton.Enabled ? _salesMana.HistoryList.OrderBy(x => x.SaleDateTime) :
                                                          _salesMana.HistoryList.OrderByDescending(x => x.SaleDateTime);
                    break;
                case 5:
                    sortList = !AscendingButton.Enabled ? _salesMana.HistoryList.OrderBy(x => x.SaleQuantity) :
                                                          _salesMana.HistoryList.OrderByDescending(x => x.SaleQuantity);
                    break;
                case 6:
                    sortList = !AscendingButton.Enabled ? _salesMana.HistoryList.OrderBy(x => x.GetSalesAmount()) :
                                                          _salesMana.HistoryList.OrderByDescending(x => x.GetSalesAmount());
                    break;

                default: break;
            }
            SalesListView.Items.Clear();
            foreach (var sale in sortList)
            {
                SalesListView.Items.Add(new ListViewItem(new string[]
                {
                    "",
                    sale.Purchase.ProductName,
                    sale.Purchase.SalePrice.ToString("#,0円"),
                    sale.Purchase.PurchaseDateTime.ToString("yyyy/MM/dd"),
                    sale.SaleDateTime.ToString("yyyy/MM/dd"),
                    sale.SaleQuantity.ToString(),
                    sale.GetSalesAmount().ToString("#,0円")
                }));
            }
        }

        private void AscendingButton_Click(object sender, EventArgs e)
        {
            SortButtonChanged(true);
        }

        private void DescendingButton_Click(object sender, EventArgs e)
        {
            SortButtonChanged(false);
        }
        private void SortButtonChanged(bool isAscendingButton)
        {
            AscendingButton.Enabled = !isAscendingButton;
            DescendingButton.Enabled = isAscendingButton;
            SortClearButton.Enabled = AscendingButton.Enabled || DescendingButton.Enabled;
        }

        private void SortClearButton_Click(object sender, EventArgs e)
        {
            SortClearButton.Enabled = false;
            UpdateScreen();
        }
    }
}
