namespace QuanLyBanHang.Forms
{
    partial class CreateReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateReportForm));
            this.createBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.todateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.fromdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.staffComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.createDatePicker = new System.Windows.Forms.DateTimePicker();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.documentKeyText = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sellManagementDbDataSet = new QuanLyBanHang.SellManagementDbDataSet();
            this.sTAFFBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sTAFFTableAdapter = new QuanLyBanHang.SellManagementDbDataSetTableAdapters.STAFFTableAdapter();
            this.documentTableAdapter = new QuanLyBanHang.SellManagementDbDataSetTableAdapters.DOCUMENTTableAdapter();
            this.dOCUMENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.businessFeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.businessFeeTableAdapter = new QuanLyBanHang.SellManagementDbDataSetTableAdapters.BusinessFeeTableAdapter();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellManagementDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTAFFBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCUMENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessFeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // createBtn
            // 
            this.createBtn.BackColor = System.Drawing.Color.Transparent;
            this.createBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createBtn.FlatAppearance.BorderSize = 2;
            this.createBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createBtn.Image = ((System.Drawing.Image)(resources.GetObject("createBtn.Image")));
            this.createBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.createBtn.Location = new System.Drawing.Point(244, 244);
            this.createBtn.Name = "createBtn";
            this.createBtn.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.createBtn.Size = new System.Drawing.Size(150, 45);
            this.createBtn.TabIndex = 21;
            this.createBtn.Text = "Lập báo cáo";
            this.createBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.createBtn.UseVisualStyleBackColor = false;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.Transparent;
            this.cancelBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.cancelBtn.FlatAppearance.BorderSize = 2;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Image = global::QuanLyBanHang.Properties.Resources.error;
            this.cancelBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelBtn.Location = new System.Drawing.Point(136, 244);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.cancelBtn.Size = new System.Drawing.Size(98, 45);
            this.cancelBtn.TabIndex = 20;
            this.cancelBtn.Text = "Hủy";
            this.cancelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.todateTimePicker);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.fromdateTimePicker);
            this.groupBox2.Controls.Add(this.staffComboBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.createDatePicker);
            this.groupBox2.Controls.Add(this.numericUpDown);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.documentKeyText);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(22, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(500, 203);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin khách hàng";
            // 
            // todateTimePicker
            // 
            this.todateTimePicker.CustomFormat = "dd\'/\'MM\'/\'yyyy";
            this.todateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.businessFeeBindingSource, "ToDate", true));
            this.todateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.todateTimePicker.Location = new System.Drawing.Point(222, 163);
            this.todateTimePicker.Name = "todateTimePicker";
            this.todateTimePicker.Size = new System.Drawing.Size(150, 20);
            this.todateTimePicker.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(149, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Đến ngày";
            // 
            // fromdateTimePicker
            // 
            this.fromdateTimePicker.CustomFormat = "dd\'/\'MM\'/\'yyyy";
            this.fromdateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.businessFeeBindingSource, "FromDate", true));
            this.fromdateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fromdateTimePicker.Location = new System.Drawing.Point(222, 137);
            this.fromdateTimePicker.Name = "fromdateTimePicker";
            this.fromdateTimePicker.Size = new System.Drawing.Size(150, 20);
            this.fromdateTimePicker.TabIndex = 27;
            // 
            // staffComboBox
            // 
            this.staffComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dOCUMENTBindingSource, "Creator", true));
            this.staffComboBox.DataSource = this.sTAFFBindingSource;
            this.staffComboBox.DisplayMember = "Name";
            this.staffComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.staffComboBox.FormattingEnabled = true;
            this.staffComboBox.Location = new System.Drawing.Point(222, 76);
            this.staffComboBox.Name = "staffComboBox";
            this.staffComboBox.Size = new System.Drawing.Size(150, 21);
            this.staffComboBox.TabIndex = 18;
            this.staffComboBox.ValueMember = "Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(149, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Từ ngày";
            // 
            // createDatePicker
            // 
            this.createDatePicker.CustomFormat = "dd\'/\'MM\'/\'yyyy";
            this.createDatePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dOCUMENTBindingSource, "CreateDate", true));
            this.createDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.createDatePicker.Location = new System.Drawing.Point(222, 50);
            this.createDatePicker.Name = "createDatePicker";
            this.createDatePicker.Size = new System.Drawing.Size(150, 20);
            this.createDatePicker.TabIndex = 14;
            // 
            // numericUpDown
            // 
            this.numericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.businessFeeBindingSource, "Term", true));
            this.numericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown.Location = new System.Drawing.Point(222, 105);
            this.numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(50, 26);
            this.numericUpDown.TabIndex = 25;
            this.numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ngày lập";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(149, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Kỳ";
            // 
            // documentKeyText
            // 
            this.documentKeyText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dOCUMENTBindingSource, "DocumentKey", true));
            this.documentKeyText.Location = new System.Drawing.Point(222, 24);
            this.documentKeyText.Name = "documentKeyText";
            this.documentKeyText.ReadOnly = true;
            this.documentKeyText.Size = new System.Drawing.Size(200, 20);
            this.documentKeyText.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyBanHang.Properties.Resources.documents;
            this.pictureBox1.Location = new System.Drawing.Point(15, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Số phiếu";
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
            // documentTableAdapter
            // 
            this.documentTableAdapter.ClearBeforeFill = true;
            // 
            // dOCUMENTBindingSource
            // 
            this.dOCUMENTBindingSource.DataMember = "DOCUMENT";
            this.dOCUMENTBindingSource.DataSource = this.sellManagementDbDataSet;
            // 
            // businessFeeBindingSource
            // 
            this.businessFeeBindingSource.DataMember = "BusinessFee";
            this.businessFeeBindingSource.DataSource = this.sellManagementDbDataSet;
            // 
            // businessFeeTableAdapter
            // 
            this.businessFeeTableAdapter.ClearBeforeFill = true;
            // 
            // CreateReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 311);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(560, 350);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(560, 350);
            this.Name = "CreateReportForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lập báo cáo";
            this.Load += new System.EventHandler(this.CreateReportForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellManagementDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTAFFBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCUMENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessFeeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox staffComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker createDatePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox documentKeyText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker todateTimePicker;
        private System.Windows.Forms.DateTimePicker fromdateTimePicker;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private SellManagementDbDataSet sellManagementDbDataSet;
        private System.Windows.Forms.BindingSource sTAFFBindingSource;
        private SellManagementDbDataSetTableAdapters.STAFFTableAdapter sTAFFTableAdapter;
        private System.Windows.Forms.BindingSource dOCUMENTBindingSource;
        private SellManagementDbDataSetTableAdapters.DOCUMENTTableAdapter documentTableAdapter;
        private System.Windows.Forms.BindingSource businessFeeBindingSource;
        private SellManagementDbDataSetTableAdapters.BusinessFeeTableAdapter businessFeeTableAdapter;
    }
}