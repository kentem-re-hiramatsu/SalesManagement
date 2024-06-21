using Product.Cores.Manager;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class StockForm : Form
    {
        private ProductManager _productMana;

        public StockForm(ProductManager productMana)
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
                    product.PurchasePrice.ToString(),
                    product.SalePrice.ToString(),
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
