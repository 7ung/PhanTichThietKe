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
    public partial class VendorOrderDetailForm : UserControl
    {
        public int OrderId { get; set; }

        private int _currentProductId;

        public VendorOrderDetailForm()
        {
            InitializeComponent();
        }

        public VendorOrderDetailForm(int orderId)
        {
            InitializeComponent();

            OrderId = orderId;
        }

        private void VendorOrderDetailForm_Load(object sender, EventArgs e)
        {
            // fill dữ liệu
            dOCUMENTTableAdapter.Fill(sellManagementDbDataSet.DOCUMENT);
            vENDORTableAdapter.Fill(sellManagementDbDataSet.VENDOR);
            vENDOR_ORDERTableAdapter.Fill(sellManagementDbDataSet.VENDOR_ORDER);
            sTAFFTableAdapter.Fill(sellManagementDbDataSet.STAFF);
            pRODUCTTableAdapter.Fill(sellManagementDbDataSet.PRODUCT);
            oRDER_DETAILTableAdapter.Fill(sellManagementDbDataSet.ORDER_DETAIL);
            oRDERTableAdapter.Fill(sellManagementDbDataSet.ORDER);
            debtTableAdapter.Fill(sellManagementDbDataSet.DEBT);
            constantTableAdapter.Fill(sellManagementDbDataSet.CONSTANT);
            iNVENTORY_CAPABILITYTableAdapter.Fill(sellManagementDbDataSet.INVENTORY_CAPABILITY);

            // order
            SelectByOrderId(OrderId);

            documentKey.Select(0, 0);
            productIdCombobox.SelectedIndex = -1;
            currentComboBox.SelectedIndex = -1;
            productNameText.Text = "";
            productPriceText.Text = "";

            // vat
            vatText.Text = sellManagementDbDataSet.CONSTANT.Where(c => c.Name == "VAT_rate").First().Value;

            bindOrderStatus();
        }

        private void SelectByOrderId(int id)
        {
            dOCUMENTBindingSource.Filter = "Id = " + id;
            vENDORORDERBindingSource.Filter = "Id = " + id;
            oRDERDETAILBindingSource.Filter = "Order_id = " + id;
            oRDERBindingSource.Filter = "Id = " + id;
        }

        private void bindOrderStatus()
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

            statusOrderComboBox.SelectedValue = "complete";
        }

        private void productIdText_TextChanged(object sender, EventArgs e)
        {
            var products = sellManagementDbDataSet.PRODUCT.Where(x => x.ProductKey.ToLower().Contains(productIdCombobox.Text.ToLower()));

            if (products.Count() == 0)
            {
                productNameText.Text = "Không tìm thấy!";
                productPriceText.Text = "";
                _currentProductId = 0;
                return;
            }

            _currentProductId = products.First().Id;
            productNameText.Text = products.First().Name;
            productPriceText.Text = products.First().OutPrice.ToString();
            currentComboBox.SelectedValue = _currentProductId;
        }

        private void addProductBtn_Click(object sender, EventArgs e)
        {
            if (_currentProductId == 0 || productQuantityText.Text == "")
                return;

            var index = oRDERDETAILBindingSource.Find("Product_id", _currentProductId);

            if (index == -1)
            {
                var newPro = (oRDERDETAILBindingSource.AddNew() as DataRowView).Row as SellManagementDbDataSet.ORDER_DETAILRow;

                newPro.BeginEdit();
                newPro.Order_id = OrderId;
                newPro.Product_id = _currentProductId;
                newPro.Quantity = Convert.ToInt32(productQuantityText.Text);
                newPro.Price = Convert.ToDouble(productPriceText.Text);
                newPro.Result = newPro.Quantity * newPro.Price;
                newPro.EndEdit();

                oRDERDETAILBindingSource.Position = -1;
            }
            else
            {
                var product = (oRDERDETAILBindingSource[index] as DataRowView).Row as SellManagementDbDataSet.ORDER_DETAILRow;

                product.BeginEdit();
                product.Quantity += Convert.ToInt32(productQuantityText.Text);
                product.Result = product.Quantity * product.Price;
                product.EndEdit();

                oRDERDETAILBindingSource.Position = -1;
            }

            var currentOrderDetail = from order_detail in sellManagementDbDataSet.ORDER_DETAIL
                                     where order_detail.Order_id == OrderId
                                     select order_detail.Result;

            totalPriceText.Text = currentOrderDetail.Sum().ToString();
        }

        private void createBill()
        {
            string orderDocKey = documentKey.Text;
            // deb key có kiểu VD_XXXXXXX
            int docDebtId = sellManagementDbDataSet.DOCUMENT.Where(d => d.DocumentKey.Contains("VD_" + orderDocKey)).First().Id;

            var debt = sellManagementDbDataSet.DEBT.Where(d => d.Id == docDebtId);
            if (debt.Count() == 0)
                return;

            // cập nhật document
            dOCUMENTBindingSource.EndEdit();
            dOCUMENTTableAdapter.Update(sellManagementDbDataSet.DOCUMENT);
            sellManagementDbDataSet.DOCUMENT.AcceptChanges();

            // purchase order
            vENDORORDERBindingSource.EndEdit();
            vENDOR_ORDERTableAdapter.Update(sellManagementDbDataSet.VENDOR_ORDER);
            sellManagementDbDataSet.VENDOR_ORDER.AcceptChanges();

            // order
            oRDERBindingSource.EndEdit();
            oRDERTableAdapter.Update(sellManagementDbDataSet.ORDER);
            sellManagementDbDataSet.ORDER.AcceptChanges();

            // order detail
            oRDERDETAILBindingSource.EndEdit();
            oRDER_DETAILTableAdapter.Update(sellManagementDbDataSet.ORDER_DETAIL);
            sellManagementDbDataSet.ORDER_DETAIL.AcceptChanges();

            // tính bill
            double changeMoney = 0;
            double paidMoney = 0;

            if (returnCashText.Text != "")
                changeMoney = Convert.ToDouble(returnCashText.Text);

            if (paidCashText.Text != "")
                paidMoney = Convert.ToDouble(paidCashText.Text);

            queriesTableAdapter.Insert_Vendor_Bill(generateBillDocumentKey(),
                                                   (int)staffComboBox.SelectedValue,
                                                   createDatePicker.Value,
                                                   docDebtId,
                                                   "cash",
                                                   paidMoney - changeMoney,
                                                   (int)paidStaffComboBox.SelectedValue,
                                                   (int)vendorComboBox.SelectedValue);
        }

        private string generateBillDocumentKey()
        {
            int max = 0;

            foreach (DataRow item in sellManagementDbDataSet.DOCUMENT.Where(c => c.DocumentKey.Substring(0, 2) == "VB"))
            {
                var value = item["DocumentKey"].ToString().TrimStart(new char[] { 'V', 'B' });
                max = Math.Max(max, Convert.ToInt32(value));
            }

            return "VB" + String.Format("{0:D6}", max + 1);
        }

        private void UpdateMoney()
        {
            double recieveMoney = 0;
            double remainPrice = 0;

            try
            {
                if (paidCashText.Text != "")
                    recieveMoney = Convert.ToDouble(paidCashText.Text);

                if (finalPriceText.Text != "")
                    remainPrice = Convert.ToDouble(finalPriceText.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Số tiền không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                doneBtn.Enabled = false;
                return;
            }

            if (recieveMoney >= remainPrice)
            {
                returnCashText.Text = (recieveMoney - remainPrice).ToString();
                doneBtn.Enabled = true;
            }
            else
            {
                returnCashText.Text = "0";
                doneBtn.Enabled = false;
            }

            // tiền thối lớn hơn tiền trả
            if ((recieveMoney - remainPrice) > remainPrice)
            {
                MessageBox.Show("Số tiền trả quá lớn!", "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                doneBtn.Enabled = false;
            }
        }

        private void totalPriceText_TextChanged(object sender, EventArgs e)
        {
            double total = 0;
            double vat = 0;

            if (totalPriceText.Text != "")
                total = Convert.ToDouble(totalPriceText.Text);

            // vat
            if (vatText.Text != "")
                vat = Convert.ToDouble(vatText.Text);

            finalPriceText.Text = (total * (1 + vat)).ToString();
        }

        private void paidCashText_TextChanged(object sender, EventArgs e)
        {
            UpdateMoney();
        }

        private void doneBtn_Click(object sender, EventArgs e)
        {
            createBill();
            closeTab();
        }

        private void closeTab()
        {
            var page = this.Parent as TabPage;
            if (page != null)
            {
                (page.Parent as TabControl).TabPages.Remove(page);
            }
        }

        private void productPriceText_TextChanged(object sender, EventArgs e)
        {
            if (productPriceText.Text == "")
                return;

            try
            {

                var value = Convert.ToDouble(productPriceText.Text);
                if(!addProductBtn.Enabled)
                    addProductBtn.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Giá trị không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                addProductBtn.Enabled = false;
                return;
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            queriesTableAdapter.Delete_Vendor_Order(OrderId);
            closeTab();
        }
    }
}
