using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanHang.Properties;

namespace QuanLyBanHang.Forms
{
    public partial class ViewBusinessFee : UserControl
    {
        public int DocumentId { get; set; }

        public ViewBusinessFee()
        {
            InitializeComponent();
        }

        public ViewBusinessFee(int docId)
        {
            InitializeComponent();

            DocumentId = docId;

        }

        private void ViewBusinessFee_Load(object sender, EventArgs e)
        {
            dOCUMENTTableAdapter.Fill(sellManagementDbDataSet.DOCUMENT);
            businessFeeTableAdapter.Fill(sellManagementDbDataSet.BusinessFee);
            tranferFeeTableAdapter.Fill(sellManagementDbDataSet.TranferFee);
            sTAFFTableAdapter.Fill(sellManagementDbDataSet.STAFF);
            iNVENTORYTableAdapter.Fill(sellManagementDbDataSet.INVENTORY);
            invenFeeTableAdapter.Fill(sellManagementDbDataSet.InvenFee);
            staffFeeTableAdapter.Fill(sellManagementDbDataSet.StaffFee);

            // filter
            dOCUMENTBindingSource.Filter = "Type = 'reportbusinessfee'";

            // format
            feeDataGridViewTextBoxColumn.DefaultCellStyle.Format = "N2";
            feeDataGridViewTextBoxColumn1.DefaultCellStyle.Format = "N2";
            feeDataGridViewTextBoxColumn2.DefaultCellStyle.Format = "N2";

            calculateFee();

            // select
            documentKeyComboBox.SelectedValue = DocumentId;
            documentKeyComboBox_SelectedIndexChanged(null, null);
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            var page = this.Parent as TabPage;
            if (page != null)
            {
                (page.Parent as TabControl).TabPages.Remove(page);
            }
        }

        private void dOCUMENTBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            calculateFee();
        }

        private void calculateFee()
        {
            // staff
            if (staffFeeGridView.RowCount <= 0)
            {
                totalStaffLabel.Text = "Tổng số nhân viên: 0";
                staffFeeText.Text = "0.00";
            }
            else
            {
                totalStaffLabel.Text = "Tổng số nhân viên: " + staffFeeGridView.RowCount;

                // tính fee
                double sum = 0;
                foreach (DataGridViewRow item in staffFeeGridView.Rows)
                {
                    sum += (double)item.Cells[feeDataGridViewTextBoxColumn2.Index].Value;
                }
                
                staffFeeText.Text = string.Format(Resources.CurrencyFormat, sum);
            }

            // inventory
            if (inventoryFeeDataGridView.RowCount <= 0)
            {
                totalInvenLabel.Text = "Tổng số kho hàng : 0";
                inventoryFeeText.Text = "0.00";
            }
            else
            {
                totalInvenLabel.Text = "Tổng số kho hàng : " + inventoryFeeDataGridView.RowCount;

                // tính fee
                double sum = 0;
                foreach (DataGridViewRow item in inventoryFeeDataGridView.Rows)
                {
                    sum += (double)item.Cells[feeDataGridViewTextBoxColumn1.Index].Value;
                }

                inventoryFeeText.Text = string.Format(Resources.CurrencyFormat, sum);
            }
            
            // in out
            if (dataGridView2.RowCount <= 0)
            {
                totalInOutLabel.Text = "Tổng số đơn hàng: 0";
                inoutFeeText.Text = "0.00";
            }
            else
            {
                totalInOutLabel.Text = "Tổng số đơn hàng: " + dataGridView2.RowCount;

                // tính fee
                double sum = 0;
                foreach (DataGridViewRow item in dataGridView2.Rows)
                {
                    sum += (double)item.Cells[feeDataGridViewTextBoxColumn.Index].Value;
                }

                inoutFeeText.Text = string.Format(Resources.CurrencyFormat, sum);
            }
        }

        private void dOCUMENTBindingSource_BindingComplete(object sender, BindingCompleteEventArgs e)
        {
            calculateFee();
        }

        private void transferFeeBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            calculateFee();
        }

        private void documentKeyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var page = this.Parent as TabPage;
            if (page != null)
            {
                page.Text = "Báo cáo chi phí bán hàng - " + documentKeyComboBox.Text;
            }
        }
    }
}
