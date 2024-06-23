using Product.Cores.Manager;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class StockForm : Form
    {
        private PurchaseManager _productMana;

        public StockForm(PurchaseManager productMana)
        {
            _productMana = productMana;
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void UpdateScreen()
        {
            StockListView.Items.Clear();

            foreach (var product in _productMana.ProductList)
            {
                StockListView.Items.Add(new ListViewItem(new string[]
                {
                    product.ProductName,
                    product.PurchaseDateTime.ToString("yyyy/MM/dd"),
                    product.PurchasePrice.ToString("#,0円"),
                    product.SalePrice.ToString("#,0円"),
                    product.StockQuantity.ToString()
                }));
            }
        }

        public void StockForm_Load(object sender, EventArgs e)
        {
            UpdateScreen();
        }
    }
}
