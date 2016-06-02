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
    public partial class CreateBillForm : Form
    {
        public int OrderId { get; set; }
        public int DebtId { get; set; }

        public CreateBillForm()
        {
            InitializeComponent();
        }

        public CreateBillForm(int orderId)
        {
            InitializeComponent();

            OrderId = orderId;
        }

        private void CreateBillForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sellManagementDbDataSet.DEBT' table. You can move, or remove it, as needed.
            this.dEBTTableAdapter.Fill(this.sellManagementDbDataSet.DEBT);
            // TODO: This line of code loads data into the 'sellManagementDbDataSet.PURCHASE_ORDER' table. You can move, or remove it, as needed.
            this.pURCHASE_ORDERTableAdapter.Fill(this.sellManagementDbDataSet.PURCHASE_ORDER);
            // TODO: This line of code loads data into the 'sellManagementDbDataSet.STAFF' table. You can move, or remove it, as needed.
            this.sTAFFTableAdapter.Fill(this.sellManagementDbDataSet.STAFF);
            // TODO: This line of code loads data into the 'sellManagementDbDataSet.CUSTOMER' table. You can move, or remove it, as needed.
            this.cUSTOMERTableAdapter.Fill(this.sellManagementDbDataSet.CUSTOMER);
            // TODO: This line of code loads data into the 'sellManagementDbDataSet.ORDER' table. You can move, or remove it, as needed.
            this.oRDERTableAdapter.Fill(this.sellManagementDbDataSet.ORDER);

            documentTableAdapter.Fill(sellManagementDbDataSet.DOCUMENT);

            SelectById(this.OrderId);
        }

        private void SelectById(int id)
        {
            pURCHASEORDERBindingSource.Filter = "Id = " + id;
            oRDERBindingSource.Filter = "Id = " + id;
            dOCUMENTBindingSource.Filter = "Id = " + id;

            var docOrder = sellManagementDbDataSet.DOCUMENT.Where(d => d.Id == this.OrderId).First();
            var docDebtId = sellManagementDbDataSet.DOCUMENT.Where(d => d.DocumentKey.Contains("CD_" + docOrder.DocumentKey)).First().Id;

            DebtId = docDebtId;
            dEBTBindingSource.Filter = "Id = " + docDebtId;
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

            try
            {
                if (changeMoneyText.Text != "")
                    changeMoney = Convert.ToDouble(changeMoneyText.Text);

                if (recieveMoneyText.Text != "")
                    recieveMoney = Convert.ToDouble(recieveMoneyText.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Số tiền không hợp lệ!", "Lỗi");
                return;
            }

            
            queriesTableAdapter.Insert_Customer_Bill(generateBillDocumentKey(),
                                                    (int)staffComboBox.SelectedValue,
                                                    createDatePicker.Value,
                                                    DebtId,
                                                    "cash",
                                                    (int)customerComboBox.SelectedValue,
                                                    changeMoney,
                                                    recieveMoney);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc muốn hủy?", "Cảnh báo!", MessageBoxButtons.OKCancel);

            if(result == DialogResult.OK)
                this.Close();
        }

        private void recieveMoneyText_TextChanged(object sender, EventArgs e)
        {
            UpdateMoney();
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
            
            if (recieveMoney > remainPrice)
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
    }
}
