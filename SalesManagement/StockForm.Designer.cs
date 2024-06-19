namespace WindowsFormsApp1
{
    partial class StockForm
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
            this.StockListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SalesButton = new System.Windows.Forms.Button();
            this.SalesGroup = new System.Windows.Forms.GroupBox();
            this.SalesQuantityTextBox = new System.Windows.Forms.TextBox();
            this.SalesLabel = new System.Windows.Forms.Label();
            this.SalesTimeDateLabel = new System.Windows.Forms.Label();
            this.SalesTimeDateTextBox = new System.Windows.Forms.TextBox();
            this.SalesGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // StockListView
            // 
            this.StockListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.StockListView.HideSelection = false;
            this.StockListView.Location = new System.Drawing.Point(12, 59);
            this.StockListView.Name = "StockListView";
            this.StockListView.Size = new System.Drawing.Size(354, 302);
            this.StockListView.TabIndex = 0;
            this.StockListView.UseCompatibleStateImageBehavior = false;
            this.StockListView.View = System.Windows.Forms.View.Details;
            this.StockListView.SelectedIndexChanged += new System.EventHandler(this.StockListView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "商品名";
            this.columnHeader1.Width = 86;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "仕入日";
            this.columnHeader2.Width = 70;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "仕入価格";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "販売価格";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "在庫数";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "販売状況";
            // 
            // CloseButton
            // 
            this.CloseButton.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.CloseButton.Location = new System.Drawing.Point(276, 462);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(90, 32);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.Text = "閉じる";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // SalesButton
            // 
            this.SalesButton.Enabled = false;
            this.SalesButton.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.SalesButton.Location = new System.Drawing.Point(80, 94);
            this.SalesButton.Name = "SalesButton";
            this.SalesButton.Size = new System.Drawing.Size(90, 32);
            this.SalesButton.TabIndex = 3;
            this.SalesButton.Text = "販売する";
            this.SalesButton.UseVisualStyleBackColor = true;
            this.SalesButton.Click += new System.EventHandler(this.SalesButton_Click);
            // 
            // SalesGroup
            // 
            this.SalesGroup.Controls.Add(this.SalesTimeDateTextBox);
            this.SalesGroup.Controls.Add(this.SalesTimeDateLabel);
            this.SalesGroup.Controls.Add(this.SalesQuantityTextBox);
            this.SalesGroup.Controls.Add(this.SalesLabel);
            this.SalesGroup.Controls.Add(this.SalesButton);
            this.SalesGroup.Enabled = false;
            this.SalesGroup.Location = new System.Drawing.Point(12, 368);
            this.SalesGroup.Name = "SalesGroup";
            this.SalesGroup.Size = new System.Drawing.Size(182, 132);
            this.SalesGroup.TabIndex = 4;
            this.SalesGroup.TabStop = false;
            this.SalesGroup.Text = "販売処理";
            // 
            // SalesQuantityTextBox
            // 
            this.SalesQuantityTextBox.Enabled = false;
            this.SalesQuantityTextBox.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.SalesQuantityTextBox.Location = new System.Drawing.Point(70, 36);
            this.SalesQuantityTextBox.Name = "SalesQuantityTextBox";
            this.SalesQuantityTextBox.Size = new System.Drawing.Size(100, 21);
            this.SalesQuantityTextBox.TabIndex = 5;
            this.SalesQuantityTextBox.TextChanged += new System.EventHandler(this.SalesQuantityTextBox_TextChanged);
            this.SalesQuantityTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SalesQuantityTextBox_KeyPress);
            // 
            // SalesLabel
            // 
            this.SalesLabel.AutoSize = true;
            this.SalesLabel.Enabled = false;
            this.SalesLabel.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.SalesLabel.Location = new System.Drawing.Point(6, 39);
            this.SalesLabel.Name = "SalesLabel";
            this.SalesLabel.Size = new System.Drawing.Size(49, 14);
            this.SalesLabel.TabIndex = 4;
            this.SalesLabel.Text = "販売数";
            // 
            // SalesTimeDateLabel
            // 
            this.SalesTimeDateLabel.AutoSize = true;
            this.SalesTimeDateLabel.Enabled = false;
            this.SalesTimeDateLabel.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.SalesTimeDateLabel.Location = new System.Drawing.Point(6, 68);
            this.SalesTimeDateLabel.Name = "SalesTimeDateLabel";
            this.SalesTimeDateLabel.Size = new System.Drawing.Size(49, 14);
            this.SalesTimeDateLabel.TabIndex = 6;
            this.SalesTimeDateLabel.Text = "販売日";
            // 
            // SalesTimeDateTextBox
            // 
            this.SalesTimeDateTextBox.Enabled = false;
            this.SalesTimeDateTextBox.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.SalesTimeDateTextBox.Location = new System.Drawing.Point(70, 65);
            this.SalesTimeDateTextBox.Name = "SalesTimeDateTextBox";
            this.SalesTimeDateTextBox.Size = new System.Drawing.Size(100, 21);
            this.SalesTimeDateTextBox.TabIndex = 7;
            // 
            // StockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 512);
            this.Controls.Add(this.SalesGroup);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StockListView);
            this.Name = "StockForm";
            this.Text = "在庫一覧";
            this.Load += new System.EventHandler(this.StockForm_Load);
            this.SalesGroup.ResumeLayout(false);
            this.SalesGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CloseButton;
        public System.Windows.Forms.ListView StockListView;
        private System.Windows.Forms.Button SalesButton;
        private System.Windows.Forms.GroupBox SalesGroup;
        private System.Windows.Forms.TextBox SalesQuantityTextBox;
        private System.Windows.Forms.Label SalesLabel;
        private System.Windows.Forms.TextBox SalesTimeDateTextBox;
        private System.Windows.Forms.Label SalesTimeDateLabel;
    }
}

