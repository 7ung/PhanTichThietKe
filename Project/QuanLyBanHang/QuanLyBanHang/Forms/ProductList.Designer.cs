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
            this.pRODUCT_METADATADataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ptrbPicture = new System.Windows.Forms.PictureBox();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.tbOurPrice = new System.Windows.Forms.TextBox();
            this.tbInPrice = new System.Windows.Forms.TextBox();
            this.tbBarCode = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbProductKey = new System.Windows.Forms.TextBox();
            lbProductKey = new System.Windows.Forms.Label();
            lbName = new System.Windows.Forms.Label();
            lbBarCode = new System.Windows.Forms.Label();
            lbInPrice = new System.Windows.Forms.Label();
            lbOutPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sellManagementDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCT_METADATABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTDataGridView)).BeginInit();
            this.gbDetailInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCT_METADATADataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptrbPicture)).BeginInit();
            this.gbInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbProductKey
            // 
            lbProductKey.AutoSize = true;
            lbProductKey.Location = new System.Drawing.Point(212, 30);
            lbProductKey.Name = "lbProductKey";
            lbProductKey.Size = new System.Drawing.Size(71, 13);
            lbProductKey.TabIndex = 4;
            lbProductKey.Text = "Mã sản phẩm";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new System.Drawing.Point(210, 56);
            lbName.Name = "lbName";
            lbName.Size = new System.Drawing.Size(75, 13);
            lbName.TabIndex = 6;
            lbName.Text = "Tên sản phẩm";
            // 
            // lbBarCode
            // 
            lbBarCode.AutoSize = true;
            lbBarCode.Location = new System.Drawing.Point(210, 81);
            lbBarCode.Name = "lbBarCode";
            lbBarCode.Size = new System.Drawing.Size(49, 13);
            lbBarCode.TabIndex = 8;
            lbBarCode.Text = "Mã vạch";
            // 
            // lbInPrice
            // 
            lbInPrice.AutoSize = true;
            lbInPrice.Location = new System.Drawing.Point(212, 154);
            lbInPrice.Name = "lbInPrice";
            lbInPrice.Size = new System.Drawing.Size(50, 13);
            lbInPrice.TabIndex = 12;
            lbInPrice.Text = "Giá nhập";
            // 
            // lbOutPrice
            // 
            lbOutPrice.AutoSize = true;
            lbOutPrice.Location = new System.Drawing.Point(212, 177);
            lbOutPrice.Name = "lbOutPrice";
            lbOutPrice.Size = new System.Drawing.Size(44, 13);
            lbOutPrice.TabIndex = 14;
            lbOutPrice.Text = "Giá bán";
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
            this.tbSearch.Location = new System.Drawing.Point(119, 18);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(229, 20);
            this.tbSearch.TabIndex = 2;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Location = new System.Drawing.Point(46, 22);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(49, 13);
            this.lbSearch.TabIndex = 3;
            this.lbSearch.Text = "Tìm kiếm";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(25, 540);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(334, 540);
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
            this.btnClose.Location = new System.Drawing.Point(833, 540);
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
            this.pRODUCTDataGridView.AutoGenerateColumns = false;
            this.pRODUCTDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pRODUCTDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.pRODUCTDataGridView.DataSource = this.pRODUCTBindingSource;
            this.pRODUCTDataGridView.Location = new System.Drawing.Point(25, 61);
            this.pRODUCTDataGridView.Name = "pRODUCTDataGridView";
            this.pRODUCTDataGridView.ReadOnly = true;
            this.pRODUCTDataGridView.Size = new System.Drawing.Size(384, 458);
            this.pRODUCTDataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ProductKey";
            this.dataGridViewTextBoxColumn2.HeaderText = "ProductKey";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 80;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 180;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "BarCode";
            this.dataGridViewTextBoxColumn4.HeaderText = "BarCode";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 80;
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(387, 470);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(75, 23);
            this.btEdit.TabIndex = 4;
            this.btEdit.Text = "Sửa";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // gbDetailInfo
            // 
            this.gbDetailInfo.Controls.Add(this.pRODUCT_METADATADataGridView);
            this.gbDetailInfo.Location = new System.Drawing.Point(17, 218);
            this.gbDetailInfo.Name = "gbDetailInfo";
            this.gbDetailInfo.Size = new System.Drawing.Size(454, 246);
            this.gbDetailInfo.TabIndex = 17;
            this.gbDetailInfo.TabStop = false;
            this.gbDetailInfo.Text = "Thông tin chi tiết sản phẩm";
            // 
            // pRODUCT_METADATADataGridView
            // 
            this.pRODUCT_METADATADataGridView.AllowUserToAddRows = false;
            this.pRODUCT_METADATADataGridView.AllowUserToDeleteRows = false;
            this.pRODUCT_METADATADataGridView.AutoGenerateColumns = false;
            this.pRODUCT_METADATADataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pRODUCT_METADATADataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn8});
            this.pRODUCT_METADATADataGridView.DataSource = this.pRODUCT_METADATABindingSource;
            this.pRODUCT_METADATADataGridView.Location = new System.Drawing.Point(14, 29);
            this.pRODUCT_METADATADataGridView.Name = "pRODUCT_METADATADataGridView";
            this.pRODUCT_METADATADataGridView.ReadOnly = true;
            this.pRODUCT_METADATADataGridView.Size = new System.Drawing.Size(431, 204);
            this.pRODUCT_METADATADataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Key";
            this.dataGridViewTextBoxColumn6.HeaderText = "Key";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 140;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Value";
            this.dataGridViewTextBoxColumn8.HeaderText = "Value";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 230;
            // 
            // ptrbPicture
            // 
            this.ptrbPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptrbPicture.DataBindings.Add(new System.Windows.Forms.Binding("ImageLocation", this.pRODUCTBindingSource, "Picture", true));
            this.ptrbPicture.Location = new System.Drawing.Point(31, 20);
            this.ptrbPicture.Name = "ptrbPicture";
            this.ptrbPicture.Size = new System.Drawing.Size(170, 170);
            this.ptrbPicture.TabIndex = 19;
            this.ptrbPicture.TabStop = false;
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.tbOurPrice);
            this.gbInfo.Controls.Add(this.tbInPrice);
            this.gbInfo.Controls.Add(this.tbBarCode);
            this.gbInfo.Controls.Add(this.tbName);
            this.gbInfo.Controls.Add(this.tbProductKey);
            this.gbInfo.Controls.Add(this.ptrbPicture);
            this.gbInfo.Controls.Add(this.gbDetailInfo);
            this.gbInfo.Controls.Add(this.btEdit);
            this.gbInfo.Controls.Add(lbOutPrice);
            this.gbInfo.Controls.Add(lbInPrice);
            this.gbInfo.Controls.Add(lbBarCode);
            this.gbInfo.Controls.Add(lbName);
            this.gbInfo.Controls.Add(lbProductKey);
            this.gbInfo.Location = new System.Drawing.Point(428, 12);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(478, 507);
            this.gbInfo.TabIndex = 6;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Thông tin";
            // 
            // tbOurPrice
            // 
            this.tbOurPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRODUCTBindingSource, "OutPrice", true));
            this.tbOurPrice.Location = new System.Drawing.Point(301, 170);
            this.tbOurPrice.Name = "tbOurPrice";
            this.tbOurPrice.Size = new System.Drawing.Size(161, 20);
            this.tbOurPrice.TabIndex = 24;
            // 
            // tbInPrice
            // 
            this.tbInPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRODUCTBindingSource, "InPrice", true));
            this.tbInPrice.Location = new System.Drawing.Point(301, 147);
            this.tbInPrice.Name = "tbInPrice";
            this.tbInPrice.Size = new System.Drawing.Size(161, 20);
            this.tbInPrice.TabIndex = 23;
            // 
            // tbBarCode
            // 
            this.tbBarCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRODUCTBindingSource, "BarCode", true));
            this.tbBarCode.Location = new System.Drawing.Point(301, 81);
            this.tbBarCode.Name = "tbBarCode";
            this.tbBarCode.Size = new System.Drawing.Size(161, 20);
            this.tbBarCode.TabIndex = 22;
            // 
            // tbName
            // 
            this.tbName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRODUCTBindingSource, "Name", true));
            this.tbName.Location = new System.Drawing.Point(301, 49);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(161, 20);
            this.tbName.TabIndex = 21;
            // 
            // tbProductKey
            // 
            this.tbProductKey.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRODUCTBindingSource, "ProductKey", true));
            this.tbProductKey.Location = new System.Drawing.Point(301, 23);
            this.tbProductKey.Name = "tbProductKey";
            this.tbProductKey.Size = new System.Drawing.Size(161, 20);
            this.tbProductKey.TabIndex = 20;
            // 
            // ProductList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pRODUCTDataGridView);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbSearch);
            this.Controls.Add(this.tbSearch);
            this.Name = "ProductList";
            this.Size = new System.Drawing.Size(918, 576);
            ((System.ComponentModel.ISupportInitialize)(this.sellManagementDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCT_METADATABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTDataGridView)).EndInit();
            this.gbDetailInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCT_METADATADataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptrbPicture)).EndInit();
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.GroupBox gbDetailInfo;
        private System.Windows.Forms.DataGridView pRODUCT_METADATADataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.PictureBox ptrbPicture;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.TextBox tbOurPrice;
        private System.Windows.Forms.TextBox tbInPrice;
        private System.Windows.Forms.TextBox tbBarCode;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbProductKey;
    }
}
