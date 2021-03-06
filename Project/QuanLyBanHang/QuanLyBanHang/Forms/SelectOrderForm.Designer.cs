﻿namespace QuanLyBanHang.Forms
{
    partial class SelectOrderForm
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
            this.billDataGridView = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.keyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cUSTOMERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sellManagementDbDataSet = new QuanLyBanHang.SellManagementDbDataSet();
            this.finalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.selectMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerOrderViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customer_Order_ViewTableAdapter = new QuanLyBanHang.SellManagementDbDataSetTableAdapters.Customer_Order_ViewTableAdapter();
            this.cUSTOMERTableAdapter = new QuanLyBanHang.SellManagementDbDataSetTableAdapters.CUSTOMERTableAdapter();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.selectBtn = new System.Windows.Forms.Button();
            this.searchText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.queriesTableAdapter = new QuanLyBanHang.SellManagementDbDataSetTableAdapters.QueriesTableAdapter();
            this.inout_INVENTORY_DETAILTableAdapter = new QuanLyBanHang.SellManagementDbDataSetTableAdapters.INOUT_INVENTORY_DETAILTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.billDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellManagementDbDataSet)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerOrderViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // billDataGridView
            // 
            this.billDataGridView.AllowUserToAddRows = false;
            this.billDataGridView.AllowUserToDeleteRows = false;
            this.billDataGridView.AllowUserToResizeRows = false;
            this.billDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.billDataGridView.AutoGenerateColumns = false;
            this.billDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.billDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.statusColumn,
            this.keyColumn,
            this.createDateDataGridViewTextBoxColumn,
            this.nameColumn,
            this.finalColumn});
            this.billDataGridView.ContextMenuStrip = this.contextMenuStrip;
            this.billDataGridView.DataSource = this.customerOrderViewBindingSource;
            this.billDataGridView.Location = new System.Drawing.Point(12, 44);
            this.billDataGridView.Name = "billDataGridView";
            this.billDataGridView.ReadOnly = true;
            this.billDataGridView.RowHeadersVisible = false;
            this.billDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.billDataGridView.Size = new System.Drawing.Size(600, 200);
            this.billDataGridView.TabIndex = 0;
            this.billDataGridView.DoubleClick += new System.EventHandler(this.billDataGridView_DoubleClick);
            // 
            // idColumn
            // 
            this.idColumn.DataPropertyName = "Id";
            this.idColumn.HeaderText = "Id";
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            this.idColumn.Visible = false;
            // 
            // statusColumn
            // 
            this.statusColumn.DataPropertyName = "Status";
            this.statusColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.statusColumn.HeaderText = "Trạng thái";
            this.statusColumn.Name = "statusColumn";
            this.statusColumn.ReadOnly = true;
            this.statusColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.statusColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // keyColumn
            // 
            this.keyColumn.DataPropertyName = "DocumentKey";
            this.keyColumn.HeaderText = "Mã hóa đơn";
            this.keyColumn.Name = "keyColumn";
            this.keyColumn.ReadOnly = true;
            // 
            // createDateDataGridViewTextBoxColumn
            // 
            this.createDateDataGridViewTextBoxColumn.DataPropertyName = "CreateDate";
            this.createDateDataGridViewTextBoxColumn.HeaderText = "Ngày lập";
            this.createDateDataGridViewTextBoxColumn.Name = "createDateDataGridViewTextBoxColumn";
            this.createDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameColumn
            // 
            this.nameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameColumn.DataPropertyName = "Customer_id";
            this.nameColumn.DataSource = this.cUSTOMERBindingSource;
            this.nameColumn.DisplayMember = "Name";
            this.nameColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.nameColumn.HeaderText = "Khách hàng";
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.ReadOnly = true;
            this.nameColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.nameColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.nameColumn.ValueMember = "Id";
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
            // finalColumn
            // 
            this.finalColumn.DataPropertyName = "FinalPrice";
            this.finalColumn.HeaderText = "Tổng hóa đơn (VNĐ)";
            this.finalColumn.Name = "finalColumn";
            this.finalColumn.ReadOnly = true;
            this.finalColumn.Width = 150;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectMenuItem,
            this.deleteMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(138, 48);
            this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_Opening);
            // 
            // selectMenuItem
            // 
            this.selectMenuItem.Image = global::QuanLyBanHang.Properties.Resources.paper;
            this.selectMenuItem.Name = "selectMenuItem";
            this.selectMenuItem.Size = new System.Drawing.Size(137, 22);
            this.selectMenuItem.Text = "Xem chi tiết";
            this.selectMenuItem.Click += new System.EventHandler(this.selectMenuItem_Click);
            // 
            // deleteMenuItem
            // 
            this.deleteMenuItem.Image = global::QuanLyBanHang.Properties.Resources.error;
            this.deleteMenuItem.Name = "deleteMenuItem";
            this.deleteMenuItem.Size = new System.Drawing.Size(137, 22);
            this.deleteMenuItem.Text = "Xóa";
            this.deleteMenuItem.Click += new System.EventHandler(this.deleteMenuItem_Click);
            // 
            // customerOrderViewBindingSource
            // 
            this.customerOrderViewBindingSource.DataMember = "Customer_Order_View";
            this.customerOrderViewBindingSource.DataSource = this.sellManagementDbDataSet;
            this.customerOrderViewBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.customerOrderViewBindingSource_ListChanged);
            // 
            // customer_Order_ViewTableAdapter
            // 
            this.customer_Order_ViewTableAdapter.ClearBeforeFill = true;
            // 
            // cUSTOMERTableAdapter
            // 
            this.cUSTOMERTableAdapter.ClearBeforeFill = true;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Image = global::QuanLyBanHang.Properties.Resources.error;
            this.cancelBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelBtn.Location = new System.Drawing.Point(200, 254);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Padding = new System.Windows.Forms.Padding(10, 0, 15, 0);
            this.cancelBtn.Size = new System.Drawing.Size(100, 45);
            this.cancelBtn.TabIndex = 1;
            this.cancelBtn.Text = "Hủy";
            this.cancelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // selectBtn
            // 
            this.selectBtn.Image = global::QuanLyBanHang.Properties.Resources.success;
            this.selectBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.selectBtn.Location = new System.Drawing.Point(333, 254);
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Padding = new System.Windows.Forms.Padding(10, 0, 15, 0);
            this.selectBtn.Size = new System.Drawing.Size(100, 45);
            this.selectBtn.TabIndex = 2;
            this.selectBtn.Text = "Chọn";
            this.selectBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.selectBtn.UseVisualStyleBackColor = true;
            this.selectBtn.Click += new System.EventHandler(this.selectBtn_Click);
            // 
            // searchText
            // 
            this.searchText.Location = new System.Drawing.Point(67, 12);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(150, 20);
            this.searchText.TabIndex = 3;
            this.searchText.TextChanged += new System.EventHandler(this.searchText_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tìm kiếm";
            // 
            // inout_INVENTORY_DETAILTableAdapter
            // 
            this.inout_INVENTORY_DETAILTableAdapter.ClearBeforeFill = true;
            // 
            // SelectOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 311);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchText);
            this.Controls.Add(this.selectBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.billDataGridView);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(640, 350);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(640, 350);
            this.Name = "SelectOrderForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Danh sách đơn hàng";
            this.Load += new System.EventHandler(this.SelectOrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.billDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellManagementDbDataSet)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customerOrderViewBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView billDataGridView;
        private SellManagementDbDataSet sellManagementDbDataSet;
        private System.Windows.Forms.BindingSource customerOrderViewBindingSource;
        private SellManagementDbDataSetTableAdapters.Customer_Order_ViewTableAdapter customer_Order_ViewTableAdapter;
        private SellManagementDbDataSetTableAdapters.CUSTOMERTableAdapter cUSTOMERTableAdapter;
        private System.Windows.Forms.BindingSource cUSTOMERBindingSource;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button selectBtn;
        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem selectMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteMenuItem;
        private SellManagementDbDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter;
        private SellManagementDbDataSetTableAdapters.INOUT_INVENTORY_DETAILTableAdapter inout_INVENTORY_DETAILTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn keyColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn statusColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
    }
}