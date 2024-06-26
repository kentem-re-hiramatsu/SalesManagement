using Product.Cores.Managers;
using Product.Cores.Models;
using System;
using System.Windows.Forms;

namespace SalesManagement
{
    public partial class SalesForm : Form
    {
        private int _selectedIndex;
        private SalesHistoryManager _salesMana;
        private PurchaseManager _purchaseMana;
        private SalesCartManager _salesCartMana = new SalesCartManager();

        public SalesForm(SalesHistoryManager salesMana, PurchaseManager purchaseMana)
        {
            _salesMana = salesMana;
            _purchaseMana = purchaseMana;
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void UpdateScreen()
        {
            StockListView.Items.Clear();
            CartListView.Items.Clear();

            foreach (var purchase in _purchaseMana.PurchaseList)
            {
                StockListView.Items.Add(new ListViewItem(new string[]
                { "",
                    purchase.ProductName,
                    purchase.PurchaseDateTime.ToString("yyyy/MM/dd"),
                    purchase.PurchasePrice.ToString("#,0円"),
                    purchase.SalePrice.ToString("#,0円"),
                    purchase.StockQuantity.ToString()
                }));
            }

            foreach (var sale in _salesCartMana.CartList)
            {
                var purchase = sale.Purchase;
                CartListView.Items.Add(new ListViewItem(new string[]
                {
                    purchase.ProductName,
                    purchase.SalePrice.ToString("#,0円"),
                    purchase.PurchaseDateTime.ToString("MM/dd"),
                    sale.SaleDateTime.ToString("MM/dd"),
                    sale.SaleQuantity.ToString()
                }));
            }
        }

        public void SalesButtonChanged()
        {
            SalesButton.Enabled = SalesQuantityTextBox.Text.Length > 0;
        }

        private void SalesButton_Click(object sender, EventArgs e)
        {
            foreach (var cartSale in _salesCartMana.CartList)
            {
                _salesMana.Add(cartSale);
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void StockListView_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //単一選択
            foreach (ListViewItem item in StockListView.Items)
            {
                if (!StockListView.Items[e.Index].Checked)
                    item.Checked = false;
            }

            //商品にチェックがされている時入力を活性化
            SalesQuantityTextBox.Enabled = e.CurrentValue == CheckState.Unchecked;
            SaleDateTime.Enabled = e.CurrentValue == CheckState.Unchecked;
            SalesButton.Enabled = e.CurrentValue == CheckState.Unchecked;

            if (e.CurrentValue == CheckState.Unchecked)
            {
                SalesButtonChanged();
                _selectedIndex = e.Index;
            }
        }

        private void SalesQuantityTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void SalesForm_Load(object sender, EventArgs e)
        {
            SaleDateTime.Value = DateTime.Now.Date;
            UpdateScreen();
        }

        private void SalesQuantityTextBox_TextChanged(object sender, EventArgs e)
        {
            SalesButtonChanged();
        }

        private void CartAddButton_Click(object sender, EventArgs e)
        {
            var saleQuantity = int.Parse(SalesQuantityTextBox.Text);
            var saleDateTime = SaleDateTime.Value;
            var purchase = _purchaseMana.GetPurchase(_selectedIndex);

            try
            {
                _salesCartMana.Add(new Sale(saleQuantity, saleDateTime, purchase));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            UpdateScreen();
        }
    }
}