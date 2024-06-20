using Product.Cores.Manager;
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
        private void MainForm_Load(object sender, System.EventArgs e)
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
        }

        private void SalesProcessingButton_Click(object sender, System.EventArgs e)
        {
            var salesOrderForm = new SalesForm(_salesMana);
            if (DialogResult.OK == salesOrderForm.ShowDialog())
            {
                UpdateScreen();
            }
        }

        private void PurchaseProcessingButton_Click(object sender, System.EventArgs e)
        {
            var orderForm = new OrderForm(_purchaseMana, _salesMana, _stockForm);
            orderForm.ShowDialog();
        }

        private void InventoryListButton_Click(object sender, System.EventArgs e)
        {
            _stockForm = new StockForm(_salesMana);

            _stockForm.FormClosed += StockForm_FormClosed;
            _stockForm.Show();
            InventoryListButton.Enabled = false;
        }

        private void CloseButton_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void StockForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            InventoryListButton.Enabled = true;
        }
    }
}
