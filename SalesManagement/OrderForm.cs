using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class OrderForm : Form
    {
        private bool _isPurchaseOrder;

        public OrderForm(bool isPurchaseOrder)
        {
            _isPurchaseOrder = isPurchaseOrder;
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
    }
}
