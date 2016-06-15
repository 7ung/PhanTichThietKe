using QuanLyBanHang.Models;
using QuanLyBanHang.Properties;
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
    public partial class SettingForm : Form
    {
        public SettingForm()
        {
            InitializeComponent();
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {
            constantTableAdapter.Fill(sellManagementDbDataSet.CONSTANT);


            bindingData();
        }

        private void bindingData()
        {
            expiredText.DataBindings.Add("Text", sellManagementDbDataSet.CONSTANT.Where(c => c.Name == "expired_paid").First(), "Value");

            vatText.DataBindings.Add("Text", sellManagementDbDataSet.CONSTANT.Where(c => c.Name == "VAT_rate").First(), "Value");

            var bind = new Binding("Text", sellManagementDbDataSet.CONSTANT.Where(c => c.Name == "price_multi_paid").First(), "Value");
            bind.FormatString = "#,##0.00";
            bind.FormattingEnabled = true;
            multipaidText.DataBindings.Add(bind);
            
            interestText.DataBindings.Add("Text", sellManagementDbDataSet.CONSTANT.Where(c => c.Name == "interest_rate").First(), "Value");

            orderStatus.DataSource = ResourceComboBoxBinding.OrderStatus;
            orderStatus.DisplayMember = "Name";
            orderStatus.ValueMember = "Value";

            debtStatus.DataSource = ResourceComboBoxBinding.BillStatus;
            debtStatus.DisplayMember = "Name";
            debtStatus.ValueMember = "Value";

            paidType.DataSource = ResourceComboBoxBinding.BillType;
            paidType.DisplayMember = "Name";
            paidType.ValueMember = "Value";
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                constantBindingSource.EndEdit();
                constantTableAdapter.Update(sellManagementDbDataSet.CONSTANT);
                sellManagementDbDataSet.CONSTANT.AcceptChanges();

                this.Close();
            }
            catch  (Exception ex)
            {
                MessageBox.Show("Lưu thiết lập thất bại. Xin kiểm tra lại. \n\nChi tiết: " + ex.Message, "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
