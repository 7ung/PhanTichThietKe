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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.customerDataGridView = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sellManagementDbDataSet = new QuanLyBanHang.SellManagementDbDataSet();
            this.customerTableAdapter = new QuanLyBanHang.SellManagementDbDataSetTableAdapters.CUSTOMERTableAdapter();
            this.addNewCustomerBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.infoGroupBox = new System.Windows.Forms.GroupBox();
            this.editBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.customerTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.customerBirthdayText = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.customerGenderComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.customerAddText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.customerEmailText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.customerPhoneText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.customerIdText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.customerNameText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.customerKeyText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.deleteBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).BeginInit();
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(75, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 1;
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
            this.customerDataGridView.DataSource = this.customerTableBindingSource;
            this.customerDataGridView.Location = new System.Drawing.Point(21, 54);
            this.customerDataGridView.MultiSelect = false;
            this.customerDataGridView.Name = "customerDataGridView";
            this.customerDataGridView.ReadOnly = true;
            this.customerDataGridView.RowHeadersVisible = false;
            this.customerDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customerDataGridView.Size = new System.Drawing.Size(414, 323);
            this.customerDataGridView.TabIndex = 2;
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
            this.infoGroupBox.Controls.Add(this.editBtn);
            this.infoGroupBox.Controls.Add(this.cancelBtn);
            this.infoGroupBox.Controls.Add(this.saveBtn);
            this.infoGroupBox.Controls.Add(this.customerTypeComboBox);
            this.infoGroupBox.Controls.Add(this.label10);
            this.infoGroupBox.Controls.Add(this.customerBirthdayText);
            this.infoGroupBox.Controls.Add(this.label9);
            this.infoGroupBox.Controls.Add(this.customerGenderComboBox);
            this.infoGroupBox.Controls.Add(this.label8);
            this.infoGroupBox.Controls.Add(this.customerAddText);
            this.infoGroupBox.Controls.Add(this.label7);
            this.infoGroupBox.Controls.Add(this.customerEmailText);
            this.infoGroupBox.Controls.Add(this.label6);
            this.infoGroupBox.Controls.Add(this.customerPhoneText);
            this.infoGroupBox.Controls.Add(this.label5);
            this.infoGroupBox.Controls.Add(this.customerIdText);
            this.infoGroupBox.Controls.Add(this.label4);
            this.infoGroupBox.Controls.Add(this.customerNameText);
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
            // customerBirthdayText
            // 
            this.customerBirthdayText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerTableBindingSource, "BirthDay", true));
            this.customerBirthdayText.Location = new System.Drawing.Point(137, 256);
            this.customerBirthdayText.Name = "customerBirthdayText";
            this.customerBirthdayText.Size = new System.Drawing.Size(170, 20);
            this.customerBirthdayText.TabIndex = 10;
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
            // customerAddText
            // 
            this.customerAddText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerTableBindingSource, "Address", true));
            this.customerAddText.Location = new System.Drawing.Point(137, 163);
            this.customerAddText.Multiline = true;
            this.customerAddText.Name = "customerAddText";
            this.customerAddText.Size = new System.Drawing.Size(170, 60);
            this.customerAddText.TabIndex = 8;
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
            // customerEmailText
            // 
            this.customerEmailText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerTableBindingSource, "Email", true));
            this.customerEmailText.Location = new System.Drawing.Point(137, 137);
            this.customerEmailText.Name = "customerEmailText";
            this.customerEmailText.Size = new System.Drawing.Size(170, 20);
            this.customerEmailText.TabIndex = 7;
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
            // customerPhoneText
            // 
            this.customerPhoneText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerTableBindingSource, "Phone", true));
            this.customerPhoneText.Location = new System.Drawing.Point(137, 111);
            this.customerPhoneText.Name = "customerPhoneText";
            this.customerPhoneText.Size = new System.Drawing.Size(170, 20);
            this.customerPhoneText.TabIndex = 6;
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
            // customerIdText
            // 
            this.customerIdText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerTableBindingSource, "IdentifyNumber", true));
            this.customerIdText.Location = new System.Drawing.Point(137, 85);
            this.customerIdText.Name = "customerIdText";
            this.customerIdText.Size = new System.Drawing.Size(170, 20);
            this.customerIdText.TabIndex = 5;
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
            // customerNameText
            // 
            this.customerNameText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerTableBindingSource, "Name", true));
            this.customerNameText.Location = new System.Drawing.Point(137, 59);
            this.customerNameText.Name = "customerNameText";
            this.customerNameText.Size = new System.Drawing.Size(170, 20);
            this.customerNameText.TabIndex = 4;
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
            // CustomerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.infoGroupBox);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.addNewCustomerBtn);
            this.Controls.Add(this.customerDataGridView);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "CustomerList";
            this.Size = new System.Drawing.Size(800, 430);
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellManagementDbDataSet)).EndInit();
            this.infoGroupBox.ResumeLayout(false);
            this.infoGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
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
        private System.Windows.Forms.TextBox customerBirthdayText;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox customerGenderComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox customerAddText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox customerEmailText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox customerPhoneText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox customerIdText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox customerNameText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox customerKeyText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox infoGroupBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button deleteBtn;
    }
}
