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
            this.SalesListView = new System.Windows.Forms.ListView();
            this.columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TotaltSalesAmountLabel = new System.Windows.Forms.Label();
            this.TotalIncomeAmountLabel = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.ClearFilterButton = new System.Windows.Forms.Button();
            this.TodaySalesButton = new System.Windows.Forms.Button();
            this.SelectProductFilterButton = new System.Windows.Forms.Button();
            this.DescendingButton = new System.Windows.Forms.Button();
            this.AscendingButton = new System.Windows.Forms.Button();
            this.SortClearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SalesProcessingButton
            // 
            this.SalesProcessingButton.Location = new System.Drawing.Point(12, 30);
            this.SalesProcessingButton.Name = "SalesProcessingButton";
            this.SalesProcessingButton.Size = new System.Drawing.Size(90, 30);
            this.SalesProcessingButton.TabIndex = 0;
            this.SalesProcessingButton.Text = "販売処理";
            this.SalesProcessingButton.UseVisualStyleBackColor = true;
            this.SalesProcessingButton.Click += new System.EventHandler(this.SalesProcessingButton_Click);
            // 
            // PurchaseProcessingButton
            // 
            this.PurchaseProcessingButton.Location = new System.Drawing.Point(108, 30);
            this.PurchaseProcessingButton.Name = "PurchaseProcessingButton";
            this.PurchaseProcessingButton.Size = new System.Drawing.Size(90, 30);
            this.PurchaseProcessingButton.TabIndex = 1;
            this.PurchaseProcessingButton.Text = "仕入処理";
            this.PurchaseProcessingButton.UseVisualStyleBackColor = true;
            this.PurchaseProcessingButton.Click += new System.EventHandler(this.PurchaseProcessingButton_Click);
            // 
            // InventoryListButton
            // 
            this.InventoryListButton.Location = new System.Drawing.Point(204, 30);
            this.InventoryListButton.Name = "InventoryListButton";
            this.InventoryListButton.Size = new System.Drawing.Size(90, 30);
            this.InventoryListButton.TabIndex = 2;
            this.InventoryListButton.Text = "在庫一覧";
            this.InventoryListButton.UseVisualStyleBackColor = true;
            this.InventoryListButton.Click += new System.EventHandler(this.InventoryListButton_Click);
            // 
            // SalesListView
            // 
            this.SalesListView.CheckBoxes = true;
            this.SalesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.SalesListView.FullRowSelect = true;
            this.SalesListView.HideSelection = false;
            this.SalesListView.Location = new System.Drawing.Point(14, 102);
            this.SalesListView.Name = "SalesListView";
            this.SalesListView.Size = new System.Drawing.Size(484, 247);
            this.SalesListView.TabIndex = 3;
            this.SalesListView.UseCompatibleStateImageBehavior = false;
            this.SalesListView.View = System.Windows.Forms.View.Details;
            this.SalesListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.SalesListView_ColumnClick);
            this.SalesListView.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.SalesListView_DrawColumnHeader);
            this.SalesListView.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.SalesListView_DrawItem);
            this.SalesListView.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.SalesListView_DrawSubItem);
            // 
            // columnHeader
            // 
            this.columnHeader.Text = "";
            this.columnHeader.Width = 25;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "商品名";
            this.columnHeader1.Width = 101;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "販売価格";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "仕入日";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader3.Width = 75;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "販売日";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader4.Width = 75;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "販売数";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "売上金額";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader6.Width = 76;
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
            this.CloseButton.Location = new System.Drawing.Point(405, 355);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(93, 29);
            this.CloseButton.TabIndex = 8;
            this.CloseButton.Text = "閉じる";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ClearFilterButton
            // 
            this.ClearFilterButton.Enabled = false;
            this.ClearFilterButton.Font = new System.Drawing.Font("MS UI Gothic", 8F);
            this.ClearFilterButton.Location = new System.Drawing.Point(440, 30);
            this.ClearFilterButton.Name = "ClearFilterButton";
            this.ClearFilterButton.Size = new System.Drawing.Size(59, 30);
            this.ClearFilterButton.TabIndex = 9;
            this.ClearFilterButton.Text = "絞込解除";
            this.ClearFilterButton.UseVisualStyleBackColor = true;
            this.ClearFilterButton.Click += new System.EventHandler(this.ClearFilterButton_Click);
            // 
            // TodaySalesButton
            // 
            this.TodaySalesButton.Font = new System.Drawing.Font("MS UI Gothic", 8F);
            this.TodaySalesButton.Location = new System.Drawing.Point(310, 30);
            this.TodaySalesButton.Name = "TodaySalesButton";
            this.TodaySalesButton.Size = new System.Drawing.Size(59, 30);
            this.TodaySalesButton.TabIndex = 10;
            this.TodaySalesButton.Text = "今日販売";
            this.TodaySalesButton.UseVisualStyleBackColor = true;
            this.TodaySalesButton.Click += new System.EventHandler(this.TodaySalesButton_Click);
            // 
            // SelectProductFilterButton
            // 
            this.SelectProductFilterButton.Font = new System.Drawing.Font("MS UI Gothic", 8F);
            this.SelectProductFilterButton.Location = new System.Drawing.Point(375, 30);
            this.SelectProductFilterButton.Name = "SelectProductFilterButton";
            this.SelectProductFilterButton.Size = new System.Drawing.Size(59, 30);
            this.SelectProductFilterButton.TabIndex = 11;
            this.SelectProductFilterButton.Text = "選択商品";
            this.SelectProductFilterButton.UseVisualStyleBackColor = true;
            this.SelectProductFilterButton.Click += new System.EventHandler(this.SelectProductFilterButton_Click);
            // 
            // DescendingButton
            // 
            this.DescendingButton.Enabled = false;
            this.DescendingButton.Font = new System.Drawing.Font("MS UI Gothic", 8F);
            this.DescendingButton.Location = new System.Drawing.Point(409, 66);
            this.DescendingButton.Name = "DescendingButton";
            this.DescendingButton.Size = new System.Drawing.Size(39, 30);
            this.DescendingButton.TabIndex = 12;
            this.DescendingButton.Text = "降順";
            this.DescendingButton.UseVisualStyleBackColor = true;
            this.DescendingButton.Click += new System.EventHandler(this.DescendingButton_Click);
            // 
            // AscendingButton
            // 
            this.AscendingButton.Font = new System.Drawing.Font("MS UI Gothic", 8F);
            this.AscendingButton.Location = new System.Drawing.Point(364, 66);
            this.AscendingButton.Name = "AscendingButton";
            this.AscendingButton.Size = new System.Drawing.Size(39, 30);
            this.AscendingButton.TabIndex = 13;
            this.AscendingButton.Text = "昇順";
            this.AscendingButton.UseVisualStyleBackColor = true;
            this.AscendingButton.Click += new System.EventHandler(this.AscendingButton_Click);
            // 
            // SortClearButton
            // 
            this.SortClearButton.Enabled = false;
            this.SortClearButton.Font = new System.Drawing.Font("MS UI Gothic", 8F);
            this.SortClearButton.Location = new System.Drawing.Point(454, 66);
            this.SortClearButton.Name = "SortClearButton";
            this.SortClearButton.Size = new System.Drawing.Size(39, 30);
            this.SortClearButton.TabIndex = 14;
            this.SortClearButton.Text = "解除";
            this.SortClearButton.UseVisualStyleBackColor = true;
            this.SortClearButton.Click += new System.EventHandler(this.SortClearButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 418);
            this.Controls.Add(this.SortClearButton);
            this.Controls.Add(this.AscendingButton);
            this.Controls.Add(this.DescendingButton);
            this.Controls.Add(this.SelectProductFilterButton);
            this.Controls.Add(this.TodaySalesButton);
            this.Controls.Add(this.ClearFilterButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.TotalIncomeAmountLabel);
            this.Controls.Add(this.TotaltSalesAmountLabel);
            this.Controls.Add(this.SalesListView);
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
        private System.Windows.Forms.ListView SalesListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label TotaltSalesAmountLabel;
        private System.Windows.Forms.Label TotalIncomeAmountLabel;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button ClearFilterButton;
        private System.Windows.Forms.Button TodaySalesButton;
        private System.Windows.Forms.Button InventoryListButton;
        private System.Windows.Forms.Button SelectProductFilterButton;
        private System.Windows.Forms.ColumnHeader columnHeader;
        private System.Windows.Forms.Button DescendingButton;
        private System.Windows.Forms.Button AscendingButton;
        private System.Windows.Forms.Button SortClearButton;
    }
}

