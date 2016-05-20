namespace QuanLyBanHang.Forms
{
    partial class CustomerOrderList
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
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.productidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oRDERDETAILBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sellManagementDbDataSet = new QuanLyBanHang.SellManagementDbDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.extraPriceText = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.vatText = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.transactionDateText = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.finalPriceText = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.discountText = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.creatorText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.createDayText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.totalPriceText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.customerNameText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.documentKeyText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.searchText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.customerOrderdataGridView = new System.Windows.Forms.DataGridView();
            this.customerOrderViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customer_Order_ViewTableAdapter = new QuanLyBanHang.SellManagementDbDataSetTableAdapters.Customer_Order_ViewTableAdapter();
            this.oRDER_DETAILTableAdapter = new QuanLyBanHang.SellManagementDbDataSetTableAdapters.ORDER_DETAILTableAdapter();
            this.customerTableAdapter = new QuanLyBanHang.SellManagementDbDataSetTableAdapters.CUSTOMERTableAdapter();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentKeyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRDERDETAILBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellManagementDbDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerOrderdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerOrderViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 270);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Danh sách sản phẩm";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productidDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.resultDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.oRDERDETAILBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(21, 286);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(414, 145);
            this.dataGridView1.TabIndex = 12;
            // 
            // productidDataGridViewTextBoxColumn
            // 
            this.productidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productidDataGridViewTextBoxColumn.DataPropertyName = "Product_id";
            this.productidDataGridViewTextBoxColumn.HeaderText = "Sản phẩm";
            this.productidDataGridViewTextBoxColumn.Name = "productidDataGridViewTextBoxColumn";
            this.productidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Giá";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Số lượng";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // resultDataGridViewTextBoxColumn
            // 
            this.resultDataGridViewTextBoxColumn.DataPropertyName = "Result";
            this.resultDataGridViewTextBoxColumn.HeaderText = "Thành tiền";
            this.resultDataGridViewTextBoxColumn.Name = "resultDataGridViewTextBoxColumn";
            this.resultDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oRDERDETAILBindingSource
            // 
            this.oRDERDETAILBindingSource.DataMember = "ORDER_DETAIL";
            this.oRDERDETAILBindingSource.DataSource = this.sellManagementDbDataSet;
            // 
            // sellManagementDbDataSet
            // 
            this.sellManagementDbDataSet.DataSetName = "SellManagementDbDataSet";
            this.sellManagementDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.extraPriceText);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.vatText);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.transactionDateText);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.finalPriceText);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.discountText);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.creatorText);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.typeComboBox);
            this.groupBox1.Controls.Add(this.createDayText);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.statusComboBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.totalPriceText);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.customerNameText);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.documentKeyText);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(459, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 412);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(236, 178);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(63, 17);
            this.checkBox2.TabIndex = 31;
            this.checkBox2.Text = "Trả góp";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // extraPriceText
            // 
            this.extraPriceText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerOrderViewBindingSource, "ExtraPaid", true));
            this.extraPriceText.Location = new System.Drawing.Point(99, 255);
            this.extraPriceText.Name = "extraPriceText";
            this.extraPriceText.Size = new System.Drawing.Size(100, 20);
            this.extraPriceText.TabIndex = 28;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 258);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "Phụ thu";
            // 
            // vatText
            // 
            this.vatText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerOrderViewBindingSource, "VAT", true));
            this.vatText.Location = new System.Drawing.Point(99, 229);
            this.vatText.Name = "vatText";
            this.vatText.Size = new System.Drawing.Size(100, 20);
            this.vatText.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 232);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "VAT";
            // 
            // transactionDateText
            // 
            this.transactionDateText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerOrderViewBindingSource, "TransactionDate", true));
            this.transactionDateText.Location = new System.Drawing.Point(99, 150);
            this.transactionDateText.Name = "transactionDateText";
            this.transactionDateText.Size = new System.Drawing.Size(150, 20);
            this.transactionDateText.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 153);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Ngày giao dịch";
            // 
            // finalPriceText
            // 
            this.finalPriceText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerOrderViewBindingSource, "FinalPrice", true));
            this.finalPriceText.Location = new System.Drawing.Point(99, 307);
            this.finalPriceText.Name = "finalPriceText";
            this.finalPriceText.Size = new System.Drawing.Size(150, 20);
            this.finalPriceText.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 310);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Tổng hóa đơn";
            // 
            // discountText
            // 
            this.discountText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerOrderViewBindingSource, "Discount", true));
            this.discountText.Location = new System.Drawing.Point(99, 281);
            this.discountText.Name = "discountText";
            this.discountText.Size = new System.Drawing.Size(100, 20);
            this.discountText.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 284);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Chiết khấu";
            // 
            // creatorText
            // 
            this.creatorText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerOrderViewBindingSource, "Creator", true));
            this.creatorText.Location = new System.Drawing.Point(99, 124);
            this.creatorText.Name = "creatorText";
            this.creatorText.Size = new System.Drawing.Size(150, 20);
            this.creatorText.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Người lập";
            // 
            // typeComboBox
            // 
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Location = new System.Drawing.Point(99, 71);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(100, 21);
            this.typeComboBox.TabIndex = 17;
            // 
            // createDayText
            // 
            this.createDayText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerOrderViewBindingSource, "CreateDate", true));
            this.createDayText.Location = new System.Drawing.Point(99, 98);
            this.createDayText.Name = "createDayText";
            this.createDayText.Size = new System.Drawing.Size(150, 20);
            this.createDayText.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Ngày lập";
            // 
            // statusComboBox
            // 
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(99, 176);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(100, 21);
            this.statusComboBox.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Trạng thái";
            // 
            // totalPriceText
            // 
            this.totalPriceText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerOrderViewBindingSource, "TotalPrice", true));
            this.totalPriceText.Location = new System.Drawing.Point(99, 203);
            this.totalPriceText.Name = "totalPriceText";
            this.totalPriceText.Size = new System.Drawing.Size(150, 20);
            this.totalPriceText.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tổng tiền";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Loại";
            // 
            // customerNameText
            // 
            this.customerNameText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerOrderViewBindingSource, "Customer_id", true));
            this.customerNameText.Location = new System.Drawing.Point(99, 45);
            this.customerNameText.Name = "customerNameText";
            this.customerNameText.Size = new System.Drawing.Size(200, 20);
            this.customerNameText.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Khách hàng";
            // 
            // documentKeyText
            // 
            this.documentKeyText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerOrderViewBindingSource, "DocumentKey", true));
            this.documentKeyText.Location = new System.Drawing.Point(99, 19);
            this.documentKeyText.Name = "documentKeyText";
            this.documentKeyText.Size = new System.Drawing.Size(200, 20);
            this.documentKeyText.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mã hóa đơn";
            // 
            // searchText
            // 
            this.searchText.Location = new System.Drawing.Point(76, 20);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(200, 20);
            this.searchText.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tìm kiếm";
            // 
            // customerOrderdataGridView
            // 
            this.customerOrderdataGridView.AllowUserToAddRows = false;
            this.customerOrderdataGridView.AllowUserToDeleteRows = false;
            this.customerOrderdataGridView.AllowUserToResizeColumns = false;
            this.customerOrderdataGridView.AllowUserToResizeRows = false;
            this.customerOrderdataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customerOrderdataGridView.AutoGenerateColumns = false;
            this.customerOrderdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerOrderdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.statusDataGridViewTextBoxColumn,
            this.documentKeyDataGridViewTextBoxColumn,
            this.customerNameColumn,
            this.finalPriceDataGridViewTextBoxColumn});
            this.customerOrderdataGridView.DataSource = this.customerOrderViewBindingSource;
            this.customerOrderdataGridView.Location = new System.Drawing.Point(21, 54);
            this.customerOrderdataGridView.Name = "customerOrderdataGridView";
            this.customerOrderdataGridView.ReadOnly = true;
            this.customerOrderdataGridView.RowHeadersVisible = false;
            this.customerOrderdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customerOrderdataGridView.Size = new System.Drawing.Size(415, 200);
            this.customerOrderdataGridView.TabIndex = 8;
            // 
            // customerOrderViewBindingSource
            // 
            this.customerOrderViewBindingSource.DataMember = "Customer_Order_View";
            this.customerOrderViewBindingSource.DataSource = this.sellManagementDbDataSet;
            // 
            // customer_Order_ViewTableAdapter
            // 
            this.customer_Order_ViewTableAdapter.ClearBeforeFill = true;
            // 
            // oRDER_DETAILTableAdapter
            // 
            this.oRDER_DETAILTableAdapter.ClearBeforeFill = true;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Trạng thái";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // documentKeyDataGridViewTextBoxColumn
            // 
            this.documentKeyDataGridViewTextBoxColumn.DataPropertyName = "DocumentKey";
            this.documentKeyDataGridViewTextBoxColumn.HeaderText = "Mã hóa đơn";
            this.documentKeyDataGridViewTextBoxColumn.Name = "documentKeyDataGridViewTextBoxColumn";
            this.documentKeyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerNameColumn
            // 
            this.customerNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.customerNameColumn.DataPropertyName = "Customer_id";
            this.customerNameColumn.HeaderText = "Khách hàng";
            this.customerNameColumn.Name = "customerNameColumn";
            this.customerNameColumn.ReadOnly = true;
            // 
            // finalPriceDataGridViewTextBoxColumn
            // 
            this.finalPriceDataGridViewTextBoxColumn.DataPropertyName = "FinalPrice";
            this.finalPriceDataGridViewTextBoxColumn.HeaderText = "Tổng hóa đơn";
            this.finalPriceDataGridViewTextBoxColumn.Name = "finalPriceDataGridViewTextBoxColumn";
            this.finalPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // CustomerOrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.searchText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customerOrderdataGridView);
            this.Name = "CustomerOrderList";
            this.Size = new System.Drawing.Size(800, 456);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRDERDETAILBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellManagementDbDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerOrderdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerOrderViewBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox extraPriceText;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox vatText;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox customerNameText;
        private System.Windows.Forms.TextBox documentKeyText;
        private System.Windows.Forms.DataGridView customerOrderdataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox totalPriceText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox createDayText;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox creatorText;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox discountText;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox finalPriceText;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox transactionDateText;
        private System.Windows.Forms.GroupBox groupBox1;
        private SellManagementDbDataSetTableAdapters.Customer_Order_ViewTableAdapter customer_Order_ViewTableAdapter;
        private SellManagementDbDataSet sellManagementDbDataSet;
        private System.Windows.Forms.BindingSource customerOrderViewBindingSource;
        private System.Windows.Forms.BindingSource oRDERDETAILBindingSource;
        private SellManagementDbDataSetTableAdapters.ORDER_DETAILTableAdapter oRDER_DETAILTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productidDataGridViewTextBoxColumn;
        private SellManagementDbDataSetTableAdapters.CUSTOMERTableAdapter customerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentKeyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
    }
}
