using Product.Cores.Manager;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class OrderForm : Form
    {
        private ProductManager _productMana;
        private StockForm _stockForm;

        public OrderForm(ProductManager productMana, StockForm stockForm)
        {
            _productMana = productMana;
            _stockForm = stockForm;
            InitializeComponent();
        }

        public void OkButtonChangedEnabled()
        {
            OkButton.Enabled = ProductTextBox.Text.Length > 0 && PurchaseQuantityTextBox.Text.Length > 0 && PurchasePriceTextBox.Text.Length > 0 && SalesPriceTextBox.Text.Length > 0;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ProductTextBox_TextChanged(object sender, EventArgs e)
        {
            OkButtonChangedEnabled();
        }

        private void PurchaseQuantityTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
            {
                return;
            }

            if (e.KeyChar < '0' || '9' < e.KeyChar)
            {
                e.Handled = true;
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            var productName = ProductTextBox.Text;
            var purchasePrice = int.Parse(PurchasePriceTextBox.Text);
            var salePrice = int.Parse(SalesPriceTextBox.Text);
            var purchaseQuantity = int.Parse(PurchaseQuantityTextBox.Text);
            var purchaseDateTime = SalesDateTime.Value;

            try
            {
                _productMana.Add(new Product.Cores.Model.Product(productName, purchasePrice, salePrice, purchaseQuantity, purchaseDateTime));

                //在庫一覧が開かれているか。
                if (_stockForm != null)
                {
                    _stockForm.UpdateScreen();
                }
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}