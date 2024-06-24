using Product.Cores.Managers;
using Product.Cores.Models;
using System;
using System.Windows.Forms;

namespace SalesManagement
{
    public partial class OrderForm : Form
    {
        private PurchaseManager _purchaseMana;

        public OrderForm(PurchaseManager purchaseMana)
        {
            _purchaseMana = purchaseMana;
            InitializeComponent();
        }

        private void OkButtonChangedEnabled()
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
                _purchaseMana.Add(new Purchase(productName, purchasePrice, salePrice, purchaseQuantity, purchaseDateTime));

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}