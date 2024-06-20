using Product.Cores.Manager;
using System;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp1;
using WindowsFormsApp2;

namespace SalesManagement
{
    public partial class MainForm : Form
    {
        private SalesManager _salesMana = new SalesManager();
        private HistoryManager _historyManager = new HistoryManager();
        private StockForm _stockForm;

        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            _stockForm = new StockForm(_salesMana);
        }

        private void UpdateScreen()
        {
            SalesListView.Items.Clear();
            foreach (var sale in _historyManager.HistoryList)
            {
                var purchase = sale.Purchase;
                SalesListView.Items.Add(new ListViewItem(new string[] { purchase.ProductName, sale.SalePrice.ToString(), purchase.PurchaseDateTime, sale.SalesDataTime, sale.SaleQuantity.ToString(), sale.GetSalesAmount().ToString() }));
            }

            TotaltSalesAmountLabel.Text = $"売上合計金額：{_historyManager.HistoryList.Sum(x => x.GetSalesAmount())}円";
            TotalIncomeAmountLabel.Text = $"利益合計金額：{_historyManager.HistoryList.Sum(x => x.GetIncomeAmount())}円";
        }

        private void SalesProcessingButton_Click(object sender, EventArgs e)
        {
            var salesOrderForm = new SalesForm(_salesMana, _historyManager, _stockForm);
            if (DialogResult.OK == salesOrderForm.ShowDialog())
            {
                UpdateScreen();
            }
        }

        private void PurchaseProcessingButton_Click(object sender, EventArgs e)
        {
            var orderForm = new OrderForm(_salesMana, _stockForm);
            orderForm.ShowDialog();
        }

        private void InventoryListButton_Click(object sender, EventArgs e)
        {
            _stockForm = new StockForm(_salesMana);

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
    }
}
