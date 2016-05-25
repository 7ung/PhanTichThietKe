namespace QuanLyBanHang.Forms
{
    partial class CreateCustomerOrderForm
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
            this.queriesTableAdapter = new QuanLyBanHang.SellManagementDbDataSetTableAdapters.QueriesTableAdapter();
            this.documentTableAdapter = new QuanLyBanHang.SellManagementDbDataSetTableAdapters.DOCUMENTTableAdapter();
            this.sellManagementDbDataSet = new QuanLyBanHang.SellManagementDbDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.documentKeyText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.createDatePicker = new System.Windows.Forms.DateTimePicker();
            this.transactionPicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.staffComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.createCustomerBtn = new System.Windows.Forms.Button();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.createBtn = new System.Windows.Forms.Button();
            this.sTAFFBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sTAFFTableAdapter = new QuanLyBanHang.SellManagementDbDataSetTableAdapters.STAFFTableAdapter();
            this.customerComboBox = new System.Windows.Forms.ComboBox();
            this.cUSTOMERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cUSTOMERTableAdapter = new QuanLyBanHang.SellManagementDbDataSetTableAdapters.CUSTOMERTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sellManagementDbDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTAFFBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // documentTableAdapter
            // 
            this.documentTableAdapter.ClearBeforeFill = true;
            // 
            // sellManagementDbDataSet
            // 
            this.sellManagementDbDataSet.DataSetName = "SellManagementDbDataSet";
            this.sellManagementDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hóa đơn";
            // 
            // documentKeyText
            // 
            this.documentKeyText.Location = new System.Drawing.Point(110, 17);
            this.documentKeyText.Name = "documentKeyText";
            this.documentKeyText.ReadOnly = true;
            this.documentKeyText.Size = new System.Drawing.Size(200, 20);
            this.documentKeyText.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày lập";
            // 
            // createDatePicker
            // 
            this.createDatePicker.CustomFormat = "dd\'/\'MM\'/\'yyyy";
            this.createDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.createDatePicker.Location = new System.Drawing.Point(110, 43);
            this.createDatePicker.Name = "createDatePicker";
            this.createDatePicker.Size = new System.Drawing.Size(120, 20);
            this.createDatePicker.TabIndex = 3;
            // 
            // transactionPicker
            // 
            this.transactionPicker.CustomFormat = "dd\'/\'MM\'/\'yyyy";
            this.transactionPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.transactionPicker.Location = new System.Drawing.Point(110, 69);
            this.transactionPicker.Name = "transactionPicker";
            this.transactionPicker.Size = new System.Drawing.Size(120, 20);
            this.transactionPicker.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày giao dịch";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(320, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nhân viên";
            // 
            // staffComboBox
            // 
            this.staffComboBox.DataSource = this.sTAFFBindingSource;
            this.staffComboBox.DisplayMember = "StaffKey";
            this.staffComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.staffComboBox.FormattingEnabled = true;
            this.staffComboBox.Location = new System.Drawing.Point(382, 42);
            this.staffComboBox.Name = "staffComboBox";
            this.staffComboBox.Size = new System.Drawing.Size(141, 21);
            this.staffComboBox.TabIndex = 7;
            this.staffComboBox.ValueMember = "Id";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.customerComboBox);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.createCustomerBtn);
            this.groupBox2.Controls.Add(this.textBox10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.textBox9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(23, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(500, 160);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin khách hàng";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyBanHang.Properties.Resources.Customer;
            this.pictureBox1.Location = new System.Drawing.Point(15, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // createCustomerBtn
            // 
            this.createCustomerBtn.Location = new System.Drawing.Point(408, 24);
            this.createCustomerBtn.Name = "createCustomerBtn";
            this.createCustomerBtn.Size = new System.Drawing.Size(70, 23);
            this.createCustomerBtn.TabIndex = 17;
            this.createCustomerBtn.Text = "Danh sách";
            this.createCustomerBtn.UseVisualStyleBackColor = true;
            // 
            // textBox10
            // 
            this.textBox10.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "Phone", true));
            this.textBox10.Location = new System.Drawing.Point(238, 78);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(164, 20);
            this.textBox10.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(150, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Số điện thoại";
            // 
            // textBox9
            // 
            this.textBox9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CustomerKey", true));
            this.textBox9.Location = new System.Drawing.Point(238, 52);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(240, 20);
            this.textBox9.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(150, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Mã khách hàng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(150, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Tên";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "Email", true));
            this.textBox2.Location = new System.Drawing.Point(238, 104);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(164, 20);
            this.textBox2.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(150, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Email";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(176, 277);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 9;
            this.cancelBtn.Text = "Hủy";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(261, 277);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(115, 23);
            this.createBtn.TabIndex = 10;
            this.createBtn.Text = "Tạo đơn hàng";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
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
            // customerComboBox
            // 
            this.customerComboBox.DataSource = this.cUSTOMERBindingSource;
            this.customerComboBox.DisplayMember = "Name";
            this.customerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customerComboBox.FormattingEnabled = true;
            this.customerComboBox.Location = new System.Drawing.Point(238, 25);
            this.customerComboBox.Name = "customerComboBox";
            this.customerComboBox.Size = new System.Drawing.Size(164, 21);
            this.customerComboBox.TabIndex = 11;
            this.customerComboBox.ValueMember = "Id";
            // 
            // cUSTOMERBindingSource
            // 
            this.cUSTOMERBindingSource.DataMember = "CUSTOMER";
            this.cUSTOMERBindingSource.DataSource = this.sellManagementDbDataSet;
            // 
            // cUSTOMERTableAdapter
            // 
            this.cUSTOMERTableAdapter.ClearBeforeFill = true;
            // 
            // CreateCustomerOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 321);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.staffComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.transactionPicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.createDatePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.documentKeyText);
            this.Controls.Add(this.label1);
            this.Name = "CreateCustomerOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tạo đơn hàng";
            this.Load += new System.EventHandler(this.CreateCustomerOrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sellManagementDbDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTAFFBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SellManagementDbDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter;
        private SellManagementDbDataSetTableAdapters.DOCUMENTTableAdapter documentTableAdapter;
        private SellManagementDbDataSet sellManagementDbDataSet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker createDatePicker;
        private System.Windows.Forms.TextBox documentKeyText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker transactionPicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox staffComboBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button createCustomerBtn;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.BindingSource sTAFFBindingSource;
        private SellManagementDbDataSetTableAdapters.STAFFTableAdapter sTAFFTableAdapter;
        private System.Windows.Forms.ComboBox customerComboBox;
        private System.Windows.Forms.BindingSource cUSTOMERBindingSource;
        private SellManagementDbDataSetTableAdapters.CUSTOMERTableAdapter cUSTOMERTableAdapter;
    }
}