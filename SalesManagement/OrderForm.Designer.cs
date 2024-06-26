﻿namespace SalesManagement
{
    partial class OrderForm
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
            this.PuchaseOrderGroup = new System.Windows.Forms.GroupBox();
            this.ProductNameComboBox = new System.Windows.Forms.ComboBox();
            this.SalesDateTime = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.SalesPriceTextBox = new System.Windows.Forms.TextBox();
            this.PurchasePriceTextBox = new System.Windows.Forms.TextBox();
            this.PurchaseQuantityTextBox = new System.Windows.Forms.TextBox();
            this.SalesPriceLabel = new System.Windows.Forms.Label();
            this.PurchasePriceLabel = new System.Windows.Forms.Label();
            this.PurchaseQuantityLabel = new System.Windows.Forms.Label();
            this.ProductLabel = new System.Windows.Forms.Label();
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.PuchaseOrderGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // PuchaseOrderGroup
            // 
            this.PuchaseOrderGroup.Controls.Add(this.ProductNameComboBox);
            this.PuchaseOrderGroup.Controls.Add(this.SalesDateTime);
            this.PuchaseOrderGroup.Controls.Add(this.label1);
            this.PuchaseOrderGroup.Controls.Add(this.SalesPriceTextBox);
            this.PuchaseOrderGroup.Controls.Add(this.PurchasePriceTextBox);
            this.PuchaseOrderGroup.Controls.Add(this.PurchaseQuantityTextBox);
            this.PuchaseOrderGroup.Controls.Add(this.SalesPriceLabel);
            this.PuchaseOrderGroup.Controls.Add(this.PurchasePriceLabel);
            this.PuchaseOrderGroup.Controls.Add(this.PurchaseQuantityLabel);
            this.PuchaseOrderGroup.Controls.Add(this.ProductLabel);
            this.PuchaseOrderGroup.Location = new System.Drawing.Point(12, 37);
            this.PuchaseOrderGroup.Name = "PuchaseOrderGroup";
            this.PuchaseOrderGroup.Size = new System.Drawing.Size(284, 173);
            this.PuchaseOrderGroup.TabIndex = 0;
            this.PuchaseOrderGroup.TabStop = false;
            this.PuchaseOrderGroup.Text = "仕入処理";
            // 
            // ProductNameComboBox
            // 
            this.ProductNameComboBox.FormattingEnabled = true;
            this.ProductNameComboBox.Location = new System.Drawing.Point(126, 25);
            this.ProductNameComboBox.Name = "ProductNameComboBox";
            this.ProductNameComboBox.Size = new System.Drawing.Size(117, 20);
            this.ProductNameComboBox.TabIndex = 12;
            this.ProductNameComboBox.SelectionChangeCommitted += new System.EventHandler(this.ProductTextBox_TextChanged);
            // 
            // SalesDateTime
            // 
            this.SalesDateTime.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.SalesDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.SalesDateTime.Location = new System.Drawing.Point(126, 51);
            this.SalesDateTime.Name = "SalesDateTime";
            this.SalesDateTime.Size = new System.Drawing.Size(117, 21);
            this.SalesDateTime.TabIndex = 12;
            this.SalesDateTime.Value = new System.DateTime(2024, 6, 25, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.label1.Location = new System.Drawing.Point(16, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 14);
            this.label1.TabIndex = 8;
            this.label1.Text = "仕入日";
            // 
            // SalesPriceTextBox
            // 
            this.SalesPriceTextBox.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.SalesPriceTextBox.Location = new System.Drawing.Point(126, 132);
            this.SalesPriceTextBox.Name = "SalesPriceTextBox";
            this.SalesPriceTextBox.Size = new System.Drawing.Size(117, 21);
            this.SalesPriceTextBox.TabIndex = 7;
            this.SalesPriceTextBox.TextChanged += new System.EventHandler(this.ProductTextBox_TextChanged);
            this.SalesPriceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PurchaseQuantityTextBox_KeyPress);
            // 
            // PurchasePriceTextBox
            // 
            this.PurchasePriceTextBox.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.PurchasePriceTextBox.Location = new System.Drawing.Point(126, 105);
            this.PurchasePriceTextBox.Name = "PurchasePriceTextBox";
            this.PurchasePriceTextBox.Size = new System.Drawing.Size(117, 21);
            this.PurchasePriceTextBox.TabIndex = 6;
            this.PurchasePriceTextBox.TextChanged += new System.EventHandler(this.ProductTextBox_TextChanged);
            this.PurchasePriceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PurchaseQuantityTextBox_KeyPress);
            // 
            // PurchaseQuantityTextBox
            // 
            this.PurchaseQuantityTextBox.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.PurchaseQuantityTextBox.Location = new System.Drawing.Point(126, 78);
            this.PurchaseQuantityTextBox.Name = "PurchaseQuantityTextBox";
            this.PurchaseQuantityTextBox.Size = new System.Drawing.Size(117, 21);
            this.PurchaseQuantityTextBox.TabIndex = 5;
            this.PurchaseQuantityTextBox.TextChanged += new System.EventHandler(this.ProductTextBox_TextChanged);
            this.PurchaseQuantityTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PurchaseQuantityTextBox_KeyPress);
            // 
            // SalesPriceLabel
            // 
            this.SalesPriceLabel.AutoSize = true;
            this.SalesPriceLabel.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.SalesPriceLabel.Location = new System.Drawing.Point(16, 139);
            this.SalesPriceLabel.Name = "SalesPriceLabel";
            this.SalesPriceLabel.Size = new System.Drawing.Size(63, 14);
            this.SalesPriceLabel.TabIndex = 3;
            this.SalesPriceLabel.Text = "販売価格";
            // 
            // PurchasePriceLabel
            // 
            this.PurchasePriceLabel.AutoSize = true;
            this.PurchasePriceLabel.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.PurchasePriceLabel.Location = new System.Drawing.Point(16, 108);
            this.PurchasePriceLabel.Name = "PurchasePriceLabel";
            this.PurchasePriceLabel.Size = new System.Drawing.Size(63, 14);
            this.PurchasePriceLabel.TabIndex = 2;
            this.PurchasePriceLabel.Text = "仕入価格";
            // 
            // PurchaseQuantityLabel
            // 
            this.PurchaseQuantityLabel.AutoSize = true;
            this.PurchaseQuantityLabel.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.PurchaseQuantityLabel.Location = new System.Drawing.Point(16, 81);
            this.PurchaseQuantityLabel.Name = "PurchaseQuantityLabel";
            this.PurchaseQuantityLabel.Size = new System.Drawing.Size(49, 14);
            this.PurchaseQuantityLabel.TabIndex = 1;
            this.PurchaseQuantityLabel.Text = "仕入数";
            // 
            // ProductLabel
            // 
            this.ProductLabel.AutoSize = true;
            this.ProductLabel.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.ProductLabel.Location = new System.Drawing.Point(16, 27);
            this.ProductLabel.Name = "ProductLabel";
            this.ProductLabel.Size = new System.Drawing.Size(49, 14);
            this.ProductLabel.TabIndex = 0;
            this.ProductLabel.Text = "商品名";
            // 
            // OkButton
            // 
            this.OkButton.Enabled = false;
            this.OkButton.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.OkButton.Location = new System.Drawing.Point(120, 227);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(85, 28);
            this.OkButton.TabIndex = 10;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.CancelButton.Location = new System.Drawing.Point(211, 227);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(85, 28);
            this.CancelButton.TabIndex = 11;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 273);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.PuchaseOrderGroup);
            this.Name = "OrderForm";
            this.Text = "仕入処理";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.PuchaseOrderGroup.ResumeLayout(false);
            this.PuchaseOrderGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox PuchaseOrderGroup;
        private System.Windows.Forms.TextBox PurchasePriceTextBox;
        private System.Windows.Forms.TextBox PurchaseQuantityTextBox;
        private System.Windows.Forms.Label SalesPriceLabel;
        private System.Windows.Forms.Label PurchasePriceLabel;
        private System.Windows.Forms.Label PurchaseQuantityLabel;
        private System.Windows.Forms.Label ProductLabel;
        private System.Windows.Forms.TextBox SalesPriceTextBox;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker SalesDateTime;
        private System.Windows.Forms.ComboBox ProductNameComboBox;
    }
}

