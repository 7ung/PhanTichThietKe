namespace QuanLyBanHang.Forms
{
    partial class AddInoutInventory
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label documentKeyLabel;
            System.Windows.Forms.Label creatorLabel;
            System.Windows.Forms.Label createDateLabel;
            System.Windows.Forms.Label respondLabel;
            System.Windows.Forms.Label carryFeeLabel;
            System.Windows.Forms.Label termLabel;
            System.Windows.Forms.Label inOutTypeLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.productidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.pRODUCTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sellManagementDbDataSet = new QuanLyBanHang.SellManagementDbDataSet();
            this.maxCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNVENTORYCAPABILITYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryComboBox = new System.Windows.Forms.ComboBox();
            this.iNOUTINVENTORYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iNVENTORYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.documentKeyTextBox = new WindowsFormsControlLibrary.CustomTextBox();
            this.documentBindingSourceForEdit = new System.Windows.Forms.BindingSource(this.components);
            this.creatorComboBox = new System.Windows.Forms.ComboBox();
            this.sTAFFBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.createDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.respondComboBox = new System.Windows.Forms.ComboBox();
            this.sTAFFBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.carryFeeTextBox = new WindowsFormsControlLibrary.CustomTextBox();
            this.termNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.isInCheckBox = new System.Windows.Forms.CheckBox();
            this.dOCUMENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.productidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oRDERDETAILBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.inOutInventoryidColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.detailBtn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.iNOUTINVENTORYDETAILBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iNOUT_INVENTORY_DETAILTableAdapter = new QuanLyBanHang.SellManagementDbDataSetTableAdapters.INOUT_INVENTORY_DETAILTableAdapter();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.totalProductLabel = new System.Windows.Forms.Label();
            this.totalOrderLabel = new System.Windows.Forms.Label();
            this.oRDER_DETAILTableAdapter = new QuanLyBanHang.SellManagementDbDataSetTableAdapters.ORDER_DETAILTableAdapter();
            this.pRODUCTTableAdapter = new QuanLyBanHang.SellManagementDbDataSetTableAdapters.PRODUCTTableAdapter();
            this.createBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.dOCUMENTTableAdapter = new QuanLyBanHang.SellManagementDbDataSetTableAdapters.DOCUMENTTableAdapter();
            this.addOrderBtn = new System.Windows.Forms.Button();
            this.removeOrderBtn = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.sTAFFTableAdapter = new QuanLyBanHang.SellManagementDbDataSetTableAdapters.STAFFTableAdapter();
            this.iNVENTORYTableAdapter = new QuanLyBanHang.SellManagementDbDataSetTableAdapters.INVENTORYTableAdapter();
            this.queriesTableAdapter = new QuanLyBanHang.SellManagementDbDataSetTableAdapters.QueriesTableAdapter();
            this.iNOUTINVENTORYTableAdapter = new QuanLyBanHang.SellManagementDbDataSetTableAdapters.INOUTINVENTORYTableAdapter();
            this.iNVENTORY_CAPABILITYTableAdapter = new QuanLyBanHang.SellManagementDbDataSetTableAdapters.INVENTORY_CAPABILITYTableAdapter();
            label1 = new System.Windows.Forms.Label();
            documentKeyLabel = new System.Windows.Forms.Label();
            creatorLabel = new System.Windows.Forms.Label();
            createDateLabel = new System.Windows.Forms.Label();
            respondLabel = new System.Windows.Forms.Label();
            carryFeeLabel = new System.Windows.Forms.Label();
            termLabel = new System.Windows.Forms.Label();
            inOutTypeLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellManagementDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVENTORYCAPABILITYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNOUTINVENTORYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVENTORYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentBindingSourceForEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTAFFBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTAFFBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.termNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCUMENTBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRDERDETAILBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNOUTINVENTORYDETAILBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(427, 138);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(30, 13);
            label1.TabIndex = 69;
            label1.Text = "VNĐ";
            // 
            // documentKeyLabel
            // 
            documentKeyLabel.AutoSize = true;
            documentKeyLabel.Location = new System.Drawing.Point(135, 28);
            documentKeyLabel.Name = "documentKeyLabel";
            documentKeyLabel.Size = new System.Drawing.Size(25, 13);
            documentKeyLabel.TabIndex = 55;
            documentKeyLabel.Text = "Mã ";
            // 
            // creatorLabel
            // 
            creatorLabel.AutoSize = true;
            creatorLabel.Location = new System.Drawing.Point(135, 54);
            creatorLabel.Name = "creatorLabel";
            creatorLabel.Size = new System.Drawing.Size(52, 13);
            creatorLabel.TabIndex = 57;
            creatorLabel.Text = "Người lập";
            // 
            // createDateLabel
            // 
            createDateLabel.AutoSize = true;
            createDateLabel.Location = new System.Drawing.Point(135, 82);
            createDateLabel.Name = "createDateLabel";
            createDateLabel.Size = new System.Drawing.Size(49, 13);
            createDateLabel.TabIndex = 59;
            createDateLabel.Text = "Ngày lập";
            // 
            // respondLabel
            // 
            respondLabel.AutoSize = true;
            respondLabel.Location = new System.Drawing.Point(135, 107);
            respondLabel.Name = "respondLabel";
            respondLabel.Size = new System.Drawing.Size(116, 13);
            respondLabel.TabIndex = 61;
            respondLabel.Text = "Người chịu trách nhiệm";
            // 
            // carryFeeLabel
            // 
            carryFeeLabel.AutoSize = true;
            carryFeeLabel.Location = new System.Drawing.Point(135, 138);
            carryFeeLabel.Name = "carryFeeLabel";
            carryFeeLabel.Size = new System.Drawing.Size(83, 13);
            carryFeeLabel.TabIndex = 63;
            carryFeeLabel.Text = "Phí vận chuyển";
            // 
            // termLabel
            // 
            termLabel.AutoSize = true;
            termLabel.Location = new System.Drawing.Point(135, 196);
            termLabel.Name = "termLabel";
            termLabel.Size = new System.Drawing.Size(19, 13);
            termLabel.TabIndex = 65;
            termLabel.Text = "Kỳ";
            termLabel.Visible = false;
            // 
            // inOutTypeLabel
            // 
            inOutTypeLabel.AutoSize = true;
            inOutTypeLabel.Location = new System.Drawing.Point(135, 168);
            inOutTypeLabel.Name = "inOutTypeLabel";
            inOutTypeLabel.Size = new System.Drawing.Size(26, 13);
            inOutTypeLabel.TabIndex = 67;
            inOutTypeLabel.Text = "Kho";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.inventoryComboBox);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(documentKeyLabel);
            this.groupBox1.Controls.Add(this.documentKeyTextBox);
            this.groupBox1.Controls.Add(creatorLabel);
            this.groupBox1.Controls.Add(this.creatorComboBox);
            this.groupBox1.Controls.Add(createDateLabel);
            this.groupBox1.Controls.Add(this.createDateDateTimePicker);
            this.groupBox1.Controls.Add(respondLabel);
            this.groupBox1.Controls.Add(this.respondComboBox);
            this.groupBox1.Controls.Add(carryFeeLabel);
            this.groupBox1.Controls.Add(this.carryFeeTextBox);
            this.groupBox1.Controls.Add(termLabel);
            this.groupBox1.Controls.Add(this.termNumericUpDown);
            this.groupBox1.Controls.Add(inOutTypeLabel);
            this.groupBox1.Controls.Add(this.isInCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(960, 232);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.dataGridView3);
            this.groupBox5.Location = new System.Drawing.Point(463, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(480, 196);
            this.groupBox5.TabIndex = 73;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Sức chứa";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productidDataGridViewTextBoxColumn1,
            this.maxCountDataGridViewTextBoxColumn,
            this.currentCountDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.iNVENTORYCAPABILITYBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(20, 19);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(445, 163);
            this.dataGridView3.TabIndex = 0;
            // 
            // productidDataGridViewTextBoxColumn1
            // 
            this.productidDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productidDataGridViewTextBoxColumn1.DataPropertyName = "Product_id";
            this.productidDataGridViewTextBoxColumn1.DataSource = this.pRODUCTBindingSource;
            this.productidDataGridViewTextBoxColumn1.DisplayMember = "Name";
            this.productidDataGridViewTextBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.productidDataGridViewTextBoxColumn1.HeaderText = "Sản phẩm";
            this.productidDataGridViewTextBoxColumn1.Name = "productidDataGridViewTextBoxColumn1";
            this.productidDataGridViewTextBoxColumn1.ReadOnly = true;
            this.productidDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.productidDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.productidDataGridViewTextBoxColumn1.ValueMember = "Id";
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
            // maxCountDataGridViewTextBoxColumn
            // 
            this.maxCountDataGridViewTextBoxColumn.DataPropertyName = "MaxCount";
            this.maxCountDataGridViewTextBoxColumn.HeaderText = "Số lượng tối đa";
            this.maxCountDataGridViewTextBoxColumn.Name = "maxCountDataGridViewTextBoxColumn";
            this.maxCountDataGridViewTextBoxColumn.ReadOnly = true;
            this.maxCountDataGridViewTextBoxColumn.Width = 150;
            // 
            // currentCountDataGridViewTextBoxColumn
            // 
            this.currentCountDataGridViewTextBoxColumn.DataPropertyName = "CurrentCount";
            this.currentCountDataGridViewTextBoxColumn.HeaderText = "Số lượng hiện tại";
            this.currentCountDataGridViewTextBoxColumn.Name = "currentCountDataGridViewTextBoxColumn";
            this.currentCountDataGridViewTextBoxColumn.ReadOnly = true;
            this.currentCountDataGridViewTextBoxColumn.Width = 150;
            // 
            // iNVENTORYCAPABILITYBindingSource
            // 
            this.iNVENTORYCAPABILITYBindingSource.DataMember = "INVENTORY_CAPABILITY";
            this.iNVENTORYCAPABILITYBindingSource.DataSource = this.sellManagementDbDataSet;
            // 
            // inventoryComboBox
            // 
            this.inventoryComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.iNOUTINVENTORYBindingSource, "Inventory_id", true));
            this.inventoryComboBox.DataSource = this.iNVENTORYBindingSource;
            this.inventoryComboBox.DisplayMember = "Name";
            this.inventoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inventoryComboBox.Enabled = false;
            this.inventoryComboBox.FormattingEnabled = true;
            this.inventoryComboBox.Location = new System.Drawing.Point(257, 162);
            this.inventoryComboBox.Name = "inventoryComboBox";
            this.inventoryComboBox.Size = new System.Drawing.Size(160, 21);
            this.inventoryComboBox.TabIndex = 72;
            this.inventoryComboBox.ValueMember = "Id";
            this.inventoryComboBox.TextChanged += new System.EventHandler(this.inventoryComboBox_TextChanged);
            // 
            // iNOUTINVENTORYBindingSource
            // 
            this.iNOUTINVENTORYBindingSource.DataMember = "INOUTINVENTORY";
            this.iNOUTINVENTORYBindingSource.DataSource = this.sellManagementDbDataSet;
            // 
            // iNVENTORYBindingSource
            // 
            this.iNVENTORYBindingSource.DataMember = "INVENTORY";
            this.iNVENTORYBindingSource.DataSource = this.sellManagementDbDataSet;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyBanHang.Properties.Resources.documents;
            this.pictureBox1.Location = new System.Drawing.Point(20, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 71;
            this.pictureBox1.TabStop = false;
            // 
            // documentKeyTextBox
            // 
            this.documentKeyTextBox.AutoSize = true;
            this.documentKeyTextBox.BackColor = System.Drawing.Color.White;
            this.documentKeyTextBox.BorderColor = System.Drawing.Color.Silver;
            this.documentKeyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.documentBindingSourceForEdit, "DocumentKey", true));
            this.documentKeyTextBox.ErrorBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.documentKeyTextBox.HoverBorderColor = System.Drawing.Color.Cyan;
            this.documentKeyTextBox.isRequired = true;
            this.documentKeyTextBox.Location = new System.Drawing.Point(257, 25);
            this.documentKeyTextBox.Multiline = false;
            this.documentKeyTextBox.Name = "documentKeyTextBox";
            this.documentKeyTextBox.NormalBorderColor = System.Drawing.Color.Silver;
            this.documentKeyTextBox.PanelBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.documentKeyTextBox.ReadOnly = true;
            this.documentKeyTextBox.Size = new System.Drawing.Size(200, 19);
            this.documentKeyTextBox.StringPattern = "[A-Za-z0-9.-]";
            this.documentKeyTextBox.TabIndex = 56;
            this.documentKeyTextBox.TextPadding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.documentKeyTextBox.TextPanelMessage = "This is an error message.";
            this.documentKeyTextBox.TextPanelMessageColor = System.Drawing.Color.White;
            this.documentKeyTextBox.ValidBorderColor = System.Drawing.Color.LightGreen;
            // 
            // documentBindingSourceForEdit
            // 
            this.documentBindingSourceForEdit.DataMember = "DOCUMENT";
            this.documentBindingSourceForEdit.DataSource = this.sellManagementDbDataSet;
            // 
            // creatorComboBox
            // 
            this.creatorComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.documentBindingSourceForEdit, "Creator", true));
            this.creatorComboBox.DataSource = this.sTAFFBindingSource;
            this.creatorComboBox.DisplayMember = "Name";
            this.creatorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.creatorComboBox.FormattingEnabled = true;
            this.creatorComboBox.Location = new System.Drawing.Point(257, 51);
            this.creatorComboBox.Name = "creatorComboBox";
            this.creatorComboBox.Size = new System.Drawing.Size(120, 21);
            this.creatorComboBox.TabIndex = 58;
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
            this.createDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.documentBindingSourceForEdit, "CreateDate", true));
            this.createDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.createDateDateTimePicker.Location = new System.Drawing.Point(257, 78);
            this.createDateDateTimePicker.MaxDate = new System.DateTime(2070, 12, 31, 0, 0, 0, 0);
            this.createDateDateTimePicker.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.createDateDateTimePicker.Name = "createDateDateTimePicker";
            this.createDateDateTimePicker.Size = new System.Drawing.Size(120, 20);
            this.createDateDateTimePicker.TabIndex = 60;
            // 
            // respondComboBox
            // 
            this.respondComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.iNOUTINVENTORYBindingSource, "Respond", true));
            this.respondComboBox.DataSource = this.sTAFFBindingSource1;
            this.respondComboBox.DisplayMember = "Name";
            this.respondComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.respondComboBox.FormattingEnabled = true;
            this.respondComboBox.Location = new System.Drawing.Point(257, 104);
            this.respondComboBox.Name = "respondComboBox";
            this.respondComboBox.Size = new System.Drawing.Size(120, 21);
            this.respondComboBox.TabIndex = 62;
            this.respondComboBox.ValueMember = "Id";
            // 
            // sTAFFBindingSource1
            // 
            this.sTAFFBindingSource1.DataMember = "STAFF";
            this.sTAFFBindingSource1.DataSource = this.sellManagementDbDataSet;
            // 
            // carryFeeTextBox
            // 
            this.carryFeeTextBox.AutoSize = true;
            this.carryFeeTextBox.BackColor = System.Drawing.Color.White;
            this.carryFeeTextBox.BorderColor = System.Drawing.Color.Silver;
            this.carryFeeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iNOUTINVENTORYBindingSource, "CarryFee", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.carryFeeTextBox.ErrorBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.carryFeeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carryFeeTextBox.HoverBorderColor = System.Drawing.Color.Cyan;
            this.carryFeeTextBox.isRequired = true;
            this.carryFeeTextBox.Location = new System.Drawing.Point(257, 131);
            this.carryFeeTextBox.Multiline = false;
            this.carryFeeTextBox.Name = "carryFeeTextBox";
            this.carryFeeTextBox.NormalBorderColor = System.Drawing.Color.Silver;
            this.carryFeeTextBox.PanelBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.carryFeeTextBox.ReadOnly = false;
            this.carryFeeTextBox.Size = new System.Drawing.Size(160, 25);
            this.carryFeeTextBox.StringPattern = "^[0-9,. ]{1,12}$";
            this.carryFeeTextBox.TabIndex = 64;
            this.carryFeeTextBox.TextPadding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.carryFeeTextBox.TextPanelMessage = "Giá trị nhập không hợp lệ.";
            this.carryFeeTextBox.TextPanelMessageColor = System.Drawing.Color.White;
            this.carryFeeTextBox.ValidBorderColor = System.Drawing.Color.LightGreen;
            this.carryFeeTextBox.xTextChanged += new System.EventHandler(this.carryFeeTextBox_xTextChanged);
            this.carryFeeTextBox.Leave += new System.EventHandler(this.carryFeeTextBox_Leave);
            // 
            // termNumericUpDown
            // 
            this.termNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.iNOUTINVENTORYBindingSource, "Term", true));
            this.termNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.termNumericUpDown.Location = new System.Drawing.Point(257, 189);
            this.termNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.termNumericUpDown.Name = "termNumericUpDown";
            this.termNumericUpDown.Size = new System.Drawing.Size(60, 26);
            this.termNumericUpDown.TabIndex = 66;
            this.termNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.termNumericUpDown.Visible = false;
            // 
            // isInCheckBox
            // 
            this.isInCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.isInCheckBox.BackColor = System.Drawing.Color.White;
            this.isInCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.iNOUTINVENTORYBindingSource, "Type", true));
            this.isInCheckBox.Enabled = false;
            this.isInCheckBox.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.isInCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.isInCheckBox.ForeColor = System.Drawing.Color.Black;
            this.isInCheckBox.Location = new System.Drawing.Point(20, 130);
            this.isInCheckBox.Name = "isInCheckBox";
            this.isInCheckBox.Size = new System.Drawing.Size(100, 26);
            this.isInCheckBox.TabIndex = 68;
            this.isInCheckBox.Text = "Xuất hàng";
            this.isInCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.isInCheckBox.UseVisualStyleBackColor = false;
            this.isInCheckBox.CheckedChanged += new System.EventHandler(this.inOutTypeCheckBox_CheckedChanged);
            // 
            // dOCUMENTBindingSource
            // 
            this.dOCUMENTBindingSource.DataMember = "DOCUMENT";
            this.dOCUMENTBindingSource.DataSource = this.sellManagementDbDataSet;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 265);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(155, 195);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách đơn hàng";
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(20, 25);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(112, 132);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.SizeChanged += new System.EventHandler(this.listBox1_SizeChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productidDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.oRDERDETAILBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(20, 25);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(273, 137);
            this.dataGridView2.TabIndex = 0;
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
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Số lượng";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oRDERDETAILBindingSource
            // 
            this.oRDERDETAILBindingSource.DataMember = "ORDER_DETAIL";
            this.oRDERDETAILBindingSource.DataSource = this.sellManagementDbDataSet;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.inOutInventoryidColumn,
            this.orderidDataGridViewTextBoxColumn,
            this.detailBtn});
            this.dataGridView1.DataSource = this.iNOUTINVENTORYDETAILBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(20, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(399, 137);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // inOutInventoryidColumn
            // 
            this.inOutInventoryidColumn.DataPropertyName = "InOutInventory_id";
            this.inOutInventoryidColumn.HeaderText = "InOutInventory_id";
            this.inOutInventoryidColumn.Name = "inOutInventoryidColumn";
            this.inOutInventoryidColumn.ReadOnly = true;
            this.inOutInventoryidColumn.Visible = false;
            // 
            // orderidDataGridViewTextBoxColumn
            // 
            this.orderidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.orderidDataGridViewTextBoxColumn.DataPropertyName = "Order_id";
            this.orderidDataGridViewTextBoxColumn.DataSource = this.dOCUMENTBindingSource;
            this.orderidDataGridViewTextBoxColumn.DisplayMember = "DocumentKey";
            this.orderidDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.orderidDataGridViewTextBoxColumn.HeaderText = "Đơn hàng";
            this.orderidDataGridViewTextBoxColumn.Name = "orderidDataGridViewTextBoxColumn";
            this.orderidDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.orderidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.orderidDataGridViewTextBoxColumn.ValueMember = "Id";
            // 
            // detailBtn
            // 
            this.detailBtn.HeaderText = "Chi tiết";
            this.detailBtn.Name = "detailBtn";
            this.detailBtn.ReadOnly = true;
            this.detailBtn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.detailBtn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // iNOUTINVENTORYDETAILBindingSource
            // 
            this.iNOUTINVENTORYDETAILBindingSource.DataMember = "INOUT_INVENTORY_DETAIL";
            this.iNOUTINVENTORYDETAILBindingSource.DataSource = this.sellManagementDbDataSet;
            this.iNOUTINVENTORYDETAILBindingSource.CurrentChanged += new System.EventHandler(this.iNOUTINVENTORYDETAILBindingSource_CurrentChanged);
            this.iNOUTINVENTORYDETAILBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.iNOUTINVENTORYDETAILBindingSource_ListChanged);
            // 
            // iNOUT_INVENTORY_DETAILTableAdapter
            // 
            this.iNOUT_INVENTORY_DETAILTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.totalProductLabel);
            this.groupBox3.Controls.Add(this.totalOrderLabel);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(220, 260);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(436, 200);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Đơn hàng được xuất/nhập";
            // 
            // totalProductLabel
            // 
            this.totalProductLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.totalProductLabel.AutoSize = true;
            this.totalProductLabel.Location = new System.Drawing.Point(250, 174);
            this.totalProductLabel.Name = "totalProductLabel";
            this.totalProductLabel.Size = new System.Drawing.Size(69, 13);
            this.totalProductLabel.TabIndex = 2;
            this.totalProductLabel.Text = "Số sản phẩm";
            this.totalProductLabel.Visible = false;
            // 
            // totalOrderLabel
            // 
            this.totalOrderLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.totalOrderLabel.AutoSize = true;
            this.totalOrderLabel.Location = new System.Drawing.Point(17, 174);
            this.totalOrderLabel.Name = "totalOrderLabel";
            this.totalOrderLabel.Size = new System.Drawing.Size(81, 13);
            this.totalOrderLabel.TabIndex = 1;
            this.totalOrderLabel.Text = "Số đơn hàng: 0";
            // 
            // oRDER_DETAILTableAdapter
            // 
            this.oRDER_DETAILTableAdapter.ClearBeforeFill = true;
            // 
            // pRODUCTTableAdapter
            // 
            this.pRODUCTTableAdapter.ClearBeforeFill = true;
            // 
            // createBtn
            // 
            this.createBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.createBtn.Enabled = false;
            this.createBtn.Image = global::QuanLyBanHang.Properties.Resources.success;
            this.createBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.createBtn.Location = new System.Drawing.Point(855, 470);
            this.createBtn.Name = "createBtn";
            this.createBtn.Padding = new System.Windows.Forms.Padding(10, 0, 15, 0);
            this.createBtn.Size = new System.Drawing.Size(100, 45);
            this.createBtn.TabIndex = 3;
            this.createBtn.Text = "Tạo";
            this.createBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBtn.Image = global::QuanLyBanHang.Properties.Resources.error;
            this.cancelBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelBtn.Location = new System.Drawing.Point(749, 470);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Padding = new System.Windows.Forms.Padding(10, 0, 15, 0);
            this.cancelBtn.Size = new System.Drawing.Size(100, 45);
            this.cancelBtn.TabIndex = 4;
            this.cancelBtn.Text = "Hủy";
            this.cancelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // dOCUMENTTableAdapter
            // 
            this.dOCUMENTTableAdapter.ClearBeforeFill = true;
            // 
            // addOrderBtn
            // 
            this.addOrderBtn.Enabled = false;
            this.addOrderBtn.Image = global::QuanLyBanHang.Properties.Resources.plus_32;
            this.addOrderBtn.Location = new System.Drawing.Point(173, 317);
            this.addOrderBtn.Name = "addOrderBtn";
            this.addOrderBtn.Size = new System.Drawing.Size(45, 45);
            this.addOrderBtn.TabIndex = 5;
            this.addOrderBtn.UseVisualStyleBackColor = true;
            this.addOrderBtn.Click += new System.EventHandler(this.addOrderBtn_Click);
            // 
            // removeOrderBtn
            // 
            this.removeOrderBtn.Enabled = false;
            this.removeOrderBtn.Image = global::QuanLyBanHang.Properties.Resources.minus_32;
            this.removeOrderBtn.Location = new System.Drawing.Point(173, 368);
            this.removeOrderBtn.Name = "removeOrderBtn";
            this.removeOrderBtn.Size = new System.Drawing.Size(45, 45);
            this.removeOrderBtn.TabIndex = 6;
            this.removeOrderBtn.UseVisualStyleBackColor = true;
            this.removeOrderBtn.Click += new System.EventHandler(this.removeOrderBtn_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.dataGridView2);
            this.groupBox4.Location = new System.Drawing.Point(662, 260);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(310, 200);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Mặt hàng";
            // 
            // sTAFFTableAdapter
            // 
            this.sTAFFTableAdapter.ClearBeforeFill = true;
            // 
            // iNVENTORYTableAdapter
            // 
            this.iNVENTORYTableAdapter.ClearBeforeFill = true;
            // 
            // iNOUTINVENTORYTableAdapter
            // 
            this.iNOUTINVENTORYTableAdapter.ClearBeforeFill = true;
            // 
            // iNVENTORY_CAPABILITYTableAdapter
            // 
            this.iNVENTORY_CAPABILITYTableAdapter.ClearBeforeFill = true;
            // 
            // AddInoutInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 526);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.removeOrderBtn);
            this.Controls.Add(this.addOrderBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(900, 565);
            this.Name = "AddInoutInventory";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đơn nhập xuất kho";
            this.Load += new System.EventHandler(this.AddInoutInventory_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellManagementDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVENTORYCAPABILITYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNOUTINVENTORYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVENTORYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentBindingSourceForEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTAFFBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTAFFBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.termNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCUMENTBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRDERDETAILBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNOUTINVENTORYDETAILBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private WindowsFormsControlLibrary.CustomTextBox documentKeyTextBox;
        private System.Windows.Forms.ComboBox creatorComboBox;
        private System.Windows.Forms.DateTimePicker createDateDateTimePicker;
        private System.Windows.Forms.ComboBox respondComboBox;
        private WindowsFormsControlLibrary.CustomTextBox carryFeeTextBox;
        private System.Windows.Forms.NumericUpDown termNumericUpDown;
        private System.Windows.Forms.CheckBox isInCheckBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SellManagementDbDataSet sellManagementDbDataSet;
        private System.Windows.Forms.BindingSource iNOUTINVENTORYDETAILBindingSource;
        private SellManagementDbDataSetTableAdapters.INOUT_INVENTORY_DETAILTableAdapter iNOUT_INVENTORY_DETAILTableAdapter;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource oRDERDETAILBindingSource;
        private SellManagementDbDataSetTableAdapters.ORDER_DETAILTableAdapter oRDER_DETAILTableAdapter;
        private System.Windows.Forms.BindingSource pRODUCTBindingSource;
        private SellManagementDbDataSetTableAdapters.PRODUCTTableAdapter pRODUCTTableAdapter;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.BindingSource dOCUMENTBindingSource;
        private SellManagementDbDataSetTableAdapters.DOCUMENTTableAdapter dOCUMENTTableAdapter;
        private System.Windows.Forms.Button addOrderBtn;
        private System.Windows.Forms.Button removeOrderBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn productidDataGridViewTextBoxColumn;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label totalProductLabel;
        private System.Windows.Forms.Label totalOrderLabel;
        private System.Windows.Forms.BindingSource sTAFFBindingSource;
        private SellManagementDbDataSetTableAdapters.STAFFTableAdapter sTAFFTableAdapter;
        private System.Windows.Forms.BindingSource sTAFFBindingSource1;
        private System.Windows.Forms.ComboBox inventoryComboBox;
        private System.Windows.Forms.BindingSource iNVENTORYBindingSource;
        private SellManagementDbDataSetTableAdapters.INVENTORYTableAdapter iNVENTORYTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn inOutInventoryidColumn;
        private System.Windows.Forms.DataGridViewLinkColumn detailBtn;
        private System.Windows.Forms.DataGridViewComboBoxColumn orderidDataGridViewTextBoxColumn;
        private SellManagementDbDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter;
        private System.Windows.Forms.BindingSource iNOUTINVENTORYBindingSource;
        private SellManagementDbDataSetTableAdapters.INOUTINVENTORYTableAdapter iNOUTINVENTORYTableAdapter;
        private System.Windows.Forms.BindingSource documentBindingSourceForEdit;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource iNVENTORYCAPABILITYBindingSource;
        private SellManagementDbDataSetTableAdapters.INVENTORY_CAPABILITYTableAdapter iNVENTORY_CAPABILITYTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn productidDataGridViewTextBoxColumn1;
    }
}