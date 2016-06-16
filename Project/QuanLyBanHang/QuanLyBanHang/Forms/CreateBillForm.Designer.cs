namespace QuanLyBanHang.Forms
{
    partial class CreateBillForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.remainPriceText = new System.Windows.Forms.TextBox();
            this.dEBTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sellManagementDbDataSet = new QuanLyBanHang.SellManagementDbDataSet();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.finalPriceText = new System.Windows.Forms.TextBox();
            this.oRDERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.staffComboBox = new System.Windows.Forms.ComboBox();
            this.sTAFFBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dOCUMENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cUSTOMERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.customerComboBox = new System.Windows.Forms.ComboBox();
            this.pURCHASEORDERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.changeMoneyText = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.recieveMoneyText = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.createDatePicker = new System.Windows.Forms.DateTimePicker();
            this.okBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.oRDERTableAdapter = new QuanLyBanHang.SellManagementDbDataSetTableAdapters.ORDERTableAdapter();
            this.cUSTOMERTableAdapter = new QuanLyBanHang.SellManagementDbDataSetTableAdapters.CUSTOMERTableAdapter();
            this.sTAFFTableAdapter = new QuanLyBanHang.SellManagementDbDataSetTableAdapters.STAFFTableAdapter();
            this.pURCHASE_ORDERTableAdapter = new QuanLyBanHang.SellManagementDbDataSetTableAdapters.PURCHASE_ORDERTableAdapter();
            this.queriesTableAdapter = new QuanLyBanHang.SellManagementDbDataSetTableAdapters.QueriesTableAdapter();
            this.documentTableAdapter = new QuanLyBanHang.SellManagementDbDataSetTableAdapters.DOCUMENTTableAdapter();
            this.dEBTTableAdapter = new QuanLyBanHang.SellManagementDbDataSetTableAdapters.DEBTTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dEBTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellManagementDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRDERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTAFFBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCUMENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pURCHASEORDERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.remainPriceText);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.finalPriceText);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.staffComboBox);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.customerComboBox);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 232);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(369, 197);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(30, 13);
            this.label14.TabIndex = 23;
            this.label14.Text = "VNĐ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(369, 165);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "VNĐ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(369, 133);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "VNĐ";
            // 
            // remainPriceText
            // 
            this.remainPriceText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.remainPriceText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dEBTBindingSource, "Remain", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.remainPriceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remainPriceText.Location = new System.Drawing.Point(209, 189);
            this.remainPriceText.Name = "remainPriceText";
            this.remainPriceText.ReadOnly = true;
            this.remainPriceText.Size = new System.Drawing.Size(154, 26);
            this.remainPriceText.TabIndex = 20;
            // 
            // dEBTBindingSource
            // 
            this.dEBTBindingSource.DataMember = "DEBT";
            this.dEBTBindingSource.DataSource = this.sellManagementDbDataSet;
            // 
            // sellManagementDbDataSet
            // 
            this.sellManagementDbDataSet.DataSetName = "SellManagementDbDataSet";
            this.sellManagementDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(117, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Còn lại";
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dEBTBindingSource, "Paid", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(209, 157);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(154, 26);
            this.textBox4.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(117, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Đã thanh toán";
            // 
            // finalPriceText
            // 
            this.finalPriceText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oRDERBindingSource, "FinalPrice", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.finalPriceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalPriceText.Location = new System.Drawing.Point(209, 125);
            this.finalPriceText.Name = "finalPriceText";
            this.finalPriceText.ReadOnly = true;
            this.finalPriceText.Size = new System.Drawing.Size(154, 26);
            this.finalPriceText.TabIndex = 16;
            // 
            // oRDERBindingSource
            // 
            this.oRDERBindingSource.DataMember = "ORDER";
            this.oRDERBindingSource.DataSource = this.sellManagementDbDataSet;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(117, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Tổng hóa đơn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nhân viên lập";
            // 
            // staffComboBox
            // 
            this.staffComboBox.DataSource = this.sTAFFBindingSource;
            this.staffComboBox.DisplayMember = "Name";
            this.staffComboBox.FormattingEnabled = true;
            this.staffComboBox.Location = new System.Drawing.Point(209, 98);
            this.staffComboBox.Name = "staffComboBox";
            this.staffComboBox.Size = new System.Drawing.Size(190, 21);
            this.staffComboBox.TabIndex = 7;
            this.staffComboBox.ValueMember = "Id";
            // 
            // sTAFFBindingSource
            // 
            this.sTAFFBindingSource.DataMember = "STAFF";
            this.sTAFFBindingSource.DataSource = this.sellManagementDbDataSet;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dOCUMENTBindingSource, "DocumentKey", true));
            this.textBox2.Location = new System.Drawing.Point(209, 72);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(120, 20);
            this.textBox2.TabIndex = 6;
            // 
            // dOCUMENTBindingSource
            // 
            this.dOCUMENTBindingSource.DataMember = "DOCUMENT";
            this.dOCUMENTBindingSource.DataSource = this.sellManagementDbDataSet;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hóa đơn";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CustomerKey", true));
            this.textBox1.Location = new System.Drawing.Point(209, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(120, 20);
            this.textBox1.TabIndex = 4;
            // 
            // cUSTOMERBindingSource
            // 
            this.cUSTOMERBindingSource.DataMember = "CUSTOMER";
            this.cUSTOMERBindingSource.DataSource = this.sellManagementDbDataSet;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên";
            // 
            // customerComboBox
            // 
            this.customerComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.pURCHASEORDERBindingSource, "Customer_id", true));
            this.customerComboBox.DataSource = this.cUSTOMERBindingSource;
            this.customerComboBox.DisplayMember = "Name";
            this.customerComboBox.Enabled = false;
            this.customerComboBox.FormattingEnabled = true;
            this.customerComboBox.Location = new System.Drawing.Point(209, 19);
            this.customerComboBox.Name = "customerComboBox";
            this.customerComboBox.Size = new System.Drawing.Size(190, 21);
            this.customerComboBox.TabIndex = 1;
            this.customerComboBox.ValueMember = "Id";
            // 
            // pURCHASEORDERBindingSource
            // 
            this.pURCHASEORDERBindingSource.DataMember = "PURCHASE_ORDER";
            this.pURCHASEORDERBindingSource.DataSource = this.sellManagementDbDataSet;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyBanHang.Properties.Resources.Customer;
            this.pictureBox1.Location = new System.Drawing.Point(11, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.comboBox3);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.changeMoneyText);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.recieveMoneyText);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.createDatePicker);
            this.groupBox2.Location = new System.Drawing.Point(12, 250);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(410, 143);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thanh toán";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(333, 113);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(30, 13);
            this.label16.TabIndex = 23;
            this.label16.Text = "VNĐ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(333, 81);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(30, 13);
            this.label15.TabIndex = 22;
            this.label15.Text = "VNĐ";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.pURCHASEORDERBindingSource, "IsMultiPaid", true));
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(336, 49);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(63, 17);
            this.checkBox1.TabIndex = 21;
            this.checkBox1.Text = "Trả góp";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Tiền mặt"});
            this.comboBox3.Location = new System.Drawing.Point(209, 46);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 20;
            this.comboBox3.Text = "Tiền mặt";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Hình thức thanh toán";
            // 
            // changeMoneyText
            // 
            this.changeMoneyText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeMoneyText.Location = new System.Drawing.Point(120, 105);
            this.changeMoneyText.Name = "changeMoneyText";
            this.changeMoneyText.ReadOnly = true;
            this.changeMoneyText.Size = new System.Drawing.Size(209, 26);
            this.changeMoneyText.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Số tiền trả lại";
            // 
            // recieveMoneyText
            // 
            this.recieveMoneyText.BackColor = System.Drawing.Color.LightSkyBlue;
            this.recieveMoneyText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recieveMoneyText.Location = new System.Drawing.Point(120, 73);
            this.recieveMoneyText.Name = "recieveMoneyText";
            this.recieveMoneyText.Size = new System.Drawing.Size(209, 26);
            this.recieveMoneyText.TabIndex = 16;
            this.recieveMoneyText.TextChanged += new System.EventHandler(this.recieveMoneyText_TextChanged);
            this.recieveMoneyText.Leave += new System.EventHandler(this.recieveMoneyText_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Số tiền nhận";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ngày lập";
            // 
            // createDatePicker
            // 
            this.createDatePicker.CustomFormat = "dd\'/\'MM\'/\'yyyy";
            this.createDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.createDatePicker.Location = new System.Drawing.Point(209, 19);
            this.createDatePicker.Name = "createDatePicker";
            this.createDatePicker.Size = new System.Drawing.Size(121, 20);
            this.createDatePicker.TabIndex = 0;
            // 
            // okBtn
            // 
            this.okBtn.Enabled = false;
            this.okBtn.Location = new System.Drawing.Point(232, 406);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 2;
            this.okBtn.Text = "Thanh toán";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(132, 406);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 3;
            this.cancelBtn.Text = "Hủy";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // oRDERTableAdapter
            // 
            this.oRDERTableAdapter.ClearBeforeFill = true;
            // 
            // cUSTOMERTableAdapter
            // 
            this.cUSTOMERTableAdapter.ClearBeforeFill = true;
            // 
            // sTAFFTableAdapter
            // 
            this.sTAFFTableAdapter.ClearBeforeFill = true;
            // 
            // pURCHASE_ORDERTableAdapter
            // 
            this.pURCHASE_ORDERTableAdapter.ClearBeforeFill = true;
            // 
            // documentTableAdapter
            // 
            this.documentTableAdapter.ClearBeforeFill = true;
            // 
            // dEBTTableAdapter
            // 
            this.dEBTTableAdapter.ClearBeforeFill = true;
            // 
            // CreateBillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 441);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(455, 480);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(455, 480);
            this.Name = "CreateBillForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thanh toán";
            this.Load += new System.EventHandler(this.CreateBillForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dEBTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellManagementDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRDERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTAFFBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCUMENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pURCHASEORDERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox staffComboBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox customerComboBox;
        private System.Windows.Forms.TextBox changeMoneyText;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox recieveMoneyText;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker createDatePicker;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox finalPriceText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox remainPriceText;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button cancelBtn;
        private SellManagementDbDataSet sellManagementDbDataSet;
        private System.Windows.Forms.BindingSource oRDERBindingSource;
        private SellManagementDbDataSetTableAdapters.ORDERTableAdapter oRDERTableAdapter;
        private System.Windows.Forms.BindingSource cUSTOMERBindingSource;
        private SellManagementDbDataSetTableAdapters.CUSTOMERTableAdapter cUSTOMERTableAdapter;
        private System.Windows.Forms.BindingSource sTAFFBindingSource;
        private SellManagementDbDataSetTableAdapters.STAFFTableAdapter sTAFFTableAdapter;
        private System.Windows.Forms.BindingSource pURCHASEORDERBindingSource;
        private SellManagementDbDataSetTableAdapters.PURCHASE_ORDERTableAdapter pURCHASE_ORDERTableAdapter;
        private SellManagementDbDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter;
        private SellManagementDbDataSetTableAdapters.DOCUMENTTableAdapter documentTableAdapter;
        private System.Windows.Forms.BindingSource dOCUMENTBindingSource;
        private System.Windows.Forms.BindingSource dEBTBindingSource;
        private SellManagementDbDataSetTableAdapters.DEBTTableAdapter dEBTTableAdapter;
    }
}