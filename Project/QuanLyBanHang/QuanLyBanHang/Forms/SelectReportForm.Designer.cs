namespace QuanLyBanHang.Forms
{
    partial class SelectReportForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.searchText = new System.Windows.Forms.TextBox();
            this.selectBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.billDataGridView = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dOCUMENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sellManagementDbDataSet = new QuanLyBanHang.SellManagementDbDataSet();
            this.termDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fromDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalFeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.businessFeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.businessFeeTableAdapter = new QuanLyBanHang.SellManagementDbDataSetTableAdapters.BusinessFeeTableAdapter();
            this.dOCUMENTTableAdapter = new QuanLyBanHang.SellManagementDbDataSetTableAdapters.DOCUMENTTableAdapter();
            this.tranferFeeTableAdapter = new QuanLyBanHang.SellManagementDbDataSetTableAdapters.TranferFeeTableAdapter();
            this.invenFeeTableAdapter = new QuanLyBanHang.SellManagementDbDataSetTableAdapters.InvenFeeTableAdapter();
            this.staffFeeTableAdapter = new QuanLyBanHang.SellManagementDbDataSetTableAdapters.StaffFeeTableAdapter();
            this.newReportBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.billDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCUMENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellManagementDbDataSet)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.businessFeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tìm kiếm";
            // 
            // searchText
            // 
            this.searchText.Location = new System.Drawing.Point(67, 12);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(150, 20);
            this.searchText.TabIndex = 13;
            this.searchText.TextChanged += new System.EventHandler(this.searchText_TextChanged);
            // 
            // selectBtn
            // 
            this.selectBtn.Image = global::QuanLyBanHang.Properties.Resources.success;
            this.selectBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.selectBtn.Location = new System.Drawing.Point(512, 256);
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.selectBtn.Size = new System.Drawing.Size(100, 45);
            this.selectBtn.TabIndex = 12;
            this.selectBtn.Text = "Chọn";
            this.selectBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.selectBtn.UseVisualStyleBackColor = true;
            this.selectBtn.Click += new System.EventHandler(this.selectBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Image = global::QuanLyBanHang.Properties.Resources.error;
            this.cancelBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelBtn.Location = new System.Drawing.Point(406, 256);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.cancelBtn.Size = new System.Drawing.Size(100, 45);
            this.cancelBtn.TabIndex = 11;
            this.cancelBtn.Text = "Đóng";
            this.cancelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
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
            this.termDataGridViewTextBoxColumn,
            this.fromDateDataGridViewTextBoxColumn,
            this.toDateDataGridViewTextBoxColumn,
            this.totalFeeDataGridViewTextBoxColumn});
            this.billDataGridView.ContextMenuStrip = this.contextMenuStrip;
            this.billDataGridView.DataSource = this.businessFeeBindingSource;
            this.billDataGridView.Location = new System.Drawing.Point(12, 44);
            this.billDataGridView.Name = "billDataGridView";
            this.billDataGridView.ReadOnly = true;
            this.billDataGridView.RowHeadersVisible = false;
            this.billDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.billDataGridView.Size = new System.Drawing.Size(600, 200);
            this.billDataGridView.TabIndex = 10;
            this.billDataGridView.DoubleClick += new System.EventHandler(this.billDataGridView_DoubleClick);
            // 
            // idColumn
            // 
            this.idColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idColumn.DataPropertyName = "Id";
            this.idColumn.DataSource = this.dOCUMENTBindingSource;
            this.idColumn.DisplayMember = "DocumentKey";
            this.idColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.idColumn.HeaderText = "Số phiếu";
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            this.idColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idColumn.ValueMember = "Id";
            // 
            // dOCUMENTBindingSource
            // 
            this.dOCUMENTBindingSource.DataMember = "DOCUMENT";
            this.dOCUMENTBindingSource.DataSource = this.sellManagementDbDataSet;
            // 
            // sellManagementDbDataSet
            // 
            this.sellManagementDbDataSet.DataSetName = "SellManagementDbDataSet";
            this.sellManagementDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // termDataGridViewTextBoxColumn
            // 
            this.termDataGridViewTextBoxColumn.DataPropertyName = "Term";
            this.termDataGridViewTextBoxColumn.HeaderText = "Kỳ";
            this.termDataGridViewTextBoxColumn.Name = "termDataGridViewTextBoxColumn";
            this.termDataGridViewTextBoxColumn.ReadOnly = true;
            this.termDataGridViewTextBoxColumn.Width = 50;
            // 
            // fromDateDataGridViewTextBoxColumn
            // 
            this.fromDateDataGridViewTextBoxColumn.DataPropertyName = "FromDate";
            this.fromDateDataGridViewTextBoxColumn.HeaderText = "Từ ngày";
            this.fromDateDataGridViewTextBoxColumn.Name = "fromDateDataGridViewTextBoxColumn";
            this.fromDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // toDateDataGridViewTextBoxColumn
            // 
            this.toDateDataGridViewTextBoxColumn.DataPropertyName = "ToDate";
            this.toDateDataGridViewTextBoxColumn.HeaderText = "Đến ngày";
            this.toDateDataGridViewTextBoxColumn.Name = "toDateDataGridViewTextBoxColumn";
            this.toDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalFeeDataGridViewTextBoxColumn
            // 
            this.totalFeeDataGridViewTextBoxColumn.DataPropertyName = "TotalFee";
            this.totalFeeDataGridViewTextBoxColumn.HeaderText = "Tổng chi phí (VNĐ)";
            this.totalFeeDataGridViewTextBoxColumn.Name = "totalFeeDataGridViewTextBoxColumn";
            this.totalFeeDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalFeeDataGridViewTextBoxColumn.Width = 150;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(139, 70);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Image = global::QuanLyBanHang.Properties.Resources.paper;
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.viewToolStripMenuItem.Text = "Xem chi tiết";
            this.viewToolStripMenuItem.Click += new System.EventHandler(this.selectBtn_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::QuanLyBanHang.Properties.Resources.edit_32;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.editToolStripMenuItem.Text = "Sửa báo cáo";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::QuanLyBanHang.Properties.Resources.error;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.deleteToolStripMenuItem.Text = "Xóa";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
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
            // dOCUMENTTableAdapter
            // 
            this.dOCUMENTTableAdapter.ClearBeforeFill = true;
            // 
            // tranferFeeTableAdapter
            // 
            this.tranferFeeTableAdapter.ClearBeforeFill = true;
            // 
            // invenFeeTableAdapter
            // 
            this.invenFeeTableAdapter.ClearBeforeFill = true;
            // 
            // staffFeeTableAdapter
            // 
            this.staffFeeTableAdapter.ClearBeforeFill = true;
            // 
            // newReportBtn
            // 
            this.newReportBtn.Image = global::QuanLyBanHang.Properties.Resources.plus_32;
            this.newReportBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newReportBtn.Location = new System.Drawing.Point(12, 256);
            this.newReportBtn.Name = "newReportBtn";
            this.newReportBtn.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.newReportBtn.Size = new System.Drawing.Size(130, 45);
            this.newReportBtn.TabIndex = 15;
            this.newReportBtn.Text = "Lập báo cáo";
            this.newReportBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.newReportBtn.UseVisualStyleBackColor = true;
            this.newReportBtn.Click += new System.EventHandler(this.newReportBtn_Click);
            // 
            // SelectReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 311);
            this.Controls.Add(this.newReportBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchText);
            this.Controls.Add(this.selectBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.billDataGridView);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(640, 350);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(640, 350);
            this.Name = "SelectReportForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Danh sách báo cáo";
            this.Load += new System.EventHandler(this.SelectReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.billDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCUMENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellManagementDbDataSet)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.businessFeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.Button selectBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.DataGridView billDataGridView;
        private SellManagementDbDataSet sellManagementDbDataSet;
        private System.Windows.Forms.BindingSource businessFeeBindingSource;
        private SellManagementDbDataSetTableAdapters.BusinessFeeTableAdapter businessFeeTableAdapter;
        private System.Windows.Forms.BindingSource dOCUMENTBindingSource;
        private SellManagementDbDataSetTableAdapters.DOCUMENTTableAdapter dOCUMENTTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalFeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fromDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn termDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idColumn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private SellManagementDbDataSetTableAdapters.TranferFeeTableAdapter tranferFeeTableAdapter;
        private SellManagementDbDataSetTableAdapters.InvenFeeTableAdapter invenFeeTableAdapter;
        private SellManagementDbDataSetTableAdapters.StaffFeeTableAdapter staffFeeTableAdapter;
        private System.Windows.Forms.Button newReportBtn;
    }
}