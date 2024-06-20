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
        private PurchaseManager _purchaseMana = new PurchaseManager();
        private SalesManager _salesMana = new SalesManager();
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
            foreach (var sales in _salesMana.SalesList)
            {
                var purchase = sales.Purchase;
                SalesListView.Items.Add(new ListViewItem(new string[] { purchase.ProductName, sales.SalesPrice.ToString(), purchase.PurchaseDateTime, sales.SalesDataTime, sales.SalesQuantity.ToString(), sales.GetSalesAmount().ToString() }));
            }

            TotaltSalesAmountLabel.Text = $"売上合計金額：{_salesMana.SalesList.Sum(x => x.GetSalesAmount())}円";
            TotalIncomeAmountLabel.Text = $"利益合計金額：{_salesMana.SalesList.Sum(x => x.GetIncomeAmount())}円";
        }

        private void SalesProcessingButton_Click(object sender, EventArgs e)
        {
            var salesOrderForm = new SalesForm(_salesMana, _stockForm);
            if (DialogResult.OK == salesOrderForm.ShowDialog())
            {
                UpdateScreen();
            }
        }

        private void PurchaseProcessingButton_Click(object sender, EventArgs e)
        {
            var orderForm = new OrderForm(_purchaseMana, _salesMana, _stockForm);
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
