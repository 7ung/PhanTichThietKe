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
    public partial class OrderDetailForm : UserControl
    {
        private int _currentProductId = 0;
        private int _currentOrderId = 48;

        // để chứa row order document hiện tại
        private SellManagementDbDataSet.DOCUMENTRow orderDocumentRow;

        // table document để fill lại cái khác
        private SellManagementDbDataSet.DOCUMENTDataTable docTable = new SellManagementDbDataSet.DOCUMENTDataTable();

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

            // các document, purchase order, order detail hiện tại của giao dịch
            dOCUMENTBindingSource.Filter = "Id = " + _currentOrderId;
            pURCHASEORDERBindingSource.Filter = "Id = " + _currentOrderId;
            oRDERDETAILBindingSource.Filter = "Order_id = " + _currentOrderId;

            // lấy thông tin nguyên cái row của order document hiện tại
            orderDocumentRow = ((dOCUMENTBindingSource.Current as DataRowView).Row as SellManagementDbDataSet.DOCUMENTRow);

            // fill lại lên nguyên cái bảng khác tìm cái debt, 
            // vì cái sellManagementDbDataSet.DOCUMENT đang xài cho cái current rồi
            dOCUMENTTableAdapter.Fill(docTable);
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

            // order detail
            oRDERDETAILBindingSource.EndEdit();
            oRDER_DETAILTableAdapter.Update(sellManagementDbDataSet.ORDER_DETAIL);
            sellManagementDbDataSet.ORDER_DETAIL.AcceptChanges();
            
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

            foreach (DataRow item in sellManagementDbDataSet.DOCUMENT.Where(c => c.DocumentKey.Substring(0, 2) == "CB"))
            {
                var value = item["DocumentKey"].ToString().TrimStart(new char[] { 'C', 'B' });
                max = Math.Max(max, Convert.ToInt32(value));
            }

            return "CB" + String.Format("{0:D6}", max + 1);
        }

        private void productIdText_TextChanged(object sender, EventArgs e)
        {
            var products = sellManagementDbDataSet.PRODUCT.Where(x => x.ProductKey.ToLower().Contains(productIdText.Text.ToLower()));

            if (products.Count() == 0)
            {
                productNameText.Text = "";
                productPriceText.Text = "";
                _currentProductId = 0;
                return;
            }

            _currentProductId = products.First().Id;
            productNameText.Text = products.First().Name;
            productPriceText.Text = products.First().OutPrice.ToString();
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
                newPro.Order_id = _currentOrderId;
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
                                      where order_detail.Order_id == _currentOrderId
                                      select order_detail.Result;

            totalPriceText.Text = currentOrderDetail.Sum().ToString();
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

            if (totalPriceText.Text != "")
                total = Convert.ToDouble(totalPriceText.Text);

            if (discountText.Text != "")
                discount = Convert.ToDouble(discountText.Text) / 100;

            if (extraText.Text != "")
                extra = Convert.ToDouble(extraText.Text);

            double finalPrice = total * (1 - discount) + extra;
            finalPriceText.Text = finalPrice.ToString();

            double recieve = 0;
            if(recieveCashText.Text != "")
                recieve = Convert.ToDouble(recieveCashText.Text);

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
            
        }

        private void recieveCashText_TextChanged(object sender, EventArgs e)
        {
            updatePrice();

            //try
            //{
            //    double recieve = Convert.ToDouble(recieveCashText.Text);
            //    double finalPrice = Convert.ToDouble(finalPriceText.Text);

            //    if(recieve > finalPrice)
            //        returnCashText.Text = (recieve - finalPrice).ToString();
            //    else
            //    {
            //        returnCashText.Text = "0";
            //    }
            //}
            //catch  (Exception ex)
            //{
            //    //hihi
            //}
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
    }
}
