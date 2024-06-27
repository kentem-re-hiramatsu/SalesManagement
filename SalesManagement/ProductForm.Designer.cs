namespace SalesManagement
{
    partial class ProductForm
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
            this.ProductNameTextBox = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.ProductAddButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProductNameTextBox
            // 
            this.ProductNameTextBox.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.ProductNameTextBox.Location = new System.Drawing.Point(15, 63);
            this.ProductNameTextBox.Name = "ProductNameTextBox";
            this.ProductNameTextBox.Size = new System.Drawing.Size(163, 21);
            this.ProductNameTextBox.TabIndex = 0;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.label.Location = new System.Drawing.Point(12, 46);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(49, 14);
            this.label.TabIndex = 1;
            this.label.Text = "商品名";
            // 
            // ProductAddButton
            // 
            this.ProductAddButton.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.ProductAddButton.Location = new System.Drawing.Point(103, 104);
            this.ProductAddButton.Name = "ProductAddButton";
            this.ProductAddButton.Size = new System.Drawing.Size(75, 23);
            this.ProductAddButton.TabIndex = 2;
            this.ProductAddButton.Text = "登録";
            this.ProductAddButton.UseVisualStyleBackColor = true;
            this.ProductAddButton.Click += new System.EventHandler(this.ProductAddButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.CloseButton.Location = new System.Drawing.Point(103, 133);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.Text = "閉じる";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(190, 168);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.ProductAddButton);
            this.Controls.Add(this.label);
            this.Controls.Add(this.ProductNameTextBox);
            this.Name = "ProductForm";
            this.Text = "商品登録";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ProductNameTextBox;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button ProductAddButton;
        private System.Windows.Forms.Button CloseButton;
    }
}

