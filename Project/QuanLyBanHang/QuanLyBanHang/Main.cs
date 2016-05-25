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
    public enum eTabType
    {
        MAIN_TAB,           // tab chính
        CUSTOMER_TAB,       // danh sách khách hàng
        VENDOR_TAB,         // danh sách nhà cung cấp
        ORDER_TAB,
        CUSTOMER_ORDER_LIST_TAB
    }

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
            createNewTab(eTabType.CUSTOMER_TAB);
        }

        private void vendorListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createNewTab(eTabType.VENDOR_TAB);
        }

        private void createNewTab(eTabType type)
        {
            switch (type)
            {
                case eTabType.MAIN_TAB:
                    break;
                case eTabType.CUSTOMER_TAB:
                    {
                        var newTab = new TabPage("Danh sách khách hàng");
                        var customerList = new CustomerList();
                        customerList.Dock = DockStyle.Fill;
                        newTab.Controls.Add(customerList);

                        tabControl.TabPages.Add(newTab);
                        tabControl.SelectedIndex = tabControl.TabCount - 1;
                        break;
                    }
                case eTabType.VENDOR_TAB:
                    {
                        var newTab = new TabPage("Danh sách nhà cung cấp");
                        var vendorList = new VendorList();
                        vendorList.Dock = DockStyle.Fill;
                        newTab.Controls.Add(vendorList);

                        tabControl.TabPages.Add(newTab);
                        tabControl.SelectedIndex = tabControl.TabCount - 1;
                        break;
                    }
                case eTabType.ORDER_TAB:
                    {
                        //var newTab = new TabPage("Giao dịch");
                        //newTab.AutoScroll = true;
                        //var order = new OrderDetailForm();
                        //order.Dock = DockStyle.Top;
                        //newTab.Controls.Add(order);

                        //tabControl.TabPages.Add(newTab);
                        //tabControl.SelectedIndex = tabControl.TabCount - 1;

                        var customerOrder = new CreateCustomerOrderForm();
                        var result = customerOrder.ShowDialog();
                        if(result == DialogResult.OK)
                        {
                            var newTab = new TabPage("Giao dịch");
                            newTab.AutoScroll = true;
                            var order = new OrderDetailForm(customerOrder.OrderId);
                            order.Dock = DockStyle.Top;
                            newTab.Controls.Add(order);

                            tabControl.TabPages.Add(newTab);
                            tabControl.SelectedIndex = tabControl.TabCount - 1;
                        }

                        break;
                    }
                case eTabType.CUSTOMER_ORDER_LIST_TAB:
                    {
                        var newTab = new TabPage("Danh sách đơn bán hàng");
                        newTab.AutoScroll = true;
                        var order = new CustomerOrderList();
                        order.Dock = DockStyle.Fill;
                        newTab.Controls.Add(order);

                        tabControl.TabPages.Add(newTab);
                        tabControl.SelectedIndex = tabControl.TabCount - 1;
                        break;
                    }
                default:
                    break;
            }
        }

        private void newCustomer_Click(object sender, EventArgs e)
        {

        }

        private void newVendorMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newOrder_Click(object sender, EventArgs e)
        {
            createNewTab(eTabType.ORDER_TAB);
        }

        private void viewOrdersBtn_Click(object sender, EventArgs e)
        {
            createNewTab(eTabType.CUSTOMER_ORDER_LIST_TAB);
        }
    }
}
