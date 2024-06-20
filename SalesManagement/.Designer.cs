﻿namespace SalesManagement
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
            this.SalesProcessingButton.Click += new System.EventHandler(this.SalesProcessingButton_Click);
            // 
            // PurchaseProcessingButton
            // 
            this.PurchaseProcessingButton.Location = new System.Drawing.Point(108, 46);
            this.PurchaseProcessingButton.Name = "PurchaseProcessingButton";
            this.PurchaseProcessingButton.Size = new System.Drawing.Size(90, 30);
            this.PurchaseProcessingButton.TabIndex = 1;
            this.PurchaseProcessingButton.Text = "仕入処理";
            this.PurchaseProcessingButton.UseVisualStyleBackColor = true;
            this.PurchaseProcessingButton.Click += new System.EventHandler(this.PurchaseProcessingButton_Click);
            // 
            // InventoryListButton
            // 
            this.InventoryListButton.Location = new System.Drawing.Point(204, 46);
            this.InventoryListButton.Name = "InventoryListButton";
            this.InventoryListButton.Size = new System.Drawing.Size(90, 30);
            this.InventoryListButton.TabIndex = 2;
            this.InventoryListButton.Text = "在庫一覧";
            this.InventoryListButton.UseVisualStyleBackColor = true;
            this.InventoryListButton.Click += new System.EventHandler(this.InventoryListButton_Click);
            // 
            // SalesListView
            // 
            this.SalesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.SalesListView.HideSelection = false;
            this.SalesListView.Location = new System.Drawing.Point(12, 102);
            this.SalesListView.Name = "SalesListView";
            this.SalesListView.Size = new System.Drawing.Size(453, 247);
            this.SalesListView.TabIndex = 3;
            this.SalesListView.UseCompatibleStateImageBehavior = false;
            this.SalesListView.View = System.Windows.Forms.View.Details;
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
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ClearFilterButton
            // 
            this.ClearFilterButton.Enabled = false;
            this.ClearFilterButton.Font = new System.Drawing.Font("MS UI Gothic", 8F);
            this.ClearFilterButton.Location = new System.Drawing.Point(406, 46);
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
            this.TodaySalesButton.Location = new System.Drawing.Point(341, 46);
            this.TodaySalesButton.Name = "TodaySalesButton";
            this.TodaySalesButton.Size = new System.Drawing.Size(59, 30);
            this.TodaySalesButton.TabIndex = 10;
            this.TodaySalesButton.Text = "今日販売";
            this.TodaySalesButton.UseVisualStyleBackColor = true;
            this.TodaySalesButton.Click += new System.EventHandler(this.TodaySalesButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 418);
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
            this.Load += new System.EventHandler(this.MainForm_Load);
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
    }
}

