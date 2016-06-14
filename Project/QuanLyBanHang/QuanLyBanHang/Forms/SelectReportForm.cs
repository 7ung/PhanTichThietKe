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
    }
}
