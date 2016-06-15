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
    public partial class OrderDetailForm : UserControl
    {
        private int _currentProductId = 0;
        private int _currentOrderId = 0;

        // để chứa row order document hiện tại
        private SellManagementDbDataSet.DOCUMENTRow orderDocumentRow;

        // table document để fill lại cái khác
        private SellManagementDbDataSet.DOCUMENTDataTable docTable = new SellManagementDbDataSet.DOCUMENTDataTable();
        private string _billPrefix = Resources.CustomerBillDocumentPrefixKey;

        public OrderDetailForm()
        {
            InitializeComponent();
        }

        public OrderDetailForm(int orderId)
        {
            InitializeComponent();

            _currentOrderId = orderId;
        }
        
        private void OrderDetailForm_Load(object sender, EventArgs e)
        {
            pRODUCTTableAdapter.Fill(sellManagementDbDataSet.PRODUCT);
            sTAFFTableAdapter.Fill(sellManagementDbDataSet.STAFF);
            dOCUMENTTableAdapter.Fill(sellManagementDbDataSet.DOCUMENT);
            cUSTOMERTableAdapter.Fill(sellManagementDbDataSet.CUSTOMER);
            pURCHASE_ORDERTableAdapter.Fill(sellManagementDbDataSet.PURCHASE_ORDER);
            debtTableAdapter.Fill(sellManagementDbDataSet.DEBT);
            billTableAdapter.Fill(sellManagementDbDataSet.BILL);
            oRDER_DETAILTableAdapter.Fill(sellManagementDbDataSet.ORDER_DETAIL);
            gROUPofCUSTOMERTableAdapter.Fill(sellManagementDbDataSet.GROUPofCUSTOMER);
            cONSTANTTableAdapter.Fill(sellManagementDbDataSet.CONSTANT);
            orderTableAdapter.Fill(sellManagementDbDataSet.ORDER);
            iNVENTORYTableAdapter.Fill(sellManagementDbDataSet.INVENTORY);
            iNVENTORY_CAPABILITYTableAdapter.Fill(sellManagementDbDataSet.INVENTORY_CAPABILITY);

            // các document, purchase order, order detail hiện tại của giao dịch
            dOCUMENTBindingSource.Filter = "Id = " + _currentOrderId;
            pURCHASEORDERBindingSource.Filter = "Id = " + _currentOrderId;
            oRDERDETAILBindingSource.Filter = "Order_id = " + _currentOrderId;

            var order = sellManagementDbDataSet.ORDER.Where(o => o.Id == _currentOrderId).First();
            oRDERBindingSource.DataSource = order;

            // lấy thông tin nguyên cái row của order document hiện tại
            orderDocumentRow = ((dOCUMENTBindingSource.Current as DataRowView).Row as SellManagementDbDataSet.DOCUMENTRow);
            
            // fill lại lên nguyên cái bảng khác tìm cái debt, 
            // vì cái sellManagementDbDataSet.DOCUMENT đang xài cho cái current rồi
            dOCUMENTTableAdapter.Fill(docTable);

            // vat
            vatText.Text = sellManagementDbDataSet.CONSTANT.Where(c => c.Name == "VAT_rate").First().Value;

            bindOrderStatus();

            _currentProductId = ((pRODUCTBindingSource.Current as DataRowView).Row as SellManagementDbDataSet.PRODUCTRow).Id;
            
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
        
        private void saveBtn_Click(object sender, EventArgs e)
        {
            createBill();
            closeTab();
        }

        private void createBill()
        {
            string orderDocKey = orderDocumentRow.DocumentKey;
            // deb key có kiểu CD_COXXXX
            int docDebtId = docTable.Where(d => d.DocumentKey.Contains("CD_" + orderDocKey)).First().Id;
            
            var debt = sellManagementDbDataSet.DEBT.Where(d => d.Id == docDebtId);
            if (debt.Count() == 0)
                return;

            // cập nhật document
            dOCUMENTBindingSource.EndEdit();
            dOCUMENTTableAdapter.Update(sellManagementDbDataSet.DOCUMENT);
            sellManagementDbDataSet.DOCUMENT.AcceptChanges();

            // purchase order
            pURCHASEORDERBindingSource.EndEdit();
            pURCHASE_ORDERTableAdapter.Update(sellManagementDbDataSet.PURCHASE_ORDER);
            sellManagementDbDataSet.PURCHASE_ORDER.AcceptChanges();

            // order
            oRDERBindingSource.EndEdit();
            orderTableAdapter.Update(sellManagementDbDataSet.ORDER);
            sellManagementDbDataSet.ORDER.AcceptChanges();

            // order detail
            oRDERDETAILBindingSource.EndEdit();
            oRDER_DETAILTableAdapter.Update(sellManagementDbDataSet.ORDER_DETAIL);
            sellManagementDbDataSet.ORDER_DETAIL.AcceptChanges();

            debtTableAdapter.Fill(sellManagementDbDataSet.DEBT);

            // tính bill
            double changeMoney = 0;
            double recieveMoney = 0;

            if (returnCashText.Text != "")
                changeMoney = Convert.ToDouble(returnCashText.Text);

            if (recieveCashText.Text != "")
                recieveMoney = Convert.ToDouble(recieveCashText.Text);

            // document key chung cho mấy loại như customer order, customer bill,...
            // có dạng số XXXXXX, nên cắt mấy chữ đầu ra
            // var docKey = documentKey.Text.Trim(new char[] { 'C', 'O' });

            //queriesTableAdapter.Insert_Customer_Bill("CB" + docKey, (int)staffComboBox.SelectedValue, createDatePicker.Value, docDebtId, "cash",
            //                                        (int)customerComboBox.SelectedValue, changeMoney, recieveMoney);

            queriesTableAdapter.Insert_Customer_Bill(generateBillDocumentKey(), 
                                                    (int)staffComboBox.SelectedValue, 
                                                    createDatePicker.Value, 
                                                    docDebtId, 
                                                    "cash",
                                                    (int)customerComboBox.SelectedValue, 
                                                    changeMoney, 
                                                    recieveMoney);
        }

        private string generateBillDocumentKey()
        {
            int max = 0;

            foreach (DataRow item in sellManagementDbDataSet.DOCUMENT.Where(c => c.DocumentKey.Substring(0, 2) == _billPrefix))
            {
                var value = item["DocumentKey"].ToString().TrimStart(_billPrefix.ToArray());
                max = Math.Max(max, Convert.ToInt32(value));
            }

            return _billPrefix + String.Format("{0:D6}", max + 1);
        }

        private void productIdText_TextChanged(object sender, EventArgs e)
        {
            var products = sellManagementDbDataSet.PRODUCT.Where(x => x.ProductKey.ToLower().Contains(productIdComboBox.Text.ToLower()));

            if (products.Count() == 0)
            {
                productNameComboBox.Text = "Không tìm thấy!";
                productPriceText.Text = "";
                _currentProductId = 0;
                addProductBtn.Enabled = false;
                return;
            }

            if(productQuantityUpDown.Text != "")
                addProductBtn.Enabled = true;

            _currentProductId = products.First().Id;
            //productNameText.Text = products.First().Name;
            //productPriceText.Text = products.First().OutPrice.ToString();
        }

        private void addProductBtn_Click(object sender, EventArgs e)
        {
            if (_currentProductId == 0 || productQuantityUpDown.Text == "")
                return;

            if((int)productQuantityUpDown.Value > Convert.ToInt32(currentComboBox.Text))
            {
                MessageBox.Show("Số lượng nhiều hơn trong kho", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            var index = oRDERDETAILBindingSource.Find("Product_id", _currentProductId);

            if (index == -1)
            {
                var newPro = (oRDERDETAILBindingSource.AddNew() as DataRowView).Row as SellManagementDbDataSet.ORDER_DETAILRow;

                newPro.BeginEdit();
                newPro.Order_id = _currentOrderId;
                newPro.Product_id = _currentProductId;
                newPro.Quantity = Convert.ToInt32(productQuantityUpDown.Text);
                newPro.Price = Convert.ToDouble(productPriceText.Text);
                newPro.Result = newPro.Quantity * newPro.Price;
                newPro.EndEdit();

                oRDERDETAILBindingSource.Position = -1;
            }
            else
            {
                var product = (oRDERDETAILBindingSource[index] as DataRowView).Row as SellManagementDbDataSet.ORDER_DETAILRow;

                product.BeginEdit();
                product.Quantity += (int)productQuantityUpDown.Value;

                // hiện sản phẩm hiện tại, lấy current
                var current = checkCurrentCount(product.Quantity, product.Product_id, (int)inventoryComboBox.SelectedValue);
                if (current != -1)
                {
                    pRODUCTBindingSource.Position = pRODUCTBindingSource.Find("Id", product.Product_id);
                    product.Quantity = current;
                }

                product.Result = product.Quantity * product.Price;
                product.EndEdit();

                oRDERDETAILBindingSource.Position = -1;
            }

            calculateTotalPrice();
            productDataGridViewRowsChanged();
        }

        private void productDataGridViewRowsChanged()
        {
            if(productDataGridView.Rows.Count > 0)
            {
                inventoryComboBox.Enabled = false;
            }
            else
            {
                inventoryComboBox.Enabled = true;
            }
        }

        private void totalPriceText_TextChanged(object sender, EventArgs e)
        {
            updatePrice();
        }

        private void updatePrice()
        {
            double discount = 0;
            double extra = 0;
            double total = 0;
            double vat = 0;
            double recieve = 0;

            if (totalPriceText.Text != "")
                total = Convert.ToDouble(totalPriceText.Text);

            if (discountComboBox.Text != "")
                discount = Convert.ToDouble(discountComboBox.Text);

            if (extraText.Text != "")
                extra = Convert.ToDouble(extraText.Text);

            if (vatText.Text != "")
                vat = Convert.ToDouble(vatText.Text);

            double finalPrice = total * (1 - discount + vat) + extra;
            finalPriceText.Text = finalPrice.ToString();
            
            // định dạng
            totalPriceText.Text = string.Format("{0:#,##0.00}", double.Parse(totalPriceText.Text));
            finalPriceText.Text = string.Format("{0:#,##0.00}", double.Parse(finalPriceText.Text));

            try
            {
                if (recieveCashText.Text != "")
                    recieve = Convert.ToDouble(recieveCashText.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Resources.InvalidValueMessage + "\n\nChi tiết: " + ex.Message, Resources.ErrorLabel, MessageBoxButtons.OK, MessageBoxIcon.Error);

                returnCashText.Text = "0";
                saveBtn.Enabled = false;
                return;
            }

            if (recieve > finalPrice)
            {
                returnCashText.Text = (recieve - finalPrice).ToString();
                saveBtn.Enabled = true;
            }
            else
            {
                returnCashText.Text = "0";
                saveBtn.Enabled = false;
            }

            // tiền thối lớn hơn tiền trả
            if ((recieve - finalPrice) > finalPrice)
            {
                MessageBox.Show("Số tiền trả quá lớn!", "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                saveBtn.Enabled = false;
            }

            if (returnCashText.Text != "")
                returnCashText.Text = string.Format("{0:#,##0.00}", double.Parse(returnCashText.Text));
        }

        private void recieveCashText_TextChanged(object sender, EventArgs e)
        {
            updatePrice();
            

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            queriesTableAdapter.Delete_Customer_Order(_currentOrderId);

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

        private void inventoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (inventoryComboBox.SelectedValue == null)
                return;

            iNVENTORYCAPABILITYBindingSource.Filter = "Inventory_id = " + inventoryComboBox.SelectedValue; 
        }

        private void productQuantityUpDown_TextChanged(object sender, EventArgs e)
        {
            if(productQuantityUpDown.Text == "")
            {
                addProductBtn.Enabled = false;
                return;
            }

            try
            {
                var count = Convert.ToInt32(productQuantityUpDown.Text);
                if (count > Convert.ToInt32(currentComboBox.Text))
                {
                    throw new Exception("Số lượng nhiều hơn trong kho.");
                }
                    
                addProductBtn.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(Resources.InvalidValueMessage + "\n\nChi tiết: " + ex.Message, Resources.ErrorLabel, MessageBoxButtons.OK, MessageBoxIcon.Error);
                addProductBtn.Enabled = false;
                productQuantityUpDown.Text = "1";
            }
        }

        private void recieveCashText_Leave(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            if (textBox == null)
                return;

            try
            {
                if (textBox.Text != "")
                    textBox.Text = string.Format("{0:#,##0.00}", double.Parse(textBox.Text));
            }
            catch  (Exception ex)
            {
                MessageBox.Show(Resources.InvalidValueMessage + "\n\nChi tiết: " + ex.Message, Resources.ErrorLabel, MessageBoxButtons.OK, MessageBoxIcon.Error);
                saveBtn.Enabled = false;
            }
        }

        private void productDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var product = (oRDERDETAILBindingSource[e.RowIndex] as DataRowView).Row as SellManagementDbDataSet.ORDER_DETAILRow;

            product.BeginEdit();

            // hiện sản phẩm hiện tại, lấy current
            var current = checkCurrentCount(product.Quantity, product.Product_id, (int)inventoryComboBox.SelectedValue);
            if (current != -1)
            {
                pRODUCTBindingSource.Position = pRODUCTBindingSource.Find("Id", product.Product_id);
                product.Quantity = current;
            }

            product.Result = product.Quantity * product.Price;
            product.EndEdit();
            
            if (product.Quantity <= 0)
                oRDERDETAILBindingSource.RemoveAt(e.RowIndex);

            calculateTotalPrice();
        }

        private int checkCurrentCount(int valueChecked, int productId, int inventoryId)
        {
            var currentRow = sellManagementDbDataSet.INVENTORY_CAPABILITY.FindByInventory_idProduct_id(inventoryId, productId);
            if(currentRow == null)
            {
                MessageBox.Show("Sản phẩm không có trong kho.", Resources.WarningLabel, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }

            if (valueChecked > currentRow.CurrentCount)
            {
                MessageBox.Show("Số lượng nhiều hơn hiện tồn trong kho.", Resources.WarningLabel, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return currentRow.CurrentCount;
            }

            return -1;
        }

        private void deleteMenuItem_Click(object sender, EventArgs e)
        {
            var r = MessageBox.Show(Resources.ConfirmMessage, Resources.DeleteLabel, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(r == DialogResult.Yes)
            {
                oRDERDETAILBindingSource.RemoveCurrent();
                calculateTotalPrice();
                productDataGridViewRowsChanged();
            }

        }

        private void calculateTotalPrice()
        {
            var currentOrderDetail = from order_detail in sellManagementDbDataSet.ORDER_DETAIL
                                     where order_detail.Order_id == _currentOrderId
                                     select order_detail.Result;

            totalPriceText.Text = currentOrderDetail.Sum().ToString();
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

        private void pRODUCTBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                var count = Convert.ToInt32(productQuantityUpDown.Text);
                if (count > Convert.ToInt32(currentComboBox.Text))
                {
                    throw new Exception();
                }
            }
            catch (Exception ex)
            {
                productQuantityUpDown.Text = "1";
            }
        }
    }
}
