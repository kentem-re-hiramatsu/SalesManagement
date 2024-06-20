using Product.Cores.Manager;
using System;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace WindowsFormsApp2
{
    public partial class SalesForm : Form
    {
        private int _selectedIndex;
        private SalesManager _salesMana;
        private StockForm _stockFrom;

        public SalesForm(SalesManager salesMana, StockForm stockForm)
        {
            _salesMana = salesMana;
            _stockFrom = stockForm;
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void UpdateScreen()
        {
            StockListView.Items.Clear();

            foreach (var sales in _salesMana.SalesList)
            {
                var purchase = sales.Purchase;
                StockListView.Items.Add(new ListViewItem(new string[] { "", purchase.ProductName, purchase.PurchaseDateTime.ToString(), purchase.PurchasePrice.ToString(), sales.SalesPrice.ToString(), sales.StockQuantity.ToString() }));
            }
        }

        public void SalesButtonChanged()
        {
            SalesButton.Enabled = SalesQuantityTextBox.Text.Length > 0;
        }

        private void SalesButton_Click(object sender, EventArgs e)
        {
            try
            {
                _salesMana.GetSales(_selectedIndex).ProcessSale(int.Parse(SalesQuantityTextBox.Text), SalesDateTime.Value.ToString("MM/dd"));

                //在庫一覧が開かれているか。
                if (_stockFrom != null)
                {
                    _stockFrom.UpdateScreen();
                }

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
            SalesDateTime.Enabled = e.CurrentValue == CheckState.Unchecked;
            SalesButton.Enabled = e.CurrentValue == CheckState.Unchecked;

            if (e.CurrentValue == CheckState.Unchecked)
                SalesButtonChanged();

            if (e.CurrentValue == CheckState.Unchecked)
                _selectedIndex = e.Index;
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
