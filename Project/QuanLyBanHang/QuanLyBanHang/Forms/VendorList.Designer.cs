namespace QuanLyBanHang.Forms
{
    partial class VendorList
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
            this.searchText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.vendorDataGridView = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sellManagementDbDataSet = new QuanLyBanHang.SellManagementDbDataSet();
            this.vendorTableAdapter = new QuanLyBanHang.SellManagementDbDataSetTableAdapters.VENDORTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.vendorPhone = new WindowsFormsControlLibrary.CustomTextBox();
            this.vendorEmail = new WindowsFormsControlLibrary.CustomTextBox();
            this.vendorAddress = new WindowsFormsControlLibrary.CustomTextBox();
            this.vendorName = new WindowsFormsControlLibrary.CustomTextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.newVendorBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.vendoR_ORDERTableAdapter = new QuanLyBanHang.SellManagementDbDataSetTableAdapters.VENDOR_ORDERTableAdapter();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.vendorDataGridView)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellManagementDbDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchText
            // 
            this.searchText.Location = new System.Drawing.Point(75, 21);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(200, 20);
            this.searchText.TabIndex = 1;
            this.searchText.TextChanged += new System.EventHandler(this.searchText_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tìm kiếm";
            // 
            // vendorDataGridView
            // 
            this.vendorDataGridView.AllowUserToAddRows = false;
            this.vendorDataGridView.AllowUserToDeleteRows = false;
            this.vendorDataGridView.AllowUserToResizeRows = false;
            this.vendorDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vendorDataGridView.AutoGenerateColumns = false;
            this.vendorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vendorDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameColumn,
            this.idColumn,
            this.phoneColumn,
            this.emailColumn});
            this.vendorDataGridView.ContextMenuStrip = this.contextMenuStrip;
            this.vendorDataGridView.DataSource = this.vendorBindingSource;
            this.vendorDataGridView.Location = new System.Drawing.Point(23, 54);
            this.vendorDataGridView.Name = "vendorDataGridView";
            this.vendorDataGridView.ReadOnly = true;
            this.vendorDataGridView.RowHeadersVisible = false;
            this.vendorDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.vendorDataGridView.Size = new System.Drawing.Size(415, 325);
            this.vendorDataGridView.TabIndex = 4;
            this.vendorDataGridView.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.vendorDataGridView_RowLeave);
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
            // vendorBindingSource
            // 
            this.vendorBindingSource.DataMember = "VENDOR";
            this.vendorBindingSource.DataSource = this.sellManagementDbDataSet;
            // 
            // sellManagementDbDataSet
            // 
            this.sellManagementDbDataSet.DataSetName = "SellManagementDbDataSet";
            this.sellManagementDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vendorTableAdapter
            // 
            this.vendorTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.vendorPhone);
            this.groupBox1.Controls.Add(this.vendorEmail);
            this.groupBox1.Controls.Add(this.vendorAddress);
            this.groupBox1.Controls.Add(this.vendorName);
            this.groupBox1.Controls.Add(this.saveBtn);
            this.groupBox1.Controls.Add(this.cancelBtn);
            this.groupBox1.Controls.Add(this.editBtn);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(455, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 358);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // vendorPhone
            // 
            this.vendorPhone.AutoSize = true;
            this.vendorPhone.BackColor = System.Drawing.Color.White;
            this.vendorPhone.BorderColor = System.Drawing.Color.Silver;
            this.vendorPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorBindingSource, "Phone", true));
            this.vendorPhone.ErrorBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.vendorPhone.HoverBorderColor = System.Drawing.Color.Cyan;
            this.vendorPhone.isRequired = false;
            this.vendorPhone.Location = new System.Drawing.Point(136, 150);
            this.vendorPhone.Multiline = false;
            this.vendorPhone.Name = "vendorPhone";
            this.vendorPhone.NormalBorderColor = System.Drawing.Color.Silver;
            this.vendorPhone.PanelBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.vendorPhone.ReadOnly = false;
            this.vendorPhone.Size = new System.Drawing.Size(170, 19);
            this.vendorPhone.StringPattern = "^[0-9 ]*$";
            this.vendorPhone.TabIndex = 13;
            this.vendorPhone.TextPadding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.vendorPhone.TextPanelMessage = "Nhập số điện thoại không hợp lệ";
            this.vendorPhone.TextPanelMessageColor = System.Drawing.Color.White;
            this.vendorPhone.ValidBorderColor = System.Drawing.Color.LightGreen;
            this.vendorPhone.xTextChanged += new System.EventHandler(this.vendorName_xTextChanged);
            // 
            // vendorEmail
            // 
            this.vendorEmail.AutoSize = true;
            this.vendorEmail.BackColor = System.Drawing.Color.White;
            this.vendorEmail.BorderColor = System.Drawing.Color.Silver;
            this.vendorEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorBindingSource, "Email", true));
            this.vendorEmail.ErrorBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.vendorEmail.HoverBorderColor = System.Drawing.Color.Cyan;
            this.vendorEmail.isRequired = false;
            this.vendorEmail.Location = new System.Drawing.Point(136, 125);
            this.vendorEmail.Multiline = false;
            this.vendorEmail.Name = "vendorEmail";
            this.vendorEmail.NormalBorderColor = System.Drawing.Color.Silver;
            this.vendorEmail.PanelBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.vendorEmail.ReadOnly = false;
            this.vendorEmail.Size = new System.Drawing.Size(170, 19);
            this.vendorEmail.StringPattern = "^\\w+([-+.\']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*$";
            this.vendorEmail.TabIndex = 12;
            this.vendorEmail.TextPadding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.vendorEmail.TextPanelMessage = "Nhập email không hợp lệ.";
            this.vendorEmail.TextPanelMessageColor = System.Drawing.Color.White;
            this.vendorEmail.ValidBorderColor = System.Drawing.Color.LightGreen;
            this.vendorEmail.xTextChanged += new System.EventHandler(this.vendorName_xTextChanged);
            // 
            // vendorAddress
            // 
            this.vendorAddress.AutoSize = true;
            this.vendorAddress.BackColor = System.Drawing.Color.White;
            this.vendorAddress.BorderColor = System.Drawing.Color.Silver;
            this.vendorAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorBindingSource, "Address", true));
            this.vendorAddress.ErrorBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.vendorAddress.HoverBorderColor = System.Drawing.Color.Cyan;
            this.vendorAddress.isRequired = true;
            this.vendorAddress.Location = new System.Drawing.Point(136, 59);
            this.vendorAddress.Multiline = true;
            this.vendorAddress.Name = "vendorAddress";
            this.vendorAddress.NormalBorderColor = System.Drawing.Color.Silver;
            this.vendorAddress.PanelBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.vendorAddress.ReadOnly = false;
            this.vendorAddress.Size = new System.Drawing.Size(170, 60);
            this.vendorAddress.StringPattern = "";
            this.vendorAddress.TabIndex = 11;
            this.vendorAddress.TextPadding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.vendorAddress.TextPanelMessage = "Nhập địa chỉ không hợp lệ.";
            this.vendorAddress.TextPanelMessageColor = System.Drawing.Color.White;
            this.vendorAddress.ValidBorderColor = System.Drawing.Color.LightGreen;
            this.vendorAddress.xTextChanged += new System.EventHandler(this.vendorName_xTextChanged);
            // 
            // vendorName
            // 
            this.vendorName.AutoSize = true;
            this.vendorName.BackColor = System.Drawing.Color.White;
            this.vendorName.BorderColor = System.Drawing.Color.Silver;
            this.vendorName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorBindingSource, "Name", true));
            this.vendorName.ErrorBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.vendorName.HoverBorderColor = System.Drawing.Color.Cyan;
            this.vendorName.isRequired = true;
            this.vendorName.Location = new System.Drawing.Point(136, 31);
            this.vendorName.Multiline = false;
            this.vendorName.Name = "vendorName";
            this.vendorName.NormalBorderColor = System.Drawing.Color.Silver;
            this.vendorName.PanelBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.vendorName.ReadOnly = false;
            this.vendorName.Size = new System.Drawing.Size(170, 19);
            this.vendorName.StringPattern = "";
            this.vendorName.TabIndex = 10;
            this.vendorName.TextPadding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.vendorName.TextPanelMessage = "Nhập tên không hợp lệ.";
            this.vendorName.TextPanelMessageColor = System.Drawing.Color.White;
            this.vendorName.ValidBorderColor = System.Drawing.Color.LightGreen;
            this.vendorName.xTextChanged += new System.EventHandler(this.vendorName_xTextChanged);
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saveBtn.Location = new System.Drawing.Point(231, 315);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 8;
            this.saveBtn.Text = "Lưu";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancelBtn.Location = new System.Drawing.Point(136, 315);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 9;
            this.cancelBtn.Text = "Hủy";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.editBtn.Location = new System.Drawing.Point(23, 315);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(75, 23);
            this.editBtn.TabIndex = 3;
            this.editBtn.Text = "Sửa";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Số điện thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên";
            // 
            // newVendorBtn
            // 
            this.newVendorBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.newVendorBtn.Location = new System.Drawing.Point(20, 395);
            this.newVendorBtn.Name = "newVendorBtn";
            this.newVendorBtn.Size = new System.Drawing.Size(75, 23);
            this.newVendorBtn.TabIndex = 2;
            this.newVendorBtn.Text = "Thêm";
            this.newVendorBtn.UseVisualStyleBackColor = true;
            this.newVendorBtn.Click += new System.EventHandler(this.newVendorBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteBtn.Location = new System.Drawing.Point(363, 395);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 11;
            this.deleteBtn.Text = "Xóa";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.Location = new System.Drawing.Point(708, 395);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 10;
            this.closeBtn.Text = "Đóng";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // vendoR_ORDERTableAdapter
            // 
            this.vendoR_ORDERTableAdapter.ClearBeforeFill = true;
            // 
            // nameColumn
            // 
            this.nameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameColumn.DataPropertyName = "Name";
            this.nameColumn.HeaderText = "Tên";
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.ReadOnly = true;
            // 
            // idColumn
            // 
            this.idColumn.DataPropertyName = "Id";
            this.idColumn.HeaderText = "Id";
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            this.idColumn.Visible = false;
            // 
            // phoneColumn
            // 
            this.phoneColumn.DataPropertyName = "Phone";
            this.phoneColumn.HeaderText = "Số điện thoại";
            this.phoneColumn.Name = "phoneColumn";
            this.phoneColumn.ReadOnly = true;
            this.phoneColumn.Width = 150;
            // 
            // emailColumn
            // 
            this.emailColumn.DataPropertyName = "Email";
            this.emailColumn.HeaderText = "Email";
            this.emailColumn.Name = "emailColumn";
            this.emailColumn.ReadOnly = true;
            this.emailColumn.Width = 200;
            // 
            // VendorList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.newVendorBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.vendorDataGridView);
            this.Controls.Add(this.searchText);
            this.Controls.Add(this.label1);
            this.Name = "VendorList";
            this.Size = new System.Drawing.Size(800, 430);
            ((System.ComponentModel.ISupportInitialize)(this.vendorDataGridView)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellManagementDbDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView vendorDataGridView;
        private System.Windows.Forms.BindingSource vendorBindingSource;
        private SellManagementDbDataSet sellManagementDbDataSet;
        private SellManagementDbDataSetTableAdapters.VENDORTableAdapter vendorTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button newVendorBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private WindowsFormsControlLibrary.CustomTextBox vendorName;
        private WindowsFormsControlLibrary.CustomTextBox vendorPhone;
        private WindowsFormsControlLibrary.CustomTextBox vendorEmail;
        private WindowsFormsControlLibrary.CustomTextBox vendorAddress;
        private SellManagementDbDataSetTableAdapters.VENDOR_ORDERTableAdapter vendoR_ORDERTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
    }
}
