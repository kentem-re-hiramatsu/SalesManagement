using Product.Cores.Manager;
using Product.Cores.Model;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class SalesForm : Form
    {
        private int _selectedIndex;
        private SalesHistoryManager _salesMana;
        private PurchaseManager _purchaseMana;

        public SalesForm(SalesHistoryManager salesMana, PurchaseManager productMana)
        {
            _salesMana = salesMana;
            _purchaseMana = productMana;
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void UpdateScreen()
        {
            StockListView.Items.Clear();

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
        }

        public void SalesButtonChanged()
        {
            SalesButton.Enabled = SalesQuantityTextBox.Text.Length > 0;
        }

        private void SalesButton_Click(object sender, EventArgs e)
        {
            var saleQuantity = int.Parse(SalesQuantityTextBox.Text);
            var saleDateTime = SaleDateTime.Value;
            var product = _purchaseMana.GetProduct(_selectedIndex);

            try
            {
                _salesMana.Add(new Sale(saleQuantity, saleDateTime, product));
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            UpdateScreen();
        }

        private void SalesQuantityTextBox_TextChanged(object sender, EventArgs e)
        {
            SalesButtonChanged();
        }
    }
}
