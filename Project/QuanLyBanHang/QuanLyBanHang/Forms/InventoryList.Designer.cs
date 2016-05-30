namespace QuanLyBanHang.Forms
{
    partial class InventoryList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label rentPriceLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label inventoryKeyLabel;
            this.sellManagementDbDataSet = new QuanLyBanHang.SellManagementDbDataSet();
            this.iNVENTORYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iNVENTORYTableAdapter = new QuanLyBanHang.SellManagementDbDataSetTableAdapters.INVENTORYTableAdapter();
            this.tableAdapterManager = new QuanLyBanHang.SellManagementDbDataSetTableAdapters.TableAdapterManager();
            this.iNVENTORYDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.tbRentPrice = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbInventoryKey = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.iNVENTORY_CAPABILITYDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNVENTORY_CAPABILITYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnEdit = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.iNVENTORY_CAPABILITYTableAdapter = new QuanLyBanHang.SellManagementDbDataSetTableAdapters.INVENTORY_CAPABILITYTableAdapter();
            rentPriceLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            inventoryKeyLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sellManagementDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVENTORYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVENTORYDataGridView)).BeginInit();
            this.gbInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iNVENTORY_CAPABILITYDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVENTORY_CAPABILITYBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rentPriceLabel
            // 
            rentPriceLabel.AutoSize = true;
            rentPriceLabel.Location = new System.Drawing.Point(43, 167);
            rentPriceLabel.Name = "rentPriceLabel";
            rentPriceLabel.Size = new System.Drawing.Size(47, 13);
            rentPriceLabel.TabIndex = 16;
            rentPriceLabel.Text = "Giá thuê";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(41, 78);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(40, 13);
            addressLabel.TabIndex = 14;
            addressLabel.Text = "Địa chỉ";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(41, 52);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(47, 13);
            nameLabel.TabIndex = 12;
            nameLabel.Text = "Tên kho";
            // 
            // inventoryKeyLabel
            // 
            inventoryKeyLabel.AutoSize = true;
            inventoryKeyLabel.Location = new System.Drawing.Point(43, 26);
            inventoryKeyLabel.Name = "inventoryKeyLabel";
            inventoryKeyLabel.Size = new System.Drawing.Size(43, 13);
            inventoryKeyLabel.TabIndex = 10;
            inventoryKeyLabel.Text = "Mã kho";
            // 
            // sellManagementDbDataSet
            // 
            this.sellManagementDbDataSet.DataSetName = "SellManagementDbDataSet";
            this.sellManagementDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iNVENTORYBindingSource
            // 
            this.iNVENTORYBindingSource.DataMember = "INVENTORY";
            this.iNVENTORYBindingSource.DataSource = this.sellManagementDbDataSet;
            // 
            // iNVENTORYTableAdapter
            // 
            this.iNVENTORYTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BILLTableAdapter = null;
            this.tableAdapterManager.CONSTANTTableAdapter = null;
            this.tableAdapterManager.CUSTOMER_BILLTableAdapter = null;
            this.tableAdapterManager.CUSTOMER_DEBTTableAdapter = null;
            this.tableAdapterManager.CUSTOMERTableAdapter = null;
            this.tableAdapterManager.DEBTTableAdapter = null;
            this.tableAdapterManager.DOCUMENTTableAdapter = null;
            this.tableAdapterManager.FEEDBACKTableAdapter = null;
            this.tableAdapterManager.GROUPofCUSTOMERTableAdapter = null;
            this.tableAdapterManager.INOUT_INVENTORY_DETAILTableAdapter = null;
            this.tableAdapterManager.INOUTINVENTORYTableAdapter = null;
            this.tableAdapterManager.INVENTORY_CAPABILITYTableAdapter = null;
            this.tableAdapterManager.INVENTORYTableAdapter = this.iNVENTORYTableAdapter;
            this.tableAdapterManager.ORDER_DETAILTableAdapter = null;
            this.tableAdapterManager.ORDERTableAdapter = null;
            this.tableAdapterManager.PRODUCT_METADATATableAdapter = null;
            this.tableAdapterManager.PRODUCTTableAdapter = null;
            this.tableAdapterManager.PURCHASE_ORDERTableAdapter = null;
            this.tableAdapterManager.QUOTE_DETAILTableAdapter = null;
            this.tableAdapterManager.QUOTETableAdapter = null;
            this.tableAdapterManager.STAFFTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QuanLyBanHang.SellManagementDbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VENDOR_BILLTableAdapter = null;
            this.tableAdapterManager.VENDOR_DEBTTableAdapter = null;
            this.tableAdapterManager.VENDOR_ORDERTableAdapter = null;
            this.tableAdapterManager.VENDORORDER_DETAILTableAdapter = null;
            this.tableAdapterManager.VENDORTableAdapter = null;
            // 
            // iNVENTORYDataGridView
            // 
            this.iNVENTORYDataGridView.AllowUserToAddRows = false;
            this.iNVENTORYDataGridView.AllowUserToDeleteRows = false;
            this.iNVENTORYDataGridView.AutoGenerateColumns = false;
            this.iNVENTORYDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.iNVENTORYDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.iNVENTORYDataGridView.DataSource = this.iNVENTORYBindingSource;
            this.iNVENTORYDataGridView.Location = new System.Drawing.Point(13, 62);
            this.iNVENTORYDataGridView.Name = "iNVENTORYDataGridView";
            this.iNVENTORYDataGridView.ReadOnly = true;
            this.iNVENTORYDataGridView.Size = new System.Drawing.Size(444, 443);
            this.iNVENTORYDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "InventoryKey";
            this.dataGridViewTextBoxColumn2.HeaderText = "Mã kho";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Tên kho";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn4.HeaderText = "Địa chỉ";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "RentPrice";
            this.dataGridViewTextBoxColumn5.HeaderText = "Giá thuê";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.tbRentPrice);
            this.gbInfo.Controls.Add(this.tbAddress);
            this.gbInfo.Controls.Add(this.tbName);
            this.gbInfo.Controls.Add(this.tbInventoryKey);
            this.gbInfo.Controls.Add(this.groupBox1);
            this.gbInfo.Controls.Add(this.btnEdit);
            this.gbInfo.Controls.Add(rentPriceLabel);
            this.gbInfo.Controls.Add(addressLabel);
            this.gbInfo.Controls.Add(nameLabel);
            this.gbInfo.Controls.Add(inventoryKeyLabel);
            this.gbInfo.Location = new System.Drawing.Point(474, 19);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(415, 486);
            this.gbInfo.TabIndex = 2;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Thông tin";
            // 
            // tbRentPrice
            // 
            this.tbRentPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iNVENTORYBindingSource, "RentPrice", true));
            this.tbRentPrice.Location = new System.Drawing.Point(132, 164);
            this.tbRentPrice.Name = "tbRentPrice";
            this.tbRentPrice.Size = new System.Drawing.Size(252, 20);
            this.tbRentPrice.TabIndex = 29;
            // 
            // tbAddress
            // 
            this.tbAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iNVENTORYBindingSource, "Address", true));
            this.tbAddress.Location = new System.Drawing.Point(132, 75);
            this.tbAddress.Multiline = true;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(252, 54);
            this.tbAddress.TabIndex = 28;
            // 
            // tbName
            // 
            this.tbName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iNVENTORYBindingSource, "Name", true));
            this.tbName.Location = new System.Drawing.Point(132, 49);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(252, 20);
            this.tbName.TabIndex = 27;
            // 
            // tbInventoryKey
            // 
            this.tbInventoryKey.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iNVENTORYBindingSource, "InventoryKey", true));
            this.tbInventoryKey.Location = new System.Drawing.Point(132, 23);
            this.tbInventoryKey.Name = "tbInventoryKey";
            this.tbInventoryKey.Size = new System.Drawing.Size(252, 20);
            this.tbInventoryKey.TabIndex = 26;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.iNVENTORY_CAPABILITYDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(11, 210);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 235);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sức chứa";
            // 
            // iNVENTORY_CAPABILITYDataGridView
            // 
            this.iNVENTORY_CAPABILITYDataGridView.AllowUserToAddRows = false;
            this.iNVENTORY_CAPABILITYDataGridView.AllowUserToDeleteRows = false;
            this.iNVENTORY_CAPABILITYDataGridView.AutoGenerateColumns = false;
            this.iNVENTORY_CAPABILITYDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.iNVENTORY_CAPABILITYDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.iNVENTORY_CAPABILITYDataGridView.DataSource = this.iNVENTORY_CAPABILITYBindingSource;
            this.iNVENTORY_CAPABILITYDataGridView.Location = new System.Drawing.Point(9, 19);
            this.iNVENTORY_CAPABILITYDataGridView.Name = "iNVENTORY_CAPABILITYDataGridView";
            this.iNVENTORY_CAPABILITYDataGridView.ReadOnly = true;
            this.iNVENTORY_CAPABILITYDataGridView.Size = new System.Drawing.Size(364, 210);
            this.iNVENTORY_CAPABILITYDataGridView.TabIndex = 25;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Product_id";
            this.dataGridViewTextBoxColumn6.HeaderText = "Mã sản phẩm";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "MaxCount";
            this.dataGridViewTextBoxColumn7.HeaderText = "Số lượng tối đa";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 110;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "CurrentCount";
            this.dataGridViewTextBoxColumn8.HeaderText = "Số lượng hiện tại";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 110;
            // 
            // iNVENTORY_CAPABILITYBindingSource
            // 
            this.iNVENTORY_CAPABILITYBindingSource.DataMember = "FK_INVENTORYCAPABILITY_INVENTORY";
            this.iNVENTORY_CAPABILITYBindingSource.DataSource = this.iNVENTORYBindingSource;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(309, 454);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 18;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(104, 19);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(254, 20);
            this.tbSearch.TabIndex = 3;
            this.tbSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tìm kiếm";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(13, 523);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(382, 523);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(783, 523);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // iNVENTORY_CAPABILITYTableAdapter
            // 
            this.iNVENTORY_CAPABILITYTableAdapter.ClearBeforeFill = true;
            // 
            // InventoryList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.iNVENTORYDataGridView);
            this.Name = "InventoryList";
            this.Size = new System.Drawing.Size(901, 561);
            ((System.ComponentModel.ISupportInitialize)(this.sellManagementDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVENTORYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVENTORYDataGridView)).EndInit();
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iNVENTORY_CAPABILITYDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVENTORY_CAPABILITYBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SellManagementDbDataSet sellManagementDbDataSet;
        private System.Windows.Forms.BindingSource iNVENTORYBindingSource;
        private SellManagementDbDataSetTableAdapters.INVENTORYTableAdapter iNVENTORYTableAdapter;
        private SellManagementDbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView iNVENTORYDataGridView;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView iNVENTORY_CAPABILITYDataGridView;
        private System.Windows.Forms.BindingSource iNVENTORY_CAPABILITYBindingSource;
        private SellManagementDbDataSetTableAdapters.INVENTORY_CAPABILITYTableAdapter iNVENTORY_CAPABILITYTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox tbRentPrice;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbInventoryKey;
    }
}
