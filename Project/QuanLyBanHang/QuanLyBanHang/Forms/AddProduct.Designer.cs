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
            this.pRODUCTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sellManagementDbDataSet = new QuanLyBanHang.SellManagementDbDataSet();
            this.pRODUCTTableAdapter = new QuanLyBanHang.SellManagementDbDataSetTableAdapters.PRODUCTTableAdapter();
            this.tableAdapterManager = new QuanLyBanHang.SellManagementDbDataSetTableAdapters.TableAdapterManager();
            this.pRODUCT_METADATATableAdapter = new QuanLyBanHang.SellManagementDbDataSetTableAdapters.PRODUCT_METADATATableAdapter();
            this.pRODUCT_METADATABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ptrbPicture = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddPicture = new System.Windows.Forms.Button();
            this.btnDeletePicture = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbInPrice = new WindowsFormsControlLibrary.CustomTextBox();
            this.tbOutPrice = new WindowsFormsControlLibrary.CustomTextBox();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.brandComboBox = new System.Windows.Forms.ComboBox();
            this.unitComboBox = new System.Windows.Forms.ComboBox();
            this.productKeyText = new System.Windows.Forms.TextBox();
            this.tbBarCode = new WindowsFormsControlLibrary.CustomTextBox();
            this.tbName = new WindowsFormsControlLibrary.CustomTextBox();
            this.constantTableAdapter = new QuanLyBanHang.SellManagementDbDataSetTableAdapters.CONSTANTTableAdapter();
            productKeyLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            barCodeLabel = new System.Windows.Forms.Label();
            inPriceLabel = new System.Windows.Forms.Label();
            outPriceLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            interestRateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellManagementDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCT_METADATABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptrbPicture)).BeginInit();
            this.groupBox2.SuspendLayout();
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
            nameLabel.Location = new System.Drawing.Point(21, 116);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(75, 13);
            nameLabel.TabIndex = 5;
            nameLabel.Text = "Tên sản phẩm";
            // 
            // barCodeLabel
            // 
            barCodeLabel.AutoSize = true;
            barCodeLabel.Location = new System.Drawing.Point(22, 46);
            barCodeLabel.Name = "barCodeLabel";
            barCodeLabel.Size = new System.Drawing.Size(49, 13);
            barCodeLabel.TabIndex = 7;
            barCodeLabel.Text = "Mã vạch";
            // 
            // inPriceLabel
            // 
            inPriceLabel.AutoSize = true;
            inPriceLabel.Location = new System.Drawing.Point(28, 31);
            inPriceLabel.Name = "inPriceLabel";
            inPriceLabel.Size = new System.Drawing.Size(50, 13);
            inPriceLabel.TabIndex = 11;
            inPriceLabel.Text = "Giá nhập";
            // 
            // outPriceLabel
            // 
            outPriceLabel.AutoSize = true;
            outPriceLabel.Location = new System.Drawing.Point(28, 82);
            outPriceLabel.Name = "outPriceLabel";
            outPriceLabel.Size = new System.Drawing.Size(44, 13);
            outPriceLabel.TabIndex = 13;
            outPriceLabel.Text = "Giá bán";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(393, 31);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(30, 13);
            label1.TabIndex = 28;
            label1.Text = "VNĐ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(393, 82);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(30, 13);
            label2.TabIndex = 29;
            label2.Text = "VNĐ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(22, 144);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(27, 13);
            label3.TabIndex = 32;
            label3.Text = "Loại";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(22, 171);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(33, 13);
            label4.TabIndex = 34;
            label4.Text = "Hãng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(22, 198);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(38, 13);
            label5.TabIndex = 36;
            label5.Text = "Đơn vị";
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
            // pRODUCTTableAdapter
            // 
            this.pRODUCTTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BILLTableAdapter = null;
            this.tableAdapterManager.BusinessFeeTableAdapter = null;
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
            this.tableAdapterManager.InvenFeeTableAdapter = null;
            this.tableAdapterManager.INVENTORY_CAPABILITYTableAdapter = null;
            this.tableAdapterManager.INVENTORYTableAdapter = null;
            this.tableAdapterManager.ORDER_DETAILTableAdapter = null;
            this.tableAdapterManager.ORDERTableAdapter = null;
            this.tableAdapterManager.PRODUCT_METADATATableAdapter = this.pRODUCT_METADATATableAdapter;
            this.tableAdapterManager.PRODUCTTableAdapter = this.pRODUCTTableAdapter;
            this.tableAdapterManager.PURCHASE_ORDERTableAdapter = null;
            this.tableAdapterManager.QUOTE_DETAILTableAdapter = null;
            this.tableAdapterManager.QUOTETableAdapter = null;
            this.tableAdapterManager.StaffFeeTableAdapter = null;
            this.tableAdapterManager.STAFFTableAdapter = null;
            this.tableAdapterManager.TranferFeeTableAdapter = null;
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
            // ptrbPicture
            // 
            this.ptrbPicture.BackgroundImage = global::QuanLyBanHang.Properties.Resources.box_3;
            this.ptrbPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptrbPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptrbPicture.DataBindings.Add(new System.Windows.Forms.Binding("ImageLocation", this.pRODUCTBindingSource, "Picture", true));
            this.ptrbPicture.ErrorImage = null;
            this.ptrbPicture.Location = new System.Drawing.Point(315, 18);
            this.ptrbPicture.Name = "ptrbPicture";
            this.ptrbPicture.Size = new System.Drawing.Size(170, 170);
            this.ptrbPicture.TabIndex = 16;
            this.ptrbPicture.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(410, 368);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 27);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(315, 368);
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
            this.btnHelp.Location = new System.Drawing.Point(15, 368);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(75, 27);
            this.btnHelp.TabIndex = 21;
            this.btnHelp.Text = "Trợ giúp";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Visible = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(222, 68);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(70, 23);
            this.button6.TabIndex = 27;
            this.button6.Text = "Quét mã";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(interestRateLabel);
            this.groupBox2.Controls.Add(label2);
            this.groupBox2.Controls.Add(outPriceLabel);
            this.groupBox2.Controls.Add(label1);
            this.groupBox2.Controls.Add(inPriceLabel);
            this.groupBox2.Controls.Add(this.tbInPrice);
            this.groupBox2.Controls.Add(this.tbOutPrice);
            this.groupBox2.Location = new System.Drawing.Point(15, 232);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(470, 118);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Giá sản phẩm";
            // 
            // tbInPrice
            // 
            this.tbInPrice.AutoSize = true;
            this.tbInPrice.BackColor = System.Drawing.Color.White;
            this.tbInPrice.BorderColor = System.Drawing.Color.Silver;
            this.tbInPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRODUCTBindingSource, "InPrice", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.tbInPrice.ErrorBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.tbInPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInPrice.HoverBorderColor = System.Drawing.Color.Cyan;
            this.tbInPrice.isRequired = true;
            this.tbInPrice.Location = new System.Drawing.Point(105, 25);
            this.tbInPrice.Multiline = false;
            this.tbInPrice.Name = "tbInPrice";
            this.tbInPrice.NormalBorderColor = System.Drawing.Color.Silver;
            this.tbInPrice.PanelBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.tbInPrice.ReadOnly = false;
            this.tbInPrice.Size = new System.Drawing.Size(270, 25);
            this.tbInPrice.StringPattern = "^([0-9,. ])*$";
            this.tbInPrice.TabIndex = 25;
            this.tbInPrice.TextPadding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.tbInPrice.TextPanelMessage = "Giá trị không hợp lệ.";
            this.tbInPrice.TextPanelMessageColor = System.Drawing.Color.White;
            this.tbInPrice.ValidBorderColor = System.Drawing.Color.LightGreen;
            this.tbInPrice.xTextChanged += new System.EventHandler(this.tbInPrice_xTextChanged);
            // 
            // tbOutPrice
            // 
            this.tbOutPrice.AutoSize = true;
            this.tbOutPrice.BackColor = System.Drawing.Color.White;
            this.tbOutPrice.BorderColor = System.Drawing.Color.Silver;
            this.tbOutPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRODUCTBindingSource, "OutPrice", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.tbOutPrice.ErrorBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.tbOutPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOutPrice.HoverBorderColor = System.Drawing.Color.Cyan;
            this.tbOutPrice.isRequired = true;
            this.tbOutPrice.Location = new System.Drawing.Point(105, 76);
            this.tbOutPrice.Multiline = false;
            this.tbOutPrice.Name = "tbOutPrice";
            this.tbOutPrice.NormalBorderColor = System.Drawing.Color.Silver;
            this.tbOutPrice.PanelBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.tbOutPrice.ReadOnly = false;
            this.tbOutPrice.Size = new System.Drawing.Size(270, 25);
            this.tbOutPrice.StringPattern = "^([0-9,. ])*$";
            this.tbOutPrice.TabIndex = 26;
            this.tbOutPrice.TextPadding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.tbOutPrice.TextPanelMessage = "Giá trị không hợp lệ.";
            this.tbOutPrice.TextPanelMessageColor = System.Drawing.Color.White;
            this.tbOutPrice.ValidBorderColor = System.Drawing.Color.LightGreen;
            // 
            // typeComboBox
            // 
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Location = new System.Drawing.Point(108, 141);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(184, 21);
            this.typeComboBox.TabIndex = 31;
            // 
            // brandComboBox
            // 
            this.brandComboBox.FormattingEnabled = true;
            this.brandComboBox.Location = new System.Drawing.Point(108, 168);
            this.brandComboBox.Name = "brandComboBox";
            this.brandComboBox.Size = new System.Drawing.Size(184, 21);
            this.brandComboBox.TabIndex = 33;
            // 
            // unitComboBox
            // 
            this.unitComboBox.FormattingEnabled = true;
            this.unitComboBox.Location = new System.Drawing.Point(108, 195);
            this.unitComboBox.Name = "unitComboBox";
            this.unitComboBox.Size = new System.Drawing.Size(100, 21);
            this.unitComboBox.TabIndex = 35;
            // 
            // productKeyText
            // 
            this.productKeyText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRODUCTBindingSource, "ProductKey", true));
            this.productKeyText.Location = new System.Drawing.Point(108, 18);
            this.productKeyText.Name = "productKeyText";
            this.productKeyText.ReadOnly = true;
            this.productKeyText.Size = new System.Drawing.Size(184, 20);
            this.productKeyText.TabIndex = 37;
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
            this.tbBarCode.Location = new System.Drawing.Point(108, 43);
            this.tbBarCode.Multiline = false;
            this.tbBarCode.Name = "tbBarCode";
            this.tbBarCode.NormalBorderColor = System.Drawing.Color.Silver;
            this.tbBarCode.PanelBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.tbBarCode.ReadOnly = false;
            this.tbBarCode.Size = new System.Drawing.Size(184, 19);
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
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.HoverBorderColor = System.Drawing.Color.Cyan;
            this.tbName.isRequired = true;
            this.tbName.Location = new System.Drawing.Point(108, 110);
            this.tbName.Multiline = false;
            this.tbName.Name = "tbName";
            this.tbName.NormalBorderColor = System.Drawing.Color.Silver;
            this.tbName.PanelBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.tbName.ReadOnly = false;
            this.tbName.Size = new System.Drawing.Size(184, 25);
            this.tbName.StringPattern = "";
            this.tbName.TabIndex = 23;
            this.tbName.TextPadding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.tbName.TextPanelMessage = "This is an error message.";
            this.tbName.TextPanelMessageColor = System.Drawing.Color.White;
            this.tbName.ValidBorderColor = System.Drawing.Color.LightGreen;
            // 
            // constantTableAdapter
            // 
            this.constantTableAdapter.ClearBeforeFill = true;
            // 
            // interestRateLabel
            // 
            interestRateLabel.AutoSize = true;
            interestRateLabel.Location = new System.Drawing.Point(102, 57);
            interestRateLabel.Name = "interestRateLabel";
            interestRateLabel.Size = new System.Drawing.Size(99, 13);
            interestRateLabel.TabIndex = 30;
            interestRateLabel.Text = "Tỉ lệ lợi nhuận: 10%";
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 421);
            this.Controls.Add(this.productKeyText);
            this.Controls.Add(label5);
            this.Controls.Add(this.unitComboBox);
            this.Controls.Add(label4);
            this.Controls.Add(this.brandComboBox);
            this.Controls.Add(label3);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.tbBarCode);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnDeletePicture);
            this.Controls.Add(this.btnAddPicture);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.ptrbPicture);
            this.Controls.Add(productKeyLabel);
            this.Controls.Add(nameLabel);
            this.Controls.Add(barCodeLabel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(520, 460);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(520, 460);
            this.Name = "AddProduct";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm sản phẩm";
            this.Load += new System.EventHandler(this.AddProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellManagementDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCT_METADATABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptrbPicture)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label productKeyLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label barCodeLabel;
        private System.Windows.Forms.Label inPriceLabel;
        private System.Windows.Forms.Label outPriceLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label interestRateLabel;
        private SellManagementDbDataSet sellManagementDbDataSet;
        private System.Windows.Forms.BindingSource pRODUCTBindingSource;
        private SellManagementDbDataSetTableAdapters.PRODUCTTableAdapter pRODUCTTableAdapter;
        private SellManagementDbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private SellManagementDbDataSetTableAdapters.PRODUCT_METADATATableAdapter pRODUCT_METADATATableAdapter;
        private System.Windows.Forms.BindingSource pRODUCT_METADATABindingSource;
        private System.Windows.Forms.PictureBox ptrbPicture;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddPicture;
        private System.Windows.Forms.Button btnDeletePicture;
        private System.Windows.Forms.Button btnHelp;
        private WindowsFormsControlLibrary.CustomTextBox tbName;
        private WindowsFormsControlLibrary.CustomTextBox tbBarCode;
        private WindowsFormsControlLibrary.CustomTextBox tbInPrice;
        private WindowsFormsControlLibrary.CustomTextBox tbOutPrice;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.ComboBox brandComboBox;
        private System.Windows.Forms.ComboBox unitComboBox;
        private System.Windows.Forms.TextBox productKeyText;
        private SellManagementDbDataSetTableAdapters.CONSTANTTableAdapter constantTableAdapter;
    }
}