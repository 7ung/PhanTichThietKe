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
    public partial class CreateReportForm : Form
    {
        public int DocumentId { get; set; }

        private string _prefix = Resources.ReportPrefixKey;

        public CreateReportForm()
        {
            InitializeComponent();
        }

        private void CreateReportForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sellManagementDbDataSet.BusinessFee' table. You can move, or remove it, as needed.
            this.businessFeeTableAdapter.Fill(this.sellManagementDbDataSet.BusinessFee);
            // TODO: This line of code loads data into the 'sellManagementDbDataSet.STAFF' table. You can move, or remove it, as needed.
            this.sTAFFTableAdapter.Fill(this.sellManagementDbDataSet.STAFF);

            this.documentTableAdapter.Fill(sellManagementDbDataSet.DOCUMENT);

            dOCUMENTBindingSource.AddNew();
            businessFeeBindingSource.AddNew();
            
            documentKeyText.Text = generateKey();
            staffComboBox.SelectedIndex = 0;
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            // gán type cho document
            var curRow = (dOCUMENTBindingSource.Current as DataRowView).Row as SellManagementDbDataSet.DOCUMENTRow;
            curRow.BeginEdit();
            curRow.DocumentKey = documentKeyText.Text;
            curRow.Type = "reportbusinessfee";
            curRow.CreateDate = createDatePicker.Value;
            curRow.Creator = (int)staffComboBox.SelectedValue;
            curRow.EndEdit();
            
            dOCUMENTBindingSource.EndEdit();
            documentTableAdapter.Update(sellManagementDbDataSet.DOCUMENT);
            sellManagementDbDataSet.DOCUMENT.AcceptChanges();

            // phí mặt định = 0
            var curFee = (businessFeeBindingSource.Current as DataRowView).Row as SellManagementDbDataSet.BusinessFeeRow;
            curFee.BeginEdit();
            curFee.TotalFee = 0;
            curFee.ToDate = todateTimePicker.Value;
            curFee.FromDate = fromdateTimePicker.Value;
            curFee.Term = (int)numericUpDown.Value;
            //cập nhật id theo document
            curFee.Id = curRow.Id;
            curFee.EndEdit();

            businessFeeBindingSource.EndEdit();
            businessFeeTableAdapter.Update(sellManagementDbDataSet.BusinessFee);
            sellManagementDbDataSet.BusinessFee.AcceptChanges();

            this.DocumentId = curRow.Id;
            this.Close();
            this.DialogResult = DialogResult.OK;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.Cancel;
        }

        private string generateKey()
        {
            int max = 0;

            foreach (DataRow item in sellManagementDbDataSet.DOCUMENT.Where(c => c.DocumentKey.Substring(0, 2) == _prefix))
            {
                var value = item["DocumentKey"].ToString().TrimStart(_prefix.ToArray());
                max = Math.Max(max, Convert.ToInt32(value));
            }

            return _prefix + String.Format("{0:D6}", max + 1);
        }
    }
}
