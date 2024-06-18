namespace SalesManagement
{
    partial class MainForm
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
            this.SalesProcessingButton = new System.Windows.Forms.Button();
            this.PurchaseProcessingButton = new System.Windows.Forms.Button();
            this.InventoryListButton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TotaltSalesAmountLabel = new System.Windows.Forms.Label();
            this.TotalIncomeAmountLabel = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SalesProcessingButton
            // 
            this.SalesProcessingButton.Location = new System.Drawing.Point(12, 46);
            this.SalesProcessingButton.Name = "SalesProcessingButton";
            this.SalesProcessingButton.Size = new System.Drawing.Size(90, 30);
            this.SalesProcessingButton.TabIndex = 0;
            this.SalesProcessingButton.Text = "販売処理";
            this.SalesProcessingButton.UseVisualStyleBackColor = true;
            // 
            // PurchaseProcessingButton
            // 
            this.PurchaseProcessingButton.Location = new System.Drawing.Point(108, 46);
            this.PurchaseProcessingButton.Name = "PurchaseProcessingButton";
            this.PurchaseProcessingButton.Size = new System.Drawing.Size(90, 30);
            this.PurchaseProcessingButton.TabIndex = 1;
            this.PurchaseProcessingButton.Text = "仕入処理";
            this.PurchaseProcessingButton.UseVisualStyleBackColor = true;
            // 
            // InventoryListButton
            // 
            this.InventoryListButton.Location = new System.Drawing.Point(204, 46);
            this.InventoryListButton.Name = "InventoryListButton";
            this.InventoryListButton.Size = new System.Drawing.Size(90, 30);
            this.InventoryListButton.TabIndex = 2;
            this.InventoryListButton.Text = "在庫一覧";
            this.InventoryListButton.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 102);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(453, 247);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "商品名";
            this.columnHeader1.Width = 101;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "販売価格";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "仕入日";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "販売日";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "販売数";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "売上金額";
            this.columnHeader6.Width = 76;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "販売商品",
            "本日の販売商品"});
            this.checkedListBox1.Location = new System.Drawing.Point(345, 46);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(6);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 46);
            this.checkedListBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(343, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "絞り込み表示";
            // 
            // TotaltSalesAmountLabel
            // 
            this.TotaltSalesAmountLabel.AutoSize = true;
            this.TotaltSalesAmountLabel.Location = new System.Drawing.Point(12, 362);
            this.TotaltSalesAmountLabel.Name = "TotaltSalesAmountLabel";
            this.TotaltSalesAmountLabel.Size = new System.Drawing.Size(83, 12);
            this.TotaltSalesAmountLabel.TabIndex = 6;
            this.TotaltSalesAmountLabel.Text = "売上合計金額：";
            // 
            // TotalIncomeAmountLabel
            // 
            this.TotalIncomeAmountLabel.AutoSize = true;
            this.TotalIncomeAmountLabel.Location = new System.Drawing.Point(12, 392);
            this.TotalIncomeAmountLabel.Name = "TotalIncomeAmountLabel";
            this.TotalIncomeAmountLabel.Size = new System.Drawing.Size(83, 12);
            this.TotalIncomeAmountLabel.TabIndex = 7;
            this.TotalIncomeAmountLabel.Text = "利益合計金額：";
            // 
            // CloseButton
            // 
            this.CloseButton.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.CloseButton.Location = new System.Drawing.Point(372, 355);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(93, 29);
            this.CloseButton.TabIndex = 8;
            this.CloseButton.Text = "閉じる";
            this.CloseButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 413);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.TotalIncomeAmountLabel);
            this.Controls.Add(this.TotaltSalesAmountLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.InventoryListButton);
            this.Controls.Add(this.PurchaseProcessingButton);
            this.Controls.Add(this.SalesProcessingButton);
            this.Name = "MainForm";
            this.Text = "販売処理";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SalesProcessingButton;
        private System.Windows.Forms.Button PurchaseProcessingButton;
        private System.Windows.Forms.Button InventoryListButton;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TotaltSalesAmountLabel;
        private System.Windows.Forms.Label TotalIncomeAmountLabel;
        private System.Windows.Forms.Button CloseButton;
    }
}

