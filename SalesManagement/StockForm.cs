using Products.Cores.Managers;
using System;
using System.Windows.Forms;

namespace SalesManagement
{
    public partial class StockForm : Form
    {
        private PurchaseManager _purchaseMana;

        public StockForm(PurchaseManager purchaseMana)
        {
            _purchaseMana = purchaseMana;
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void UpdateScreen()
        {
            StockListView.Items.Clear();

            foreach (var purchase in _purchaseMana.PurchaseList)
            {
                StockListView.Items.Add(new ListViewItem(new string[]
                {
                    purchase.Product.Name,
                    purchase.PurchaseDateTime.ToString("yyyy/MM/dd"),
                    purchase.PurchasePrice.ToString("#,0円"),
                    purchase.SalePrice.ToString("#,0円"),
                    purchase.StockQuantity.ToString()
                }));
            }
        }

        public void StockForm_Load(object sender, EventArgs e)
        {
            UpdateScreen();
        }
    }
}