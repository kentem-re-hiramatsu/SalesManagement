namespace WindowsFormsApp1
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
            this.SalesPriceTextBox = new System.Windows.Forms.TextBox();
            this.PurchasePriceTextBox = new System.Windows.Forms.TextBox();
            this.PurchaseQuantityTextBox = new System.Windows.Forms.TextBox();
            this.ProductTextBox = new System.Windows.Forms.TextBox();
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
            this.PuchaseOrderGroup.Controls.Add(this.SalesPriceTextBox);
            this.PuchaseOrderGroup.Controls.Add(this.PurchasePriceTextBox);
            this.PuchaseOrderGroup.Controls.Add(this.PurchaseQuantityTextBox);
            this.PuchaseOrderGroup.Controls.Add(this.ProductTextBox);
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
            // SalesPriceTextBox
            // 
            this.SalesPriceTextBox.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.SalesPriceTextBox.Location = new System.Drawing.Point(126, 136);
            this.SalesPriceTextBox.Name = "SalesPriceTextBox";
            this.SalesPriceTextBox.Size = new System.Drawing.Size(117, 21);
            this.SalesPriceTextBox.TabIndex = 7;
            this.SalesPriceTextBox.TextChanged += new System.EventHandler(this.ProductTextBox_TextChanged);
            this.SalesPriceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PurchaseQuantityTextBox_KeyPress);
            // 
            // PurchasePriceTextBox
            // 
            this.PurchasePriceTextBox.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.PurchasePriceTextBox.Location = new System.Drawing.Point(126, 100);
            this.PurchasePriceTextBox.Name = "PurchasePriceTextBox";
            this.PurchasePriceTextBox.Size = new System.Drawing.Size(117, 21);
            this.PurchasePriceTextBox.TabIndex = 6;
            this.PurchasePriceTextBox.TextChanged += new System.EventHandler(this.ProductTextBox_TextChanged);
            this.PurchasePriceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PurchaseQuantityTextBox_KeyPress);
            // 
            // PurchaseQuantityTextBox
            // 
            this.PurchaseQuantityTextBox.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.PurchaseQuantityTextBox.Location = new System.Drawing.Point(126, 61);
            this.PurchaseQuantityTextBox.Name = "PurchaseQuantityTextBox";
            this.PurchaseQuantityTextBox.Size = new System.Drawing.Size(117, 21);
            this.PurchaseQuantityTextBox.TabIndex = 5;
            this.PurchaseQuantityTextBox.TextChanged += new System.EventHandler(this.ProductTextBox_TextChanged);
            this.PurchaseQuantityTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PurchaseQuantityTextBox_KeyPress);
            // 
            // ProductTextBox
            // 
            this.ProductTextBox.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.ProductTextBox.Location = new System.Drawing.Point(126, 24);
            this.ProductTextBox.Name = "ProductTextBox";
            this.ProductTextBox.Size = new System.Drawing.Size(117, 21);
            this.ProductTextBox.TabIndex = 4;
            this.ProductTextBox.TextChanged += new System.EventHandler(this.ProductTextBox_TextChanged);
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
            this.PurchasePriceLabel.Location = new System.Drawing.Point(16, 103);
            this.PurchasePriceLabel.Name = "PurchasePriceLabel";
            this.PurchasePriceLabel.Size = new System.Drawing.Size(63, 14);
            this.PurchasePriceLabel.TabIndex = 2;
            this.PurchasePriceLabel.Text = "仕入価格";
            // 
            // PurchaseQuantityLabel
            // 
            this.PurchaseQuantityLabel.AutoSize = true;
            this.PurchaseQuantityLabel.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.PurchaseQuantityLabel.Location = new System.Drawing.Point(16, 64);
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
            this.ClientSize = new System.Drawing.Size(308, 270);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.PuchaseOrderGroup);
            this.Name = "OrderForm";
            this.Text = "仕入処理";
            this.PuchaseOrderGroup.ResumeLayout(false);
            this.PuchaseOrderGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox PuchaseOrderGroup;
        private System.Windows.Forms.TextBox PurchasePriceTextBox;
        private System.Windows.Forms.TextBox PurchaseQuantityTextBox;
        private System.Windows.Forms.TextBox ProductTextBox;
        private System.Windows.Forms.Label SalesPriceLabel;
        private System.Windows.Forms.Label PurchasePriceLabel;
        private System.Windows.Forms.Label PurchaseQuantityLabel;
        private System.Windows.Forms.Label ProductLabel;
        private System.Windows.Forms.TextBox SalesPriceTextBox;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelButton;
    }
}

