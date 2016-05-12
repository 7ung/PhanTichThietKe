using QuanLyBanHang.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void newProductMenuItem_Click(object sender, EventArgs e)
        {
            var newTab = new TabPage("Thêm sản phẩm");
            tabControl.TabPages.Add(newTab);
            tabControl.SelectedIndex = tabControl.TabCount - 1;
        }

        private void viewCustomerList_Click(object sender, EventArgs e)
        {
            var newTab = new TabPage("Danh sách khách hàng");
            var customerList = new CustomerList();
            customerList.Dock = DockStyle.Fill;
            newTab.Controls.Add(customerList);

            tabControl.TabPages.Add(newTab);
            tabControl.SelectedIndex = tabControl.TabCount - 1;
        }
    }
}
