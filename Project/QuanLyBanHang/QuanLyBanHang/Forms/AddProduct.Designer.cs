namespace QuanLyBanHang.Forms
{
    partial class AddProduct
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
            System.Windows.Forms.Label productKeyLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label barCodeLabel;
            System.Windows.Forms.Label inPriceLabel;
            System.Windows.Forms.Label outPriceLabel;
            this.pRODUCTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sellManagementDbDataSet = new QuanLyBanHang.SellManagementDbDataSet();
            this.pRODUCTTableAdapter = new QuanLyBanHang.SellManagementDbDataSetTableAdapters.PRODUCTTableAdapter();
            this.tableAdapterManager = new QuanLyBanHang.SellManagementDbDataSetTableAdapters.TableAdapterManager();
            this.pRODUCT_METADATATableAdapter = new QuanLyBanHang.SellManagementDbDataSetTableAdapters.PRODUCT_METADATATableAdapter();
            this.pRODUCT_METADATABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pRODUCT_METADATADataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ptrbPicture = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddPicture = new System.Windows.Forms.Button();
            this.btnDeletePicture = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.tbOutPrice = new WindowsFormsControlLibrary.CustomTextBox();
            this.tbInPrice = new WindowsFormsControlLibrary.CustomTextBox();
            this.tbBarCode = new WindowsFormsControlLibrary.CustomTextBox();
            this.tbName = new WindowsFormsControlLibrary.CustomTextBox();
            this.tbProductKey = new WindowsFormsControlLibrary.CustomTextBox();
            productKeyLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            barCodeLabel = new System.Windows.Forms.Label();
            inPriceLabel = new System.Windows.Forms.Label();
            outPriceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellManagementDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCT_METADATABindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCT_METADATADataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptrbPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // productKeyLabel
            // 
            productKeyLabel.AutoSize = true;
            productKeyLabel.Location = new System.Drawing.Point(22, 21);
            productKeyLabel.Name = "productKeyLabel";
            productKeyLabel.Size = new System.Drawing.Size(71, 13);
            productKeyLabel.TabIndex = 3;
            productKeyLabel.Text = "Mã sản phẩm";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(22, 52);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(75, 13);
            nameLabel.TabIndex = 5;
            nameLabel.Text = "Tên sản phẩm";
            // 
            // barCodeLabel
            // 
            barCodeLabel.AutoSize = true;
            barCodeLabel.Location = new System.Drawing.Point(22, 83);
            barCodeLabel.Name = "barCodeLabel";
            barCodeLabel.Size = new System.Drawing.Size(49, 13);
            barCodeLabel.TabIndex = 7;
            barCodeLabel.Text = "Mã vạch";
            // 
            // inPriceLabel
            // 
            inPriceLabel.AutoSize = true;
            inPriceLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRODUCTBindingSource, "InPrice", true));
            inPriceLabel.Location = new System.Drawing.Point(22, 171);
            inPriceLabel.Name = "inPriceLabel";
            inPriceLabel.Size = new System.Drawing.Size(50, 13);
            inPriceLabel.TabIndex = 11;
            inPriceLabel.Text = "Giá nhập";
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
            // outPriceLabel
            // 
            outPriceLabel.AutoSize = true;
            outPriceLabel.Location = new System.Drawing.Point(22, 202);
            outPriceLabel.Name = "outPriceLabel";
            outPriceLabel.Size = new System.Drawing.Size(44, 13);
            outPriceLabel.TabIndex = 13;
            outPriceLabel.Text = "Giá bán";
            // 
            // pRODUCTTableAdapter
            // 
            this.pRODUCTTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.INVENTORYTableAdapter = null;
            this.tableAdapterManager.ORDER_DETAILTableAdapter = null;
            this.tableAdapterManager.ORDERTableAdapter = null;
            this.tableAdapterManager.PRODUCT_METADATATableAdapter = this.pRODUCT_METADATATableAdapter;
            this.tableAdapterManager.PRODUCTTableAdapter = this.pRODUCTTableAdapter;
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
            // pRODUCT_METADATATableAdapter
            // 
            this.pRODUCT_METADATATableAdapter.ClearBeforeFill = true;
            // 
            // pRODUCT_METADATABindingSource
            // 
            this.pRODUCT_METADATABindingSource.DataMember = "FK_PRODUCTMETADATA_PRODUCT";
            this.pRODUCT_METADATABindingSource.DataSource = this.pRODUCTBindingSource;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pRODUCT_METADATADataGridView);
            this.groupBox1.Location = new System.Drawing.Point(15, 240);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 227);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết sản phẩm";
            // 
            // pRODUCT_METADATADataGridView
            // 
            this.pRODUCT_METADATADataGridView.AutoGenerateColumns = false;
            this.pRODUCT_METADATADataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pRODUCT_METADATADataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.pRODUCT_METADATADataGridView.DataSource = this.pRODUCT_METADATABindingSource;
            this.pRODUCT_METADATADataGridView.Location = new System.Drawing.Point(7, 30);
            this.pRODUCT_METADATADataGridView.Name = "pRODUCT_METADATADataGridView";
            this.pRODUCT_METADATADataGridView.Size = new System.Drawing.Size(457, 185);
            this.pRODUCT_METADATADataGridView.TabIndex = 15;
            this.pRODUCT_METADATADataGridView.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.pRODUCT_METADATADataGridView_UserAddedRow);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Key";
            this.dataGridViewTextBoxColumn3.HeaderText = "Khóa";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Value";
            this.dataGridViewTextBoxColumn4.HeaderText = "Giá trị";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 250;
            // 
            // ptrbPicture
            // 
            this.ptrbPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptrbPicture.DataBindings.Add(new System.Windows.Forms.Binding("ImageLocation", this.pRODUCTBindingSource, "Picture", true));
            this.ptrbPicture.Location = new System.Drawing.Point(315, 18);
            this.ptrbPicture.Name = "ptrbPicture";
            this.ptrbPicture.Size = new System.Drawing.Size(170, 170);
            this.ptrbPicture.TabIndex = 16;
            this.ptrbPicture.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(277, 473);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 27);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(391, 473);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 27);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddPicture
            // 
            this.btnAddPicture.Location = new System.Drawing.Point(315, 194);
            this.btnAddPicture.Name = "btnAddPicture";
            this.btnAddPicture.Size = new System.Drawing.Size(75, 23);
            this.btnAddPicture.TabIndex = 19;
            this.btnAddPicture.Text = "Chọn";
            this.btnAddPicture.UseVisualStyleBackColor = true;
            this.btnAddPicture.Click += new System.EventHandler(this.btnAddPicture_Click);
            // 
            // btnDeletePicture
            // 
            this.btnDeletePicture.Location = new System.Drawing.Point(411, 194);
            this.btnDeletePicture.Name = "btnDeletePicture";
            this.btnDeletePicture.Size = new System.Drawing.Size(75, 23);
            this.btnDeletePicture.TabIndex = 20;
            this.btnDeletePicture.Text = "Xóa";
            this.btnDeletePicture.UseVisualStyleBackColor = true;
            this.btnDeletePicture.Click += new System.EventHandler(this.btnDeletePicture_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(18, 473);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(75, 27);
            this.btnHelp.TabIndex = 21;
            this.btnHelp.Text = "Trợ giúp";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(208, 109);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(84, 19);
            this.button6.TabIndex = 27;
            this.button6.Text = "Quét mã";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // tbOutPrice
            // 
            this.tbOutPrice.AutoSize = true;
            this.tbOutPrice.BackColor = System.Drawing.Color.White;
            this.tbOutPrice.BorderColor = System.Drawing.Color.Silver;
            this.tbOutPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRODUCTBindingSource, "OutPrice", true));
            this.tbOutPrice.ErrorBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.tbOutPrice.HoverBorderColor = System.Drawing.Color.Cyan;
            this.tbOutPrice.isRequired = true;
            this.tbOutPrice.Location = new System.Drawing.Point(108, 196);
            this.tbOutPrice.Multiline = false;
            this.tbOutPrice.Name = "tbOutPrice";
            this.tbOutPrice.NormalBorderColor = System.Drawing.Color.Silver;
            this.tbOutPrice.PanelBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.tbOutPrice.ReadOnly = false;
            this.tbOutPrice.Size = new System.Drawing.Size(184, 19);
            this.tbOutPrice.StringPattern = "^([ẮẰẲẴẶĂẤẦẨẪẬÂÁÀÃẢẠĐẾỀỂỄỆÊÉÈẺẼẸÍÌỈĨỊỐỒỔỖỘÔỚỜỞỠỢƠÓÒÕỎỌỨỪỬỮỰƯÚÙỦŨỤÝỲỶỸỴA-Za-z0-9 ]" +
    ")*$";
            this.tbOutPrice.TabIndex = 26;
            this.tbOutPrice.TextPadding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.tbOutPrice.TextPanelMessage = "This is an error message.";
            this.tbOutPrice.TextPanelMessageColor = System.Drawing.Color.White;
            this.tbOutPrice.ValidBorderColor = System.Drawing.Color.LightGreen;
            // 
            // tbInPrice
            // 
            this.tbInPrice.AutoSize = true;
            this.tbInPrice.BackColor = System.Drawing.Color.White;
            this.tbInPrice.BorderColor = System.Drawing.Color.Silver;
            this.tbInPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRODUCTBindingSource, "InPrice", true));
            this.tbInPrice.ErrorBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.tbInPrice.HoverBorderColor = System.Drawing.Color.Cyan;
            this.tbInPrice.isRequired = true;
            this.tbInPrice.Location = new System.Drawing.Point(108, 165);
            this.tbInPrice.Multiline = false;
            this.tbInPrice.Name = "tbInPrice";
            this.tbInPrice.NormalBorderColor = System.Drawing.Color.Silver;
            this.tbInPrice.PanelBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.tbInPrice.ReadOnly = false;
            this.tbInPrice.Size = new System.Drawing.Size(184, 19);
            this.tbInPrice.StringPattern = "^([ẮẰẲẴẶĂẤẦẨẪẬÂÁÀÃẢẠĐẾỀỂỄỆÊÉÈẺẼẸÍÌỈĨỊỐỒỔỖỘÔỚỜỞỠỢƠÓÒÕỎỌỨỪỬỮỰƯÚÙỦŨỤÝỲỶỸỴA-Za-z0-9 ]" +
    ")*$";
            this.tbInPrice.TabIndex = 25;
            this.tbInPrice.TextPadding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.tbInPrice.TextPanelMessage = "This is an error message.";
            this.tbInPrice.TextPanelMessageColor = System.Drawing.Color.White;
            this.tbInPrice.ValidBorderColor = System.Drawing.Color.LightGreen;
            // 
            // tbBarCode
            // 
            this.tbBarCode.AutoSize = true;
            this.tbBarCode.BackColor = System.Drawing.Color.White;
            this.tbBarCode.BorderColor = System.Drawing.Color.Silver;
            this.tbBarCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRODUCTBindingSource, "BarCode", true));
            this.tbBarCode.ErrorBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.tbBarCode.HoverBorderColor = System.Drawing.Color.Cyan;
            this.tbBarCode.isRequired = true;
            this.tbBarCode.Location = new System.Drawing.Point(25, 109);
            this.tbBarCode.Multiline = false;
            this.tbBarCode.Name = "tbBarCode";
            this.tbBarCode.NormalBorderColor = System.Drawing.Color.Silver;
            this.tbBarCode.PanelBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.tbBarCode.ReadOnly = false;
            this.tbBarCode.Size = new System.Drawing.Size(177, 19);
            this.tbBarCode.StringPattern = "^([ẮẰẲẴẶĂẤẦẨẪẬÂÁÀÃẢẠĐẾỀỂỄỆÊÉÈẺẼẸÍÌỈĨỊỐỒỔỖỘÔỚỜỞỠỢƠÓÒÕỎỌỨỪỬỮỰƯÚÙỦŨỤÝỲỶỸỴA-Za-z0-9 ]" +
    ")*$";
            this.tbBarCode.TabIndex = 24;
            this.tbBarCode.TextPadding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.tbBarCode.TextPanelMessage = "This is an error message.";
            this.tbBarCode.TextPanelMessageColor = System.Drawing.Color.White;
            this.tbBarCode.ValidBorderColor = System.Drawing.Color.LightGreen;
            // 
            // tbName
            // 
            this.tbName.AutoSize = true;
            this.tbName.BackColor = System.Drawing.Color.White;
            this.tbName.BorderColor = System.Drawing.Color.Silver;
            this.tbName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRODUCTBindingSource, "Name", true));
            this.tbName.ErrorBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.tbName.HoverBorderColor = System.Drawing.Color.Cyan;
            this.tbName.isRequired = true;
            this.tbName.Location = new System.Drawing.Point(108, 46);
            this.tbName.Multiline = false;
            this.tbName.Name = "tbName";
            this.tbName.NormalBorderColor = System.Drawing.Color.Silver;
            this.tbName.PanelBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.tbName.ReadOnly = false;
            this.tbName.Size = new System.Drawing.Size(184, 19);
            this.tbName.StringPattern = "^([ẮẰẲẴẶĂẤẦẨẪẬÂÁÀÃẢẠĐẾỀỂỄỆÊÉÈẺẼẸÍÌỈĨỊỐỒỔỖỘÔỚỜỞỠỢƠÓÒÕỎỌỨỪỬỮỰƯÚÙỦŨỤÝỲỶỸỴA-Za-z0-9 ]" +
    ")*$";
            this.tbName.TabIndex = 23;
            this.tbName.TextPadding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.tbName.TextPanelMessage = "This is an error message.";
            this.tbName.TextPanelMessageColor = System.Drawing.Color.White;
            this.tbName.ValidBorderColor = System.Drawing.Color.LightGreen;
            // 
            // tbProductKey
            // 
            this.tbProductKey.AutoSize = true;
            this.tbProductKey.BackColor = System.Drawing.Color.White;
            this.tbProductKey.BorderColor = System.Drawing.Color.Silver;
            this.tbProductKey.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRODUCTBindingSource, "ProductKey", true));
            this.tbProductKey.ErrorBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.tbProductKey.HoverBorderColor = System.Drawing.Color.Cyan;
            this.tbProductKey.isRequired = true;
            this.tbProductKey.Location = new System.Drawing.Point(108, 15);
            this.tbProductKey.Multiline = false;
            this.tbProductKey.Name = "tbProductKey";
            this.tbProductKey.NormalBorderColor = System.Drawing.Color.Silver;
            this.tbProductKey.PanelBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.tbProductKey.ReadOnly = false;
            this.tbProductKey.Size = new System.Drawing.Size(184, 19);
            this.tbProductKey.StringPattern = "^([ẮẰẲẴẶĂẤẦẨẪẬÂÁÀÃẢẠĐẾỀỂỄỆÊÉÈẺẼẸÍÌỈĨỊỐỒỔỖỘÔỚỜỞỠỢƠÓÒÕỎỌỨỪỬỮỰƯÚÙỦŨỤÝỲỶỸỴA-Za-z0-9 ]" +
    ")*$";
            this.tbProductKey.TabIndex = 22;
            this.tbProductKey.TextPadding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.tbProductKey.TextPanelMessage = "This is an error message.";
            this.tbProductKey.TextPanelMessageColor = System.Drawing.Color.White;
            this.tbProductKey.ValidBorderColor = System.Drawing.Color.LightGreen;
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 513);
            this.ControlBox = false;
            this.Controls.Add(this.button6);
            this.Controls.Add(this.tbOutPrice);
            this.Controls.Add(this.tbInPrice);
            this.Controls.Add(this.tbBarCode);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbProductKey);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnDeletePicture);
            this.Controls.Add(this.btnAddPicture);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.ptrbPicture);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(productKeyLabel);
            this.Controls.Add(nameLabel);
            this.Controls.Add(barCodeLabel);
            this.Controls.Add(inPriceLabel);
            this.Controls.Add(outPriceLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddProduct";
            this.Text = "Thêm sản phẩm";
            this.Load += new System.EventHandler(this.AddProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellManagementDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCT_METADATABindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCT_METADATADataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptrbPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SellManagementDbDataSet sellManagementDbDataSet;
        private System.Windows.Forms.BindingSource pRODUCTBindingSource;
        private SellManagementDbDataSetTableAdapters.PRODUCTTableAdapter pRODUCTTableAdapter;
        private SellManagementDbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private SellManagementDbDataSetTableAdapters.PRODUCT_METADATATableAdapter pRODUCT_METADATATableAdapter;
        private System.Windows.Forms.BindingSource pRODUCT_METADATABindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox ptrbPicture;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddPicture;
        private System.Windows.Forms.Button btnDeletePicture;
        private System.Windows.Forms.Button btnHelp;
        private WindowsFormsControlLibrary.CustomTextBox tbProductKey;
        private WindowsFormsControlLibrary.CustomTextBox tbName;
        private WindowsFormsControlLibrary.CustomTextBox tbBarCode;
        private WindowsFormsControlLibrary.CustomTextBox tbInPrice;
        private WindowsFormsControlLibrary.CustomTextBox tbOutPrice;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView pRODUCT_METADATADataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}