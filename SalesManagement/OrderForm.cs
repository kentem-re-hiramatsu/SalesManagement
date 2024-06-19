using Product.Cores.Manager;
using Product.Cores.Model;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class OrderForm : Form
    {
        private bool _isPurchaseOrder;
        private PurchaseManager _purchaseMana;
        private SalesManager _salesMana;
        private StockForm _stockForm;

        public OrderForm(bool isPurchaseOrder, PurchaseManager purchaseMana, SalesManager salesManager, StockForm stockForm)
        {
            _isPurchaseOrder = isPurchaseOrder;
            _purchaseMana = purchaseMana;
            _salesMana = salesManager;
            _stockForm = stockForm;
            InitializeComponent();
        }
        private void OrderForm_Load(object sender, System.EventArgs e)
        {
            OrderFormSettings();
        }

        public void OrderFormSettings()
        {
            PuchaseOrderGroup.Enabled = _isPurchaseOrder;
            SalesGroup.Enabled = !_isPurchaseOrder;
        }

        public void OkButtonChangedEnabled()
        {
            OkButton.Enabled = ProductTextBox.Text.Length > 0 && PurchaseQuantityTextBox.Text.Length > 0 && PurchasePriceTextBox.Text.Length > 0 && SalesPriceTextBox.Text.Length > 0 || SalesQuantityTextBox.Text.Length > 0;
        }

        private void CancelButton_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void ProductTextBox_TextChanged(object sender, System.EventArgs e)
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

        private void OkButton_Click(object sender, System.EventArgs e)
        {
            if (_isPurchaseOrder)
            {
                var productName = ProductTextBox.Text;
                var purchaseQuantity = int.Parse(PurchaseQuantityTextBox.Text);
                var purchasePrice = int.Parse(PurchasePriceTextBox.Text);
                var salesPrice = int.Parse(SalesPriceTextBox.Text);
                var purchase = new Purchase(productName, purchaseQuantity, purchasePrice);

                try
                {
                    _purchaseMana.Add(purchase);
                    _salesMana.Add(new Sales(salesPrice, purchase));
                    var stockForm = new StockForm(_purchaseMana, _salesMana);
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
            else
            {

            }
        }
    }
}
