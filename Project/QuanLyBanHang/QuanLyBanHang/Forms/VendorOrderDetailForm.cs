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
using QuanLyBanHang.Properties;

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
            iNVENTORYTableAdapter.Fill(sellManagementDbDataSet.INVENTORY);

            // order
            SelectByOrderId(OrderId);

            documentKey.Select(0, 0);
            //productIdCombobox.SelectedIndex = -1;
            //currentComboBox.SelectedIndex = -1;
            //productNameComboBox.Text = "";
            //productPriceText.Text = "";

            // vat
            vatText.Text = sellManagementDbDataSet.CONSTANT.Where(c => c.Name == "VAT_rate").First().Value;

            bindOrderStatus();

            _currentProductId = ((pRODUCTBindingSource.Current as DataRowView).Row as SellManagementDbDataSet.PRODUCTRow).Id;

            // format
            resultDataGridViewTextBoxColumn.DefaultCellStyle.Format = "N2";
            priceDataGridViewTextBoxColumn.DefaultCellStyle.Format = "N2";
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
                productNameComboBox.Text = "Không tìm thấy!";
                productPriceText.Text = "";
                _currentProductId = 0;
                addProductBtn.Enabled = false;
                return;
            }

            if (numericUpDown.Text != "")
                addProductBtn.Enabled = true;

            _currentProductId = products.First().Id;
            //productNameComboBox.Text = products.First().Name;
            //productPriceText.Text = products.First().OutPrice.ToString();
            //currentComboBox.SelectedValue = _currentProductId;
        }

        private void addProductBtn_Click(object sender, EventArgs e)
        {
            if (_currentProductId == 0 || numericUpDown.Text == "")
                return;

            // kiểm tra max sức chứa
            var max = sellManagementDbDataSet.INVENTORY_CAPABILITY.Where(p => p.Product_id == _currentProductId && p.Inventory_id == (int)inventoryComboBox.SelectedValue);

            if (max.Count() <= 0)
            {
                // ko có trong ko
                MessageBox.Show("Sản phẩm không có thông tin trong kho", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                var number = (max.First().MaxCount - max.First().CurrentCount);
                if (numericUpDown.Value > number)
                {
                    MessageBox.Show("Số lượng sản phẩm quá sức chứa của ko", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    numericUpDown.Value = number;
                    return;
                }
            }

            var index = oRDERDETAILBindingSource.Find("Product_id", _currentProductId);

            if (index == -1)
            {
                var newPro = (oRDERDETAILBindingSource.AddNew() as DataRowView).Row as SellManagementDbDataSet.ORDER_DETAILRow;

                newPro.BeginEdit();
                newPro.Order_id = OrderId;
                newPro.Product_id = _currentProductId;
                newPro.Quantity = Convert.ToInt32(numericUpDown.Text);
                newPro.Price = Convert.ToDouble(productPriceText.Text);
                newPro.Result = newPro.Quantity * newPro.Price;
                newPro.EndEdit();

                oRDERDETAILBindingSource.Position = -1;
            }
            else
            {
                var product = (oRDERDETAILBindingSource[index] as DataRowView).Row as SellManagementDbDataSet.ORDER_DETAILRow;

                product.BeginEdit();
                product.Quantity += Convert.ToInt32(numericUpDown.Text);
                
                if (max.Count() > 0)
                {
                    var remain = (max.First().MaxCount - max.First().CurrentCount);
                    if (product.Quantity > remain)
                    {
                        product.Quantity = remain;
                    }
                }
                product.Result = product.Quantity * product.Price;
                product.EndEdit();

                oRDERDETAILBindingSource.Position = -1;
            }

            calculateTotalPrice();
            productDataGridViewRowsChanged();
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
            }
            catch (Exception)
            {
                //MessageBox.Show("Số tiền không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                paidCashText.Text = paidCashText.Text.Substring(0, paidCashText.Text.Length - 1);
                paidCashText.SelectionStart = paidCashText.Text.Length;

                doneBtn.Enabled = false;
                return;
            }
            
            if (finalPriceText.Text != "")
                remainPrice = Convert.ToDouble(finalPriceText.Text);

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
            //if ((recieveMoney - remainPrice) > remainPrice)
            //{
            //    MessageBox.Show("Số tiền trả quá lớn!", "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    doneBtn.Enabled = false;
            //}

            if (returnCashText.Text != "")
                returnCashText.Text = string.Format("{0:#,##0.00}", double.Parse(returnCashText.Text));

            if(recieveMoney > 1000000000000)
            {
                doneBtn.Enabled = false;
            }

            if(productDataGridView.RowCount <= 0)
            {
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

            // định dạng
            totalPriceText.Text = string.Format("{0:#,##0.00}", double.Parse(totalPriceText.Text));
            finalPriceText.Text = string.Format("{0:#,##0.00}", double.Parse(finalPriceText.Text));
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
                if (!addProductBtn.Enabled)
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

        private void inventoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (inventoryComboBox.SelectedValue == null)
                return;

            iNVENTORYCAPABILITYBindingSource.Filter = "Inventory_id = " + inventoryComboBox.SelectedValue;
        }

        private void numericUpDown_TextChanged(object sender, EventArgs e)
        {
            if (numericUpDown.Text == "")
            {
                addProductBtn.Enabled = false;
                return;
            }
            
            addProductBtn.Enabled = true;
        }

        private void productDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var product = (oRDERDETAILBindingSource[e.RowIndex] as DataRowView).Row as SellManagementDbDataSet.ORDER_DETAILRow;

            product.BeginEdit();

            var max = sellManagementDbDataSet.INVENTORY_CAPABILITY.Where(p => p.Product_id == product.Product_id && p.Inventory_id == (int)inventoryComboBox.SelectedValue);
            if(max.Count() <= 0)
            {
                // ko có trong ko
                MessageBox.Show("Sản phẩm không có thông tin trong kho", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                product.Quantity = 0;
            }
            else
            {
                var number = (max.First().MaxCount - max.First().CurrentCount);
                if (product.Quantity > number)
                {
                    MessageBox.Show("Số lượng sản phẩm quá sức chứa của ko", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    product.Quantity = number;
                }
            }
            
            product.Result = product.Quantity * product.Price;
            product.EndEdit();

            if (product.Quantity <= 0)
                oRDERDETAILBindingSource.RemoveAt(e.RowIndex);

            calculateTotalPrice();
        }

        private void calculateTotalPrice()
        {
            var currentOrderDetail = from order_detail in sellManagementDbDataSet.ORDER_DETAIL
                                     where order_detail.Order_id == OrderId
                                     select order_detail.Result;

            totalPriceText.Text = currentOrderDetail.Sum().ToString();
        }

        private void deleteMenuItem_Click(object sender, EventArgs e)
        {
            var r = MessageBox.Show(Resources.ConfirmMessage, Resources.DeleteLabel, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                oRDERDETAILBindingSource.RemoveCurrent();
                calculateTotalPrice();
                productDataGridViewRowsChanged();
            }

        }

        private void paidCashText_Leave(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            if (textBox == null)
                return;

            try
            {
                if (textBox.Text != "")
                    textBox.Text = string.Format("{0:#,##0.00}", double.Parse(textBox.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(Resources.InvalidValueMessage + "\n\nChi tiết: " + ex.Message, Resources.ErrorLabel, MessageBoxButtons.OK, MessageBoxIcon.Error);
                doneBtn.Enabled = false;
            }
        }

        private void finalPriceText_TextChanged(object sender, EventArgs e)
        {
            UpdateMoney();
        }

        private void chooseProductBtn_Click(object sender, EventArgs e)
        {
            var newTab = new TabPage("Danh sách sản phẩm");
            newTab.AutoScroll = true;
            var product = new ProductList();
            product.Dock = DockStyle.Fill;
            newTab.Controls.Add(product);

            var tabControl = (this.Parent.Parent as TabControl);

            tabControl.TabPages.Add(newTab);
            tabControl.SelectedIndex = tabControl.TabCount - 1;
        }

        private void productDataGridViewRowsChanged()
        {
            if (productDataGridView.Rows.Count > 0)
            {
                inventoryComboBox.Enabled = false;
            }
            else
            {
                inventoryComboBox.Enabled = true;
            }
        }
    }
}
