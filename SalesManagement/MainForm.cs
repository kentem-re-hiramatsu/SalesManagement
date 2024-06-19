using Product.Cores.Manager;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace SalesManagement
{
    public partial class MainForm : Form
    {
        private PurchaseManager _purchaseMana = new PurchaseManager();
        private SalesManager _salesMana = new SalesManager();
        private StockForm _stockForm;

        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, System.EventArgs e)
        {
            _stockForm = new StockForm(_purchaseMana, _salesMana);
        }

        private void IsPurchaseOrder(bool isPurchaseOrder)
        {
            var orderForm = new OrderForm(isPurchaseOrder, _purchaseMana, _salesMana, _stockForm);
            orderForm.ShowDialog();
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
            _stockForm = new StockForm(_purchaseMana, _salesMana);

            _stockForm.FormClosed += StockForm_FormClosed;
            _stockForm.Show();
            InventoryListButton.Enabled = false;
        }

        private void CloseButton_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void StockForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            InventoryListButton.Enabled = true;
        }
    }
}
