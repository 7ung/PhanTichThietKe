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
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void searchText_TextChanged(object sender, EventArgs e)
        {
            customerOrderViewBindingSource.Filter = billDataGridView.Columns["keyColumn"].DataPropertyName.ToString() + " LIKE '%" + searchText.Text + "%'";
        }
    }
}
