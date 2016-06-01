namespace QuanLyBanHang.Forms
{
    partial class InOutInventory
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
            System.Windows.Forms.Label inOutTypeLabel;
            System.Windows.Forms.Label termLabel;
            System.Windows.Forms.Label carryFeeLabel;
            System.Windows.Forms.Label respondLabel;
            System.Windows.Forms.Label createDateLabel;
            System.Windows.Forms.Label creatorLabel;
            System.Windows.Forms.Label documentKeyLabel;
            this.sellManagementDbDataSet = new QuanLyBanHang.SellManagementDbDataSet();
            this.inOut_Inventory_ViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inOut_Inventory_ViewTableAdapter = new QuanLyBanHang.SellManagementDbDataSetTableAdapters.InOut_Inventory_ViewTableAdapter();
            this.tableAdapterManager = new QuanLyBanHang.SellManagementDbDataSetTableAdapters.TableAdapterManager();
            this.inOut_Inventory_ViewDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Creator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staff_bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventory_bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sTAFFTableAdapter = new QuanLyBanHang.SellManagementDbDataSetTableAdapters.STAFFTableAdapter();
            this.iNVENTORYTableAdapter = new QuanLyBanHang.SellManagementDbDataSetTableAdapters.INVENTORYTableAdapter();
            this.inOutTypeCheckBox = new System.Windows.Forms.CheckBox();
            this.termNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.carryFeeTextBox = new System.Windows.Forms.TextBox();
            this.respondComboBox = new System.Windows.Forms.ComboBox();
            this.createDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.creatorComboBox = new System.Windows.Forms.ComboBox();
            this.documentKeyTextBox = new System.Windows.Forms.TextBox();
            this.fKINOUTINVENTORYSTAFFBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iNOUTINVENTORYTableAdapter = new QuanLyBanHang.SellManagementDbDataSetTableAdapters.INOUTINVENTORYTableAdapter();
            inOutTypeLabel = new System.Windows.Forms.Label();
            termLabel = new System.Windows.Forms.Label();
            carryFeeLabel = new System.Windows.Forms.Label();
            respondLabel = new System.Windows.Forms.Label();
            createDateLabel = new System.Windows.Forms.Label();
            creatorLabel = new System.Windows.Forms.Label();
            documentKeyLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sellManagementDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inOut_Inventory_ViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inOut_Inventory_ViewDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staff_bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventory_bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.termNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKINOUTINVENTORYSTAFFBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // inOutTypeLabel
            // 
            inOutTypeLabel.AutoSize = true;
            inOutTypeLabel.Location = new System.Drawing.Point(488, 216);
            inOutTypeLabel.Name = "inOutTypeLabel";
            inOutTypeLabel.Size = new System.Drawing.Size(66, 13);
            inOutTypeLabel.TabIndex = 35;
            inOutTypeLabel.Text = "In Out Type:";
            // 
            // termLabel
            // 
            termLabel.AutoSize = true;
            termLabel.Location = new System.Drawing.Point(488, 185);
            termLabel.Name = "termLabel";
            termLabel.Size = new System.Drawing.Size(34, 13);
            termLabel.TabIndex = 33;
            termLabel.Text = "Term:";
            // 
            // carryFeeLabel
            // 
            carryFeeLabel.AutoSize = true;
            carryFeeLabel.Location = new System.Drawing.Point(488, 162);
            carryFeeLabel.Name = "carryFeeLabel";
            carryFeeLabel.Size = new System.Drawing.Size(55, 13);
            carryFeeLabel.TabIndex = 31;
            carryFeeLabel.Text = "Carry Fee:";
            // 
            // respondLabel
            // 
            respondLabel.AutoSize = true;
            respondLabel.Location = new System.Drawing.Point(488, 135);
            respondLabel.Name = "respondLabel";
            respondLabel.Size = new System.Drawing.Size(53, 13);
            respondLabel.TabIndex = 29;
            respondLabel.Text = "Respond:";
            // 
            // createDateLabel
            // 
            createDateLabel.AutoSize = true;
            createDateLabel.Location = new System.Drawing.Point(488, 110);
            createDateLabel.Name = "createDateLabel";
            createDateLabel.Size = new System.Drawing.Size(67, 13);
            createDateLabel.TabIndex = 25;
            createDateLabel.Text = "Create Date:";
            // 
            // creatorLabel
            // 
            creatorLabel.AutoSize = true;
            creatorLabel.Location = new System.Drawing.Point(488, 82);
            creatorLabel.Name = "creatorLabel";
            creatorLabel.Size = new System.Drawing.Size(44, 13);
            creatorLabel.TabIndex = 23;
            creatorLabel.Text = "Creator:";
            // 
            // documentKeyLabel
            // 
            documentKeyLabel.AutoSize = true;
            documentKeyLabel.Location = new System.Drawing.Point(488, 56);
            documentKeyLabel.Name = "documentKeyLabel";
            documentKeyLabel.Size = new System.Drawing.Size(80, 13);
            documentKeyLabel.TabIndex = 21;
            documentKeyLabel.Text = "Document Key:";
            // 
            // sellManagementDbDataSet
            // 
            this.sellManagementDbDataSet.DataSetName = "SellManagementDbDataSet";
            this.sellManagementDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inOut_Inventory_ViewBindingSource
            // 
            this.inOut_Inventory_ViewBindingSource.DataMember = "InOut_Inventory_View";
            this.inOut_Inventory_ViewBindingSource.DataSource = this.sellManagementDbDataSet;
            // 
            // inOut_Inventory_ViewTableAdapter
            // 
            this.inOut_Inventory_ViewTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BILLTableAdapter = null;
            this.tableAdapterManager.Connection = null;
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
            this.tableAdapterManager.INVENTORYTableAdapter = null;
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
            // inOut_Inventory_ViewDataGridView
            // 
            this.inOut_Inventory_ViewDataGridView.AutoGenerateColumns = false;
            this.inOut_Inventory_ViewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inOut_Inventory_ViewDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.Creator,
            this.dataGridViewTextBoxColumn5,
            this.Column1});
            this.inOut_Inventory_ViewDataGridView.DataSource = this.inOut_Inventory_ViewBindingSource;
            this.inOut_Inventory_ViewDataGridView.Location = new System.Drawing.Point(3, 41);
            this.inOut_Inventory_ViewDataGridView.Name = "inOut_Inventory_ViewDataGridView";
            this.inOut_Inventory_ViewDataGridView.ReadOnly = true;
            this.inOut_Inventory_ViewDataGridView.Size = new System.Drawing.Size(445, 255);
            this.inOut_Inventory_ViewDataGridView.TabIndex = 21;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DocumentKey";
            this.dataGridViewTextBoxColumn2.HeaderText = "Mã đơn";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Creator
            // 
            this.Creator.DataPropertyName = "CreatorName";
            this.Creator.HeaderText = "Người lập";
            this.Creator.Name = "Creator";
            this.Creator.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CreateDate";
            this.dataGridViewTextBoxColumn5.HeaderText = "Ngày lập";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "InventoryName";
            this.Column1.HeaderText = "Tên kho hàng";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // staff_bindingSource
            // 
            this.staff_bindingSource.DataMember = "STAFF";
            this.staff_bindingSource.DataSource = this.sellManagementDbDataSet;
            this.staff_bindingSource.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // inventory_bindingSource
            // 
            this.inventory_bindingSource.DataMember = "INVENTORY";
            this.inventory_bindingSource.DataSource = this.sellManagementDbDataSet;
            // 
            // sTAFFTableAdapter
            // 
            this.sTAFFTableAdapter.ClearBeforeFill = true;
            // 
            // iNVENTORYTableAdapter
            // 
            this.iNVENTORYTableAdapter.ClearBeforeFill = true;
            // 
            // inOutTypeCheckBox
            // 
            this.inOutTypeCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.inOutTypeCheckBox.BackColor = System.Drawing.Color.White;
            this.inOutTypeCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.inOut_Inventory_ViewBindingSource, "InOutType", true));
            this.inOutTypeCheckBox.ForeColor = System.Drawing.Color.Black;
            this.inOutTypeCheckBox.Location = new System.Drawing.Point(574, 211);
            this.inOutTypeCheckBox.Name = "inOutTypeCheckBox";
            this.inOutTypeCheckBox.Size = new System.Drawing.Size(200, 24);
            this.inOutTypeCheckBox.TabIndex = 36;
            this.inOutTypeCheckBox.Text = "Nhập hàng";
            this.inOutTypeCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.inOutTypeCheckBox.UseVisualStyleBackColor = false;
            this.inOutTypeCheckBox.CheckedChanged += new System.EventHandler(this.inOutTypeCheckBox_CheckedChanged);
            // 
            // termNumericUpDown
            // 
            this.termNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.inOut_Inventory_ViewBindingSource, "Term", true));
            this.termNumericUpDown.Location = new System.Drawing.Point(574, 185);
            this.termNumericUpDown.Name = "termNumericUpDown";
            this.termNumericUpDown.Size = new System.Drawing.Size(200, 20);
            this.termNumericUpDown.TabIndex = 34;
            // 
            // carryFeeTextBox
            // 
            this.carryFeeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inOut_Inventory_ViewBindingSource, "CarryFee", true));
            this.carryFeeTextBox.Location = new System.Drawing.Point(574, 159);
            this.carryFeeTextBox.Name = "carryFeeTextBox";
            this.carryFeeTextBox.Size = new System.Drawing.Size(200, 20);
            this.carryFeeTextBox.TabIndex = 32;
            // 
            // respondComboBox
            // 
            this.respondComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inOut_Inventory_ViewBindingSource, "RespondName", true));
            this.respondComboBox.DataSource = this.staff_bindingSource;
            this.respondComboBox.DisplayMember = "Name";
            this.respondComboBox.FormattingEnabled = true;
            this.respondComboBox.Location = new System.Drawing.Point(574, 132);
            this.respondComboBox.Name = "respondComboBox";
            this.respondComboBox.Size = new System.Drawing.Size(200, 21);
            this.respondComboBox.TabIndex = 30;
            this.respondComboBox.ValueMember = "Id";
            // 
            // createDateDateTimePicker
            // 
            this.createDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.inOut_Inventory_ViewBindingSource, "CreateDate", true));
            this.createDateDateTimePicker.Location = new System.Drawing.Point(574, 106);
            this.createDateDateTimePicker.Name = "createDateDateTimePicker";
            this.createDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.createDateDateTimePicker.TabIndex = 26;
            // 
            // creatorComboBox
            // 
            this.creatorComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inOut_Inventory_ViewBindingSource, "CreatorName", true));
            this.creatorComboBox.DataSource = this.staff_bindingSource;
            this.creatorComboBox.DisplayMember = "Name";
            this.creatorComboBox.FormattingEnabled = true;
            this.creatorComboBox.Location = new System.Drawing.Point(574, 79);
            this.creatorComboBox.Name = "creatorComboBox";
            this.creatorComboBox.Size = new System.Drawing.Size(200, 21);
            this.creatorComboBox.TabIndex = 24;
            this.creatorComboBox.ValueMember = "Id";
            // 
            // documentKeyTextBox
            // 
            this.documentKeyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inOut_Inventory_ViewBindingSource, "DocumentKey", true));
            this.documentKeyTextBox.Location = new System.Drawing.Point(574, 53);
            this.documentKeyTextBox.Name = "documentKeyTextBox";
            this.documentKeyTextBox.Size = new System.Drawing.Size(200, 20);
            this.documentKeyTextBox.TabIndex = 22;
            // 
            // fKINOUTINVENTORYSTAFFBindingSource
            // 
            this.fKINOUTINVENTORYSTAFFBindingSource.DataMember = "FK_INOUTINVENTORY_STAFF";
            this.fKINOUTINVENTORYSTAFFBindingSource.DataSource = this.staff_bindingSource;
            // 
            // iNOUTINVENTORYTableAdapter
            // 
            this.iNOUTINVENTORYTableAdapter.ClearBeforeFill = true;
            // 
            // InOutInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(documentKeyLabel);
            this.Controls.Add(this.documentKeyTextBox);
            this.Controls.Add(creatorLabel);
            this.Controls.Add(this.creatorComboBox);
            this.Controls.Add(createDateLabel);
            this.Controls.Add(this.createDateDateTimePicker);
            this.Controls.Add(respondLabel);
            this.Controls.Add(this.respondComboBox);
            this.Controls.Add(carryFeeLabel);
            this.Controls.Add(this.carryFeeTextBox);
            this.Controls.Add(termLabel);
            this.Controls.Add(this.termNumericUpDown);
            this.Controls.Add(inOutTypeLabel);
            this.Controls.Add(this.inOutTypeCheckBox);
            this.Controls.Add(this.inOut_Inventory_ViewDataGridView);
            this.Name = "InOutInventory";
            this.Size = new System.Drawing.Size(854, 585);
            this.Load += new System.EventHandler(this.InOutInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sellManagementDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inOut_Inventory_ViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inOut_Inventory_ViewDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staff_bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventory_bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.termNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKINOUTINVENTORYSTAFFBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SellManagementDbDataSet sellManagementDbDataSet;
        private System.Windows.Forms.BindingSource inOut_Inventory_ViewBindingSource;
        private SellManagementDbDataSetTableAdapters.InOut_Inventory_ViewTableAdapter inOut_Inventory_ViewTableAdapter;
        private SellManagementDbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView inOut_Inventory_ViewDataGridView;
        private System.Windows.Forms.BindingSource staff_bindingSource;
        private System.Windows.Forms.BindingSource inventory_bindingSource;
        private SellManagementDbDataSetTableAdapters.STAFFTableAdapter sTAFFTableAdapter;
        private SellManagementDbDataSetTableAdapters.INVENTORYTableAdapter iNVENTORYTableAdapter;
        private System.Windows.Forms.CheckBox inOutTypeCheckBox;
        private System.Windows.Forms.NumericUpDown termNumericUpDown;
        private System.Windows.Forms.TextBox carryFeeTextBox;
        private System.Windows.Forms.ComboBox respondComboBox;
        private System.Windows.Forms.DateTimePicker createDateDateTimePicker;
        private System.Windows.Forms.ComboBox creatorComboBox;
        private System.Windows.Forms.TextBox documentKeyTextBox;
        private System.Windows.Forms.BindingSource fKINOUTINVENTORYSTAFFBindingSource;
        private SellManagementDbDataSetTableAdapters.INOUTINVENTORYTableAdapter iNOUTINVENTORYTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Creator;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;

    }
}
