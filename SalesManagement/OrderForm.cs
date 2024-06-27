using Products.Cores.Managers;
using Products.Cores.Models;
using System;
using System.Windows.Forms;

namespace SalesManagement
{
    public partial class OrderForm : Form
    {
        private PurchaseManager _purchaseMana;
        private ProductManager _productMana;

        public OrderForm(PurchaseManager purchaseMana, ProductManager productMana)
        {
            _purchaseMana = purchaseMana;
            _productMana = productMana;
            InitializeComponent();
        }
        private void OrderForm_Load(object sender, EventArgs e)
        {
            SalesDateTime.Value = DateTime.Now.Date;
            foreach (var product in _productMana.ProductList)
            {
                ProductNameComboBox.Items.Add(product.Name);
            }
        }

        private void OkButtonChangedEnabled()
        {
            OkButton.Enabled = ProductNameComboBox.SelectedIndex >= 0 && PurchaseQuantityTextBox.Text.Length > 0 && PurchasePriceTextBox.Text.Length > 0 && SalesPriceTextBox.Text.Length > 0;
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
            var product = _productMana.GetProduct(ProductNameComboBox.SelectedIndex);
            var purchasePrice = int.Parse(PurchasePriceTextBox.Text);
            var salePrice = int.Parse(SalesPriceTextBox.Text);
            var purchaseQuantity = int.Parse(PurchaseQuantityTextBox.Text);
            var purchaseDateTime = SalesDateTime.Value;

            try
            {
                _purchaseMana.Add(new Purchase(product, purchasePrice, salePrice, purchaseQuantity, purchaseDateTime));

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