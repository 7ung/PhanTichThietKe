﻿using QuanLyBanHang.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        CUSTOMER_ORDER_LIST_TAB,
        PRODUCT_TAB,
        STORE_TAB,
        STAFF_TAB,
        INOUT_INVENTORY,    // nhập xuất đơn hàng.
        INVENTORY_LIST,
        VENDOR_ORDER_TAB,
        VENDOR_ORDER_LIST_TAB,
        REVENUE_REPORT_TAB,
        CUSTOMER_REPORT_TAB,
        CREATE_BUSINESS_REPORT_TAB,
        VIEW_BUSINESS_REPORT_TAB,
        INVENTORY_REPORT_TAB,
    }

    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void newProductMenuItem_Click(object sender, EventArgs e)
        {
            (new AddProduct()).ShowDialog();
        }

        private void viewCustomerList_Click(object sender, EventArgs e)
        {
            createNewTab(eTabType.CUSTOMER_TAB);
        }

        private void vendorListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createNewTab(eTabType.VENDOR_TAB);
        }

        // Hieu
        // Kiem tra su ton tai cua tabpage
        private TabPage isExitTabPage(string nameTab)
        {
            foreach (TabPage tab in tabControl.TabPages)
            {
                if(tab.Text == nameTab)
                {
                    return tab;
                }
            }
          
                return null;
        }
        

        private void createNewTab(eTabType type)
        {
            switch (type)
            {
                case eTabType.MAIN_TAB:
                    break;
                case eTabType.CUSTOMER_TAB:
                    {
                        //Hieu 
                        //Edit
                        var newTab = isExitTabPage("Danh sách khách hàng");
                        if (newTab == null)
                        {
                            newTab = new TabPage("Danh sách khách hàng");
                            var customerList = new CustomerList();
                            customerList.Dock = DockStyle.Fill;
                            newTab.Controls.Add(customerList);

                            tabControl.TabPages.Add(newTab);
                        }

                        tabControl.SelectedTab = newTab;
                        break;
                    }
                case eTabType.VENDOR_TAB:
                    {
                        var newTab = isExitTabPage("Danh sách nhà cung cấp");
                        if (newTab == null)
                        {
                            newTab = new TabPage("Danh sách nhà cung cấp");
                            var vendorList = new VendorList();
                            vendorList.Dock = DockStyle.Fill;
                            newTab.Controls.Add(vendorList);

                            tabControl.TabPages.Add(newTab);
                        }

                        tabControl.SelectedTab = newTab;
                        break;
                    }
                case eTabType.ORDER_TAB:
                    {
                        var customerOrder = new CreateCustomerOrderForm();
                        var result = customerOrder.ShowDialog();
                        if(result == DialogResult.OK)
                        {
                            var newTab = isExitTabPage("Giao dịch");
                            if (newTab == null)
                            {
                                newTab = new TabPage("Giao dịch");
                                newTab.AutoScroll = true;
                                var order = new OrderDetailForm(customerOrder.OrderId);
                                order.Dock = DockStyle.Top;
                                newTab.Controls.Add(order);

                                tabControl.TabPages.Add(newTab);
                            }

                            tabControl.SelectedTab = newTab;
                        }
                        else if(result == DialogResult.Retry)
                        {
                            createNewTab(eTabType.CUSTOMER_TAB);
                        }

                        break;
                    }
                case eTabType.CUSTOMER_ORDER_LIST_TAB:
                    {
                        var selectForm = new SelectOrderForm();
                        var result = selectForm.ShowDialog();

                        if (result == DialogResult.OK)
                        {
                            var text = "Đơn hàng " + selectForm.OrderKey;
                            var newTab = isExitTabPage(text);

                            if (newTab == null)
                            {
                                newTab = new TabPage(text);
                                newTab.AutoScroll = true;
                                var order = new CustomerOrderDetail(selectForm.OrderId);
                                order.Dock = DockStyle.Fill;
                                newTab.Controls.Add(order);

                                tabControl.TabPages.Add(newTab);
                            }

                            tabControl.SelectedTab = newTab;
                        }

                        break;
                    }
                case eTabType.STORE_TAB:
                    {
                        var text = "Danh sách kho hàng";
                        var newTab = isExitTabPage(text);

                        if (newTab == null)
                        {
                            newTab = new TabPage(text);
                            newTab.AutoScroll = true;
                            var store = new InventoryList();
                            store.Dock = DockStyle.Fill;
                            newTab.Controls.Add(store);

                            tabControl.TabPages.Add(newTab);
                        }
                        tabControl.SelectedTab = newTab;
                        break;
                    }
                case eTabType.PRODUCT_TAB:
                    {
                        var text = "Danh sách mặt hàng";
                        var newTab = isExitTabPage(text);

                        if (newTab == null)
                        {
                            newTab = new TabPage(text);
                            newTab.AutoScroll = true;
                            var product = new ProductList();
                            product.Dock = DockStyle.Fill;
                            newTab.Controls.Add(product);
                            this.newProductMenuItem.Click += product.showDialogAddProduct; //7ung
                            tabControl.TabPages.Add(newTab);
                        }

                        tabControl.SelectedTab = newTab;
                        break;
                    }

                case eTabType.STAFF_TAB:
                    {
                        var text = "Danh sách nhân viên";
                        var newTab = isExitTabPage(text);

                        if (newTab == null)
                        {
                            newTab = new TabPage(text);
                            newTab.AutoScroll = true;
                            var staff = new StaffList();
                            staff.Dock = DockStyle.Fill;
                            newTab.Controls.Add(staff);

                            tabControl.TabPages.Add(newTab);
                        }
                        tabControl.SelectedTab = newTab;
                        break;
                    }
                case eTabType.INOUT_INVENTORY:
                    {
                        var text = "Quản lý đơn hàng nhập xuất kho";
                        var newTab = isExitTabPage(text);

                        if (newTab == null)
                        {
                            newTab = new TabPage(text);
                            newTab.AutoScroll = true;
                            var store = new InOutInventoryList();
                            store.Dock = DockStyle.Fill;
                            newTab.Controls.Add(store);

                            tabControl.TabPages.Add(newTab);
                        }
                        tabControl.SelectedTab = newTab;
                        break;
                    }
                case eTabType.INVENTORY_LIST:
                    {
                        var text = "Quản lý kho hàng";
                        var newTab = isExitTabPage(text);

                        if (newTab == null)
                        {
                            newTab = new TabPage(text);
                            newTab.AutoScroll = true;
                            var store = new InventoryList();
                            store.Dock = DockStyle.Fill;
                            newTab.Controls.Add(store);

                            tabControl.TabPages.Add(newTab);
                        }
                        tabControl.SelectedTab = newTab;
                        break;
                    }
                case eTabType.VENDOR_ORDER_TAB:
                    {
                        var vendorOrder = new CreateVendorOrderForm();
                        var result = vendorOrder.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            var text = "Giao dịch đơn hàng " + vendorOrder.DocumentKey;
                            var newTab = isExitTabPage(text);

                            if (newTab == null)
                            {
                                newTab = new TabPage(text);
                                newTab.AutoScroll = true;
                                var order = new VendorOrderDetailForm(vendorOrder.OrderId);
                                order.Dock = DockStyle.Top;
                                newTab.Controls.Add(order);

                                tabControl.TabPages.Add(newTab);
                            }
                            tabControl.SelectedTab = newTab;
                        }
                        else if (result == DialogResult.Retry)
                        {
                            createNewTab(eTabType.VENDOR_TAB);
                        }
                        break;
                    }
                case eTabType.VENDOR_ORDER_LIST_TAB:
                    {
                        var selectForm = new SelectVendorOrderForm();
                        var result = selectForm.ShowDialog();

                        if (result == DialogResult.OK)
                        {
                            var text = "Đơn hàng " + selectForm.DocumentKey;
                            var newTab = isExitTabPage(text);

                            if (newTab == null)
                            {
                                newTab = new TabPage(text);
                                newTab.AutoScroll = true;
                                var order = new VendorOrderDetail(selectForm.OrderId);
                                order.DocumentKey = selectForm.DocumentKey;
                                order.Dock = DockStyle.Fill;
                                newTab.Controls.Add(order);

                                tabControl.TabPages.Add(newTab);
                            }
                            tabControl.SelectedTab = newTab;
                        }
                        break;
                    }

                case eTabType.REVENUE_REPORT_TAB:
                    {
                        var text = "Báo cáo doanh thu";
                        var newTab = isExitTabPage(text);

                        if (newTab == null)
                        {
                            newTab = new TabPage(text);
                            newTab.AutoScroll = true;
                            var report = new RevenueReport();
                            report.Dock = DockStyle.Fill;
                            newTab.Controls.Add(report);

                            tabControl.TabPages.Add(newTab);
                        }
                        tabControl.SelectedTab = newTab;
                        break;
                    }
                case eTabType.CUSTOMER_REPORT_TAB:
                    {
                        var text = "Báo cáo tình hình khách hàng";
                        var newTab = isExitTabPage(text);

                        if (newTab == null)
                        {
                            newTab = new TabPage(text);
                            newTab.AutoScroll = true;
                            var report = new CustomerReport();
                            report.Dock = DockStyle.Top;
                            newTab.Controls.Add(report);

                            tabControl.TabPages.Add(newTab);
                        }
                        tabControl.SelectedTab = newTab;
                        break;
                    }
                case eTabType.CREATE_BUSINESS_REPORT_TAB:
                    {
                        var dialogCreate = new CreateReportForm();
                        var r = dialogCreate.ShowDialog();

                        if (r == DialogResult.OK)
                        {
                            var text = "Báo cáo chi phí bán hàng";
                            var newTab = isExitTabPage(text);

                            if (newTab == null)
                            {
                                newTab = new TabPage(text);
                                newTab.AutoScroll = true;
                                var report = new CreateBusinessFee(dialogCreate.DocumentId, true);
                                report.Dock = DockStyle.Top;
                                newTab.Controls.Add(report);

                                tabControl.TabPages.Add(newTab);
                            }
                            tabControl.SelectedTab = newTab;
                        }
                        break;
                    }
                case eTabType.VIEW_BUSINESS_REPORT_TAB:
                    {
                        var text = "Xem cáo chi phí bán hàng";
                        var newTab = isExitTabPage(text);

                        if (newTab == null)
                        {
                            newTab = new TabPage(text);
                            newTab.AutoScroll = true;
                            var report = new ViewBusinessFee();
                            report.Dock = DockStyle.Top;
                            newTab.Controls.Add(report);

                            tabControl.TabPages.Add(newTab);
                        }
                        tabControl.SelectedTab = newTab;
                        break;
                    }
                case eTabType.INVENTORY_REPORT_TAB:
                    {
                        var text = "Báo cáo tồn kho";
                        var newTab = isExitTabPage(text);

                        if (newTab == null)
                        {
                            newTab = new TabPage(text);
                            newTab.AutoScroll = true;
                            var report = new InventoryReport();
                            report.Dock = DockStyle.Fill;
                            newTab.Controls.Add(report);

                            tabControl.TabPages.Add(newTab);
                        }
                        tabControl.SelectedTab = newTab;
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

        private void productsMenuItem_Click(object sender, EventArgs e)
        {
            createNewTab(eTabType.PRODUCT_TAB);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            createNewTab(eTabType.STORE_TAB);
        }

        private void staffListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createNewTab(eTabType.STAFF_TAB);
        }

        private void listDocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createNewTab(eTabType.INOUT_INVENTORY);
        }

        // tung
        public void remove_refresh(EventHandler showDialogAddProduct)
        {
            this.newProductMenuItem.Click -= showDialogAddProduct;
        }

        private void newVendorOrderBtn_Click(object sender, EventArgs e)
        {
            createNewTab(eTabType.VENDOR_ORDER_TAB);
        }

        private void vendorOrdersBtn_Click(object sender, EventArgs e)
        {
            createNewTab(eTabType.VENDOR_ORDER_LIST_TAB);
        }

        private void inventoryListBtn_Click(object sender, EventArgs e)
        {
            createNewTab(eTabType.INVENTORY_LIST);
        }

        private void inoutInventoryBtn_Click(object sender, EventArgs e)
        {
            createNewTab(eTabType.INOUT_INVENTORY);
        }

        private void inInventoryBtn_Click(object sender, EventArgs e)
        {
            var listForm = new SelectInventoryForm();
            var result = listForm.ShowDialog();

            if(result == DialogResult.OK)
            {
                var addForm = new AddInoutInventory(true);
                addForm.InventoryId = listForm.InventoryId;
                addForm.ShowDialog();
            }

        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            var listForm = new SelectInventoryForm();
            var result = listForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                var addForm = new AddInoutInventory(false);
                addForm.InventoryId = listForm.InventoryId;
                addForm.ShowDialog();
            }
        }

        private void productListBtn_Click(object sender, EventArgs e)
        {
            createNewTab(eTabType.PRODUCT_TAB);
        }

        private void newInvetoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var r = (new AddInventory()).ShowDialog();
            if (r == DialogResult.OK ){
                createNewTab(eTabType.INVENTORY_LIST);
            }
        }

        private void revenueReportBtn_Click(object sender, EventArgs e)
        {
            var listForm = new SelectReportForm();
            var result = listForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                var newTab = new TabPage("Báo cáo chi phí bán hàng");
                newTab.AutoScroll = true;
                var report = new ViewBusinessFee(listForm.DocumentId);
                report.Dock = DockStyle.Top;
                newTab.Controls.Add(report);

                tabControl.TabPages.Add(newTab);
                tabControl.SelectedIndex = tabControl.TabCount - 1;
            }
            else if (result == DialogResult.Retry)
            {
                var newTab = new TabPage("Sửa báo cáo chi phí bán hàng");
                newTab.AutoScroll = true;
                var report = new CreateBusinessFee(listForm.DocumentId, false);
                report.Dock = DockStyle.Top;
                newTab.Controls.Add(report);

                tabControl.TabPages.Add(newTab);
                tabControl.SelectedIndex = tabControl.TabCount - 1;
            }
            else if (result == DialogResult.Yes)
            {
                createNewTab(eTabType.CREATE_BUSINESS_REPORT_TAB);
            }
        }

        private void customerReportBtn_Click(object sender, EventArgs e)
        {
            createNewTab(eTabType.CUSTOMER_REPORT_TAB);
        }

        private void createBusinessFeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createNewTab(eTabType.CREATE_BUSINESS_REPORT_TAB);
        }

        private void viewBusinessFeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createNewTab(eTabType.VIEW_BUSINESS_REPORT_TAB);
        }

        private void inventoryReportBtn_Click(object sender, EventArgs e)
        {
            createNewTab(eTabType.INVENTORY_REPORT_TAB);
        }

        private void revenueBtn_Click(object sender, EventArgs e)
        {
            createNewTab(eTabType.REVENUE_REPORT_TAB);
        }

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createNewTab(eTabType.REVENUE_REPORT_TAB);
        }

        private void tonKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createNewTab(eTabType.INVENTORY_REPORT_TAB);
        }

        private Point position = new Point(0,0);
        private int gap = 20;

        private void mainPage_SizeChanged(object sender, EventArgs e)
        {
            int groupW = sellGroupBox.Width;
            int groupH = sellGroupBox.Height;

            position.X = (mainPage.Size.Width - (sellGroupBox.Width * 2) - gap * 3) / 2;
            position.Y = (mainPage.Size.Height - (sellGroupBox.Height * 2) - gap * 3) / 2;

            sellGroupBox.Location = position;
            groupBox1.Location = new Point(position.X + groupW + gap, position.Y);
            groupBox2.Location = new Point(position.X, position.Y + groupH + gap);
            groupBox3.Location = new Point(groupBox1.Location.X, groupBox2.Location.Y);
        }

        private void sellManagementDbDataSet_Initialized(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
        }

        private void allTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var types = new ProductMetaList();
            types.ShowDialog();
        }

        private void productTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var types = new ProductMetaList(ProductMetaList.eProductType.TYPE);
            types.ShowDialog();
        }

        private void brandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var types = new ProductMetaList(ProductMetaList.eProductType.BRAND);
            types.ShowDialog();
        }

        private void unitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var types = new ProductMetaList(ProductMetaList.eProductType.UNIT);
            types.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var settings = new SettingForm();
            settings.ShowDialog();
        }

        private void infoMenuItem_Click(object sender, EventArgs e)
        {
            var info = new InfoForm();
            info.ShowDialog();
        }
    }
}
