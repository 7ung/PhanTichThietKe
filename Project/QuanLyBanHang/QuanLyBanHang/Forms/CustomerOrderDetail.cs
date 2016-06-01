﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanHang.Models;

namespace QuanLyBanHang.Forms
{
    public partial class CustomerOrderDetail : UserControl, IFormList
    {
        public int OrderId { get; set; }

        public eFormState State
        {
            get;  set;
        }

        public CustomerOrderDetail(int orderId)
        {
            OrderId = orderId;

            InitializeComponent();
        }

        public CustomerOrderDetail()
        {
            InitializeComponent();
        }

        private void CustomerOrderDetail_Load(object sender, EventArgs e)
        {
            // datagridview settings
            billDataGridView.AutoGenerateColumns = false;

            orderTableAdapter.Fill(sellManagementDbDataSet.ORDER);
            oRDER_DETAILTableAdapter.Fill(sellManagementDbDataSet.ORDER_DETAIL);
            billTableAdapter.Fill(sellManagementDbDataSet.BILL);
            cUSTOMER_BILLTableAdapter.Fill(sellManagementDbDataSet.CUSTOMER_BILL);
            pRODUCTTableAdapter.Fill(sellManagementDbDataSet.PRODUCT);
            sTAFFTableAdapter.Fill(sellManagementDbDataSet.STAFF);
            dEBTTableAdapter.Fill(sellManagementDbDataSet.DEBT);
            pURCHASE_ORDERTableAdapter.Fill(sellManagementDbDataSet.PURCHASE_ORDER);
            documentTableAdapter.Fill(sellManagementDbDataSet.DOCUMENT);
            cUSTOMERTableAdapter.Fill(sellManagementDbDataSet.CUSTOMER);
            constantTableAdapter.Fill(sellManagementDbDataSet.CONSTANT);
            groupofCUSTOMERTableAdapter.Fill(sellManagementDbDataSet.GROUPofCUSTOMER);

            // bind type combobox
            BindingType();
            BindingOrderStatus();
            BindingDebtStatus();

            // filter order
            SelectOrderById(this.OrderId);

            // update state
            updateState(eFormState.VIEW);

            // update constant
            var value = sellManagementDbDataSet.CONSTANT.Where(c => c.Name == "VAT_rate").First().Value;
            vatValueText.Text = (Convert.ToDouble(value) * 100).ToString() + "%";
        }

        private void SelectOrderById(int orderId)
        {
            // tìm document order
            var docOrder = sellManagementDbDataSet.DOCUMENT.Where(d => d.Id == orderId).First();
            dOCUMENTBindingSource.DataSource = docOrder;

            // orders
            var orders = sellManagementDbDataSet.ORDER.Where(o => o.Id == orderId);
            var orderdetail = sellManagementDbDataSet.ORDER_DETAIL.Where(o => o.Order_id == orderId);

            if(orders.Count() > 0)
            {
                oRDERBindingSource.DataSource = orders.ToList();
            }

            if(orderdetail.Count() > 0)
            {
                oRDERDETAILBindingSource.DataSource = orderdetail.ToList();
            }
            
            // tìm document debt id
            var docDebtId = sellManagementDbDataSet.DOCUMENT.Where(d => d.DocumentKey.Contains("CD_" + docOrder.DocumentKey)).First().Id;

            // debt
            var debt = sellManagementDbDataSet.DEBT.Where(d => d.Id == docDebtId);
            if(debt.Count() > 0)
            {
                dEBTBindingSource.DataSource = debt.ToList();
            }

            // bill
            var customerBill = from bill in sellManagementDbDataSet.BILL
                               join billdetail in sellManagementDbDataSet.CUSTOMER_BILL on bill.Id equals billdetail.Id
                               where bill.Debt_id == docDebtId
                               select new { bill.Id, bill.Debt_id, bill.PaidMethod, billdetail.ReceiveMoney, billdetail.ChangeMoney };

            if(customerBill.Count() > 0)
            {
                billDataGridView.DataSource = customerBill.ToList();
            }

            // purchase order
            var purchase = sellManagementDbDataSet.PURCHASE_ORDER.Where(p => p.Id == orderId).First();
            pURCHASEORDERBindingSource.DataSource = purchase;

            // update discount
            var customer = sellManagementDbDataSet.CUSTOMER.Where(c => c.Id == purchase.Customer_id).First();
            var group = sellManagementDbDataSet.GROUPofCUSTOMER.Where(g => g.Id == customer.Group_id).First();
            discountText.Text = (group.Discount * 100).ToString() + "%";
        }

        private void BindingType()
        {
            var types = new StringNStringBindingData[]
           {
                new StringNStringBindingData("Đơn hàng NCC" ,"vendororder"),
                new StringNStringBindingData("Đơn hàng khách hàng", "customerorder"),
                new StringNStringBindingData("Nợ NCC", "vendordebt"),
                new StringNStringBindingData("Nợ khách hàng", "customerdebt"),
                new StringNStringBindingData("Thanh toán NCC", "vendorbill"),
                new StringNStringBindingData("Thanh toán khách hàng", "customerbill"),
           };

            typeComboBox.DataSource = types;
            typeComboBox.DisplayMember = "Name";
            typeComboBox.ValueMember = "Value";
        }

        private void BindingOrderStatus()
        {
            var types = new StringNStringBindingData[]
            {
                new StringNStringBindingData("Hoàn thành" ,"complete"),
                new StringNStringBindingData("Hết hàng", "outofstock"),
                new StringNStringBindingData("Đang giao hàng", "shipping")
            };

            statusOrderComboBox.DataSource = types;
            statusOrderComboBox.DisplayMember = "Name";
            statusOrderComboBox.ValueMember = "Value";
        }

        private void BindingDebtStatus()
        {
            var types = new StringNStringBindingData[]
            {
                new StringNStringBindingData("Một phần" ,"apart"),
                new StringNStringBindingData("Hoàn thành", "finish"),
                new StringNStringBindingData("Quá hạng", "expired"),
                new StringNStringBindingData("Chưa thanh toán", "nopaid"),
            };

            statusDebtComboBox.DataSource = types;
            statusDebtComboBox.DisplayMember = "Name";
            statusDebtComboBox.ValueMember = "Value";
        }

        public void updateState(eFormState state)
        {
            switch (state)
            {
                case eFormState.EDIT:
                    {
                        enableAllControls(true, false);
                        saveBtn.Visible = true;
                        editBtn.Visible = false;
                        cancelBtn.Visible = true;
                        addBillBtn.Visible = isMultiPaid.Checked;
                        addProductBtn.Visible = true;
                        
                        break;
                    }
                case eFormState.CREATE_NEW:
                    break;
                case eFormState.VIEW:
                    {
                        enableAllControls(true, true);
                        saveBtn.Visible = false;
                        editBtn.Visible = true;
                        cancelBtn.Visible = false;
                        addBillBtn.Visible = false;
                        addProductBtn.Visible = false;
                        break;
                    }
                default:
                    break;
            }
        }

        public void enableAllControls(bool enable, bool readOnly)
        {
            //customerNameComboBox.Enabled = enable;
            typeComboBox.Enabled = enable;
            createDateTimePicker.Enabled = enable;
            staffComboBox.Enabled = enable;
            statusOrderComboBox.Enabled = enable;
            extraTextBox.Enabled = enable;

            //customerNameComboBox.Enabled = !readOnly;
            typeComboBox.Enabled = !readOnly;
            createDateTimePicker.Enabled = !readOnly;
            staffComboBox.Enabled = !readOnly;
            statusOrderComboBox.Enabled = !readOnly;
            extraTextBox.ReadOnly = readOnly;

        }

        public bool IsValidInformation()
        {
            return true;
        }

        private void saveData()
        {
            oRDERBindingSource.EndEdit();
            orderTableAdapter.Update(sellManagementDbDataSet.ORDER);
            sellManagementDbDataSet.ORDER.AcceptChanges();

            pURCHASEORDERBindingSource.EndEdit();
            pURCHASE_ORDERTableAdapter.Update(sellManagementDbDataSet.PURCHASE_ORDER);
            sellManagementDbDataSet.PURCHASE_ORDER.AcceptChanges();

            dOCUMENTBindingSource.EndEdit();
            documentTableAdapter.Update(sellManagementDbDataSet.DOCUMENT);
            sellManagementDbDataSet.DOCUMENT.AcceptChanges();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {

            saveData();
            updateState(eFormState.VIEW);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            sellManagementDbDataSet.RejectChanges();

            updateState(eFormState.VIEW);
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            updateState(eFormState.EDIT);
        }

        private void customerNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateDiscount();
        }

        private void updateDiscount()
        {
            // update discount
            // var purchase = pURCHASEORDERBindingSource.DataSource as SellManagementDbDataSet.PURCHASE_ORDERRow;
            var customer = sellManagementDbDataSet.CUSTOMER.Where(c => c.Id == (int)customerNameComboBox.SelectedValue).First();
            var group = sellManagementDbDataSet.GROUPofCUSTOMER.Where(g => g.Id == customer.Group_id).First();
            discountText.Text = (group.Discount * 100).ToString() + "%";
        }

        private void customerNameComboBox_TextChanged(object sender, EventArgs e)
        {
            // không cập nhật discount vì ko cho thay đổi customer
            // updateDiscount();
        }
    }
}