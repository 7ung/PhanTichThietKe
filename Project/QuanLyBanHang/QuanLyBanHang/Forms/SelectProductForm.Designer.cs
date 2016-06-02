namespace QuanLyBanHang.Forms
{
    partial class SelectProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.currentCountComboBox = new System.Windows.Forms.ComboBox();
            this.pRODUCTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sellManagementDbDataSet = new QuanLyBanHang.SellManagementDbDataSet();
            this.iNVENTORYCAPABILITYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.productPriceText = new System.Windows.Forms.TextBox();
            this.productQuantityText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.productNameText = new System.Windows.Forms.TextBox();
            this.productIdText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.searchText = new System.Windows.Forms.TextBox();
            this.productDataGridView = new System.Windows.Forms.DataGridView();
            this.ProductKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.pRODUCTTableAdapter = new QuanLyBanHang.SellManagementDbDataSetTableAdapters.PRODUCTTableAdapter();
            this.iNVENTORY_CAPABILITYTableAdapter = new QuanLyBanHang.SellManagementDbDataSetTableAdapters.INVENTORY_CAPABILITYTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellManagementDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVENTORYCAPABILITYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.currentCountComboBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.productPriceText);
            this.groupBox1.Controls.Add(this.productQuantityText);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.productNameText);
            this.groupBox1.Controls.Add(this.productIdText);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 245);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 175);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sản phẩm";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(355, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "VNĐ";
            // 
            // currentCountComboBox
            // 
            this.currentCountComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.pRODUCTBindingSource, "Id", true));
            this.currentCountComboBox.DataSource = this.iNVENTORYCAPABILITYBindingSource;
            this.currentCountComboBox.DisplayMember = "CurrentCount";
            this.currentCountComboBox.Enabled = false;
            this.currentCountComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentCountComboBox.FormattingEnabled = true;
            this.currentCountComboBox.Location = new System.Drawing.Point(391, 60);
            this.currentCountComboBox.Name = "currentCountComboBox";
            this.currentCountComboBox.Size = new System.Drawing.Size(103, 28);
            this.currentCountComboBox.TabIndex = 17;
            this.currentCountComboBox.ValueMember = "Product_id";
            // 
            // pRODUCTBindingSource
            // 
            this.pRODUCTBindingSource.DataMember = "PRODUCT";
            this.pRODUCTBindingSource.DataSource = this.sellManagementDbDataSet;
            // 
            // sellManagementDbDataSet
            // 
            this.sellManagementDbDataSet.DataSetName = "SellManagementDbDataSet";
            this.sellManagementDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iNVENTORYCAPABILITYBindingSource
            // 
            this.iNVENTORYCAPABILITYBindingSource.DataMember = "INVENTORY_CAPABILITY";
            this.iNVENTORYCAPABILITYBindingSource.DataSource = this.sellManagementDbDataSet;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(163, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Giá bán";
            // 
            // productPriceText
            // 
            this.productPriceText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productPriceText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRODUCTBindingSource, "OutPrice", true));
            this.productPriceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productPriceText.Location = new System.Drawing.Point(166, 114);
            this.productPriceText.Name = "productPriceText";
            this.productPriceText.ReadOnly = true;
            this.productPriceText.Size = new System.Drawing.Size(184, 26);
            this.productPriceText.TabIndex = 14;
            // 
            // productQuantityText
            // 
            this.productQuantityText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.productQuantityText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productQuantityText.Location = new System.Drawing.Point(391, 114);
            this.productQuantityText.Name = "productQuantityText";
            this.productQuantityText.Size = new System.Drawing.Size(103, 26);
            this.productQuantityText.TabIndex = 13;
            this.productQuantityText.Text = "1";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(388, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Số lượng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(163, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tên";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(388, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Hiện tồn";
            // 
            // productNameText
            // 
            this.productNameText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productNameText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRODUCTBindingSource, "Name", true));
            this.productNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productNameText.Location = new System.Drawing.Point(166, 60);
            this.productNameText.Name = "productNameText";
            this.productNameText.ReadOnly = true;
            this.productNameText.Size = new System.Drawing.Size(219, 26);
            this.productNameText.TabIndex = 8;
            // 
            // productIdText
            // 
            this.productIdText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productIdText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRODUCTBindingSource, "ProductKey", true));
            this.productIdText.Location = new System.Drawing.Point(218, 19);
            this.productIdText.Name = "productIdText";
            this.productIdText.ReadOnly = true;
            this.productIdText.Size = new System.Drawing.Size(276, 20);
            this.productIdText.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã hàng";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyBanHang.Properties.Resources.Product;
            this.pictureBox1.Location = new System.Drawing.Point(6, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.searchText);
            this.groupBox2.Controls.Add(this.productDataGridView);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(500, 227);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tìm kiếm";
            // 
            // searchText
            // 
            this.searchText.Location = new System.Drawing.Point(61, 19);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(200, 20);
            this.searchText.TabIndex = 1;
            this.searchText.TextChanged += new System.EventHandler(this.searchText_TextChanged);
            // 
            // productDataGridView
            // 
            this.productDataGridView.AllowUserToAddRows = false;
            this.productDataGridView.AllowUserToDeleteRows = false;
            this.productDataGridView.AllowUserToResizeRows = false;
            this.productDataGridView.AutoGenerateColumns = false;
            this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductKey,
            this.nameColumn,
            this.outPriceColumn});
            this.productDataGridView.DataSource = this.pRODUCTBindingSource;
            this.productDataGridView.Location = new System.Drawing.Point(6, 46);
            this.productDataGridView.Name = "productDataGridView";
            this.productDataGridView.ReadOnly = true;
            this.productDataGridView.RowHeadersVisible = false;
            this.productDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productDataGridView.Size = new System.Drawing.Size(488, 175);
            this.productDataGridView.TabIndex = 0;
            // 
            // ProductKey
            // 
            this.ProductKey.DataPropertyName = "ProductKey";
            this.ProductKey.HeaderText = "Mã sản phẩm";
            this.ProductKey.Name = "ProductKey";
            this.ProductKey.ReadOnly = true;
            // 
            // nameColumn
            // 
            this.nameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameColumn.DataPropertyName = "Name";
            this.nameColumn.HeaderText = "Tên";
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.ReadOnly = true;
            // 
            // outPriceColumn
            // 
            this.outPriceColumn.DataPropertyName = "OutPrice";
            this.outPriceColumn.HeaderText = "Giá bán";
            this.outPriceColumn.Name = "outPriceColumn";
            this.outPriceColumn.ReadOnly = true;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(287, 426);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 7;
            this.addBtn.Text = "Thêm";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(178, 426);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 8;
            this.cancelBtn.Text = "Hủy";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // pRODUCTTableAdapter
            // 
            this.pRODUCTTableAdapter.ClearBeforeFill = true;
            // 
            // iNVENTORY_CAPABILITYTableAdapter
            // 
            this.iNVENTORY_CAPABILITYTableAdapter.ClearBeforeFill = true;
            // 
            // SelectProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 461);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(545, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(545, 500);
            this.Name = "SelectProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chọn sản phẩm";
            this.Load += new System.EventHandler(this.SelectProductForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellManagementDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVENTORYCAPABILITYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox productPriceText;
        private System.Windows.Forms.TextBox productQuantityText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox productNameText;
        private System.Windows.Forms.TextBox productIdText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.DataGridView productDataGridView;
        private SellManagementDbDataSet sellManagementDbDataSet;
        private System.Windows.Forms.BindingSource pRODUCTBindingSource;
        private SellManagementDbDataSetTableAdapters.PRODUCTTableAdapter pRODUCTTableAdapter;
        private System.Windows.Forms.BindingSource iNVENTORYCAPABILITYBindingSource;
        private SellManagementDbDataSetTableAdapters.INVENTORY_CAPABILITYTableAdapter iNVENTORY_CAPABILITYTableAdapter;
        private System.Windows.Forms.ComboBox currentCountComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.DataGridViewTextBoxColumn outPriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductKey;
    }
}