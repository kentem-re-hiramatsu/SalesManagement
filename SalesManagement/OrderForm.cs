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

        private void CancelButton_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void OkButton_Click(object sender, System.EventArgs e)
        {

        }
    }
}
