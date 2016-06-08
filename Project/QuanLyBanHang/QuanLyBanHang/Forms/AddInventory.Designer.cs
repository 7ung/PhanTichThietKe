namespace QuanLyBanHang.Forms
{
    partial class AddInventory
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
            System.Windows.Forms.Label inventoryKeyLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label rentPriceLabel;
            System.Windows.Forms.Label termLabel;
            System.Windows.Forms.Label label1;
            this.sellManagementDbDataSet = new QuanLyBanHang.SellManagementDbDataSet();
            this.iNVENTORY_CAPABILITYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iNVENTORY_CAPABILITYTableAdapter = new QuanLyBanHang.SellManagementDbDataSetTableAdapters.INVENTORY_CAPABILITYTableAdapter();
            this.tableAdapterManager = new QuanLyBanHang.SellManagementDbDataSetTableAdapters.TableAdapterManager();
            this.iNVENTORYTableAdapter = new QuanLyBanHang.SellManagementDbDataSetTableAdapters.INVENTORYTableAdapter();
            this.iNVENTORYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.iNVENTORY_CAPABILITYDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.pRODUCTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.iNVENTORY_CAPABILITYBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnHelp = new System.Windows.Forms.Button();
            this.termNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.tbRentPrice = new WindowsFormsControlLibrary.CustomTextBox();
            this.tbAddress = new WindowsFormsControlLibrary.CustomTextBox();
            this.tbName = new WindowsFormsControlLibrary.CustomTextBox();
            this.tbInventoryKey = new WindowsFormsControlLibrary.CustomTextBox();
            this.pRODUCTTableAdapter = new QuanLyBanHang.SellManagementDbDataSetTableAdapters.PRODUCTTableAdapter();
            this.queriesTableAdapter = new QuanLyBanHang.SellManagementDbDataSetTableAdapters.QueriesTableAdapter();
            inventoryKeyLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            rentPriceLabel = new System.Windows.Forms.Label();
            termLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sellManagementDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVENTORY_CAPABILITYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVENTORYBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iNVENTORY_CAPABILITYDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVENTORY_CAPABILITYBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.termNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // inventoryKeyLabel
            // 
            inventoryKeyLabel.AutoSize = true;
            inventoryKeyLabel.Location = new System.Drawing.Point(21, 21);
            inventoryKeyLabel.Name = "inventoryKeyLabel";
            inventoryKeyLabel.Size = new System.Drawing.Size(43, 13);
            inventoryKeyLabel.TabIndex = 1;
            inventoryKeyLabel.Text = "Mã kho";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(21, 45);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(47, 13);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Tên kho";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(21, 68);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(40, 13);
            addressLabel.TabIndex = 5;
            addressLabel.Text = "Địa chỉ";
            // 
            // rentPriceLabel
            // 
            rentPriceLabel.AutoSize = true;
            rentPriceLabel.Location = new System.Drawing.Point(21, 167);
            rentPriceLabel.Name = "rentPriceLabel";
            rentPriceLabel.Size = new System.Drawing.Size(47, 13);
            rentPriceLabel.TabIndex = 7;
            rentPriceLabel.Text = "Giá thuê";
            // 
            // termLabel
            // 
            termLabel.AutoSize = true;
            termLabel.Location = new System.Drawing.Point(21, 138);
            termLabel.Name = "termLabel";
            termLabel.Size = new System.Drawing.Size(19, 13);
            termLabel.TabIndex = 16;
            termLabel.Text = "Kỳ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(348, 170);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(30, 13);
            label1.TabIndex = 18;
            label1.Text = "VNĐ";
            // 
            // sellManagementDbDataSet
            // 
            this.sellManagementDbDataSet.DataSetName = "SellManagementDbDataSet";
            this.sellManagementDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iNVENTORY_CAPABILITYBindingSource
            // 
            this.iNVENTORY_CAPABILITYBindingSource.DataMember = "INVENTORY_CAPABILITY";
            this.iNVENTORY_CAPABILITYBindingSource.DataSource = this.sellManagementDbDataSet;
            // 
            // iNVENTORY_CAPABILITYTableAdapter
            // 
            this.iNVENTORY_CAPABILITYTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.INVENTORY_CAPABILITYTableAdapter = this.iNVENTORY_CAPABILITYTableAdapter;
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
            // iNVENTORYTableAdapter
            // 
            this.iNVENTORYTableAdapter.ClearBeforeFill = true;
            // 
            // iNVENTORYBindingSource
            // 
            this.iNVENTORYBindingSource.DataMember = "INVENTORY";
            this.iNVENTORYBindingSource.DataSource = this.sellManagementDbDataSet;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.iNVENTORY_CAPABILITYDataGridView);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Location = new System.Drawing.Point(12, 207);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 312);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sức chứa";
            // 
            // iNVENTORY_CAPABILITYDataGridView
            // 
            this.iNVENTORY_CAPABILITYDataGridView.AllowUserToResizeRows = false;
            this.iNVENTORY_CAPABILITYDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iNVENTORY_CAPABILITYDataGridView.AutoGenerateColumns = false;
            this.iNVENTORY_CAPABILITYDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.iNVENTORY_CAPABILITYDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.idColumn,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.iNVENTORY_CAPABILITYDataGridView.DataSource = this.iNVENTORY_CAPABILITYBindingSource;
            this.iNVENTORY_CAPABILITYDataGridView.Location = new System.Drawing.Point(13, 19);
            this.iNVENTORY_CAPABILITYDataGridView.Name = "iNVENTORY_CAPABILITYDataGridView";
            this.iNVENTORY_CAPABILITYDataGridView.Size = new System.Drawing.Size(530, 242);
            this.iNVENTORY_CAPABILITYDataGridView.TabIndex = 0;
            this.iNVENTORY_CAPABILITYDataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.iNVENTORY_CAPABILITYDataGridView_RowsAdded);
            this.iNVENTORY_CAPABILITYDataGridView.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.iNVENTORY_CAPABILITYDataGridView_UserAddedRow);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Product_id";
            this.dataGridViewTextBoxColumn2.DataSource = this.pRODUCTBindingSource;
            this.dataGridViewTextBoxColumn2.DisplayMember = "Name";
            this.dataGridViewTextBoxColumn2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.dataGridViewTextBoxColumn2.HeaderText = "Sản phẩm";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "Id";
            // 
            // pRODUCTBindingSource
            // 
            this.pRODUCTBindingSource.DataMember = "PRODUCT";
            this.pRODUCTBindingSource.DataSource = this.sellManagementDbDataSet;
            // 
            // idColumn
            // 
            this.idColumn.DataPropertyName = "Inventory_id";
            this.idColumn.HeaderText = "Inventory_id";
            this.idColumn.Name = "idColumn";
            this.idColumn.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MaxCount";
            this.dataGridViewTextBoxColumn3.HeaderText = "Tối đa";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Last";
            this.dataGridViewTextBoxColumn4.HeaderText = "Số kì trước";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CurrentCount";
            this.dataGridViewTextBoxColumn5.HeaderText = "Hiện tại";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(387, 281);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(468, 281);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // iNVENTORY_CAPABILITYBindingSource1
            // 
            this.iNVENTORY_CAPABILITYBindingSource1.DataMember = "FK_INVENTORYCAPABILITY_INVENTORY";
            this.iNVENTORY_CAPABILITYBindingSource1.DataSource = this.iNVENTORYBindingSource;
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(25, 488);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(75, 23);
            this.btnHelp.TabIndex = 16;
            this.btnHelp.Text = "Trợ giúp";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // termNumericUpDown
            // 
            this.termNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.iNVENTORYBindingSource, "Term", true));
            this.termNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.termNumericUpDown.Location = new System.Drawing.Point(103, 131);
            this.termNumericUpDown.Name = "termNumericUpDown";
            this.termNumericUpDown.Size = new System.Drawing.Size(60, 26);
            this.termNumericUpDown.TabIndex = 13;
            // 
            // tbRentPrice
            // 
            this.tbRentPrice.AutoSize = true;
            this.tbRentPrice.BackColor = System.Drawing.Color.White;
            this.tbRentPrice.BorderColor = System.Drawing.Color.Silver;
            this.tbRentPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iNVENTORYBindingSource, "RentPrice", true));
            this.tbRentPrice.ErrorBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.tbRentPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRentPrice.HoverBorderColor = System.Drawing.Color.Cyan;
            this.tbRentPrice.isRequired = true;
            this.tbRentPrice.Location = new System.Drawing.Point(103, 163);
            this.tbRentPrice.Multiline = false;
            this.tbRentPrice.Name = "tbRentPrice";
            this.tbRentPrice.NormalBorderColor = System.Drawing.Color.Silver;
            this.tbRentPrice.PanelBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.tbRentPrice.ReadOnly = false;
            this.tbRentPrice.Size = new System.Drawing.Size(239, 25);
            this.tbRentPrice.StringPattern = "^([0-9.])*$";
            this.tbRentPrice.TabIndex = 14;
            this.tbRentPrice.TextPadding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.tbRentPrice.TextPanelMessage = "Giá trị không hợp lệ.";
            this.tbRentPrice.TextPanelMessageColor = System.Drawing.Color.White;
            this.tbRentPrice.ValidBorderColor = System.Drawing.Color.LightGreen;
            this.tbRentPrice.xTextChanged += new System.EventHandler(this.tbRentPrice_xTextChanged);
            // 
            // tbAddress
            // 
            this.tbAddress.AutoSize = true;
            this.tbAddress.BackColor = System.Drawing.Color.White;
            this.tbAddress.BorderColor = System.Drawing.Color.Silver;
            this.tbAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iNVENTORYBindingSource, "Address", true));
            this.tbAddress.ErrorBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.tbAddress.HoverBorderColor = System.Drawing.Color.Cyan;
            this.tbAddress.isRequired = true;
            this.tbAddress.Location = new System.Drawing.Point(103, 67);
            this.tbAddress.Multiline = true;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.NormalBorderColor = System.Drawing.Color.Silver;
            this.tbAddress.PanelBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.tbAddress.ReadOnly = false;
            this.tbAddress.Size = new System.Drawing.Size(280, 58);
            this.tbAddress.StringPattern = "^([ẮẰẲẴẶĂẤẦẨẪẬÂÁÀÃẢẠĐẾỀỂỄỆÊÉÈẺẼẸÍÌỈĨỊỐỒỔỖỘÔỚỜỞỠỢƠÓÒÕỎỌỨỪỬỮỰƯÚÙỦŨỤÝỲỶỸỴA-Za-z0-9/ " +
    "])*$";
            this.tbAddress.TabIndex = 12;
            this.tbAddress.TextPadding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.tbAddress.TextPanelMessage = "Chuỗi không hợp lệ.";
            this.tbAddress.TextPanelMessageColor = System.Drawing.Color.White;
            this.tbAddress.ValidBorderColor = System.Drawing.Color.LightGreen;
            // 
            // tbName
            // 
            this.tbName.AutoSize = true;
            this.tbName.BackColor = System.Drawing.Color.White;
            this.tbName.BorderColor = System.Drawing.Color.Silver;
            this.tbName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iNVENTORYBindingSource, "Name", true));
            this.tbName.ErrorBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.tbName.HoverBorderColor = System.Drawing.Color.Cyan;
            this.tbName.isRequired = true;
            this.tbName.Location = new System.Drawing.Point(103, 42);
            this.tbName.Multiline = false;
            this.tbName.Name = "tbName";
            this.tbName.NormalBorderColor = System.Drawing.Color.Silver;
            this.tbName.PanelBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.tbName.ReadOnly = false;
            this.tbName.Size = new System.Drawing.Size(280, 19);
            this.tbName.StringPattern = "^([ẮẰẲẴẶĂẤẦẨẪẬÂÁÀÃẢẠĐẾỀỂỄỆÊÉÈẺẼẸÍÌỈĨỊỐỒỔỖỘÔỚỜỞỠỢƠÓÒÕỎỌỨỪỬỮỰƯÚÙỦŨỤÝỲỶỸỴA-Za-z0-9/ " +
    "])*$";
            this.tbName.TabIndex = 11;
            this.tbName.TextPadding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.tbName.TextPanelMessage = "Chuỗi không hợp lệ.";
            this.tbName.TextPanelMessageColor = System.Drawing.Color.White;
            this.tbName.ValidBorderColor = System.Drawing.Color.LightGreen;
            // 
            // tbInventoryKey
            // 
            this.tbInventoryKey.AutoSize = true;
            this.tbInventoryKey.BackColor = System.Drawing.Color.White;
            this.tbInventoryKey.BorderColor = System.Drawing.Color.Silver;
            this.tbInventoryKey.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iNVENTORYBindingSource, "InventoryKey", true));
            this.tbInventoryKey.ErrorBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.tbInventoryKey.HoverBorderColor = System.Drawing.Color.Cyan;
            this.tbInventoryKey.isRequired = true;
            this.tbInventoryKey.Location = new System.Drawing.Point(103, 17);
            this.tbInventoryKey.Multiline = false;
            this.tbInventoryKey.Name = "tbInventoryKey";
            this.tbInventoryKey.NormalBorderColor = System.Drawing.Color.Silver;
            this.tbInventoryKey.PanelBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.tbInventoryKey.ReadOnly = true;
            this.tbInventoryKey.Size = new System.Drawing.Size(160, 19);
            this.tbInventoryKey.StringPattern = "^([ẮẰẲẴẶĂẤẦẨẪẬÂÁÀÃẢẠĐẾỀỂỄỆÊÉÈẺẼẸÍÌỈĨỊỐỒỔỖỘÔỚỜỞỠỢƠÓÒÕỎỌỨỪỬỮỰƯÚÙỦŨỤÝỲỶỸỴA-Za-z0-9 ]" +
    ")*$";
            this.tbInventoryKey.TabIndex = 10;
            this.tbInventoryKey.TextPadding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.tbInventoryKey.TextPanelMessage = "";
            this.tbInventoryKey.TextPanelMessageColor = System.Drawing.Color.White;
            this.tbInventoryKey.ValidBorderColor = System.Drawing.Color.LightGreen;
            // 
            // pRODUCTTableAdapter
            // 
            this.pRODUCTTableAdapter.ClearBeforeFill = true;
            // 
            // AddInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 531);
            this.Controls.Add(label1);
            this.Controls.Add(termLabel);
            this.Controls.Add(this.termNumericUpDown);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.tbRentPrice);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbInventoryKey);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(rentPriceLabel);
            this.Controls.Add(addressLabel);
            this.Controls.Add(nameLabel);
            this.Controls.Add(inventoryKeyLabel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 570);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 570);
            this.Name = "AddInventory";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm kho hàng";
            this.Load += new System.EventHandler(this.AddInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sellManagementDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVENTORY_CAPABILITYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVENTORYBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iNVENTORY_CAPABILITYDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVENTORY_CAPABILITYBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.termNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SellManagementDbDataSet sellManagementDbDataSet;
        private System.Windows.Forms.BindingSource iNVENTORY_CAPABILITYBindingSource;
        private SellManagementDbDataSetTableAdapters.INVENTORY_CAPABILITYTableAdapter iNVENTORY_CAPABILITYTableAdapter;
        private SellManagementDbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private SellManagementDbDataSetTableAdapters.INVENTORYTableAdapter iNVENTORYTableAdapter;
        private System.Windows.Forms.BindingSource iNVENTORYBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private WindowsFormsControlLibrary.CustomTextBox tbName;
        private WindowsFormsControlLibrary.CustomTextBox tbAddress;
        private WindowsFormsControlLibrary.CustomTextBox tbRentPrice;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.NumericUpDown termNumericUpDown;
        private System.Windows.Forms.BindingSource iNVENTORY_CAPABILITYBindingSource1;
        private System.Windows.Forms.DataGridView iNVENTORY_CAPABILITYDataGridView;
        private WindowsFormsControlLibrary.CustomTextBox tbInventoryKey;
        private System.Windows.Forms.BindingSource pRODUCTBindingSource;
        private SellManagementDbDataSetTableAdapters.PRODUCTTableAdapter pRODUCTTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private SellManagementDbDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter;
    }
}