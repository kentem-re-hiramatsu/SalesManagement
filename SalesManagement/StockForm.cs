using Product.Cores.Manager;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class StockForm : Form
    {
        private SalesManager _salesMana;

        public StockForm(SalesManager salesManager)
        {
            _salesMana = salesManager;
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void UpdateScreen()
        {
            StockListView.Items.Clear();

            foreach (var sales in _salesMana.SalesList)
            {
                var purchase = sales.Purchase;
                StockListView.Items.Add(new ListViewItem(new string[] { purchase.ProductName, purchase.PurchaseDateTime.ToString(), purchase.PurchasePrice.ToString(), sales.SalesPrice.ToString(), sales.StockQuantity.ToString() }));
            }
        }

        public void StockForm_Load(object sender, EventArgs e)
        {
            UpdateScreen();
        }
    }
}
