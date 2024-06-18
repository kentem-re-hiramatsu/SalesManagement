using Product.Cores.Manager;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace SalesManagement
{
    public partial class MainForm : Form
    {
        PurchaseManager purchaseManager = new PurchaseManager();

        public MainForm()
        {
            InitializeComponent();
        }

        private void IsPurchaseOrder(bool isPurchaseOrder)
        {
            var orderForm = new OrderForm(isPurchaseOrder);

            if (DialogResult.OK == orderForm.ShowDialog())
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

        private void InventoryListButton_Click(object sender, System.EventArgs e)
        {
            var stockForm = new StockForm();
            stockForm.Show();
        }

        private void CloseButton_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
