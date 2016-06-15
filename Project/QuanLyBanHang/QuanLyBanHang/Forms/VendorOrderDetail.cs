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
    public partial class VendorOrderDetail : UserControl, IFormList
    {
        public int OrderId { get; set; }
        public string DocumentKey { get; set; }

        public eFormState State
        {
            get; set;
        }

        public VendorOrderDetail()
        {
            InitializeComponent();
        }

        public VendorOrderDetail(int orderId)
        {
            InitializeComponent();

            OrderId = orderId;
        }

        private void VendorOrderDetail_Load(object sender, EventArgs e)
        {
            billDataGridView.AutoGenerateColumns = false;
            
            // binding
            BindingType();
            BindingOrderStatus();
            BindingDebtStatus();
            BindingTypeBill();
            
            // fill
            oRDERTableAdapter.Fill(sellManagementDbDataSet.ORDER);
            oRDER_DETAILTableAdapter.Fill(sellManagementDbDataSet.ORDER_DETAIL);
            dOCUMENTTableAdapter.Fill(sellManagementDbDataSet.DOCUMENT);
            vENDORTableAdapter.Fill(sellManagementDbDataSet.VENDOR);
            vENDOR_ORDERTableAdapter.Fill(sellManagementDbDataSet.VENDOR_ORDER);
            sTAFFTableAdapter.Fill(sellManagementDbDataSet.STAFF);
            dEBTTableAdapter.Fill(sellManagementDbDataSet.DEBT);
            pRODUCTTableAdapter.Fill(sellManagementDbDataSet.PRODUCT);
            billTableAdapter.Fill(sellManagementDbDataSet.BILL);
            vendoR_BILLTableAdapter.Fill(sellManagementDbDataSet.VENDOR_BILL);
            constantTableAdapter.Fill(sellManagementDbDataSet.CONSTANT);

            // order
            SelectByOrderId(OrderId);

            //stage
            updateState(eFormState.VIEW);

            CheckBillForButton();

            var value = sellManagementDbDataSet.CONSTANT.Where(c => c.Name == "VAT_rate").First().Value;
            vatValueText.Text = (Convert.ToDouble(value) * 100).ToString() + "%";

            // FORMAT
            returnMoneyColumn.DefaultCellStyle.Format = "N2";
            priceDataGridViewTextBoxColumn.DefaultCellStyle.Format = "N2";
            resultDataGridViewTextBoxColumn.DefaultCellStyle.Format = "N2";
        }

        private void SelectByOrderId(int orderId)
        {
            dOCUMENTBindingSource.Filter = "Id = " + orderId;
            oRDERBindingSource.Filter = "Id = " + orderId;
            oRDERDETAILBindingSource.Filter = "Order_id = " + orderId;
            
            // tìm document order
            var docOrder = sellManagementDbDataSet.DOCUMENT.Where(d => d.Id == orderId).First();

            // tìm document debt id
            var docDebtId = sellManagementDbDataSet.DOCUMENT.Where(d => d.DocumentKey.Contains("VD_" + docOrder.DocumentKey)).First().Id;

            dEBTBindingSource.Filter = "Id = " + docDebtId;

            SelectBill(docDebtId);
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

        private void BindingTypeBill()
        {
            var types = new StringNStringBindingData[]
            {
                new StringNStringBindingData("Tiền mặt" ,"cash"),
                new StringNStringBindingData("Thẻ", "credit"),
                new StringNStringBindingData("Online", "online")
            };

            typeColumn.DataSource = types;
            typeColumn.DisplayMember = "Name";
            typeColumn.ValueMember = "Value";
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

            //customerNameComboBox.Enabled = !readOnly;
            typeComboBox.Enabled = !readOnly;
            createDateTimePicker.Enabled = !readOnly;
            staffComboBox.Enabled = !readOnly;
            statusOrderComboBox.Enabled = !readOnly;

        }

        public bool IsValidInformation()
        {
            return true;
        }

        private void SelectBill(int debtId)
        {
            billTableAdapter.Fill(sellManagementDbDataSet.BILL);
            vendoR_BILLTableAdapter.Fill(sellManagementDbDataSet.VENDOR_BILL);

            var customerBill = from bill in sellManagementDbDataSet.BILL
                               join billdetail in sellManagementDbDataSet.VENDOR_BILL on bill.Id equals billdetail.Id
                               where bill.Debt_id == debtId
                               select new { bill.Id, bill.Debt_id, bill.PaidMethod, bill.PaidMoney, billdetail.PaidStaff };

            if (customerBill.Count() > 0)
            {
                billDataGridView.DataSource = customerBill.ToList();
            }
        }

        private void CheckBillForButton()
        {
            if (isMultiPaid.Checked || Convert.ToDouble(debtText.Text) > 0)
            {
                addBillBtn.Visible = true;
            }
            else
            {
                addBillBtn.Visible = false;
            }
        }

        private void saveData()
        {
            oRDERBindingSource.EndEdit();
            oRDERTableAdapter.Update(sellManagementDbDataSet.ORDER);
            sellManagementDbDataSet.ORDER.AcceptChanges();

            oRDERDETAILBindingSource.EndEdit();
            oRDER_DETAILTableAdapter.Update(sellManagementDbDataSet.ORDER_DETAIL);
            sellManagementDbDataSet.ORDER_DETAIL.AcceptChanges();

            vENDORORDERBindingSource.EndEdit();
            vENDOR_ORDERTableAdapter.Update(sellManagementDbDataSet.VENDOR_ORDER);
            sellManagementDbDataSet.PURCHASE_ORDER.AcceptChanges();

            dOCUMENTBindingSource.EndEdit();
            dOCUMENTTableAdapter.Update(sellManagementDbDataSet.DOCUMENT);
            sellManagementDbDataSet.DOCUMENT.AcceptChanges();

            // fill lại
            oRDERTableAdapter.Fill(sellManagementDbDataSet.ORDER);
            oRDER_DETAILTableAdapter.Fill(sellManagementDbDataSet.ORDER_DETAIL);
            dOCUMENTTableAdapter.Fill(sellManagementDbDataSet.DOCUMENT);
            vENDOR_ORDERTableAdapter.Fill(sellManagementDbDataSet.VENDOR_ORDER);
            dEBTTableAdapter.Fill(sellManagementDbDataSet.DEBT);

            CheckBillForButton();
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

        private void addProductBtn_Click(object sender, EventArgs e)
        {
            var selectProduct = new SelectProductForm(OrderId);
            var result = selectProduct.ShowDialog();
            if (result == DialogResult.OK)
            {
                var resultRow = selectProduct.ResultOrderDetailRow;
                var index = oRDERDETAILBindingSource.Find("Product_id", resultRow.Product_id);

                if (index == -1)
                {
                    var newRow = sellManagementDbDataSet.ORDER_DETAIL.NewORDER_DETAILRow();

                    newRow.BeginEdit();

                    newRow.Order_id = OrderId;
                    newRow.Product_id = resultRow.Product_id;
                    newRow.Quantity = resultRow.Quantity;
                    newRow.Price = resultRow.Price;
                    newRow.Result = resultRow.Result;

                    newRow.EndEdit();

                    oRDERDETAILBindingSource.Position = -1;

                    sellManagementDbDataSet.ORDER_DETAIL.AddORDER_DETAILRow(newRow);
                }
                else
                {
                    var product = (oRDERDETAILBindingSource[index] as DataRowView).Row as SellManagementDbDataSet.ORDER_DETAILRow;

                    product.BeginEdit();
                    product.Quantity += resultRow.Quantity;
                    product.Result = product.Quantity * product.Price;
                    product.EndEdit();

                    oRDERDETAILBindingSource.Position = -1;
                }
            }
        }

        private void addBillBtn_Click(object sender, EventArgs e)
        {
            var billForm = new CreateVendorBillForm(this.OrderId);
            var result = billForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                // refresh lại
                vENDOR_ORDERTableAdapter.Fill(sellManagementDbDataSet.VENDOR_ORDER);
                dEBTTableAdapter.Fill(sellManagementDbDataSet.DEBT);

                // bill
                SelectBill(billForm.DebtId);

                CheckBillForButton();
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            var page = this.Parent as TabPage;
            if (page != null)
            {
                (page.Parent as TabControl).TabPages.Remove(page);
            }
        }
    }
}
