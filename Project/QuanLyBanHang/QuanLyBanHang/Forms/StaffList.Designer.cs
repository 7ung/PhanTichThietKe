namespace QuanLyBanHang.Forms
{
    partial class StaffList
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
            System.Windows.Forms.Label genderLabel1;
            System.Windows.Forms.Label staffKeyLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label identifyNumberLabel;
            System.Windows.Forms.Label functionLabel;
            System.Windows.Forms.Label birthdayLabel;
            System.Windows.Forms.Label salaryLabel;
            this.sellManagementDbDataSet = new QuanLyBanHang.SellManagementDbDataSet();
            this.sTAFFBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sTAFFTableAdapter = new QuanLyBanHang.SellManagementDbDataSetTableAdapters.STAFFTableAdapter();
            this.tableAdapterManager = new QuanLyBanHang.SellManagementDbDataSetTableAdapters.TableAdapterManager();
            this.sTAFFDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbbFunction = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.cbbGender = new System.Windows.Forms.ComboBox();
            this.tbStaffKey = new System.Windows.Forms.TextBox();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.tbSalary = new WindowsFormsControlLibrary.CustomTextBox();
            this.tbAddress = new WindowsFormsControlLibrary.CustomTextBox();
            this.tbIdentifyNumber = new WindowsFormsControlLibrary.CustomTextBox();
            this.tbEmail = new WindowsFormsControlLibrary.CustomTextBox();
            this.tbPhone = new WindowsFormsControlLibrary.CustomTextBox();
            this.tbNameStaff = new WindowsFormsControlLibrary.CustomTextBox();
            this.genderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            genderLabel1 = new System.Windows.Forms.Label();
            staffKeyLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            identifyNumberLabel = new System.Windows.Forms.Label();
            functionLabel = new System.Windows.Forms.Label();
            birthdayLabel = new System.Windows.Forms.Label();
            salaryLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sellManagementDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTAFFBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTAFFDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // genderLabel1
            // 
            genderLabel1.AutoSize = true;
            genderLabel1.Location = new System.Drawing.Point(18, 108);
            genderLabel1.Name = "genderLabel1";
            genderLabel1.Size = new System.Drawing.Size(47, 13);
            genderLabel1.TabIndex = 47;
            genderLabel1.Text = "Giới tính";
            // 
            // staffKeyLabel
            // 
            staffKeyLabel.AutoSize = true;
            staffKeyLabel.Location = new System.Drawing.Point(18, 24);
            staffKeyLabel.Name = "staffKeyLabel";
            staffKeyLabel.Size = new System.Drawing.Size(72, 13);
            staffKeyLabel.TabIndex = 31;
            staffKeyLabel.Text = "Mã nhân viên";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(18, 81);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(70, 13);
            phoneLabel.TabIndex = 33;
            phoneLabel.Text = "Số điện thoại";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(18, 137);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 35;
            emailLabel.Text = "Email:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(18, 163);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(40, 13);
            addressLabel.TabIndex = 37;
            addressLabel.Text = "Địa chỉ";
            // 
            // identifyNumberLabel
            // 
            identifyNumberLabel.AutoSize = true;
            identifyNumberLabel.Location = new System.Drawing.Point(18, 230);
            identifyNumberLabel.Name = "identifyNumberLabel";
            identifyNumberLabel.Size = new System.Drawing.Size(55, 13);
            identifyNumberLabel.TabIndex = 39;
            identifyNumberLabel.Text = "Số CMND";
            // 
            // functionLabel
            // 
            functionLabel.AutoSize = true;
            functionLabel.Location = new System.Drawing.Point(18, 260);
            functionLabel.Name = "functionLabel";
            functionLabel.Size = new System.Drawing.Size(47, 13);
            functionLabel.TabIndex = 41;
            functionLabel.Text = "Chức vụ";
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Location = new System.Drawing.Point(18, 291);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new System.Drawing.Size(54, 13);
            birthdayLabel.TabIndex = 43;
            birthdayLabel.Text = "Ngày sinh";
            // 
            // salaryLabel
            // 
            salaryLabel.AutoSize = true;
            salaryLabel.Location = new System.Drawing.Point(18, 320);
            salaryLabel.Name = "salaryLabel";
            salaryLabel.Size = new System.Drawing.Size(37, 13);
            salaryLabel.TabIndex = 45;
            salaryLabel.Text = "Lương";
            // 
            // sellManagementDbDataSet
            // 
            this.sellManagementDbDataSet.DataSetName = "SellManagementDbDataSet";
            this.sellManagementDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sTAFFBindingSource
            // 
            this.sTAFFBindingSource.DataMember = "STAFF";
            this.sTAFFBindingSource.DataSource = this.sellManagementDbDataSet;
            // 
            // sTAFFTableAdapter
            // 
            this.sTAFFTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.PRODUCTTableAdapter = null;
            this.tableAdapterManager.PURCHASE_ORDERTableAdapter = null;
            this.tableAdapterManager.QUOTE_DETAILTableAdapter = null;
            this.tableAdapterManager.QUOTETableAdapter = null;
            this.tableAdapterManager.STAFFTableAdapter = this.sTAFFTableAdapter;
            this.tableAdapterManager.UpdateOrder = QuanLyBanHang.SellManagementDbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VENDOR_BILLTableAdapter = null;
            this.tableAdapterManager.VENDOR_DEBTTableAdapter = null;
            this.tableAdapterManager.VENDOR_ORDERTableAdapter = null;
            this.tableAdapterManager.VENDORORDER_DETAILTableAdapter = null;
            this.tableAdapterManager.VENDORTableAdapter = null;
            // 
            // sTAFFDataGridView
            // 
            this.sTAFFDataGridView.AllowUserToAddRows = false;
            this.sTAFFDataGridView.AllowUserToDeleteRows = false;
            this.sTAFFDataGridView.AutoGenerateColumns = false;
            this.sTAFFDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sTAFFDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.Phone});
            this.sTAFFDataGridView.DataSource = this.sTAFFBindingSource;
            this.sTAFFDataGridView.Location = new System.Drawing.Point(14, 65);
            this.sTAFFDataGridView.Name = "sTAFFDataGridView";
            this.sTAFFDataGridView.ReadOnly = true;
            this.sTAFFDataGridView.Size = new System.Drawing.Size(470, 339);
            this.sTAFFDataGridView.TabIndex = 1;
            this.sTAFFDataGridView.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.sTAFFDataGridView_RowLeave);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "StaffKey";
            this.dataGridViewTextBoxColumn2.HeaderText = "StaffKey";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "Phone";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(116, 24);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(232, 20);
            this.tbSearch.TabIndex = 22;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Tìm kiếm";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(14, 421);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 24;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(409, 421);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(748, 421);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 29;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.tbSalary);
            this.groupBox1.Controls.Add(this.tbAddress);
            this.groupBox1.Controls.Add(this.cbbFunction);
            this.groupBox1.Controls.Add(this.tbIdentifyNumber);
            this.groupBox1.Controls.Add(this.tbEmail);
            this.groupBox1.Controls.Add(this.tbPhone);
            this.groupBox1.Controls.Add(this.tbNameStaff);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(genderLabel1);
            this.groupBox1.Controls.Add(this.cbbGender);
            this.groupBox1.Controls.Add(staffKeyLabel);
            this.groupBox1.Controls.Add(this.tbStaffKey);
            this.groupBox1.Controls.Add(phoneLabel);
            this.groupBox1.Controls.Add(emailLabel);
            this.groupBox1.Controls.Add(addressLabel);
            this.groupBox1.Controls.Add(identifyNumberLabel);
            this.groupBox1.Controls.Add(functionLabel);
            this.groupBox1.Controls.Add(birthdayLabel);
            this.groupBox1.Controls.Add(this.dtpBirthday);
            this.groupBox1.Controls.Add(salaryLabel);
            this.groupBox1.Location = new System.Drawing.Point(496, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 391);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(293, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 23);
            this.button1.TabIndex = 61;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbbFunction
            // 
            this.cbbFunction.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sTAFFBindingSource, "Func", true));
            this.cbbFunction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbFunction.FormattingEnabled = true;
            this.cbbFunction.Location = new System.Drawing.Point(108, 256);
            this.cbbFunction.Name = "cbbFunction";
            this.cbbFunction.Size = new System.Drawing.Size(168, 21);
            this.cbbFunction.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 53;
            this.label2.Text = "Tên";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(252, 350);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 51;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(137, 350);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 50;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(21, 350);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 49;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // cbbGender
            // 
            this.cbbGender.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.sTAFFBindingSource, "Gender", true));
            this.cbbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGender.FormattingEnabled = true;
            this.cbbGender.Location = new System.Drawing.Point(108, 105);
            this.cbbGender.Name = "cbbGender";
            this.cbbGender.Size = new System.Drawing.Size(219, 21);
            this.cbbGender.TabIndex = 48;
            // 
            // tbStaffKey
            // 
            this.tbStaffKey.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sTAFFBindingSource, "StaffKey", true));
            this.tbStaffKey.Location = new System.Drawing.Point(108, 21);
            this.tbStaffKey.Name = "tbStaffKey";
            this.tbStaffKey.Size = new System.Drawing.Size(219, 20);
            this.tbStaffKey.TabIndex = 32;
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.CustomFormat = "dd\'/\'MM\'/\'yyyy";
            this.dtpBirthday.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.sTAFFBindingSource, "Birthday", true));
            this.dtpBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBirthday.Location = new System.Drawing.Point(108, 287);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(219, 20);
            this.dtpBirthday.TabIndex = 44;
            // 
            // tbSalary
            // 
            this.tbSalary.AutoSize = true;
            this.tbSalary.BackColor = System.Drawing.Color.White;
            this.tbSalary.BorderColor = System.Drawing.Color.Silver;
            this.tbSalary.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sTAFFBindingSource, "Salary", true));
            this.tbSalary.ErrorBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.tbSalary.HoverBorderColor = System.Drawing.Color.Cyan;
            this.tbSalary.isRequired = true;
            this.tbSalary.Location = new System.Drawing.Point(108, 317);
            this.tbSalary.Multiline = false;
            this.tbSalary.Name = "tbSalary";
            this.tbSalary.NormalBorderColor = System.Drawing.Color.Silver;
            this.tbSalary.PanelBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.tbSalary.ReadOnly = false;
            this.tbSalary.Size = new System.Drawing.Size(219, 19);
            this.tbSalary.StringPattern = "^([ẮẰẲẴẶĂẤẦẨẪẬÂÁÀÃẢẠĐẾỀỂỄỆÊÉÈẺẼẸÍÌỈĨỊỐỒỔỖỘÔỚỜỞỠỢƠÓÒÕỎỌỨỪỬỮỰƯÚÙỦŨỤÝỲỶỸỴA-Za-z0-9 ]" +
    ")*$";
            this.tbSalary.TabIndex = 60;
            this.tbSalary.TextPadding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.tbSalary.TextPanelMessage = "This is an error message.";
            this.tbSalary.TextPanelMessageColor = System.Drawing.Color.White;
            this.tbSalary.ValidBorderColor = System.Drawing.Color.LightGreen;
            // 
            // tbAddress
            // 
            this.tbAddress.AutoSize = true;
            this.tbAddress.BackColor = System.Drawing.Color.White;
            this.tbAddress.BorderColor = System.Drawing.Color.Silver;
            this.tbAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sTAFFBindingSource, "Address", true));
            this.tbAddress.ErrorBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.tbAddress.HoverBorderColor = System.Drawing.Color.Cyan;
            this.tbAddress.isRequired = true;
            this.tbAddress.Location = new System.Drawing.Point(108, 163);
            this.tbAddress.Multiline = true;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.NormalBorderColor = System.Drawing.Color.Silver;
            this.tbAddress.PanelBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.tbAddress.ReadOnly = false;
            this.tbAddress.Size = new System.Drawing.Size(219, 56);
            this.tbAddress.StringPattern = "^([ẮẰẲẴẶĂẤẦẨẪẬÂÁÀÃẢẠĐẾỀỂỄỆÊÉÈẺẼẸÍÌỈĨỊỐỒỔỖỘÔỚỜỞỠỢƠÓÒÕỎỌỨỪỬỮỰƯÚÙỦŨỤÝỲỶỸỴA-Za-z0-9 ]" +
    ")*$";
            this.tbAddress.TabIndex = 59;
            this.tbAddress.TextPadding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.tbAddress.TextPanelMessage = "This is an error message.";
            this.tbAddress.TextPanelMessageColor = System.Drawing.Color.White;
            this.tbAddress.ValidBorderColor = System.Drawing.Color.LightGreen;
            // 
            // tbIdentifyNumber
            // 
            this.tbIdentifyNumber.AutoSize = true;
            this.tbIdentifyNumber.BackColor = System.Drawing.Color.White;
            this.tbIdentifyNumber.BorderColor = System.Drawing.Color.Silver;
            this.tbIdentifyNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sTAFFBindingSource, "IdentifyNumber", true));
            this.tbIdentifyNumber.ErrorBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.tbIdentifyNumber.HoverBorderColor = System.Drawing.Color.Cyan;
            this.tbIdentifyNumber.isRequired = true;
            this.tbIdentifyNumber.Location = new System.Drawing.Point(108, 228);
            this.tbIdentifyNumber.Multiline = false;
            this.tbIdentifyNumber.Name = "tbIdentifyNumber";
            this.tbIdentifyNumber.NormalBorderColor = System.Drawing.Color.Silver;
            this.tbIdentifyNumber.PanelBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.tbIdentifyNumber.ReadOnly = false;
            this.tbIdentifyNumber.Size = new System.Drawing.Size(219, 19);
            this.tbIdentifyNumber.StringPattern = "^([ẮẰẲẴẶĂẤẦẨẪẬÂÁÀÃẢẠĐẾỀỂỄỆÊÉÈẺẼẸÍÌỈĨỊỐỒỔỖỘÔỚỜỞỠỢƠÓÒÕỎỌỨỪỬỮỰƯÚÙỦŨỤÝỲỶỸỴA-Za-z0-9 ]" +
    ")*$";
            this.tbIdentifyNumber.TabIndex = 57;
            this.tbIdentifyNumber.TextPadding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.tbIdentifyNumber.TextPanelMessage = "This is an error message.";
            this.tbIdentifyNumber.TextPanelMessageColor = System.Drawing.Color.White;
            this.tbIdentifyNumber.ValidBorderColor = System.Drawing.Color.LightGreen;
            // 
            // tbEmail
            // 
            this.tbEmail.AutoSize = true;
            this.tbEmail.BackColor = System.Drawing.Color.White;
            this.tbEmail.BorderColor = System.Drawing.Color.Silver;
            this.tbEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sTAFFBindingSource, "Email", true));
            this.tbEmail.ErrorBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.tbEmail.HoverBorderColor = System.Drawing.Color.Cyan;
            this.tbEmail.isRequired = true;
            this.tbEmail.Location = new System.Drawing.Point(108, 135);
            this.tbEmail.Multiline = false;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.NormalBorderColor = System.Drawing.Color.Silver;
            this.tbEmail.PanelBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.tbEmail.ReadOnly = false;
            this.tbEmail.Size = new System.Drawing.Size(219, 19);
            this.tbEmail.StringPattern = "^([ẮẰẲẴẶĂẤẦẨẪẬÂÁÀÃẢẠĐẾỀỂỄỆÊÉÈẺẼẸÍÌỈĨỊỐỒỔỖỘÔỚỜỞỠỢƠÓÒÕỎỌỨỪỬỮỰƯÚÙỦŨỤÝỲỶỸỴA-Za-z0-9 ]" +
    ")*$";
            this.tbEmail.TabIndex = 56;
            this.tbEmail.TextPadding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.tbEmail.TextPanelMessage = "This is an error message.";
            this.tbEmail.TextPanelMessageColor = System.Drawing.Color.White;
            this.tbEmail.ValidBorderColor = System.Drawing.Color.LightGreen;
            // 
            // tbPhone
            // 
            this.tbPhone.AutoSize = true;
            this.tbPhone.BackColor = System.Drawing.Color.White;
            this.tbPhone.BorderColor = System.Drawing.Color.Silver;
            this.tbPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sTAFFBindingSource, "Phone", true));
            this.tbPhone.ErrorBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.tbPhone.HoverBorderColor = System.Drawing.Color.Cyan;
            this.tbPhone.isRequired = true;
            this.tbPhone.Location = new System.Drawing.Point(108, 81);
            this.tbPhone.Multiline = false;
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.NormalBorderColor = System.Drawing.Color.Silver;
            this.tbPhone.PanelBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.tbPhone.ReadOnly = false;
            this.tbPhone.Size = new System.Drawing.Size(219, 19);
            this.tbPhone.StringPattern = "^([ẮẰẲẴẶĂẤẦẨẪẬÂÁÀÃẢẠĐẾỀỂỄỆÊÉÈẺẼẸÍÌỈĨỊỐỒỔỖỘÔỚỜỞỠỢƠÓÒÕỎỌỨỪỬỮỰƯÚÙỦŨỤÝỲỶỸỴA-Za-z0-9 ]" +
    ")*$";
            this.tbPhone.TabIndex = 55;
            this.tbPhone.TextPadding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.tbPhone.TextPanelMessage = "This is an error message.";
            this.tbPhone.TextPanelMessageColor = System.Drawing.Color.White;
            this.tbPhone.ValidBorderColor = System.Drawing.Color.LightGreen;
            // 
            // tbNameStaff
            // 
            this.tbNameStaff.AutoSize = true;
            this.tbNameStaff.BackColor = System.Drawing.Color.White;
            this.tbNameStaff.BorderColor = System.Drawing.Color.Silver;
            this.tbNameStaff.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sTAFFBindingSource, "Name", true));
            this.tbNameStaff.ErrorBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.tbNameStaff.HoverBorderColor = System.Drawing.Color.Cyan;
            this.tbNameStaff.isRequired = true;
            this.tbNameStaff.Location = new System.Drawing.Point(108, 50);
            this.tbNameStaff.Multiline = false;
            this.tbNameStaff.Name = "tbNameStaff";
            this.tbNameStaff.NormalBorderColor = System.Drawing.Color.Silver;
            this.tbNameStaff.PanelBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.tbNameStaff.ReadOnly = false;
            this.tbNameStaff.Size = new System.Drawing.Size(219, 19);
            this.tbNameStaff.StringPattern = "^([ẮẰẲẴẶĂẤẦẨẪẬÂÁÀÃẢẠĐẾỀỂỄỆÊÉÈẺẼẸÍÌỈĨỊỐỒỔỖỘÔỚỜỞỠỢƠÓÒÕỎỌỨỪỬỮỰƯÚÙỦŨỤÝỲỶỸỴA-Za-z0-9 ]" +
    ")*$";
            this.tbNameStaff.TabIndex = 54;
            this.tbNameStaff.TextPadding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.tbNameStaff.TextPanelMessage = "This is an error message.";
            this.tbNameStaff.TextPanelMessageColor = System.Drawing.Color.White;
            this.tbNameStaff.ValidBorderColor = System.Drawing.Color.LightGreen;
            // 
            // genderBindingSource
            // 
            this.genderBindingSource.DataSource = typeof(QuanLyBanHang.Models.Gender);
            // 
            // StaffList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.sTAFFDataGridView);
            this.Name = "StaffList";
            this.Size = new System.Drawing.Size(851, 461);
            ((System.ComponentModel.ISupportInitialize)(this.sellManagementDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTAFFBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTAFFDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SellManagementDbDataSet sellManagementDbDataSet;
        private System.Windows.Forms.BindingSource sTAFFBindingSource;
        private SellManagementDbDataSetTableAdapters.STAFFTableAdapter sTAFFTableAdapter;
        private SellManagementDbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView sTAFFDataGridView;
        private System.Windows.Forms.BindingSource genderBindingSource;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox tbStaffKey;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.Label label2;
        private WindowsFormsControlLibrary.CustomTextBox tbNameStaff;
        private System.Windows.Forms.ComboBox cbbFunction;
        private WindowsFormsControlLibrary.CustomTextBox tbIdentifyNumber;
        private WindowsFormsControlLibrary.CustomTextBox tbEmail;
        private WindowsFormsControlLibrary.CustomTextBox tbPhone;
        private WindowsFormsControlLibrary.CustomTextBox tbAddress;
        private WindowsFormsControlLibrary.CustomTextBox tbSalary;
        private System.Windows.Forms.ComboBox cbbGender;
        private System.Windows.Forms.Button button1;

    }
}
