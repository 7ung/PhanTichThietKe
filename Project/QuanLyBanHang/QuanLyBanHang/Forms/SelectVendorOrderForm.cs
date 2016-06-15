using QuanLyBanHang.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang.Forms
{
    public partial class SelectVendorOrderForm : Form
    {
        public int OrderId { get; set; }
        public string DocumentKey { get; set; }

        public SelectVendorOrderForm()
        {
            InitializeComponent();
        }

        private void SelectVendorOrderForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sellManagementDbDataSet.VENDOR' table. You can move, or remove it, as needed.
            this.vENDORTableAdapter.Fill(this.sellManagementDbDataSet.VENDOR);
            // TODO: This line of code loads data into the 'sellManagementDbDataSet.Vendor_Order_View' table. You can move, or remove it, as needed.
            this.vendor_Order_ViewTableAdapter.Fill(this.sellManagementDbDataSet.Vendor_Order_View);

            this.inouT_INVENTORY_DETAILTableAdapter.Fill(this.sellManagementDbDataSet.INOUT_INVENTORY_DETAIL);

            BindingOrderStatus();

            // format
            finalPriceDataGridViewTextBoxColumn.DefaultCellStyle.Format = "N2";
            createDateDataGridViewTextBoxColumn.DefaultCellStyle.Format = "dd'/'MM'/'yyyy";
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void searchText_TextChanged(object sender, EventArgs e)
        {
            vendorOrderViewBindingSource.Filter = dataGridView1.Columns["keyColumn"].DataPropertyName.ToString() + " LIKE '%" + searchText.Text + "%'";
        }

        private void selectBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var row = dataGridView1.SelectedRows[0].Cells["idColumn"];
                OrderId = Convert.ToInt32(row.Value);
                DocumentKey = dataGridView1.SelectedRows[0].Cells["keyColumn"].Value.ToString();
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BindingOrderStatus()
        {
            var types = new StringNStringBindingData[]
            {
                new StringNStringBindingData("Hoàn thành" ,"complete"),
                new StringNStringBindingData("Hết hàng", "outofstock"),
                new StringNStringBindingData("Đang giao hàng", "shipping"),
                new StringNStringBindingData("Không", "")
            };

            statusColumn.DataSource = types;
            statusColumn.DisplayMember = "Name";
            statusColumn.ValueMember = "Value";
        }

        private void deleteMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var row = dataGridView1.SelectedRows[0].Cells["idColumn"];
                queriesTableAdapter.Delete_Vendor_Order(Convert.ToInt32(row.Value));

                // fill
                vendor_Order_ViewTableAdapter.Fill(sellManagementDbDataSet.Vendor_Order_View);
            }
        }

        private void selectMenuItem_Click(object sender, EventArgs e)
        {
            selectBtn_Click(sender, e);
        }

        private void contextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            if (vendorOrderViewBindingSource.Current == null || dataGridView1.RowCount <= 0)
            {
                if (vendorOrderViewBindingSource.Current != null)
                    contextMenuStrip.Enabled = false;

                selectBtn.Enabled = false;

                return;
            }

            deleteMenuItem.Enabled = true;
            var current = ((vendorOrderViewBindingSource.Current as DataRowView).Row as SellManagementDbDataSet.Vendor_Order_ViewRow);

            var list = sellManagementDbDataSet.INOUT_INVENTORY_DETAIL.Where(o => o.Order_id == current.Id);
            if (list.Count() > 0)
            {
                deleteMenuItem.Enabled = false;
            }
        }
    }
}
