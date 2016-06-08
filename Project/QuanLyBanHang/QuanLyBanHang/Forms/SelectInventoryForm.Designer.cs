namespace QuanLyBanHang.Forms
{
    partial class SelectInventoryForm
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
            this.selectBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.billDataGridView = new System.Windows.Forms.DataGridView();
            this.inventoryKeyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.termDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNVENTORYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sellManagementDbDataSet = new QuanLyBanHang.SellManagementDbDataSet();
            this.iNVENTORYTableAdapter = new QuanLyBanHang.SellManagementDbDataSetTableAdapters.INVENTORYTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.billDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVENTORYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellManagementDbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tìm kiếm";
            // 
            // searchText
            // 
            this.searchText.Location = new System.Drawing.Point(67, 12);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(150, 20);
            this.searchText.TabIndex = 8;
            // 
            // selectBtn
            // 
            this.selectBtn.Location = new System.Drawing.Point(314, 256);
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Size = new System.Drawing.Size(75, 23);
            this.selectBtn.TabIndex = 7;
            this.selectBtn.Text = "Chọn";
            this.selectBtn.UseVisualStyleBackColor = true;
            this.selectBtn.Click += new System.EventHandler(this.selectBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(196, 256);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 6;
            this.cancelBtn.Text = "Hủy";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // billDataGridView
            // 
            this.billDataGridView.AllowUserToAddRows = false;
            this.billDataGridView.AllowUserToDeleteRows = false;
            this.billDataGridView.AllowUserToResizeRows = false;
            this.billDataGridView.AutoGenerateColumns = false;
            this.billDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.billDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.inventoryKeyDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.rentPriceDataGridViewTextBoxColumn,
            this.termDataGridViewTextBoxColumn});
            this.billDataGridView.DataSource = this.iNVENTORYBindingSource;
            this.billDataGridView.Location = new System.Drawing.Point(12, 44);
            this.billDataGridView.Name = "billDataGridView";
            this.billDataGridView.ReadOnly = true;
            this.billDataGridView.RowHeadersVisible = false;
            this.billDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.billDataGridView.Size = new System.Drawing.Size(560, 193);
            this.billDataGridView.TabIndex = 5;
            // 
            // inventoryKeyDataGridViewTextBoxColumn
            // 
            this.inventoryKeyDataGridViewTextBoxColumn.DataPropertyName = "InventoryKey";
            this.inventoryKeyDataGridViewTextBoxColumn.HeaderText = "Mã kho";
            this.inventoryKeyDataGridViewTextBoxColumn.Name = "inventoryKeyDataGridViewTextBoxColumn";
            this.inventoryKeyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Tên";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rentPriceDataGridViewTextBoxColumn
            // 
            this.rentPriceDataGridViewTextBoxColumn.DataPropertyName = "RentPrice";
            this.rentPriceDataGridViewTextBoxColumn.HeaderText = "Giá thuê";
            this.rentPriceDataGridViewTextBoxColumn.Name = "rentPriceDataGridViewTextBoxColumn";
            this.rentPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // termDataGridViewTextBoxColumn
            // 
            this.termDataGridViewTextBoxColumn.DataPropertyName = "Term";
            this.termDataGridViewTextBoxColumn.HeaderText = "Kỳ";
            this.termDataGridViewTextBoxColumn.Name = "termDataGridViewTextBoxColumn";
            this.termDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iNVENTORYBindingSource
            // 
            this.iNVENTORYBindingSource.DataMember = "INVENTORY";
            this.iNVENTORYBindingSource.DataSource = this.sellManagementDbDataSet;
            // 
            // sellManagementDbDataSet
            // 
            this.sellManagementDbDataSet.DataSetName = "SellManagementDbDataSet";
            this.sellManagementDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iNVENTORYTableAdapter
            // 
            this.iNVENTORYTableAdapter.ClearBeforeFill = true;
            // 
            // SelectInventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 291);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchText);
            this.Controls.Add(this.selectBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.billDataGridView);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 330);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 330);
            this.Name = "SelectInventoryForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Danh sách kho hàng";
            this.Load += new System.EventHandler(this.SelectInventoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.billDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVENTORYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellManagementDbDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.Button selectBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.DataGridView billDataGridView;
        private SellManagementDbDataSet sellManagementDbDataSet;
        private System.Windows.Forms.BindingSource iNVENTORYBindingSource;
        private SellManagementDbDataSetTableAdapters.INVENTORYTableAdapter iNVENTORYTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventoryKeyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn termDataGridViewTextBoxColumn;
    }
}