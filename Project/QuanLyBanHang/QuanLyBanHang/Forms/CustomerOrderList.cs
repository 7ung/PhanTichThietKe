using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang.Forms
{
    public partial class CustomerOrderList : UserControl
    {
        public CustomerOrderList()
        {
            InitializeComponent();

            customer_Order_ViewTableAdapter.Fill(sellManagementDbDataSet.Customer_Order_View);
            customerTableAdapter.Fill(sellManagementDbDataSet.CUSTOMER);

            customerOrderdataGridView.Columns["customerNameColumn"].DataGridView.DataSource = sellManagementDbDataSet.CUSTOMER;
            customerOrderdataGridView.Columns["customerNameColumn"].DataGridView.DataMember = "Id";
        }
    }
}
