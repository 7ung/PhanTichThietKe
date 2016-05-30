using System;
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
    public partial class CustomerOrderList : UserControl, IFormList
    {
        public CustomerOrderList()
        {
            InitializeComponent();

            customer_Order_ViewTableAdapter.Fill(sellManagementDbDataSet.Customer_Order_View);
            customerTableAdapter.Fill(sellManagementDbDataSet.CUSTOMER);
            orderDetailTableAdapter.Fill(sellManagementDbDataSet.ORDER_DETAIL);
            productTableAdapter.Fill(sellManagementDbDataSet.PRODUCT);
            cONSTANTTableAdapter.Fill(sellManagementDbDataSet.CONSTANT);
            sTAFFTableAdapter.Fill(sellManagementDbDataSet.STAFF);

            documentTableAdapter.Fill(sellManagementDbDataSet.DOCUMENT);
            orderTableAdapter.Fill(sellManagementDbDataSet.ORDER);
            purchaseORDERTableAdapter.Fill(sellManagementDbDataSet.PURCHASE_ORDER);

            updateState(eFormState.VIEW);

            BindOrderStatusConstant();
            BindTypeComboBox();
        }

        private void BindTypeComboBox()
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

        private void BindOrderStatusConstant()
        {
            //var orderStatus = from constant in sellManagementDbDataSet.CONSTANT
            //                  where constant.Name == "order_status"
            //                  select constant;

            //statusComboBox.DataSource = orderStatus.ToArray();
            //statusComboBox.DisplayMember = "Value";
            //statusComboBox.ValueMember = "Id";
        }

        public eFormState State { get; set; }

        public void enableAllControls(bool enable, bool readOnly)
        {
            customerNameComboBox.Enabled = enable;
            chooseCusomerBtn.Enabled = enable;
            typeComboBox.Enabled = enable;
            createDateTimePicker.Enabled = enable;
            staffComboBox.Enabled = enable;
            chooseStaffBtn.Enabled = enable;
            transactionDatePicker.Enabled = enable;
            statusText.Enabled = enable;
            isMultiPaid.Enabled = enable;
            vatTextBox.Enabled = enable;
            extraTextBox.Enabled = enable;
            discountTextBox.Enabled = enable;
            productsDataGridView.Enabled = enable;

            customerNameComboBox.Enabled = !readOnly;
            chooseCusomerBtn.Enabled = !readOnly;
            typeComboBox.Enabled = !readOnly;
            createDateTimePicker.Enabled = !readOnly;
            staffComboBox.Enabled = !readOnly;
            chooseStaffBtn.Enabled = !readOnly;
            transactionDatePicker.Enabled = !readOnly;
            statusText.Enabled = !readOnly;
            isMultiPaid.Enabled = !readOnly;
            vatTextBox.ReadOnly = readOnly;
            extraTextBox.ReadOnly = readOnly;
            discountTextBox.ReadOnly = readOnly;
            productsDataGridView.Enabled = !readOnly;
        }

        public bool IsValidInformation()
        {
            return true;
        }

        public void updateState(eFormState state)
        {
            switch (state)
            {
                case eFormState.EDIT:
                    {
                        enableAllControls(true, false);
                        cancelBtn.Visible = true;
                        saveBtn.Visible = true;
                        editBtn.Visible = false;
                        break;
                    }
                case eFormState.VIEW:
                    {
                        enableAllControls(true, true);
                        cancelBtn.Visible = false;
                        saveBtn.Visible = false;
                        editBtn.Visible = true;
                        break;
                    }
                default:
                    break;
            }
        }

        private void customerOrderdataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (customerOrderDataGridView.SelectedRows.Count <= 0)
                return;

            var id = customerOrderDataGridView.SelectedRows[0].Cells["idColumn"];
            orderDetailBindingSource.Filter = "Order_id = " + id.Value;
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            updateState(eFormState.EDIT);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (State == eFormState.EDIT)
            {
                try
                {
                    customerOrderViewBindingSource.EndEdit();
                    
                    //orderTableAdapter.Update(sellManagementDbDataSet.ORDER);
                    //documentTableAdapter.Update(sellManagementDbDataSet.DOCUMENT);
                    //purchaseORDERTableAdapter.Update(sellManagementDbDataSet.PURCHASE_ORDER);
                    //orderDetailTableAdapter.Update(sellManagementDbDataSet.ORDER_DETAIL);

                
                    //sellManagementDbDataSet.ORDER.AcceptChanges();
                    //sellManagementDbDataSet.Customer_Order_View.AcceptChanges();
                    //sellManagementDbDataSet.AcceptChanges();

                    var currentRow = (customerOrderViewBindingSource.Current as DataRowView).Row as SellManagementDbDataSet.Customer_Order_ViewRow;
                    var curOrder = sellManagementDbDataSet.ORDER.FindById(currentRow.Id);
                    var curDoc = sellManagementDbDataSet.DOCUMENT.FindById(currentRow.Id);
                    var curPur = sellManagementDbDataSet.PURCHASE_ORDER.FindById(currentRow.Id);

                    // order
                    //curOrder.BeginEdit();

                    //curOrder.TransactionDate = currentRow.TransactionDate;

                    //curOrder.EndEdit();

                    //orderTableAdapter.Update(sellManagementDbDataSet.ORDER);
                    //sellManagementDbDataSet.ORDER.AcceptChanges();

                    // doc
                    curDoc.BeginEdit();
                    curDoc.Type = currentRow.Type;
                    curDoc.Creator = currentRow.Creator;
                    curDoc.CreateDate = currentRow.CreateDate;
                    curDoc.EndEdit();

                    documentTableAdapter.Update(sellManagementDbDataSet.DOCUMENT);
                    sellManagementDbDataSet.DOCUMENT.AcceptChanges();

                    // purchase
                    curPur.BeginEdit();
                    curPur.Customer_id = currentRow.Customer_id;
                    curPur.Discount = currentRow.Discount;
                    curPur.ExtraPaid = currentRow.ExtraPaid;
                    curPur.IsMultiPaid = currentRow.IsMultiPaid;
                    curPur.EndEdit();

                    purchaseORDERTableAdapter.Update(sellManagementDbDataSet.PURCHASE_ORDER);
                    sellManagementDbDataSet.PURCHASE_ORDER.AcceptChanges();


                    updateState(eFormState.VIEW);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void customerOrderDataGridView_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            //sellManagementDbDataSet.Customer_Order_View.RejectChanges();
        }
    }
}
