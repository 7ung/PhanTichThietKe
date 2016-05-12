namespace QuanLyBanHang
{
    partial class Main
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sellMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createOderMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendorMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newProductMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainPage = new System.Windows.Forms.TabPage();
            this.sellGroupBox = new System.Windows.Forms.GroupBox();
            this.viewOrdersBtn = new System.Windows.Forms.Button();
            this.viewCustomersBtn = new System.Windows.Forms.Button();
            this.newOrder = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.viewCustomerList = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.mainPage.SuspendLayout();
            this.sellGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileStripMenuItem,
            this.sellMenuItem,
            this.buyMenuItem,
            this.productMenuItem,
            this.inventoryMenuItem,
            this.vendorMenuItem,
            this.customerMenuItem,
            this.staffMenuItem,
            this.infoMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(984, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileStripMenuItem
            // 
            this.fileStripMenuItem.Name = "fileStripMenuItem";
            this.fileStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileStripMenuItem.Text = "File";
            // 
            // sellMenuItem
            // 
            this.sellMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createOderMenuItem});
            this.sellMenuItem.Name = "sellMenuItem";
            this.sellMenuItem.Size = new System.Drawing.Size(69, 20);
            this.sellMenuItem.Text = "Bán hàng";
            // 
            // createOderMenuItem
            // 
            this.createOderMenuItem.Name = "createOderMenuItem";
            this.createOderMenuItem.Size = new System.Drawing.Size(152, 22);
            this.createOderMenuItem.Text = "Tạo đơn hàng";
            // 
            // buyMenuItem
            // 
            this.buyMenuItem.Name = "buyMenuItem";
            this.buyMenuItem.Size = new System.Drawing.Size(73, 20);
            this.buyMenuItem.Text = "Mua hàng";
            // 
            // productMenuItem
            // 
            this.productMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newProductMenuItem,
            this.productsMenuItem});
            this.productMenuItem.Name = "productMenuItem";
            this.productMenuItem.Size = new System.Drawing.Size(70, 20);
            this.productMenuItem.Text = "Mặt hàng";
            // 
            // customerMenuItem
            // 
            this.customerMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewCustomerList});
            this.customerMenuItem.Name = "customerMenuItem";
            this.customerMenuItem.Size = new System.Drawing.Size(82, 20);
            this.customerMenuItem.Text = "Khách hàng";
            // 
            // vendorMenuItem
            // 
            this.vendorMenuItem.Name = "vendorMenuItem";
            this.vendorMenuItem.Size = new System.Drawing.Size(93, 20);
            this.vendorMenuItem.Text = "Nhà cung cấp";
            // 
            // staffMenuItem
            // 
            this.staffMenuItem.Name = "staffMenuItem";
            this.staffMenuItem.Size = new System.Drawing.Size(73, 20);
            this.staffMenuItem.Text = "Nhân viên";
            // 
            // infoMenuItem
            // 
            this.infoMenuItem.Name = "infoMenuItem";
            this.infoMenuItem.Size = new System.Drawing.Size(71, 20);
            this.infoMenuItem.Text = "Thông tin";
            // 
            // newProductMenuItem
            // 
            this.newProductMenuItem.Name = "newProductMenuItem";
            this.newProductMenuItem.Size = new System.Drawing.Size(183, 22);
            this.newProductMenuItem.Text = "Thêm mặt hàng";
            this.newProductMenuItem.Click += new System.EventHandler(this.newProductMenuItem_Click);
            // 
            // productsMenuItem
            // 
            this.productsMenuItem.Name = "productsMenuItem";
            this.productsMenuItem.Size = new System.Drawing.Size(183, 22);
            this.productsMenuItem.Text = "Danh sách mặt hàng";
            // 
            // inventoryMenuItem
            // 
            this.inventoryMenuItem.Name = "inventoryMenuItem";
            this.inventoryMenuItem.Size = new System.Drawing.Size(70, 20);
            this.inventoryMenuItem.Text = "Kho hàng";
            // 
            // mainPage
            // 
            this.mainPage.Controls.Add(this.groupBox3);
            this.mainPage.Controls.Add(this.groupBox2);
            this.mainPage.Controls.Add(this.groupBox1);
            this.mainPage.Controls.Add(this.sellGroupBox);
            this.mainPage.Location = new System.Drawing.Point(4, 22);
            this.mainPage.Name = "mainPage";
            this.mainPage.Padding = new System.Windows.Forms.Padding(3);
            this.mainPage.Size = new System.Drawing.Size(976, 511);
            this.mainPage.TabIndex = 0;
            this.mainPage.Text = "Trang chủ";
            this.mainPage.UseVisualStyleBackColor = true;
            // 
            // sellGroupBox
            // 
            this.sellGroupBox.Controls.Add(this.newOrder);
            this.sellGroupBox.Controls.Add(this.viewCustomersBtn);
            this.sellGroupBox.Controls.Add(this.viewOrdersBtn);
            this.sellGroupBox.Location = new System.Drawing.Point(20, 20);
            this.sellGroupBox.Name = "sellGroupBox";
            this.sellGroupBox.Size = new System.Drawing.Size(458, 225);
            this.sellGroupBox.TabIndex = 0;
            this.sellGroupBox.TabStop = false;
            this.sellGroupBox.Text = "Bán hàng";
            // 
            // viewOrdersBtn
            // 
            this.viewOrdersBtn.Location = new System.Drawing.Point(207, 35);
            this.viewOrdersBtn.Name = "viewOrdersBtn";
            this.viewOrdersBtn.Size = new System.Drawing.Size(222, 40);
            this.viewOrdersBtn.TabIndex = 1;
            this.viewOrdersBtn.Text = "Danh sách đơn bán hàng";
            this.viewOrdersBtn.UseVisualStyleBackColor = true;
            // 
            // viewCustomersBtn
            // 
            this.viewCustomersBtn.Location = new System.Drawing.Point(207, 81);
            this.viewCustomersBtn.Name = "viewCustomersBtn";
            this.viewCustomersBtn.Size = new System.Drawing.Size(222, 40);
            this.viewCustomersBtn.TabIndex = 2;
            this.viewCustomersBtn.Text = "Danh sách khách hàng";
            this.viewCustomersBtn.UseVisualStyleBackColor = true;
            // 
            // newOrder
            // 
            this.newOrder.Location = new System.Drawing.Point(20, 35);
            this.newOrder.Name = "newOrder";
            this.newOrder.Size = new System.Drawing.Size(160, 160);
            this.newOrder.TabIndex = 3;
            this.newOrder.Text = "Giao dịch mới";
            this.newOrder.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(497, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 225);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mua hàng";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 160);
            this.button1.TabIndex = 4;
            this.button1.Text = "Giao dịch mới";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(210, 35);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(222, 40);
            this.button2.TabIndex = 4;
            this.button2.Text = "Danh sách đơn nhập hàng";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(210, 81);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(222, 40);
            this.button3.TabIndex = 5;
            this.button3.Text = "Danh sách nhà cung cấp";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Location = new System.Drawing.Point(20, 267);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(458, 225);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kho hàng";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(20, 35);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(160, 80);
            this.button4.TabIndex = 4;
            this.button4.Text = "Nhập kho";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(20, 121);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(160, 80);
            this.button5.TabIndex = 5;
            this.button5.Text = "Xuất kho";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(207, 35);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(222, 40);
            this.button6.TabIndex = 4;
            this.button6.Text = "Danh sách kho";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button8);
            this.groupBox3.Controls.Add(this.button7);
            this.groupBox3.Location = new System.Drawing.Point(497, 267);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(458, 225);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Báo cáo";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(20, 35);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(222, 40);
            this.button7.TabIndex = 6;
            this.button7.Text = "Tồn kho";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(20, 81);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(222, 40);
            this.button8.TabIndex = 7;
            this.button8.Text = "Công nợ";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.mainPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 24);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(984, 537);
            this.tabControl.TabIndex = 1;
            // 
            // viewCustomerList
            // 
            this.viewCustomerList.Name = "viewCustomerList";
            this.viewCustomerList.Size = new System.Drawing.Size(194, 22);
            this.viewCustomerList.Text = "Danh sách khách hàng";
            this.viewCustomerList.Click += new System.EventHandler(this.viewCustomerList_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý bán hàng";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.mainPage.ResumeLayout(false);
            this.sellGroupBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sellMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createOderMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buyMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendorMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newProductMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryMenuItem;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.Button viewOrdersBtn;
        private System.Windows.Forms.Button viewCustomersBtn;
        private System.Windows.Forms.Button newOrder;
        private System.Windows.Forms.GroupBox sellGroupBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TabPage mainPage;
        private System.Windows.Forms.ToolStripMenuItem viewCustomerList;
    }
}

