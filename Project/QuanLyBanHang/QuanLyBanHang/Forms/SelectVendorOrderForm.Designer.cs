namespace QuanLyBanHang.Forms
{
    partial class SelectVendorOrderForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.searchText = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.statusColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.keyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendoridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.vENDORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sellManagementDbDataSet = new QuanLyBanHang.SellManagementDbDataSet();
            this.createDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendorOrderViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendor_Order_ViewTableAdapter = new QuanLyBanHang.SellManagementDbDataSetTableAdapters.Vendor_Order_ViewTableAdapter();
            this.vENDORTableAdapter = new QuanLyBanHang.SellManagementDbDataSetTableAdapters.VENDORTableAdapter();
            this.selectBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENDORBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellManagementDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorOrderViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tìm kiếm";
            // 
            // searchText
            // 
            this.searchText.Location = new System.Drawing.Point(75, 17);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(150, 20);
            this.searchText.TabIndex = 5;
            this.searchText.TextChanged += new System.EventHandler(this.searchText_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.statusColumn,
            this.keyColumn,
            this.vendoridDataGridViewTextBoxColumn,
            this.createDateDataGridViewTextBoxColumn,
            this.finalPriceDataGridViewTextBoxColumn,
            this.idColumn});
            this.dataGridView1.DataSource = this.vendorOrderViewBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(23, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(540, 150);
            this.dataGridView1.TabIndex = 7;
            // 
            // statusColumn
            // 
            this.statusColumn.DataPropertyName = "Status";
            this.statusColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.statusColumn.HeaderText = "Trạng thái";
            this.statusColumn.Name = "statusColumn";
            this.statusColumn.ReadOnly = true;
            this.statusColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.statusColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // keyColumn
            // 
            this.keyColumn.DataPropertyName = "DocumentKey";
            this.keyColumn.HeaderText = "Mã hóa đơn";
            this.keyColumn.Name = "keyColumn";
            this.keyColumn.ReadOnly = true;
            // 
            // vendoridDataGridViewTextBoxColumn
            // 
            this.vendoridDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.vendoridDataGridViewTextBoxColumn.DataPropertyName = "Vendor_id";
            this.vendoridDataGridViewTextBoxColumn.DataSource = this.vENDORBindingSource;
            this.vendoridDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.vendoridDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.vendoridDataGridViewTextBoxColumn.HeaderText = "Nhà cung cấp";
            this.vendoridDataGridViewTextBoxColumn.Name = "vendoridDataGridViewTextBoxColumn";
            this.vendoridDataGridViewTextBoxColumn.ReadOnly = true;
            this.vendoridDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.vendoridDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.vendoridDataGridViewTextBoxColumn.ValueMember = "Id";
            // 
            // vENDORBindingSource
            // 
            this.vENDORBindingSource.DataMember = "VENDOR";
            this.vENDORBindingSource.DataSource = this.sellManagementDbDataSet;
            // 
            // sellManagementDbDataSet
            // 
            this.sellManagementDbDataSet.DataSetName = "SellManagementDbDataSet";
            this.sellManagementDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // createDateDataGridViewTextBoxColumn
            // 
            this.createDateDataGridViewTextBoxColumn.DataPropertyName = "CreateDate";
            this.createDateDataGridViewTextBoxColumn.HeaderText = "Ngày lập";
            this.createDateDataGridViewTextBoxColumn.Name = "createDateDataGridViewTextBoxColumn";
            this.createDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // finalPriceDataGridViewTextBoxColumn
            // 
            this.finalPriceDataGridViewTextBoxColumn.DataPropertyName = "FinalPrice";
            this.finalPriceDataGridViewTextBoxColumn.HeaderText = "Tổng hóa đơn";
            this.finalPriceDataGridViewTextBoxColumn.Name = "finalPriceDataGridViewTextBoxColumn";
            this.finalPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idColumn
            // 
            this.idColumn.DataPropertyName = "Id";
            this.idColumn.HeaderText = "Id";
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            this.idColumn.Visible = false;
            // 
            // vendorOrderViewBindingSource
            // 
            this.vendorOrderViewBindingSource.DataMember = "Vendor_Order_View";
            this.vendorOrderViewBindingSource.DataSource = this.sellManagementDbDataSet;
            // 
            // vendor_Order_ViewTableAdapter
            // 
            this.vendor_Order_ViewTableAdapter.ClearBeforeFill = true;
            // 
            // vENDORTableAdapter
            // 
            this.vENDORTableAdapter.ClearBeforeFill = true;
            // 
            // selectBtn
            // 
            this.selectBtn.Location = new System.Drawing.Point(305, 215);
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Size = new System.Drawing.Size(75, 23);
            this.selectBtn.TabIndex = 9;
            this.selectBtn.Text = "Chọn";
            this.selectBtn.UseVisualStyleBackColor = true;
            this.selectBtn.Click += new System.EventHandler(this.selectBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(187, 215);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 8;
            this.cancelBtn.Text = "Hủy";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // SelectVendorOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.selectBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchText);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 300);
            this.Name = "SelectVendorOrderForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Danh sách đơn hàng Nhà cung cấp";
            this.Load += new System.EventHandler(this.SelectVendorOrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENDORBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellManagementDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorOrderViewBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SellManagementDbDataSet sellManagementDbDataSet;
        private System.Windows.Forms.BindingSource vendorOrderViewBindingSource;
        private SellManagementDbDataSetTableAdapters.Vendor_Order_ViewTableAdapter vendor_Order_ViewTableAdapter;
        private System.Windows.Forms.BindingSource vENDORBindingSource;
        private SellManagementDbDataSetTableAdapters.VENDORTableAdapter vENDORTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn vendoridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn keyColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn statusColumn;
        private System.Windows.Forms.Button selectBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}