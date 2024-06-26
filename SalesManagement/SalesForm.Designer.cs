namespace SalesManagement
{
    partial class SalesForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.SaleDateTime = new System.Windows.Forms.DateTimePicker();
            this.SalesTimeDateLabel = new System.Windows.Forms.Label();
            this.SalesQuantityTextBox = new System.Windows.Forms.TextBox();
            this.SalesLabel = new System.Windows.Forms.Label();
            this.SalesButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.StockListView = new System.Windows.Forms.ListView();
            this.columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.CartListView = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CartAddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SaleDateTime
            // 
            this.SaleDateTime.Enabled = false;
            this.SaleDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.SaleDateTime.Location = new System.Drawing.Point(93, 423);
            this.SaleDateTime.Name = "SaleDateTime";
            this.SaleDateTime.Size = new System.Drawing.Size(100, 19);
            this.SaleDateTime.TabIndex = 7;
            this.SaleDateTime.Value = new System.DateTime(2024, 6, 25, 0, 0, 0, 0);
            // 
            // SalesTimeDateLabel
            // 
            this.SalesTimeDateLabel.AutoSize = true;
            this.SalesTimeDateLabel.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.SalesTimeDateLabel.Location = new System.Drawing.Point(30, 427);
            this.SalesTimeDateLabel.Name = "SalesTimeDateLabel";
            this.SalesTimeDateLabel.Size = new System.Drawing.Size(49, 14);
            this.SalesTimeDateLabel.TabIndex = 6;
            this.SalesTimeDateLabel.Text = "販売日";
            // 
            // SalesQuantityTextBox
            // 
            this.SalesQuantityTextBox.Enabled = false;
            this.SalesQuantityTextBox.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.SalesQuantityTextBox.Location = new System.Drawing.Point(93, 384);
            this.SalesQuantityTextBox.Name = "SalesQuantityTextBox";
            this.SalesQuantityTextBox.Size = new System.Drawing.Size(100, 21);
            this.SalesQuantityTextBox.TabIndex = 5;
            this.SalesQuantityTextBox.TextChanged += new System.EventHandler(this.SalesQuantityTextBox_TextChanged);
            this.SalesQuantityTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SalesQuantityTextBox_KeyPress);
            // 
            // SalesLabel
            // 
            this.SalesLabel.AutoSize = true;
            this.SalesLabel.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.SalesLabel.Location = new System.Drawing.Point(30, 387);
            this.SalesLabel.Name = "SalesLabel";
            this.SalesLabel.Size = new System.Drawing.Size(49, 14);
            this.SalesLabel.TabIndex = 4;
            this.SalesLabel.Text = "販売数";
            // 
            // SalesButton
            // 
            this.SalesButton.Enabled = false;
            this.SalesButton.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.SalesButton.Location = new System.Drawing.Point(678, 379);
            this.SalesButton.Name = "SalesButton";
            this.SalesButton.Size = new System.Drawing.Size(90, 32);
            this.SalesButton.TabIndex = 3;
            this.SalesButton.Text = "販売する";
            this.SalesButton.UseVisualStyleBackColor = true;
            this.SalesButton.Click += new System.EventHandler(this.SalesButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.CloseButton.Location = new System.Drawing.Point(678, 417);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(90, 32);
            this.CloseButton.TabIndex = 7;
            this.CloseButton.Text = "閉じる";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "在庫状況";
            // 
            // StockListView
            // 
            this.StockListView.CheckBoxes = true;
            this.StockListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.StockListView.FullRowSelect = true;
            this.StockListView.HideSelection = false;
            this.StockListView.Location = new System.Drawing.Point(12, 52);
            this.StockListView.MultiSelect = false;
            this.StockListView.Name = "StockListView";
            this.StockListView.Size = new System.Drawing.Size(389, 302);
            this.StockListView.TabIndex = 5;
            this.StockListView.UseCompatibleStateImageBehavior = false;
            this.StockListView.View = System.Windows.Forms.View.Details;
            this.StockListView.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.StockListView_ItemCheck);
            // 
            // columnHeader
            // 
            this.columnHeader.Text = "";
            this.columnHeader.Width = 35;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "商品名";
            this.columnHeader1.Width = 86;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "仕入日";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader2.Width = 75;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "仕入価格";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "販売価格";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "在庫数";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.label2.Location = new System.Drawing.Point(404, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "カート";
            // 
            // CartListView
            // 
            this.CartListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.CartListView.FullRowSelect = true;
            this.CartListView.HideSelection = false;
            this.CartListView.Location = new System.Drawing.Point(407, 52);
            this.CartListView.MultiSelect = false;
            this.CartListView.Name = "CartListView";
            this.CartListView.Size = new System.Drawing.Size(361, 302);
            this.CartListView.TabIndex = 9;
            this.CartListView.UseCompatibleStateImageBehavior = false;
            this.CartListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "商品名";
            this.columnHeader7.Width = 86;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "販売価格";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader8.Width = 75;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "仕入日";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "販売日";
            this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "販売数";
            this.columnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CartAddButton
            // 
            this.CartAddButton.Enabled = false;
            this.CartAddButton.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.CartAddButton.Location = new System.Drawing.Point(311, 417);
            this.CartAddButton.Name = "CartAddButton";
            this.CartAddButton.Size = new System.Drawing.Size(90, 32);
            this.CartAddButton.TabIndex = 10;
            this.CartAddButton.Text = "カートに追加";
            this.CartAddButton.UseVisualStyleBackColor = true;
            this.CartAddButton.Click += new System.EventHandler(this.CartAddButton_Click);
            // 
            // SalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 462);
            this.Controls.Add(this.CartAddButton);
            this.Controls.Add(this.CartListView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SaleDateTime);
            this.Controls.Add(this.SalesTimeDateLabel);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.SalesQuantityTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SalesLabel);
            this.Controls.Add(this.StockListView);
            this.Controls.Add(this.SalesButton);
            this.Name = "SalesForm";
            this.Text = "販売処理";
            this.Load += new System.EventHandler(this.SalesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker SaleDateTime;
        private System.Windows.Forms.Label SalesTimeDateLabel;
        private System.Windows.Forms.TextBox SalesQuantityTextBox;
        private System.Windows.Forms.Label SalesLabel;
        private System.Windows.Forms.Button SalesButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ListView StockListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ListView CartListView;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.Button CartAddButton;
    }
}

