using Product.Cores.Manager;
using Product.Cores.Model;
using System;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace WindowsFormsApp2
{
    public partial class SalesForm : Form
    {
        private int _selectedIndex;
        private SalesHistoryManager _salesMana;
        private ProductManager _productMana;
        private StockForm _stockFrom;

        public SalesForm(SalesHistoryManager salesMana, ProductManager productMana, StockForm stockForm)
        {
            _salesMana = salesMana;
            _productMana = productMana;
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

            foreach (var product in _productMana.ProductList)
            {
                StockListView.Items.Add(new ListViewItem(new string[]
                { "",
                    product.ProductName,
                    product.PurchaseDateTime.ToString("yyyy/MM/dd"),
                    product.PurchasePrice.ToString(),
                    product.SalePrice.ToString(),
                    product.StockQuantity.ToString()
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
            var product = _productMana.GetProduct(_selectedIndex);

            try
            {
                _salesMana.Add(new Sale(saleQuantity, saleDateTime, product));
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
            SaleDateTime.Enabled = e.CurrentValue == CheckState.Unchecked;
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
