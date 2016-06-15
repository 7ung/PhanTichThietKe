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
    public partial class SelectReportForm : Form
    {
        public int DocumentId { get; set; }

        public SelectReportForm()
        {
            InitializeComponent();
        }

        private void SelectReportForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sellManagementDbDataSet.DOCUMENT' table. You can move, or remove it, as needed.
            this.dOCUMENTTableAdapter.Fill(this.sellManagementDbDataSet.DOCUMENT);
            // TODO: This line of code loads data into the 'sellManagementDbDataSet.BusinessFee' table. You can move, or remove it, as needed.
            this.businessFeeTableAdapter.Fill(this.sellManagementDbDataSet.BusinessFee);


            // format
            fromDateDataGridViewTextBoxColumn.DefaultCellStyle.Format = "dd'/'MM'/'yyyy";
            toDateDataGridViewTextBoxColumn.DefaultCellStyle.Format = "dd'/'MM'/'yyyy";
            totalFeeDataGridViewTextBoxColumn.DefaultCellStyle.Format = "N2";
        }

        private void selectBtn_Click(object sender, EventArgs e)
        {
            if (billDataGridView.RowCount <= 0 || businessFeeBindingSource.Current == null)
                return;

            var curRow = (businessFeeBindingSource.Current as DataRowView).Row as SellManagementDbDataSet.BusinessFeeRow;

            DocumentId = curRow.Id;

            this.Close();
            this.DialogResult = DialogResult.OK;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.Cancel;
        }

        private void searchText_TextChanged(object sender, EventArgs e)
        {
            businessFeeBindingSource.Filter = "Id LIKE '%" + searchText.Text + "%'";
        }

        private void billDataGridView_DoubleClick(object sender, EventArgs e)
        {
            selectBtn_Click(sender, e);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (billDataGridView.RowCount <= 0 || businessFeeBindingSource.Current == null)
                return;

            var curRow = (businessFeeBindingSource.Current as DataRowView).Row as SellManagementDbDataSet.BusinessFeeRow;

            DocumentId = curRow.Id;

            this.Close();
            this.DialogResult = DialogResult.Retry;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show("Bạn có chắt muốn xóa không?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (result == DialogResult.OK)
                {
                    deleteCurrentRow();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Chi tiết: " + ex.Message, "Xóa thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

            // fill lại
            businessFeeTableAdapter.Fill(sellManagementDbDataSet.BusinessFee);
            dOCUMENTTableAdapter.Fill(sellManagementDbDataSet.DOCUMENT);
        }

        private void deleteCurrentRow()
        {
            if (billDataGridView.RowCount <= 0 || businessFeeBindingSource.Current == null)
                return;

            var curRow = (businessFeeBindingSource.Current as DataRowView).Row as SellManagementDbDataSet.BusinessFeeRow;
            int curId = curRow.Id;

            //fill
            tranferFeeTableAdapter.Fill(sellManagementDbDataSet.TranferFee);
            invenFeeTableAdapter.Fill(sellManagementDbDataSet.InvenFee);
            staffFeeTableAdapter.Fill(sellManagementDbDataSet.StaffFee);

            // xóa fee transfer
            var transFee = sellManagementDbDataSet.TranferFee.Where(t => t.BusinessFee_Id == curRow.Id);
            foreach (var item in transFee)
            {
                item.Delete();
            }

            tranferFeeTableAdapter.Update(sellManagementDbDataSet.TranferFee);
            sellManagementDbDataSet.TranferFee.AcceptChanges();

            // xóa fee inve
            var invenFee = sellManagementDbDataSet.InvenFee.Where(t => t.BusinessFee_id == curRow.Id);
            foreach (var item in invenFee)
            {
                item.Delete();
            }

            invenFeeTableAdapter.Update(sellManagementDbDataSet.InvenFee);
            sellManagementDbDataSet.InvenFee.AcceptChanges();

            // xóa fee staff
            var staffFee = sellManagementDbDataSet.StaffFee.Where(t => t.BusinessFee_Id == curRow.Id);
            foreach (var item in staffFee)
            {
                item.Delete();
            }

            staffFeeTableAdapter.Update(sellManagementDbDataSet.StaffFee);
            sellManagementDbDataSet.StaffFee.AcceptChanges();


            // xóa doc
            var curDoc = sellManagementDbDataSet.DOCUMENT.Where(d => d.Id == curRow.Id);
            if(curDoc.Count() > 0)
            {
                curDoc.First().Delete();
            }
            
            businessFeeTableAdapter.Fill(sellManagementDbDataSet.BusinessFee);

            var cur = sellManagementDbDataSet.BusinessFee.Where(d => d.Id == curId);
            if (cur.Count() > 0)
            {
                cur.First().Delete();
            }

            businessFeeTableAdapter.Update(sellManagementDbDataSet.BusinessFee);
            sellManagementDbDataSet.BusinessFee.AcceptChanges();

            dOCUMENTTableAdapter.Update(sellManagementDbDataSet.DOCUMENT);
            sellManagementDbDataSet.DOCUMENT.AcceptChanges();
        }

        private void newReportBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.Yes;
        }
    }
}
