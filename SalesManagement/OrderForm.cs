using Product.Cores.Manager;
using Product.Cores.Model;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class OrderForm : Form
    {
        private SalesManager _salesMana;
        private StockForm _stockForm;

        public OrderForm(SalesManager salesMana, StockForm stockForm)
        {
            _salesMana = salesMana;
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
            var purchaseDateTime = SalesDateTime.Value.ToString("MM/dd");
            var purchaseQuantity = int.Parse(PurchaseQuantityTextBox.Text);
            var purchasePrice = int.Parse(PurchasePriceTextBox.Text);
            var salesPrice = int.Parse(SalesPriceTextBox.Text);

            try
            {
                var purchase = new Purchase(productName, purchaseDateTime, purchaseQuantity, purchasePrice);
                _salesMana.Add(new Sale(salesPrice, purchase));

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