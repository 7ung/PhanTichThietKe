namespace QuanLyBanHang.Forms
{
    partial class InOutInventoryList
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
            System.Windows.Forms.Label documentKeyLabel;
            System.Windows.Forms.Label creatorLabel;
            System.Windows.Forms.Label createDateLabel;
            System.Windows.Forms.Label respondLabel;
            System.Windows.Forms.Label carryFeeLabel;
            System.Windows.Forms.Label termLabel;
            System.Windows.Forms.Label inOutTypeLabel;
            System.Windows.Forms.Label label1;
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.inOutTypeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.documentKeyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.iNVENTORYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sellManagementDbDataSet = new QuanLyBanHang.SellManagementDbDataSet();
            this.createDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inOutInventoryViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.closeBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.documentKeyText = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.editBtn = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.productidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.pRODUCTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inOutInventoryDetailProductQuantityViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.creatorComboBox = new System.Windows.Forms.ComboBox();
            this.sTAFFBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.createDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.respondComboBox = new System.Windows.Forms.ComboBox();
            this.sTAFFBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.inOutTypeCheckBox = new System.Windows.Forms.CheckBox();
            this.inOut_Inventory_ViewTableAdapter = new QuanLyBanHang.SellManagementDbDataSetTableAdapters.InOut_Inventory_ViewTableAdapter();
            this.inOutInventory_Detail_ProductQuantity_ViewTableAdapter = new QuanLyBanHang.SellManagementDbDataSetTableAdapters.InOutInventory_Detail_ProductQuantity_ViewTableAdapter();
            this.sTAFFTableAdapter = new QuanLyBanHang.SellManagementDbDataSetTableAdapters.STAFFTableAdapter();
            this.pRODUCTTableAdapter = new QuanLyBanHang.SellManagementDbDataSetTableAdapters.PRODUCTTableAdapter();
            this.iNVENTORYTableAdapter = new QuanLyBanHang.SellManagementDbDataSetTableAdapters.INVENTORYTableAdapter();
            this.queriesTableAdapter = new QuanLyBanHang.SellManagementDbDataSetTableAdapters.QueriesTableAdapter();
            this.inouT_INVENTORY_DETAILTableAdapter = new QuanLyBanHang.SellManagementDbDataSetTableAdapters.INOUT_INVENTORY_DETAILTableAdapter();
            this.ordeR_DETAILTableAdapter = new QuanLyBanHang.SellManagementDbDataSetTableAdapters.ORDER_DETAILTableAdapter();
            this.inventorY_CAPABILITYTableAdapter = new QuanLyBanHang.SellManagementDbDataSetTableAdapters.INVENTORY_CAPABILITYTableAdapter();
            this.tranferFeeTableAdapter = new QuanLyBanHang.SellManagementDbDataSetTableAdapters.TranferFeeTableAdapter();
            documentKeyLabel = new System.Windows.Forms.Label();
            creatorLabel = new System.Windows.Forms.Label();
            createDateLabel = new System.Windows.Forms.Label();
            respondLabel = new System.Windows.Forms.Label();
            carryFeeLabel = new System.Windows.Forms.Label();
            termLabel = new System.Windows.Forms.Label();
            inOutTypeLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVENTORYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellManagementDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inOutInventoryViewBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inOutInventoryDetailProductQuantityViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTAFFBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTAFFBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // documentKeyLabel
            // 
            documentKeyLabel.AutoSize = true;
            documentKeyLabel.Location = new System.Drawing.Point(16, 19);
            documentKeyLabel.Name = "documentKeyLabel";
            documentKeyLabel.Size = new System.Drawing.Size(25, 13);
            documentKeyLabel.TabIndex = 37;
            documentKeyLabel.Text = "Mã ";
            // 
            // creatorLabel
            // 
            creatorLabel.AutoSize = true;
            creatorLabel.Location = new System.Drawing.Point(16, 45);
            creatorLabel.Name = "creatorLabel";
            creatorLabel.Size = new System.Drawing.Size(52, 13);
            creatorLabel.TabIndex = 39;
            creatorLabel.Text = "Người lập";
            // 
            // createDateLabel
            // 
            createDateLabel.AutoSize = true;
            createDateLabel.Location = new System.Drawing.Point(16, 73);
            createDateLabel.Name = "createDateLabel";
            createDateLabel.Size = new System.Drawing.Size(49, 13);
            createDateLabel.TabIndex = 41;
            createDateLabel.Text = "Ngày lập";
            // 
            // respondLabel
            // 
            respondLabel.AutoSize = true;
            respondLabel.Location = new System.Drawing.Point(16, 98);
            respondLabel.Name = "respondLabel";
            respondLabel.Size = new System.Drawing.Size(116, 13);
            respondLabel.TabIndex = 43;
            respondLabel.Text = "Người chịu trách nhiệm";
            // 
            // carryFeeLabel
            // 
            carryFeeLabel.AutoSize = true;
            carryFeeLabel.Location = new System.Drawing.Point(16, 129);
            carryFeeLabel.Name = "carryFeeLabel";
            carryFeeLabel.Size = new System.Drawing.Size(83, 13);
            carryFeeLabel.TabIndex = 45;
            carryFeeLabel.Text = "Phí vận chuyển";
            // 
            // termLabel
            // 
            termLabel.AutoSize = true;
            termLabel.Location = new System.Drawing.Point(16, 162);
            termLabel.Name = "termLabel";
            termLabel.Size = new System.Drawing.Size(19, 13);
            termLabel.TabIndex = 47;
            termLabel.Text = "Kỳ";
            // 
            // inOutTypeLabel
            // 
            inOutTypeLabel.AutoSize = true;
            inOutTypeLabel.Location = new System.Drawing.Point(16, 191);
            inOutTypeLabel.Name = "inOutTypeLabel";
            inOutTypeLabel.Size = new System.Drawing.Size(27, 13);
            inOutTypeLabel.TabIndex = 49;
            inOutTypeLabel.Text = "Loại";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(301, 129);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(30, 13);
            label1.TabIndex = 53;
            label1.Text = "VNĐ";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.deleteBtn);
            this.splitContainer1.Panel1.Controls.Add(this.addBtn);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.closeBtn);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(944, 521);
            this.splitContainer1.SplitterDistance = 400;
            this.splitContainer1.TabIndex = 0;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteBtn.BackColor = System.Drawing.Color.Transparent;
            this.deleteBtn.Image = global::QuanLyBanHang.Properties.Resources.error;
            this.deleteBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteBtn.Location = new System.Drawing.Point(280, 460);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.deleteBtn.Size = new System.Drawing.Size(100, 45);
            this.deleteBtn.TabIndex = 56;
            this.deleteBtn.Text = "Xóa";
            this.deleteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addBtn.Location = new System.Drawing.Point(20, 470);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 55;
            this.addBtn.Text = "Thêm";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Visible = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(20, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 434);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách đơn";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.inOutTypeDataGridViewCheckBoxColumn,
            this.documentKeyDataGridViewTextBoxColumn,
            this.inventoryidDataGridViewTextBoxColumn,
            this.createDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.inOutInventoryViewBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.Silver;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(348, 409);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // inOutTypeDataGridViewCheckBoxColumn
            // 
            this.inOutTypeDataGridViewCheckBoxColumn.DataPropertyName = "InOutType";
            this.inOutTypeDataGridViewCheckBoxColumn.HeaderText = "Nhập";
            this.inOutTypeDataGridViewCheckBoxColumn.Name = "inOutTypeDataGridViewCheckBoxColumn";
            this.inOutTypeDataGridViewCheckBoxColumn.ReadOnly = true;
            this.inOutTypeDataGridViewCheckBoxColumn.Width = 50;
            // 
            // documentKeyDataGridViewTextBoxColumn
            // 
            this.documentKeyDataGridViewTextBoxColumn.DataPropertyName = "DocumentKey";
            this.documentKeyDataGridViewTextBoxColumn.HeaderText = "Mã đơn";
            this.documentKeyDataGridViewTextBoxColumn.Name = "documentKeyDataGridViewTextBoxColumn";
            this.documentKeyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inventoryidDataGridViewTextBoxColumn
            // 
            this.inventoryidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.inventoryidDataGridViewTextBoxColumn.DataPropertyName = "Inventory_id";
            this.inventoryidDataGridViewTextBoxColumn.DataSource = this.iNVENTORYBindingSource;
            this.inventoryidDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.inventoryidDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.inventoryidDataGridViewTextBoxColumn.HeaderText = "Kho hàng";
            this.inventoryidDataGridViewTextBoxColumn.Name = "inventoryidDataGridViewTextBoxColumn";
            this.inventoryidDataGridViewTextBoxColumn.ReadOnly = true;
            this.inventoryidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.inventoryidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.inventoryidDataGridViewTextBoxColumn.ValueMember = "Id";
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
            // createDateDataGridViewTextBoxColumn
            // 
            this.createDateDataGridViewTextBoxColumn.DataPropertyName = "CreateDate";
            this.createDateDataGridViewTextBoxColumn.HeaderText = "Ngày lập";
            this.createDateDataGridViewTextBoxColumn.Name = "createDateDataGridViewTextBoxColumn";
            this.createDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inOutInventoryViewBindingSource
            // 
            this.inOutInventoryViewBindingSource.DataMember = "InOut_Inventory_View";
            this.inOutInventoryViewBindingSource.DataSource = this.sellManagementDbDataSet;
            this.inOutInventoryViewBindingSource.CurrentChanged += new System.EventHandler(this.inOutInventoryViewBindingSource_CurrentChanged);
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.Location = new System.Drawing.Point(402, 460);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(100, 45);
            this.closeBtn.TabIndex = 57;
            this.closeBtn.Text = "Đóng";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.documentKeyText);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(label1);
            this.groupBox2.Controls.Add(this.editBtn);
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Controls.Add(documentKeyLabel);
            this.groupBox2.Controls.Add(creatorLabel);
            this.groupBox2.Controls.Add(this.creatorComboBox);
            this.groupBox2.Controls.Add(createDateLabel);
            this.groupBox2.Controls.Add(this.createDateDateTimePicker);
            this.groupBox2.Controls.Add(respondLabel);
            this.groupBox2.Controls.Add(this.respondComboBox);
            this.groupBox2.Controls.Add(carryFeeLabel);
            this.groupBox2.Controls.Add(termLabel);
            this.groupBox2.Controls.Add(inOutTypeLabel);
            this.groupBox2.Controls.Add(this.inOutTypeCheckBox);
            this.groupBox2.Location = new System.Drawing.Point(20, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(500, 434);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin";
            // 
            // documentKeyText
            // 
            this.documentKeyText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inOutInventoryViewBindingSource, "DocumentKey", true));
            this.documentKeyText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.documentKeyText.Location = new System.Drawing.Point(138, 16);
            this.documentKeyText.Name = "documentKeyText";
            this.documentKeyText.ReadOnly = true;
            this.documentKeyText.Size = new System.Drawing.Size(157, 20);
            this.documentKeyText.TabIndex = 56;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inOutInventoryViewBindingSource, "CarryFee", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(138, 122);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(157, 26);
            this.textBox2.TabIndex = 55;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inOutInventoryViewBindingSource, "Term", true));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(138, 154);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(50, 26);
            this.textBox1.TabIndex = 54;
            // 
            // editBtn
            // 
            this.editBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.editBtn.Image = global::QuanLyBanHang.Properties.Resources.edit_32;
            this.editBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editBtn.Location = new System.Drawing.Point(382, 377);
            this.editBtn.Name = "editBtn";
            this.editBtn.Padding = new System.Windows.Forms.Padding(10, 0, 12, 0);
            this.editBtn.Size = new System.Drawing.Size(100, 45);
            this.editBtn.TabIndex = 52;
            this.editBtn.Text = "Sửa";
            this.editBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productidDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.inOutInventoryDetailProductQuantityViewBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(19, 230);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(463, 141);
            this.dataGridView2.TabIndex = 51;
            // 
            // productidDataGridViewTextBoxColumn
            // 
            this.productidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productidDataGridViewTextBoxColumn.DataPropertyName = "Product_id";
            this.productidDataGridViewTextBoxColumn.DataSource = this.pRODUCTBindingSource;
            this.productidDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.productidDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.productidDataGridViewTextBoxColumn.HeaderText = "Sản phẩm";
            this.productidDataGridViewTextBoxColumn.Name = "productidDataGridViewTextBoxColumn";
            this.productidDataGridViewTextBoxColumn.ReadOnly = true;
            this.productidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.productidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.productidDataGridViewTextBoxColumn.ValueMember = "Id";
            // 
            // pRODUCTBindingSource
            // 
            this.pRODUCTBindingSource.DataMember = "PRODUCT";
            this.pRODUCTBindingSource.DataSource = this.sellManagementDbDataSet;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Số lượng";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inOutInventoryDetailProductQuantityViewBindingSource
            // 
            this.inOutInventoryDetailProductQuantityViewBindingSource.DataMember = "InOutInventory_Detail_ProductQuantity_View";
            this.inOutInventoryDetailProductQuantityViewBindingSource.DataSource = this.sellManagementDbDataSet;
            // 
            // creatorComboBox
            // 
            this.creatorComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.inOutInventoryViewBindingSource, "Creator", true));
            this.creatorComboBox.DataSource = this.sTAFFBindingSource;
            this.creatorComboBox.DisplayMember = "Name";
            this.creatorComboBox.Enabled = false;
            this.creatorComboBox.FormattingEnabled = true;
            this.creatorComboBox.Location = new System.Drawing.Point(138, 42);
            this.creatorComboBox.Name = "creatorComboBox";
            this.creatorComboBox.Size = new System.Drawing.Size(120, 21);
            this.creatorComboBox.TabIndex = 40;
            this.creatorComboBox.ValueMember = "Id";
            // 
            // sTAFFBindingSource
            // 
            this.sTAFFBindingSource.DataMember = "STAFF";
            this.sTAFFBindingSource.DataSource = this.sellManagementDbDataSet;
            // 
            // createDateDateTimePicker
            // 
            this.createDateDateTimePicker.CustomFormat = "dd\'/\'MM\'/\'yyyy";
            this.createDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.inOutInventoryViewBindingSource, "CreateDate", true));
            this.createDateDateTimePicker.Enabled = false;
            this.createDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.createDateDateTimePicker.Location = new System.Drawing.Point(138, 69);
            this.createDateDateTimePicker.Name = "createDateDateTimePicker";
            this.createDateDateTimePicker.Size = new System.Drawing.Size(120, 20);
            this.createDateDateTimePicker.TabIndex = 42;
            // 
            // respondComboBox
            // 
            this.respondComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.inOutInventoryViewBindingSource, "Respond", true));
            this.respondComboBox.DataSource = this.sTAFFBindingSource1;
            this.respondComboBox.DisplayMember = "Name";
            this.respondComboBox.Enabled = false;
            this.respondComboBox.FormattingEnabled = true;
            this.respondComboBox.Location = new System.Drawing.Point(138, 95);
            this.respondComboBox.Name = "respondComboBox";
            this.respondComboBox.Size = new System.Drawing.Size(120, 21);
            this.respondComboBox.TabIndex = 44;
            this.respondComboBox.ValueMember = "Id";
            // 
            // sTAFFBindingSource1
            // 
            this.sTAFFBindingSource1.DataMember = "STAFF";
            this.sTAFFBindingSource1.DataSource = this.sellManagementDbDataSet;
            // 
            // inOutTypeCheckBox
            // 
            this.inOutTypeCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.inOutTypeCheckBox.BackColor = System.Drawing.Color.White;
            this.inOutTypeCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.inOutInventoryViewBindingSource, "InOutType", true));
            this.inOutTypeCheckBox.Enabled = false;
            this.inOutTypeCheckBox.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.inOutTypeCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inOutTypeCheckBox.ForeColor = System.Drawing.Color.Black;
            this.inOutTypeCheckBox.Location = new System.Drawing.Point(138, 185);
            this.inOutTypeCheckBox.Name = "inOutTypeCheckBox";
            this.inOutTypeCheckBox.Size = new System.Drawing.Size(120, 26);
            this.inOutTypeCheckBox.TabIndex = 50;
            this.inOutTypeCheckBox.Text = "Nhập hàng";
            this.inOutTypeCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.inOutTypeCheckBox.UseVisualStyleBackColor = false;
            this.inOutTypeCheckBox.CheckedChanged += new System.EventHandler(this.inOutTypeCheckBox_CheckedChanged);
            // 
            // inOut_Inventory_ViewTableAdapter
            // 
            this.inOut_Inventory_ViewTableAdapter.ClearBeforeFill = true;
            // 
            // inOutInventory_Detail_ProductQuantity_ViewTableAdapter
            // 
            this.inOutInventory_Detail_ProductQuantity_ViewTableAdapter.ClearBeforeFill = true;
            // 
            // sTAFFTableAdapter
            // 
            this.sTAFFTableAdapter.ClearBeforeFill = true;
            // 
            // pRODUCTTableAdapter
            // 
            this.pRODUCTTableAdapter.ClearBeforeFill = true;
            // 
            // iNVENTORYTableAdapter
            // 
            this.iNVENTORYTableAdapter.ClearBeforeFill = true;
            // 
            // inouT_INVENTORY_DETAILTableAdapter
            // 
            this.inouT_INVENTORY_DETAILTableAdapter.ClearBeforeFill = true;
            // 
            // ordeR_DETAILTableAdapter
            // 
            this.ordeR_DETAILTableAdapter.ClearBeforeFill = true;
            // 
            // inventorY_CAPABILITYTableAdapter
            // 
            this.inventorY_CAPABILITYTableAdapter.ClearBeforeFill = true;
            // 
            // tranferFeeTableAdapter
            // 
            this.tranferFeeTableAdapter.ClearBeforeFill = true;
            // 
            // InOutInventoryList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "InOutInventoryList";
            this.Size = new System.Drawing.Size(944, 521);
            this.Load += new System.EventHandler(this.InOutInventoryList_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVENTORYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellManagementDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inOutInventoryViewBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inOutInventoryDetailProductQuantityViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTAFFBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTAFFBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SellManagementDbDataSet sellManagementDbDataSet;
        private System.Windows.Forms.ComboBox creatorComboBox;
        private System.Windows.Forms.DateTimePicker createDateDateTimePicker;
        private System.Windows.Forms.ComboBox respondComboBox;
        private System.Windows.Forms.CheckBox inOutTypeCheckBox;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource inOutInventoryViewBindingSource;
        private SellManagementDbDataSetTableAdapters.InOut_Inventory_ViewTableAdapter inOut_Inventory_ViewTableAdapter;
        private System.Windows.Forms.BindingSource inOutInventoryDetailProductQuantityViewBindingSource;
        private SellManagementDbDataSetTableAdapters.InOutInventory_Detail_ProductQuantity_ViewTableAdapter inOutInventory_Detail_ProductQuantity_ViewTableAdapter;
        private System.Windows.Forms.BindingSource sTAFFBindingSource;
        private SellManagementDbDataSetTableAdapters.STAFFTableAdapter sTAFFTableAdapter;
        private System.Windows.Forms.BindingSource sTAFFBindingSource1;
        private System.Windows.Forms.BindingSource pRODUCTBindingSource;
        private SellManagementDbDataSetTableAdapters.PRODUCTTableAdapter pRODUCTTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn productidDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.BindingSource iNVENTORYBindingSource;
        private SellManagementDbDataSetTableAdapters.INVENTORYTableAdapter iNVENTORYTableAdapter;
        private SellManagementDbDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter;
        private SellManagementDbDataSetTableAdapters.INOUT_INVENTORY_DETAILTableAdapter inouT_INVENTORY_DETAILTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn inventoryidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentKeyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn inOutTypeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox documentKeyText;
        private SellManagementDbDataSetTableAdapters.ORDER_DETAILTableAdapter ordeR_DETAILTableAdapter;
        private SellManagementDbDataSetTableAdapters.INVENTORY_CAPABILITYTableAdapter inventorY_CAPABILITYTableAdapter;
        private SellManagementDbDataSetTableAdapters.TranferFeeTableAdapter tranferFeeTableAdapter;
    }
}
