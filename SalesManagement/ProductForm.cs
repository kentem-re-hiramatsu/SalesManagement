using Products.Cores.Managers;
using Products.Cores.Models;
using System;
using System.Windows.Forms;

namespace SalesManagement
{
    public partial class ProductForm : Form
    {
        ProductManager _productMana;

        public ProductForm(ProductManager productMana)
        {
            _productMana = productMana;
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void ProductAddButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                _productMana.Add(new Product(ProductNameTextBox.Text));
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ProductNameTextBox_TextChanged(object sender, EventArgs e)
        {
            ProductAddButton.Enabled = ProductNameTextBox.Text.Length > 0;
        }
    }
}