using System.Windows.Forms;
using WindowsFormsApp1;

namespace SalesManagement
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void IsPurchaseOrder(bool isPurchaseOrder)
        {
            var OrderForm = new OrderForm(isPurchaseOrder);

            if (DialogResult.OK == OrderForm.ShowDialog())
            {

            }
        }

        private void SalesProcessingButton_Click(object sender, System.EventArgs e)
        {
            IsPurchaseOrder(false);
        }

        private void PurchaseProcessingButton_Click(object sender, System.EventArgs e)
        {
            IsPurchaseOrder(true);
        }
    }
}
