namespace QuanLyBanHang.Forms
{
    partial class CustomerList
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
            this.searchText = new System.Windows.Forms.TextBox();
            this.customerDataGridView = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sellManagementDbDataSet = new QuanLyBanHang.SellManagementDbDataSet();
            this.customerTableAdapter = new QuanLyBanHang.SellManagementDbDataSetTableAdapters.CUSTOMERTableAdapter();
            this.addNewCustomerBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.infoGroupBox = new System.Windows.Forms.GroupBox();
            this.birthdayPicker = new System.Windows.Forms.DateTimePicker();
            this.customerAddress = new WindowsFormsControlLibrary.CustomTextBox();
            this.customerEmail = new WindowsFormsControlLibrary.CustomTextBox();
            this.customerPhone = new WindowsFormsControlLibrary.CustomTextBox();
            this.customerId = new WindowsFormsControlLibrary.CustomTextBox();
            this.customerName = new WindowsFormsControlLibrary.CustomTextBox();
            this.editBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.customerTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.customerGenderComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.customerKeyText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.purchasE_ORDERTableAdapter = new QuanLyBanHang.SellManagementDbDataSetTableAdapters.PURCHASE_ORDERTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellManagementDbDataSet)).BeginInit();
            this.infoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm kiếm";
            // 
            // searchText
            // 
            this.searchText.Location = new System.Drawing.Point(75, 21);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(200, 20);
            this.searchText.TabIndex = 1;
            this.searchText.TextChanged += new System.EventHandler(this.searchText_TextChanged);
            // 
            // customerDataGridView
            // 
            this.customerDataGridView.AllowUserToAddRows = false;
            this.customerDataGridView.AllowUserToDeleteRows = false;
            this.customerDataGridView.AllowUserToResizeRows = false;
            this.customerDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customerDataGridView.AutoGenerateColumns = false;
            this.customerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.customerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.nameColumn,
            this.phoneColumn});
            this.customerDataGridView.ContextMenuStrip = this.contextMenuStrip;
            this.customerDataGridView.DataSource = this.customerTableBindingSource;
            this.customerDataGridView.Location = new System.Drawing.Point(20, 54);
            this.customerDataGridView.Name = "customerDataGridView";
            this.customerDataGridView.ReadOnly = true;
            this.customerDataGridView.RowHeadersVisible = false;
            this.customerDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customerDataGridView.Size = new System.Drawing.Size(415, 325);
            this.customerDataGridView.TabIndex = 2;
            this.customerDataGridView.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerDataGridView_RowLeave);
            // 
            // idColumn
            // 
            this.idColumn.DataPropertyName = "CustomerKey";
            this.idColumn.HeaderText = "Mã khách hàng";
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            // 
            // nameColumn
            // 
            this.nameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameColumn.DataPropertyName = "Name";
            this.nameColumn.HeaderText = "Tên";
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.ReadOnly = true;
            // 
            // phoneColumn
            // 
            this.phoneColumn.DataPropertyName = "Phone";
            this.phoneColumn.HeaderText = "Số điện thoại";
            this.phoneColumn.Name = "phoneColumn";
            this.phoneColumn.ReadOnly = true;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(95, 48);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.editToolStripMenuItem.Text = "Sửa";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.deleteToolStripMenuItem.Text = "Xóa";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // customerTableBindingSource
            // 
            this.customerTableBindingSource.DataMember = "CUSTOMER";
            this.customerTableBindingSource.DataSource = this.sellManagementDbDataSet;
            // 
            // sellManagementDbDataSet
            // 
            this.sellManagementDbDataSet.DataSetName = "SellManagementDbDataSet";
            this.sellManagementDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // addNewCustomerBtn
            // 
            this.addNewCustomerBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addNewCustomerBtn.Location = new System.Drawing.Point(21, 393);
            this.addNewCustomerBtn.Name = "addNewCustomerBtn";
            this.addNewCustomerBtn.Size = new System.Drawing.Size(75, 23);
            this.addNewCustomerBtn.TabIndex = 2;
            this.addNewCustomerBtn.Text = "Thêm";
            this.addNewCustomerBtn.UseVisualStyleBackColor = true;
            this.addNewCustomerBtn.Click += new System.EventHandler(this.addNewCustomerBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.Location = new System.Drawing.Point(705, 393);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 14;
            this.closeBtn.Text = "Đóng";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // infoGroupBox
            // 
            this.infoGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infoGroupBox.Controls.Add(this.birthdayPicker);
            this.infoGroupBox.Controls.Add(this.customerAddress);
            this.infoGroupBox.Controls.Add(this.customerEmail);
            this.infoGroupBox.Controls.Add(this.customerPhone);
            this.infoGroupBox.Controls.Add(this.customerId);
            this.infoGroupBox.Controls.Add(this.customerName);
            this.infoGroupBox.Controls.Add(this.editBtn);
            this.infoGroupBox.Controls.Add(this.cancelBtn);
            this.infoGroupBox.Controls.Add(this.saveBtn);
            this.infoGroupBox.Controls.Add(this.customerTypeComboBox);
            this.infoGroupBox.Controls.Add(this.label10);
            this.infoGroupBox.Controls.Add(this.label9);
            this.infoGroupBox.Controls.Add(this.customerGenderComboBox);
            this.infoGroupBox.Controls.Add(this.label8);
            this.infoGroupBox.Controls.Add(this.label7);
            this.infoGroupBox.Controls.Add(this.label6);
            this.infoGroupBox.Controls.Add(this.label5);
            this.infoGroupBox.Controls.Add(this.label4);
            this.infoGroupBox.Controls.Add(this.label3);
            this.infoGroupBox.Controls.Add(this.customerKeyText);
            this.infoGroupBox.Controls.Add(this.label2);
            this.infoGroupBox.Location = new System.Drawing.Point(452, 21);
            this.infoGroupBox.Name = "infoGroupBox";
            this.infoGroupBox.Size = new System.Drawing.Size(328, 358);
            this.infoGroupBox.TabIndex = 6;
            this.infoGroupBox.TabStop = false;
            this.infoGroupBox.Text = "Thông tin";
            // 
            // birthdayPicker
            // 
            this.birthdayPicker.CustomFormat = "dd\'/\'MM\'/\'yyyy";
            this.birthdayPicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.customerTableBindingSource, "BirthDay", true));
            this.birthdayPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.birthdayPicker.Location = new System.Drawing.Point(137, 256);
            this.birthdayPicker.MaxDate = new System.DateTime(2000, 12, 31, 0, 0, 0, 0);
            this.birthdayPicker.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.birthdayPicker.Name = "birthdayPicker";
            this.birthdayPicker.Size = new System.Drawing.Size(170, 20);
            this.birthdayPicker.TabIndex = 22;
            this.birthdayPicker.Value = new System.DateTime(2000, 12, 31, 0, 0, 0, 0);
            // 
            // customerAddress
            // 
            this.customerAddress.AutoSize = true;
            this.customerAddress.BackColor = System.Drawing.Color.White;
            this.customerAddress.BorderColor = System.Drawing.Color.Silver;
            this.customerAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerTableBindingSource, "Address", true));
            this.customerAddress.ErrorBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.customerAddress.HoverBorderColor = System.Drawing.Color.Cyan;
            this.customerAddress.isRequired = false;
            this.customerAddress.Location = new System.Drawing.Point(137, 160);
            this.customerAddress.Multiline = true;
            this.customerAddress.Name = "customerAddress";
            this.customerAddress.NormalBorderColor = System.Drawing.Color.Silver;
            this.customerAddress.PanelBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.customerAddress.ReadOnly = false;
            this.customerAddress.Size = new System.Drawing.Size(170, 63);
            this.customerAddress.StringPattern = "";
            this.customerAddress.TabIndex = 7;
            this.customerAddress.TextPadding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.customerAddress.TextPanelMessage = "Nhập địa chỉ không hợp lệ.";
            this.customerAddress.TextPanelMessageColor = System.Drawing.Color.White;
            this.customerAddress.ValidBorderColor = System.Drawing.Color.LightGreen;
            // 
            // customerEmail
            // 
            this.customerEmail.AutoSize = true;
            this.customerEmail.BackColor = System.Drawing.Color.White;
            this.customerEmail.BorderColor = System.Drawing.Color.Silver;
            this.customerEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerTableBindingSource, "Email", true));
            this.customerEmail.ErrorBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.customerEmail.HoverBorderColor = System.Drawing.Color.Cyan;
            this.customerEmail.isRequired = false;
            this.customerEmail.Location = new System.Drawing.Point(137, 135);
            this.customerEmail.Multiline = false;
            this.customerEmail.Name = "customerEmail";
            this.customerEmail.NormalBorderColor = System.Drawing.Color.Silver;
            this.customerEmail.PanelBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.customerEmail.ReadOnly = false;
            this.customerEmail.Size = new System.Drawing.Size(170, 19);
            this.customerEmail.StringPattern = "^\\w+([-+.\']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*$";
            this.customerEmail.TabIndex = 6;
            this.customerEmail.TextPadding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.customerEmail.TextPanelMessage = "Nhập email không hợp lệ.";
            this.customerEmail.TextPanelMessageColor = System.Drawing.Color.White;
            this.customerEmail.ValidBorderColor = System.Drawing.Color.LightGreen;
            this.customerEmail.xTextChanged += new System.EventHandler(this.customerName_xTextChanged);
            // 
            // customerPhone
            // 
            this.customerPhone.AutoSize = true;
            this.customerPhone.BackColor = System.Drawing.Color.White;
            this.customerPhone.BorderColor = System.Drawing.Color.Silver;
            this.customerPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerTableBindingSource, "Phone", true));
            this.customerPhone.ErrorBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.customerPhone.HoverBorderColor = System.Drawing.Color.Cyan;
            this.customerPhone.isRequired = true;
            this.customerPhone.Location = new System.Drawing.Point(137, 110);
            this.customerPhone.Multiline = false;
            this.customerPhone.Name = "customerPhone";
            this.customerPhone.NormalBorderColor = System.Drawing.Color.Silver;
            this.customerPhone.PanelBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.customerPhone.ReadOnly = false;
            this.customerPhone.Size = new System.Drawing.Size(170, 19);
            this.customerPhone.StringPattern = "^([0-9 ])*$";
            this.customerPhone.TabIndex = 5;
            this.customerPhone.TextPadding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.customerPhone.TextPanelMessage = "Nhập số đt không hợp lệ";
            this.customerPhone.TextPanelMessageColor = System.Drawing.Color.White;
            this.customerPhone.ValidBorderColor = System.Drawing.Color.LightGreen;
            this.customerPhone.xTextChanged += new System.EventHandler(this.customerName_xTextChanged);
            // 
            // customerId
            // 
            this.customerId.AutoSize = true;
            this.customerId.BackColor = System.Drawing.Color.White;
            this.customerId.BorderColor = System.Drawing.Color.Silver;
            this.customerId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerTableBindingSource, "IdentifyNumber", true));
            this.customerId.ErrorBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.customerId.HoverBorderColor = System.Drawing.Color.Cyan;
            this.customerId.isRequired = false;
            this.customerId.Location = new System.Drawing.Point(137, 85);
            this.customerId.Multiline = false;
            this.customerId.Name = "customerId";
            this.customerId.NormalBorderColor = System.Drawing.Color.Silver;
            this.customerId.PanelBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.customerId.ReadOnly = false;
            this.customerId.Size = new System.Drawing.Size(170, 19);
            this.customerId.StringPattern = "^([0-9])*$";
            this.customerId.TabIndex = 4;
            this.customerId.TextPadding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.customerId.TextPanelMessage = "Nhập cmnd không hợp lệ. (0-9)";
            this.customerId.TextPanelMessageColor = System.Drawing.Color.White;
            this.customerId.ValidBorderColor = System.Drawing.Color.LightGreen;
            this.customerId.xTextChanged += new System.EventHandler(this.customerName_xTextChanged);
            // 
            // customerName
            // 
            this.customerName.AutoSize = true;
            this.customerName.BackColor = System.Drawing.Color.White;
            this.customerName.BorderColor = System.Drawing.Color.Silver;
            this.customerName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerTableBindingSource, "Name", true));
            this.customerName.ErrorBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.customerName.HoverBorderColor = System.Drawing.Color.Cyan;
            this.customerName.isRequired = true;
            this.customerName.Location = new System.Drawing.Point(137, 60);
            this.customerName.Multiline = false;
            this.customerName.Name = "customerName";
            this.customerName.NormalBorderColor = System.Drawing.Color.Silver;
            this.customerName.PanelBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.customerName.ReadOnly = false;
            this.customerName.Size = new System.Drawing.Size(170, 19);
            this.customerName.StringPattern = "^([ẮẰẲẴẶĂẤẦẨẪẬÂÁÀÃẢẠĐẾỀỂỄỆÊÉÈẺẼẸÍÌỈĨỊỐỒỔỖỘÔỚỜỞỠỢƠÓÒÕỎỌỨỪỬỮỰƯÚÙỦŨỤÝỲỶỸỴA-Za-z0-9 ]" +
    ")*$";
            this.customerName.TabIndex = 3;
            this.customerName.TextPadding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.customerName.TextPanelMessage = "Nhập tên không hợp lệ.";
            this.customerName.TextPanelMessageColor = System.Drawing.Color.White;
            this.customerName.ValidBorderColor = System.Drawing.Color.LightGreen;
            this.customerName.xTextChanged += new System.EventHandler(this.customerName_xTextChanged);
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(23, 323);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(75, 23);
            this.editBtn.TabIndex = 3;
            this.editBtn.Text = "Sửa";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBtn.Location = new System.Drawing.Point(137, 323);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 13;
            this.cancelBtn.Text = "Hủy";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveBtn.Location = new System.Drawing.Point(232, 323);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 12;
            this.saveBtn.Text = "Lưu";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // customerTypeComboBox
            // 
            this.customerTypeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.customerTableBindingSource, "Group_id", true));
            this.customerTypeComboBox.FormattingEnabled = true;
            this.customerTypeComboBox.Location = new System.Drawing.Point(137, 282);
            this.customerTypeComboBox.Name = "customerTypeComboBox";
            this.customerTypeComboBox.Size = new System.Drawing.Size(170, 21);
            this.customerTypeComboBox.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 285);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Loại khách hàng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 259);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Ngày sinh";
            // 
            // customerGenderComboBox
            // 
            this.customerGenderComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.customerTableBindingSource, "Gender", true));
            this.customerGenderComboBox.FormattingEnabled = true;
            this.customerGenderComboBox.Location = new System.Drawing.Point(137, 229);
            this.customerGenderComboBox.Name = "customerGenderComboBox";
            this.customerGenderComboBox.Size = new System.Drawing.Size(170, 21);
            this.customerGenderComboBox.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Giới tính";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Địa chỉ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Số điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "CMND";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ tên";
            // 
            // customerKeyText
            // 
            this.customerKeyText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerTableBindingSource, "CustomerKey", true));
            this.customerKeyText.Location = new System.Drawing.Point(137, 33);
            this.customerKeyText.Name = "customerKeyText";
            this.customerKeyText.ReadOnly = true;
            this.customerKeyText.Size = new System.Drawing.Size(170, 20);
            this.customerKeyText.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã khách hàng";
            // 
            // deleteBtn
            // 
            this.deleteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteBtn.Location = new System.Drawing.Point(360, 393);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 17;
            this.deleteBtn.Text = "Xóa";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // purchasE_ORDERTableAdapter
            // 
            this.purchasE_ORDERTableAdapter.ClearBeforeFill = true;
            // 
            // CustomerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.infoGroupBox);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.addNewCustomerBtn);
            this.Controls.Add(this.customerDataGridView);
            this.Controls.Add(this.searchText);
            this.Controls.Add(this.label1);
            this.Name = "CustomerList";
            this.Size = new System.Drawing.Size(800, 430);
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customerTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellManagementDbDataSet)).EndInit();
            this.infoGroupBox.ResumeLayout(false);
            this.infoGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.DataGridView customerDataGridView;
        private System.Windows.Forms.BindingSource customerTableBindingSource;
        private SellManagementDbDataSet sellManagementDbDataSet;
        private SellManagementDbDataSetTableAdapters.CUSTOMERTableAdapter customerTableAdapter;
        private System.Windows.Forms.Button addNewCustomerBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.ComboBox customerTypeComboBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox customerGenderComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox customerKeyText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox infoGroupBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker birthdayPicker;
        private WindowsFormsControlLibrary.CustomTextBox customerAddress;
        private WindowsFormsControlLibrary.CustomTextBox customerEmail;
        private WindowsFormsControlLibrary.CustomTextBox customerPhone;
        private WindowsFormsControlLibrary.CustomTextBox customerId;
        private WindowsFormsControlLibrary.CustomTextBox customerName;
        private SellManagementDbDataSetTableAdapters.PURCHASE_ORDERTableAdapter purchasE_ORDERTableAdapter;
    }
}
