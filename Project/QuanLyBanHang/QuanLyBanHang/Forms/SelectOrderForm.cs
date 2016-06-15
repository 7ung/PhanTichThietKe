using QuanLyBanHang.Models;
using QuanLyBanHang.Properties;
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
    public partial class SelectOrderForm : Form
    {
        public int OrderId { get; set; }
        public string OrderKey { get; set; }

        public SelectOrderForm()
        {
            InitializeComponent();
        }

        private void SelectOrderForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sellManagementDbDataSet.CUSTOMER' table. You can move, or remove it, as needed.
            this.cUSTOMERTableAdapter.Fill(this.sellManagementDbDataSet.CUSTOMER);
            // TODO: This line of code loads data into the 'sellManagementDbDataSet.Customer_Order_View' table. You can move, or remove it, as needed.
            this.customer_Order_ViewTableAdapter.Fill(this.sellManagementDbDataSet.Customer_Order_View);
            this.inout_INVENTORY_DETAILTableAdapter.Fill(this.sellManagementDbDataSet.INOUT_INVENTORY_DETAIL);

            BindingOrderStatus();

            // format
            finalColumn.DefaultCellStyle.Format = "N2";
            createDateDataGridViewTextBoxColumn.DefaultCellStyle.Format = "dd'/'MM'/'yyyy";
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void selectBtn_Click(object sender, EventArgs e)
        {
            if (billDataGridView.SelectedRows.Count > 0)
            {
                var row = billDataGridView.SelectedRows[0].Cells["idColumn"];
                OrderId = Convert.ToInt32(row.Value);
                OrderKey = billDataGridView.SelectedRows[0].Cells["keyColumn"].Value.ToString();
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void searchText_TextChanged(object sender, EventArgs e)
        {
            customerOrderViewBindingSource.Filter = billDataGridView.Columns["keyColumn"].DataPropertyName.ToString() + " LIKE '%" + searchText.Text + "%'";
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

        private void selectMenuItem_Click(object sender, EventArgs e)
        {
            selectBtn_Click(sender, e);
        }

        private void deleteMenuItem_Click(object sender, EventArgs e)
        {
            if (billDataGridView.SelectedRows.Count > 0)
            {
                try
                {
                    var row = billDataGridView.SelectedRows[0].Cells["idColumn"];
                    queriesTableAdapter.Delete_Customer_Order(Convert.ToInt32(row.Value));
                    
                    // fill lại
                    customer_Order_ViewTableAdapter.Fill(sellManagementDbDataSet.Customer_Order_View);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể xóa vì đơn hàng đang được sử dụng.", Resources.ErrorLabel, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void contextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            if(customerOrderViewBindingSource.Current == null || billDataGridView.RowCount <= 0)
            {
                if(customerOrderViewBindingSource.Current != null)
                    contextMenuStrip.Enabled = false;

                selectBtn.Enabled = false;

                return;
            }

            deleteMenuItem.Enabled = true;
            var current = ((customerOrderViewBindingSource.Current as DataRowView).Row as SellManagementDbDataSet.Customer_Order_ViewRow);

            var list = sellManagementDbDataSet.INOUT_INVENTORY_DETAIL.Where(o => o.Order_id == current.Id);
            if(list.Count() > 0)
            {
                deleteMenuItem.Enabled = false;
            }
        }

        private void billDataGridView_DoubleClick(object sender, EventArgs e)
        {
            selectBtn_Click(sender, e);
        }
    }
}
