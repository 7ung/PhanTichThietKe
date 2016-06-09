namespace QuanLyBanHang.Forms
{
    partial class ProductList
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
            System.Windows.Forms.Label lbProductKey;
            System.Windows.Forms.Label lbName;
            System.Windows.Forms.Label lbBarCode;
            System.Windows.Forms.Label lbInPrice;
            System.Windows.Forms.Label lbOutPrice;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            this.sellManagementDbDataSet = new QuanLyBanHang.SellManagementDbDataSet();
            this.pRODUCTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRODUCTTableAdapter = new QuanLyBanHang.SellManagementDbDataSetTableAdapters.PRODUCTTableAdapter();
            this.tableAdapterManager = new QuanLyBanHang.SellManagementDbDataSetTableAdapters.TableAdapterManager();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.lbSearch = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pRODUCT_METADATABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.pRODUCT_METADATATableAdapter = new QuanLyBanHang.SellManagementDbDataSetTableAdapters.PRODUCT_METADATATableAdapter();
            this.pRODUCTDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btEdit = new System.Windows.Forms.Button();
            this.gbDetailInfo = new System.Windows.Forms.GroupBox();
            this.tbOurPrice = new System.Windows.Forms.TextBox();
            this.tbInPrice = new System.Windows.Forms.TextBox();
            this.ptrbPicture = new System.Windows.Forms.PictureBox();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.unitText = new System.Windows.Forms.TextBox();
            this.brandText = new System.Windows.Forms.TextBox();
            this.typeText = new System.Windows.Forms.TextBox();
            this.tbBarCode = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbProductKey = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            lbProductKey = new System.Windows.Forms.Label();
            lbName = new System.Windows.Forms.Label();
            lbBarCode = new System.Windows.Forms.Label();
            lbInPrice = new System.Windows.Forms.Label();
            lbOutPrice = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sellManagementDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCT_METADATABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTDataGridView)).BeginInit();
            this.gbDetailInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrbPicture)).BeginInit();
            this.gbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbProductKey
            // 
            lbProductKey.AutoSize = true;
            lbProductKey.Location = new System.Drawing.Point(210, 61);
            lbProductKey.Name = "lbProductKey";
            lbProductKey.Size = new System.Drawing.Size(71, 13);
            lbProductKey.TabIndex = 4;
            lbProductKey.Text = "Mã sản phẩm";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new System.Drawing.Point(210, 34);
            lbName.Name = "lbName";
            lbName.Size = new System.Drawing.Size(26, 13);
            lbName.TabIndex = 6;
            lbName.Text = "Tên";
            // 
            // lbBarCode
            // 
            lbBarCode.AutoSize = true;
            lbBarCode.Location = new System.Drawing.Point(210, 87);
            lbBarCode.Name = "lbBarCode";
            lbBarCode.Size = new System.Drawing.Size(49, 13);
            lbBarCode.TabIndex = 8;
            lbBarCode.Text = "Mã vạch";
            // 
            // lbInPrice
            // 
            lbInPrice.AutoSize = true;
            lbInPrice.Location = new System.Drawing.Point(46, 32);
            lbInPrice.Name = "lbInPrice";
            lbInPrice.Size = new System.Drawing.Size(50, 13);
            lbInPrice.TabIndex = 12;
            lbInPrice.Text = "Giá nhập";
            // 
            // lbOutPrice
            // 
            lbOutPrice.AutoSize = true;
            lbOutPrice.Location = new System.Drawing.Point(46, 68);
            lbOutPrice.Name = "lbOutPrice";
            lbOutPrice.Size = new System.Drawing.Size(44, 13);
            lbOutPrice.TabIndex = 14;
            lbOutPrice.Text = "Giá bán";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(210, 128);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(27, 13);
            label1.TabIndex = 23;
            label1.Text = "Loại";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(210, 154);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(33, 13);
            label2.TabIndex = 25;
            label2.Text = "Hãng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(210, 180);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(38, 13);
            label3.TabIndex = 27;
            label3.Text = "Đơn vị";
            // 
            // label4
            // 
            label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(390, 32);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(30, 13);
            label4.TabIndex = 25;
            label4.Text = "VNĐ";
            // 
            // label5
            // 
            label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(390, 68);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(30, 13);
            label5.TabIndex = 26;
            label5.Text = "VNĐ";
            // 
            // sellManagementDbDataSet
            // 
            this.sellManagementDbDataSet.DataSetName = "SellManagementDbDataSet";
            this.sellManagementDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pRODUCTBindingSource
            // 
            this.pRODUCTBindingSource.DataMember = "PRODUCT";
            this.pRODUCTBindingSource.DataSource = this.sellManagementDbDataSet;
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
            this.tableAdapterManager.PRODUCT_METADATATableAdapter = null;
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
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(70, 19);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(220, 20);
            this.tbSearch.TabIndex = 2;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Location = new System.Drawing.Point(15, 22);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(49, 13);
            this.lbSearch.TabIndex = 3;
            this.lbSearch.Text = "Tìm kiếm";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.Location = new System.Drawing.Point(15, 533);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(270, 533);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pRODUCT_METADATABindingSource
            // 
            this.pRODUCT_METADATABindingSource.DataMember = "FK_PRODUCTMETADATA_PRODUCT";
            this.pRODUCT_METADATABindingSource.DataSource = this.pRODUCTBindingSource;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(438, 533);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // pRODUCT_METADATATableAdapter
            // 
            this.pRODUCT_METADATATableAdapter.ClearBeforeFill = true;
            // 
            // pRODUCTDataGridView
            // 
            this.pRODUCTDataGridView.AllowUserToAddRows = false;
            this.pRODUCTDataGridView.AllowUserToDeleteRows = false;
            this.pRODUCTDataGridView.AllowUserToResizeRows = false;
            this.pRODUCTDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pRODUCTDataGridView.AutoGenerateColumns = false;
            this.pRODUCTDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pRODUCTDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.pRODUCTDataGridView.DataSource = this.pRODUCTBindingSource;
            this.pRODUCTDataGridView.Location = new System.Drawing.Point(15, 49);
            this.pRODUCTDataGridView.Name = "pRODUCTDataGridView";
            this.pRODUCTDataGridView.ReadOnly = true;
            this.pRODUCTDataGridView.RowHeadersVisible = false;
            this.pRODUCTDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pRODUCTDataGridView.Size = new System.Drawing.Size(330, 468);
            this.pRODUCTDataGridView.TabIndex = 7;
            this.pRODUCTDataGridView.SelectionChanged += new System.EventHandler(this.pRODUCTDataGridView_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ProductKey";
            this.dataGridViewTextBoxColumn2.HeaderText = "Mã sản phẩm";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Tên";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "BarCode";
            this.dataGridViewTextBoxColumn4.HeaderText = "Mã vạch";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // btEdit
            // 
            this.btEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btEdit.Location = new System.Drawing.Point(423, 467);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(75, 23);
            this.btEdit.TabIndex = 4;
            this.btEdit.Text = "Sửa";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // gbDetailInfo
            // 
            this.gbDetailInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDetailInfo.Controls.Add(label5);
            this.gbDetailInfo.Controls.Add(label4);
            this.gbDetailInfo.Controls.Add(this.tbOurPrice);
            this.gbDetailInfo.Controls.Add(this.tbInPrice);
            this.gbDetailInfo.Controls.Add(lbInPrice);
            this.gbDetailInfo.Controls.Add(lbOutPrice);
            this.gbDetailInfo.Location = new System.Drawing.Point(20, 218);
            this.gbDetailInfo.Name = "gbDetailInfo";
            this.gbDetailInfo.Size = new System.Drawing.Size(478, 110);
            this.gbDetailInfo.TabIndex = 17;
            this.gbDetailInfo.TabStop = false;
            this.gbDetailInfo.Text = "Giá sản phẩm";
            // 
            // tbOurPrice
            // 
            this.tbOurPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOurPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbOurPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRODUCTBindingSource, "OutPrice", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.tbOurPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOurPrice.Location = new System.Drawing.Point(128, 60);
            this.tbOurPrice.Name = "tbOurPrice";
            this.tbOurPrice.ReadOnly = true;
            this.tbOurPrice.Size = new System.Drawing.Size(256, 26);
            this.tbOurPrice.TabIndex = 24;
            // 
            // tbInPrice
            // 
            this.tbInPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbInPrice.BackColor = System.Drawing.Color.LavenderBlush;
            this.tbInPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRODUCTBindingSource, "InPrice", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.tbInPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInPrice.Location = new System.Drawing.Point(128, 24);
            this.tbInPrice.Name = "tbInPrice";
            this.tbInPrice.ReadOnly = true;
            this.tbInPrice.Size = new System.Drawing.Size(256, 26);
            this.tbInPrice.TabIndex = 23;
            // 
            // ptrbPicture
            // 
            this.ptrbPicture.BackgroundImage = global::QuanLyBanHang.Properties.Resources.box_3;
            this.ptrbPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptrbPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptrbPicture.DataBindings.Add(new System.Windows.Forms.Binding("ImageLocation", this.pRODUCTBindingSource, "Picture", true));
            this.ptrbPicture.ErrorImage = null;
            this.ptrbPicture.Location = new System.Drawing.Point(20, 25);
            this.ptrbPicture.Name = "ptrbPicture";
            this.ptrbPicture.Size = new System.Drawing.Size(170, 170);
            this.ptrbPicture.TabIndex = 19;
            this.ptrbPicture.TabStop = false;
            // 
            // gbInfo
            // 
            this.gbInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbInfo.Controls.Add(this.unitText);
            this.gbInfo.Controls.Add(label3);
            this.gbInfo.Controls.Add(this.brandText);
            this.gbInfo.Controls.Add(label2);
            this.gbInfo.Controls.Add(this.typeText);
            this.gbInfo.Controls.Add(label1);
            this.gbInfo.Controls.Add(this.tbBarCode);
            this.gbInfo.Controls.Add(this.tbName);
            this.gbInfo.Controls.Add(this.tbProductKey);
            this.gbInfo.Controls.Add(this.ptrbPicture);
            this.gbInfo.Controls.Add(this.gbDetailInfo);
            this.gbInfo.Controls.Add(this.btEdit);
            this.gbInfo.Controls.Add(lbBarCode);
            this.gbInfo.Controls.Add(lbName);
            this.gbInfo.Controls.Add(lbProductKey);
            this.gbInfo.Location = new System.Drawing.Point(17, 13);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(514, 504);
            this.gbInfo.TabIndex = 6;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Thông tin";
            // 
            // unitText
            // 
            this.unitText.Location = new System.Drawing.Point(301, 177);
            this.unitText.Name = "unitText";
            this.unitText.ReadOnly = true;
            this.unitText.Size = new System.Drawing.Size(67, 20);
            this.unitText.TabIndex = 28;
            // 
            // brandText
            // 
            this.brandText.Location = new System.Drawing.Point(301, 151);
            this.brandText.Name = "brandText";
            this.brandText.ReadOnly = true;
            this.brandText.Size = new System.Drawing.Size(160, 20);
            this.brandText.TabIndex = 26;
            // 
            // typeText
            // 
            this.typeText.Location = new System.Drawing.Point(301, 125);
            this.typeText.Name = "typeText";
            this.typeText.ReadOnly = true;
            this.typeText.Size = new System.Drawing.Size(160, 20);
            this.typeText.TabIndex = 24;
            // 
            // tbBarCode
            // 
            this.tbBarCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRODUCTBindingSource, "BarCode", true));
            this.tbBarCode.Location = new System.Drawing.Point(301, 84);
            this.tbBarCode.Name = "tbBarCode";
            this.tbBarCode.ReadOnly = true;
            this.tbBarCode.Size = new System.Drawing.Size(160, 20);
            this.tbBarCode.TabIndex = 22;
            // 
            // tbName
            // 
            this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRODUCTBindingSource, "Name", true));
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(301, 26);
            this.tbName.Name = "tbName";
            this.tbName.ReadOnly = true;
            this.tbName.Size = new System.Drawing.Size(197, 26);
            this.tbName.TabIndex = 21;
            // 
            // tbProductKey
            // 
            this.tbProductKey.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRODUCTBindingSource, "ProductKey", true));
            this.tbProductKey.Location = new System.Drawing.Point(301, 58);
            this.tbProductKey.Name = "tbProductKey";
            this.tbProductKey.ReadOnly = true;
            this.tbProductKey.Size = new System.Drawing.Size(160, 20);
            this.tbProductKey.TabIndex = 20;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lbSearch);
            this.splitContainer1.Panel1.Controls.Add(this.pRODUCTDataGridView);
            this.splitContainer1.Panel1.Controls.Add(this.tbSearch);
            this.splitContainer1.Panel1.Controls.Add(this.btnAdd);
            this.splitContainer1.Panel1.Controls.Add(this.btnDelete);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gbInfo);
            this.splitContainer1.Panel2.Controls.Add(this.btnClose);
            this.splitContainer1.Panel2MinSize = 550;
            this.splitContainer1.Size = new System.Drawing.Size(918, 576);
            this.splitContainer1.SplitterDistance = 364;
            this.splitContainer1.TabIndex = 8;
            // 
            // ProductList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "ProductList";
            this.Size = new System.Drawing.Size(918, 576);
            this.Load += new System.EventHandler(this.ProductList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sellManagementDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCT_METADATABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTDataGridView)).EndInit();
            this.gbDetailInfo.ResumeLayout(false);
            this.gbDetailInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrbPicture)).EndInit();
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SellManagementDbDataSet sellManagementDbDataSet;
        private System.Windows.Forms.BindingSource pRODUCTBindingSource;
        private SellManagementDbDataSetTableAdapters.PRODUCTTableAdapter pRODUCTTableAdapter;
        private SellManagementDbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.BindingSource pRODUCT_METADATABindingSource;
        private SellManagementDbDataSetTableAdapters.PRODUCT_METADATATableAdapter pRODUCT_METADATATableAdapter;
        private System.Windows.Forms.DataGridView pRODUCTDataGridView;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.GroupBox gbDetailInfo;
        private System.Windows.Forms.PictureBox ptrbPicture;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.TextBox tbOurPrice;
        private System.Windows.Forms.TextBox tbInPrice;
        private System.Windows.Forms.TextBox tbBarCode;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbProductKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.TextBox unitText;
        private System.Windows.Forms.TextBox brandText;
        private System.Windows.Forms.TextBox typeText;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}
