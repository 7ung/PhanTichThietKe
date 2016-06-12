namespace QuanLyBanHang.Forms
{
    partial class RevenueReport
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
            this.label1 = new System.Windows.Forms.Label();
            this.beginDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.viewBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.incomeText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.incomeDataGridView = new System.Windows.Forms.DataGridView();
            this.documentKeyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customeridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cUSTOMERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sellManagementDbDataSet = new QuanLyBanHang.SellManagementDbDataSet();
            this.creatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.sTAFFBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.createDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.customerOrderViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.documentKeyDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendoridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.vENDORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.creatorDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.createDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vATDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalPriceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.vendorOrderViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customer_Order_ViewTableAdapter = new QuanLyBanHang.SellManagementDbDataSetTableAdapters.Customer_Order_ViewTableAdapter();
            this.closeBtn = new System.Windows.Forms.Button();
            this.cUSTOMERTableAdapter = new QuanLyBanHang.SellManagementDbDataSetTableAdapters.CUSTOMERTableAdapter();
            this.sTAFFTableAdapter = new QuanLyBanHang.SellManagementDbDataSetTableAdapters.STAFFTableAdapter();
            this.vendor_Order_ViewTableAdapter = new QuanLyBanHang.SellManagementDbDataSetTableAdapters.Vendor_Order_ViewTableAdapter();
            this.vENDORTableAdapter = new QuanLyBanHang.SellManagementDbDataSetTableAdapters.VENDORTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.incomeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellManagementDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTAFFBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerOrderViewBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENDORBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorOrderViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thời gian";
            // 
            // beginDateTimePicker
            // 
            this.beginDateTimePicker.CustomFormat = "dd\'/\'MM\'/\'yyyy";
            this.beginDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beginDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.beginDateTimePicker.Location = new System.Drawing.Point(92, 19);
            this.beginDateTimePicker.Name = "beginDateTimePicker";
            this.beginDateTimePicker.Size = new System.Drawing.Size(120, 26);
            this.beginDateTimePicker.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "đến";
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.CustomFormat = "dd\'/\'MM\'/\'yyyy";
            this.endDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDateTimePicker.Location = new System.Drawing.Point(283, 19);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(120, 26);
            this.endDateTimePicker.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.clearBtn);
            this.groupBox1.Controls.Add(this.viewBtn);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.incomeText);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.endDateTimePicker);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.beginDateTimePicker);
            this.groupBox1.Location = new System.Drawing.Point(20, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(960, 133);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(490, 19);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 26);
            this.clearBtn.TabIndex = 10;
            this.clearBtn.Text = "Xóa";
            this.clearBtn.UseVisualStyleBackColor = true;
            // 
            // viewBtn
            // 
            this.viewBtn.Location = new System.Drawing.Point(409, 19);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(75, 26);
            this.viewBtn.TabIndex = 9;
            this.viewBtn.Text = "Xem";
            this.viewBtn.UseVisualStyleBackColor = true;
            this.viewBtn.Click += new System.EventHandler(this.viewBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(92, 88);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(311, 26);
            this.textBox1.TabIndex = 8;
            // 
            // incomeText
            // 
            this.incomeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomeText.Location = new System.Drawing.Point(92, 54);
            this.incomeText.Name = "incomeText";
            this.incomeText.Size = new System.Drawing.Size(311, 26);
            this.incomeText.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Chi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Thu";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(20, 159);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(960, 252);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.incomeDataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(952, 226);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thu vào";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(169, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tổng số khách hàng";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tổng số hóa đơn";
            // 
            // incomeDataGridView
            // 
            this.incomeDataGridView.AllowUserToAddRows = false;
            this.incomeDataGridView.AllowUserToDeleteRows = false;
            this.incomeDataGridView.AllowUserToResizeRows = false;
            this.incomeDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.incomeDataGridView.AutoGenerateColumns = false;
            this.incomeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.incomeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.documentKeyDataGridViewTextBoxColumn,
            this.customeridDataGridViewTextBoxColumn,
            this.creatorDataGridViewTextBoxColumn,
            this.createDateDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn,
            this.vATDataGridViewTextBoxColumn,
            this.finalPriceDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.incomeDataGridView.DataSource = this.customerOrderViewBindingSource;
            this.incomeDataGridView.Location = new System.Drawing.Point(0, 0);
            this.incomeDataGridView.Name = "incomeDataGridView";
            this.incomeDataGridView.ReadOnly = true;
            this.incomeDataGridView.Size = new System.Drawing.Size(952, 185);
            this.incomeDataGridView.TabIndex = 0;
            // 
            // documentKeyDataGridViewTextBoxColumn
            // 
            this.documentKeyDataGridViewTextBoxColumn.DataPropertyName = "DocumentKey";
            this.documentKeyDataGridViewTextBoxColumn.HeaderText = "Mã đơn hàng";
            this.documentKeyDataGridViewTextBoxColumn.Name = "documentKeyDataGridViewTextBoxColumn";
            this.documentKeyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customeridDataGridViewTextBoxColumn
            // 
            this.customeridDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.customeridDataGridViewTextBoxColumn.DataPropertyName = "Customer_id";
            this.customeridDataGridViewTextBoxColumn.DataSource = this.cUSTOMERBindingSource;
            this.customeridDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.customeridDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.customeridDataGridViewTextBoxColumn.HeaderText = "Khách hàng";
            this.customeridDataGridViewTextBoxColumn.Name = "customeridDataGridViewTextBoxColumn";
            this.customeridDataGridViewTextBoxColumn.ReadOnly = true;
            this.customeridDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.customeridDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.customeridDataGridViewTextBoxColumn.ValueMember = "Id";
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
            // creatorDataGridViewTextBoxColumn
            // 
            this.creatorDataGridViewTextBoxColumn.DataPropertyName = "Creator";
            this.creatorDataGridViewTextBoxColumn.DataSource = this.sTAFFBindingSource;
            this.creatorDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.creatorDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.creatorDataGridViewTextBoxColumn.HeaderText = "Nhân viên";
            this.creatorDataGridViewTextBoxColumn.Name = "creatorDataGridViewTextBoxColumn";
            this.creatorDataGridViewTextBoxColumn.ReadOnly = true;
            this.creatorDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.creatorDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.creatorDataGridViewTextBoxColumn.ValueMember = "Id";
            this.creatorDataGridViewTextBoxColumn.Width = 150;
            // 
            // sTAFFBindingSource
            // 
            this.sTAFFBindingSource.DataMember = "STAFF";
            this.sTAFFBindingSource.DataSource = this.sellManagementDbDataSet;
            // 
            // createDateDataGridViewTextBoxColumn
            // 
            this.createDateDataGridViewTextBoxColumn.DataPropertyName = "CreateDate";
            this.createDateDataGridViewTextBoxColumn.HeaderText = "Ngày lập";
            this.createDateDataGridViewTextBoxColumn.Name = "createDateDataGridViewTextBoxColumn";
            this.createDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.createDateDataGridViewTextBoxColumn.Width = 150;
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
            // 
            // finalPriceDataGridViewTextBoxColumn
            // 
            this.finalPriceDataGridViewTextBoxColumn.DataPropertyName = "FinalPrice";
            this.finalPriceDataGridViewTextBoxColumn.HeaderText = "Tổng hóa đơn";
            this.finalPriceDataGridViewTextBoxColumn.Name = "finalPriceDataGridViewTextBoxColumn";
            this.finalPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.finalPriceDataGridViewTextBoxColumn.Width = 120;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.statusDataGridViewTextBoxColumn.HeaderText = "Trạng thái";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.statusDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // customerOrderViewBindingSource
            // 
            this.customerOrderViewBindingSource.DataMember = "Customer_Order_View";
            this.customerOrderViewBindingSource.DataSource = this.sellManagementDbDataSet;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(952, 226);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Chi ra";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.documentKeyDataGridViewTextBoxColumn1,
            this.vendoridDataGridViewTextBoxColumn,
            this.creatorDataGridViewTextBoxColumn1,
            this.createDateDataGridViewTextBoxColumn1,
            this.totalPriceDataGridViewTextBoxColumn1,
            this.vATDataGridViewTextBoxColumn1,
            this.finalPriceDataGridViewTextBoxColumn1,
            this.statusDataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.vendorOrderViewBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(952, 185);
            this.dataGridView1.TabIndex = 0;
            // 
            // documentKeyDataGridViewTextBoxColumn1
            // 
            this.documentKeyDataGridViewTextBoxColumn1.DataPropertyName = "DocumentKey";
            this.documentKeyDataGridViewTextBoxColumn1.HeaderText = "Mã đơn hàng";
            this.documentKeyDataGridViewTextBoxColumn1.Name = "documentKeyDataGridViewTextBoxColumn1";
            this.documentKeyDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // vendoridDataGridViewTextBoxColumn
            // 
            this.vendoridDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.vendoridDataGridViewTextBoxColumn.DataPropertyName = "Vendor_id";
            this.vendoridDataGridViewTextBoxColumn.DataSource = this.vENDORBindingSource;
            this.vendoridDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.vendoridDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.vendoridDataGridViewTextBoxColumn.HeaderText = "Nhà cung cấp";
            this.vendoridDataGridViewTextBoxColumn.Name = "vendoridDataGridViewTextBoxColumn";
            this.vendoridDataGridViewTextBoxColumn.ReadOnly = true;
            this.vendoridDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.vendoridDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.vendoridDataGridViewTextBoxColumn.ValueMember = "Id";
            // 
            // vENDORBindingSource
            // 
            this.vENDORBindingSource.DataMember = "VENDOR";
            this.vENDORBindingSource.DataSource = this.sellManagementDbDataSet;
            // 
            // creatorDataGridViewTextBoxColumn1
            // 
            this.creatorDataGridViewTextBoxColumn1.DataPropertyName = "Creator";
            this.creatorDataGridViewTextBoxColumn1.DataSource = this.sTAFFBindingSource;
            this.creatorDataGridViewTextBoxColumn1.DisplayMember = "Name";
            this.creatorDataGridViewTextBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.creatorDataGridViewTextBoxColumn1.HeaderText = "Người lập";
            this.creatorDataGridViewTextBoxColumn1.Name = "creatorDataGridViewTextBoxColumn1";
            this.creatorDataGridViewTextBoxColumn1.ReadOnly = true;
            this.creatorDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.creatorDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.creatorDataGridViewTextBoxColumn1.ValueMember = "Id";
            this.creatorDataGridViewTextBoxColumn1.Width = 150;
            // 
            // createDateDataGridViewTextBoxColumn1
            // 
            this.createDateDataGridViewTextBoxColumn1.DataPropertyName = "CreateDate";
            this.createDateDataGridViewTextBoxColumn1.HeaderText = "Ngày lập";
            this.createDateDataGridViewTextBoxColumn1.Name = "createDateDataGridViewTextBoxColumn1";
            this.createDateDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // totalPriceDataGridViewTextBoxColumn1
            // 
            this.totalPriceDataGridViewTextBoxColumn1.DataPropertyName = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn1.HeaderText = "Tổng tiền";
            this.totalPriceDataGridViewTextBoxColumn1.Name = "totalPriceDataGridViewTextBoxColumn1";
            this.totalPriceDataGridViewTextBoxColumn1.ReadOnly = true;
            this.totalPriceDataGridViewTextBoxColumn1.Width = 150;
            // 
            // vATDataGridViewTextBoxColumn1
            // 
            this.vATDataGridViewTextBoxColumn1.DataPropertyName = "VAT";
            this.vATDataGridViewTextBoxColumn1.HeaderText = "VAT";
            this.vATDataGridViewTextBoxColumn1.Name = "vATDataGridViewTextBoxColumn1";
            this.vATDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // finalPriceDataGridViewTextBoxColumn1
            // 
            this.finalPriceDataGridViewTextBoxColumn1.DataPropertyName = "FinalPrice";
            this.finalPriceDataGridViewTextBoxColumn1.HeaderText = "Tổng hóa đơn";
            this.finalPriceDataGridViewTextBoxColumn1.Name = "finalPriceDataGridViewTextBoxColumn1";
            this.finalPriceDataGridViewTextBoxColumn1.ReadOnly = true;
            this.finalPriceDataGridViewTextBoxColumn1.Width = 150;
            // 
            // statusDataGridViewTextBoxColumn1
            // 
            this.statusDataGridViewTextBoxColumn1.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn1.HeaderText = "Trạng thái";
            this.statusDataGridViewTextBoxColumn1.Name = "statusDataGridViewTextBoxColumn1";
            this.statusDataGridViewTextBoxColumn1.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.statusDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // vendorOrderViewBindingSource
            // 
            this.vendorOrderViewBindingSource.DataMember = "Vendor_Order_View";
            this.vendorOrderViewBindingSource.DataSource = this.sellManagementDbDataSet;
            // 
            // customer_Order_ViewTableAdapter
            // 
            this.customer_Order_ViewTableAdapter.ClearBeforeFill = true;
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.Location = new System.Drawing.Point(901, 421);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 6;
            this.closeBtn.Text = "Đóng";
            this.closeBtn.UseVisualStyleBackColor = true;
            // 
            // cUSTOMERTableAdapter
            // 
            this.cUSTOMERTableAdapter.ClearBeforeFill = true;
            // 
            // sTAFFTableAdapter
            // 
            this.sTAFFTableAdapter.ClearBeforeFill = true;
            // 
            // vendor_Order_ViewTableAdapter
            // 
            this.vendor_Order_ViewTableAdapter.ClearBeforeFill = true;
            // 
            // vENDORTableAdapter
            // 
            this.vENDORTableAdapter.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(169, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Tổng số khách hàng";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Tổng số hóa đơn";
            // 
            // RevenueReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Name = "RevenueReport";
            this.Size = new System.Drawing.Size(1000, 461);
            this.Load += new System.EventHandler(this.RevenueReport_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.incomeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellManagementDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTAFFBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerOrderViewBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENDORBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorOrderViewBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker beginDateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox incomeText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView incomeDataGridView;
        private System.Windows.Forms.BindingSource customerOrderViewBindingSource;
        private SellManagementDbDataSet sellManagementDbDataSet;
        private SellManagementDbDataSetTableAdapters.Customer_Order_ViewTableAdapter customer_Order_ViewTableAdapter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.BindingSource cUSTOMERBindingSource;
        private System.Windows.Forms.BindingSource sTAFFBindingSource;
        private SellManagementDbDataSetTableAdapters.CUSTOMERTableAdapter cUSTOMERTableAdapter;
        private SellManagementDbDataSetTableAdapters.STAFFTableAdapter sTAFFTableAdapter;
        private System.Windows.Forms.DataGridViewComboBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vATDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn creatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn customeridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentKeyDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button viewBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource vendorOrderViewBindingSource;
        private SellManagementDbDataSetTableAdapters.Vendor_Order_ViewTableAdapter vendor_Order_ViewTableAdapter;
        private System.Windows.Forms.BindingSource vENDORBindingSource;
        private SellManagementDbDataSetTableAdapters.VENDORTableAdapter vENDORTableAdapter;
        private System.Windows.Forms.DataGridViewComboBoxColumn statusDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalPriceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn vATDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn creatorDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn vendoridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentKeyDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}
