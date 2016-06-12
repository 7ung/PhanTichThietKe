namespace QuanLyBanHang.Forms
{
    partial class CustomerReport
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cUSTOMERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sellManagementDbDataSet = new QuanLyBanHang.SellManagementDbDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.customerComboBox = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cUSTOMERTableAdapter = new QuanLyBanHang.SellManagementDbDataSetTableAdapters.CUSTOMERTableAdapter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.numberofDebtText = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.documentKeyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debtMoneyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remainDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datePaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extraPaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.customerDebtViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.documentKeyDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.sTAFFBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.createDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.customerOrderViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customer_Debt_ViewTableAdapter = new QuanLyBanHang.SellManagementDbDataSetTableAdapters.Customer_Debt_ViewTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.latestOrderDate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.remainText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.paidMoneyText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.totalOrderMoneyText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.totalOrderText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.customer_Order_ViewTableAdapter = new QuanLyBanHang.SellManagementDbDataSetTableAdapters.Customer_Order_ViewTableAdapter();
            this.sTAFFTableAdapter = new QuanLyBanHang.SellManagementDbDataSetTableAdapters.STAFFTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellManagementDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDebtViewBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTAFFBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerOrderViewBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.customerComboBox);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.textBox10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.textBox9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(20, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(957, 187);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "Address", true));
            this.textBox2.Location = new System.Drawing.Point(275, 124);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(270, 46);
            this.textBox2.TabIndex = 42;
            // 
            // cUSTOMERBindingSource
            // 
            this.cUSTOMERBindingSource.DataMember = "CUSTOMER";
            this.cUSTOMERBindingSource.DataSource = this.sellManagementDbDataSet;
            // 
            // sellManagementDbDataSet
            // 
            this.sellManagementDbDataSet.DataSetName = "SellManagementDbDataSet";
            this.sellManagementDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Địa chỉ";
            // 
            // customerComboBox
            // 
            this.customerComboBox.DataSource = this.cUSTOMERBindingSource;
            this.customerComboBox.DisplayMember = "Name";
            this.customerComboBox.FormattingEnabled = true;
            this.customerComboBox.Location = new System.Drawing.Point(275, 20);
            this.customerComboBox.Name = "customerComboBox";
            this.customerComboBox.Size = new System.Drawing.Size(160, 21);
            this.customerComboBox.TabIndex = 40;
            this.customerComboBox.ValueMember = "Id";
            this.customerComboBox.SelectedIndexChanged += new System.EventHandler(this.customerComboBox_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "Email", true));
            this.textBox1.Location = new System.Drawing.Point(275, 98);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(160, 20);
            this.textBox1.TabIndex = 39;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(187, 101);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(32, 13);
            this.label22.TabIndex = 38;
            this.label22.Text = "Email";
            // 
            // textBox10
            // 
            this.textBox10.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "Phone", true));
            this.textBox10.Location = new System.Drawing.Point(275, 72);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(160, 20);
            this.textBox10.TabIndex = 37;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(187, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 36;
            this.label11.Text = "Số điện thoại";
            // 
            // textBox9
            // 
            this.textBox9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CustomerKey", true));
            this.textBox9.Location = new System.Drawing.Point(275, 46);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(160, 20);
            this.textBox9.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(187, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Mã khách hàng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(187, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Tên";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyBanHang.Properties.Resources.Customer;
            this.pictureBox1.Location = new System.Drawing.Point(20, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cUSTOMERTableAdapter
            // 
            this.cUSTOMERTableAdapter.ClearBeforeFill = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(20, 414);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(957, 336);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.numberofDebtText);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(949, 310);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Danh sách nợ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // numberofDebtText
            // 
            this.numberofDebtText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numberofDebtText.AutoSize = true;
            this.numberofDebtText.Location = new System.Drawing.Point(13, 284);
            this.numberofDebtText.Name = "numberofDebtText";
            this.numberofDebtText.Size = new System.Drawing.Size(88, 13);
            this.numberofDebtText.TabIndex = 1;
            this.numberofDebtText.Text = "Số danh sách nợ";
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
            this.documentKeyDataGridViewTextBoxColumn,
            this.createDateDataGridViewTextBoxColumn,
            this.debtMoneyDataGridViewTextBoxColumn,
            this.paidDataGridViewTextBoxColumn,
            this.remainDataGridViewTextBoxColumn,
            this.datePaidDataGridViewTextBoxColumn,
            this.extraPaidDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.customerDebtViewBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(949, 270);
            this.dataGridView1.TabIndex = 0;
            // 
            // documentKeyDataGridViewTextBoxColumn
            // 
            this.documentKeyDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.documentKeyDataGridViewTextBoxColumn.DataPropertyName = "DocumentKey";
            this.documentKeyDataGridViewTextBoxColumn.HeaderText = "Mã công nợ";
            this.documentKeyDataGridViewTextBoxColumn.Name = "documentKeyDataGridViewTextBoxColumn";
            this.documentKeyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // createDateDataGridViewTextBoxColumn
            // 
            this.createDateDataGridViewTextBoxColumn.DataPropertyName = "CreateDate";
            this.createDateDataGridViewTextBoxColumn.HeaderText = "Ngày lập";
            this.createDateDataGridViewTextBoxColumn.Name = "createDateDataGridViewTextBoxColumn";
            this.createDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // debtMoneyDataGridViewTextBoxColumn
            // 
            this.debtMoneyDataGridViewTextBoxColumn.DataPropertyName = "DebtMoney";
            this.debtMoneyDataGridViewTextBoxColumn.HeaderText = "Số tiền nợ";
            this.debtMoneyDataGridViewTextBoxColumn.Name = "debtMoneyDataGridViewTextBoxColumn";
            this.debtMoneyDataGridViewTextBoxColumn.ReadOnly = true;
            this.debtMoneyDataGridViewTextBoxColumn.Width = 150;
            // 
            // paidDataGridViewTextBoxColumn
            // 
            this.paidDataGridViewTextBoxColumn.DataPropertyName = "Paid";
            this.paidDataGridViewTextBoxColumn.HeaderText = "Đã thanh toán";
            this.paidDataGridViewTextBoxColumn.Name = "paidDataGridViewTextBoxColumn";
            this.paidDataGridViewTextBoxColumn.ReadOnly = true;
            this.paidDataGridViewTextBoxColumn.Width = 120;
            // 
            // remainDataGridViewTextBoxColumn
            // 
            this.remainDataGridViewTextBoxColumn.DataPropertyName = "Remain";
            this.remainDataGridViewTextBoxColumn.HeaderText = "Còn lại";
            this.remainDataGridViewTextBoxColumn.Name = "remainDataGridViewTextBoxColumn";
            this.remainDataGridViewTextBoxColumn.ReadOnly = true;
            this.remainDataGridViewTextBoxColumn.Width = 120;
            // 
            // datePaidDataGridViewTextBoxColumn
            // 
            this.datePaidDataGridViewTextBoxColumn.DataPropertyName = "DatePaid";
            this.datePaidDataGridViewTextBoxColumn.HeaderText = "Ngày thanh toán";
            this.datePaidDataGridViewTextBoxColumn.Name = "datePaidDataGridViewTextBoxColumn";
            this.datePaidDataGridViewTextBoxColumn.ReadOnly = true;
            this.datePaidDataGridViewTextBoxColumn.Width = 120;
            // 
            // extraPaidDataGridViewTextBoxColumn
            // 
            this.extraPaidDataGridViewTextBoxColumn.DataPropertyName = "ExtraPaid";
            this.extraPaidDataGridViewTextBoxColumn.HeaderText = "Phụ thu";
            this.extraPaidDataGridViewTextBoxColumn.Name = "extraPaidDataGridViewTextBoxColumn";
            this.extraPaidDataGridViewTextBoxColumn.ReadOnly = true;
            this.extraPaidDataGridViewTextBoxColumn.Width = 120;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.statusDataGridViewTextBoxColumn.HeaderText = "Tình trạng nợ";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.statusDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // customerDebtViewBindingSource
            // 
            this.customerDebtViewBindingSource.DataMember = "Customer_Debt_View";
            this.customerDebtViewBindingSource.DataSource = this.sellManagementDbDataSet;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(949, 310);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Danh sách đơn hàng";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.documentKeyDataGridViewTextBoxColumn1,
            this.creatorDataGridViewTextBoxColumn,
            this.createDateDataGridViewTextBoxColumn1,
            this.totalPriceDataGridViewTextBoxColumn,
            this.vATDataGridViewTextBoxColumn,
            this.finalPriceDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.customerOrderViewBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(949, 270);
            this.dataGridView2.TabIndex = 0;
            // 
            // documentKeyDataGridViewTextBoxColumn1
            // 
            this.documentKeyDataGridViewTextBoxColumn1.DataPropertyName = "DocumentKey";
            this.documentKeyDataGridViewTextBoxColumn1.HeaderText = "Mã đơn hàng";
            this.documentKeyDataGridViewTextBoxColumn1.Name = "documentKeyDataGridViewTextBoxColumn1";
            this.documentKeyDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // creatorDataGridViewTextBoxColumn
            // 
            this.creatorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.creatorDataGridViewTextBoxColumn.DataPropertyName = "Creator";
            this.creatorDataGridViewTextBoxColumn.DataSource = this.sTAFFBindingSource;
            this.creatorDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.creatorDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.creatorDataGridViewTextBoxColumn.HeaderText = "Nhân viên lập";
            this.creatorDataGridViewTextBoxColumn.Name = "creatorDataGridViewTextBoxColumn";
            this.creatorDataGridViewTextBoxColumn.ReadOnly = true;
            this.creatorDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.creatorDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.creatorDataGridViewTextBoxColumn.ValueMember = "Id";
            // 
            // sTAFFBindingSource
            // 
            this.sTAFFBindingSource.DataMember = "STAFF";
            this.sTAFFBindingSource.DataSource = this.sellManagementDbDataSet;
            // 
            // createDateDataGridViewTextBoxColumn1
            // 
            this.createDateDataGridViewTextBoxColumn1.DataPropertyName = "CreateDate";
            this.createDateDataGridViewTextBoxColumn1.HeaderText = "Ngày lập";
            this.createDateDataGridViewTextBoxColumn1.Name = "createDateDataGridViewTextBoxColumn1";
            this.createDateDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            this.totalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn.HeaderText = "Tổng tiền";
            this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            this.totalPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalPriceDataGridViewTextBoxColumn.Width = 120;
            // 
            // vATDataGridViewTextBoxColumn
            // 
            this.vATDataGridViewTextBoxColumn.DataPropertyName = "VAT";
            this.vATDataGridViewTextBoxColumn.HeaderText = "VAT";
            this.vATDataGridViewTextBoxColumn.Name = "vATDataGridViewTextBoxColumn";
            this.vATDataGridViewTextBoxColumn.ReadOnly = true;
            this.vATDataGridViewTextBoxColumn.Width = 120;
            // 
            // finalPriceDataGridViewTextBoxColumn
            // 
            this.finalPriceDataGridViewTextBoxColumn.DataPropertyName = "FinalPrice";
            this.finalPriceDataGridViewTextBoxColumn.HeaderText = "Tổng hóa đơn";
            this.finalPriceDataGridViewTextBoxColumn.Name = "finalPriceDataGridViewTextBoxColumn";
            this.finalPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.finalPriceDataGridViewTextBoxColumn.Width = 120;
            // 
            // statusDataGridViewTextBoxColumn1
            // 
            this.statusDataGridViewTextBoxColumn1.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.statusDataGridViewTextBoxColumn1.HeaderText = "Tình trạng";
            this.statusDataGridViewTextBoxColumn1.Name = "statusDataGridViewTextBoxColumn1";
            this.statusDataGridViewTextBoxColumn1.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.statusDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // customerOrderViewBindingSource
            // 
            this.customerOrderViewBindingSource.DataMember = "Customer_Order_View";
            this.customerOrderViewBindingSource.DataSource = this.sellManagementDbDataSet;
            // 
            // customer_Debt_ViewTableAdapter
            // 
            this.customer_Debt_ViewTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.latestOrderDate);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.remainText);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.paidMoneyText);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.totalOrderMoneyText);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.totalOrderText);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(20, 213);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(957, 195);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(441, 62);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 13);
            this.label12.TabIndex = 48;
            this.label12.Text = "VNĐ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(441, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 47;
            this.label8.Text = "VNĐ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(441, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "VNĐ";
            // 
            // latestOrderDate
            // 
            this.latestOrderDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latestOrderDate.Location = new System.Drawing.Point(190, 150);
            this.latestOrderDate.Name = "latestOrderDate";
            this.latestOrderDate.ReadOnly = true;
            this.latestOrderDate.Size = new System.Drawing.Size(160, 26);
            this.latestOrderDate.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Lần mua hàng gần nhất";
            // 
            // remainText
            // 
            this.remainText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.remainText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remainText.Location = new System.Drawing.Point(190, 118);
            this.remainText.Name = "remainText";
            this.remainText.ReadOnly = true;
            this.remainText.Size = new System.Drawing.Size(245, 26);
            this.remainText.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Còn nợ";
            // 
            // paidMoneyText
            // 
            this.paidMoneyText.BackColor = System.Drawing.Color.PaleTurquoise;
            this.paidMoneyText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paidMoneyText.Location = new System.Drawing.Point(190, 86);
            this.paidMoneyText.Name = "paidMoneyText";
            this.paidMoneyText.ReadOnly = true;
            this.paidMoneyText.Size = new System.Drawing.Size(245, 26);
            this.paidMoneyText.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Đã thanh toán";
            // 
            // totalOrderMoneyText
            // 
            this.totalOrderMoneyText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.totalOrderMoneyText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalOrderMoneyText.Location = new System.Drawing.Point(190, 54);
            this.totalOrderMoneyText.Name = "totalOrderMoneyText";
            this.totalOrderMoneyText.ReadOnly = true;
            this.totalOrderMoneyText.Size = new System.Drawing.Size(245, 26);
            this.totalOrderMoneyText.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Tổng tiền giao dịch";
            // 
            // totalOrderText
            // 
            this.totalOrderText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalOrderText.Location = new System.Drawing.Point(190, 22);
            this.totalOrderText.Name = "totalOrderText";
            this.totalOrderText.ReadOnly = true;
            this.totalOrderText.Size = new System.Drawing.Size(86, 26);
            this.totalOrderText.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Tổng số giao dịch";
            // 
            // customer_Order_ViewTableAdapter
            // 
            this.customer_Order_ViewTableAdapter.ClearBeforeFill = true;
            // 
            // sTAFFTableAdapter
            // 
            this.sTAFFTableAdapter.ClearBeforeFill = true;
            // 
            // CustomerReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Name = "CustomerReport";
            this.Size = new System.Drawing.Size(1000, 800);
            this.Load += new System.EventHandler(this.CustomerReport_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellManagementDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDebtViewBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTAFFBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerOrderViewBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.BindingSource cUSTOMERBindingSource;
        private SellManagementDbDataSet sellManagementDbDataSet;
        private System.Windows.Forms.ComboBox customerComboBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private SellManagementDbDataSetTableAdapters.CUSTOMERTableAdapter cUSTOMERTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource customerDebtViewBindingSource;
        private SellManagementDbDataSetTableAdapters.Customer_Debt_ViewTableAdapter customer_Debt_ViewTableAdapter;
        private System.Windows.Forms.DataGridViewComboBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn extraPaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datePaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remainDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn debtMoneyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentKeyDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label numberofDebtText;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox latestOrderDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox remainText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox paidMoneyText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox totalOrderMoneyText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox totalOrderText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource sTAFFBindingSource;
        private System.Windows.Forms.BindingSource customerOrderViewBindingSource;
        private SellManagementDbDataSetTableAdapters.Customer_Order_ViewTableAdapter customer_Order_ViewTableAdapter;
        private SellManagementDbDataSetTableAdapters.STAFFTableAdapter sTAFFTableAdapter;
        private System.Windows.Forms.DataGridViewComboBoxColumn statusDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vATDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn creatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentKeyDataGridViewTextBoxColumn1;
    }
}
