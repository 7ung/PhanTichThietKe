using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang.Forms
{
    public partial class CreateVendorBillForm : Form
    {
        public int OrderId { get; set; }
        public int DebtId { get; set; }
        public int VendorId { get; set; }

        public CreateVendorBillForm()
        {
            InitializeComponent();
        }

        public CreateVendorBillForm(int orderId)
        {
            InitializeComponent();

            OrderId = orderId;
        }

        private void CreateVendorBillForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sellManagementDbDataSet.VENDOR' table. You can move, or remove it, as needed.
            this.vENDORTableAdapter.Fill(this.sellManagementDbDataSet.VENDOR);

            // TODO: This line of code loads data into the 'sellManagementDbDataSet.DEBT' table. You can move, or remove it, as needed.
            this.dEBTTableAdapter.Fill(this.sellManagementDbDataSet.DEBT);
            // TODO: This line of code loads data into the 'sellManagementDbDataSet.ORDER' table. You can move, or remove it, as needed.
            this.oRDERTableAdapter.Fill(this.sellManagementDbDataSet.ORDER);
            // TODO: This line of code loads data into the 'sellManagementDbDataSet.STAFF' table. You can move, or remove it, as needed.
            this.sTAFFTableAdapter.Fill(this.sellManagementDbDataSet.STAFF);
            // TODO: This line of code loads data into the 'sellManagementDbDataSet.DOCUMENT' table. You can move, or remove it, as needed.
            this.dOCUMENTTableAdapter.Fill(this.sellManagementDbDataSet.DOCUMENT);
            // TODO: This line of code loads data into the 'sellManagementDbDataSet.VENDOR_ORDER' table. You can move, or remove it, as needed.
            this.vENDOR_ORDERTableAdapter.Fill(this.sellManagementDbDataSet.VENDOR_ORDER);

            SelectById(OrderId);
        }

        private void SelectById(int id)
        {
            vENDORORDERBindingSource.Filter = "Id = " + id;
            oRDERBindingSource.Filter = "Id = " + id;
            dOCUMENTBindingSource.Filter = "Id = " + id;

            var docOrder = sellManagementDbDataSet.DOCUMENT.Where(d => d.Id == this.OrderId).First();
            var docDebtId = sellManagementDbDataSet.DOCUMENT.Where(d => d.DocumentKey.Contains("VD_" + docOrder.DocumentKey)).First().Id;

            DebtId = docDebtId;
            dEBTBindingSource.Filter = "Id = " + docDebtId;

            VendorId = sellManagementDbDataSet.VENDOR_ORDER.Where(v => v.Id == this.OrderId).First().Vendor_id;
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            createBill();
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void createBill()
        {
            // tính bill
            double changeMoney = 0;
            double recieveMoney = 0;
            double remain = 0;

            try
            {
                if (changeMoneyText.Text != "")
                    changeMoney = Convert.ToDouble(changeMoneyText.Text);

                if (recieveMoneyText.Text != "")
                    recieveMoney = Convert.ToDouble(recieveMoneyText.Text);

                if (remainPriceText.Text != "")
                    remain = Convert.ToDouble(remainPriceText.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Số tiền không hợp lệ!", "Lỗi");
                return;
            }


            queriesTableAdapter.Insert_Vendor_Bill( generateBillDocumentKey(),
                                                    (int)staffComboBox.SelectedValue,
                                                    createDatePicker.Value,
                                                    DebtId,
                                                    "cash",
                                                    remain, // phải trả đủ cho vendor -_- 
                                                    (int)paidStaffComboBox.SelectedValue, 
                                                    VendorId);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc muốn hủy?", "Cảnh báo!", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
                this.Close();
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
                if (recieveMoneyText.Text != "")
                    recieveMoney = Convert.ToDouble(recieveMoneyText.Text);

                remainPrice = ((dEBTBindingSource.Current as DataRowView).Row as SellManagementDbDataSet.DEBTRow).Remain;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Số tiền không hợp lệ!", "Lỗi");
                okBtn.Enabled = false;
                return;
            }

            if (recieveMoney >= remainPrice)
            {
                //changeMoneyText.Text = (recieveMoney - remainPrice).ToString("0.00");
                changeMoneyText.Text = (recieveMoney - remainPrice).ToString();
                okBtn.Enabled = true;
            }
            else
            {
                changeMoneyText.Text = "0";
                okBtn.Enabled = false;
            }

            // tiền thối lớn hơn tiền trả
            if ((recieveMoney - remainPrice) > remainPrice)
            {
                MessageBox.Show("Số tiền trả quá lớn!", "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                okBtn.Enabled = false;
            }
        }

        private void recieveMoneyText_TextChanged(object sender, EventArgs e)
        {
            UpdateMoney();
        }
    }
}
