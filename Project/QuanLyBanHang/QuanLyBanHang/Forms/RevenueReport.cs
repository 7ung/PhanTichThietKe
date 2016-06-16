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

namespace QuanLyBanHang.Forms
{
    public partial class RevenueReport : UserControl
    {
        public RevenueReport()
        {
            InitializeComponent();
        }

        private void RevenueReport_Load(object sender, EventArgs e)
        {
            customer_Order_ViewTableAdapter.Fill(sellManagementDbDataSet.Customer_Order_View);
            cUSTOMERTableAdapter.Fill(sellManagementDbDataSet.CUSTOMER);
            sTAFFTableAdapter.Fill(sellManagementDbDataSet.STAFF);
            vendor_Order_ViewTableAdapter.Fill(sellManagementDbDataSet.Vendor_Order_View);
            vENDORTableAdapter.Fill(sellManagementDbDataSet.VENDOR);
            dOCUMENTTableAdapter.Fill(sellManagementDbDataSet.DOCUMENT);
            businessFeeTableAdapter.Fill(sellManagementDbDataSet.BusinessFee);

            //format
            // in
            finalPriceDataGridViewTextBoxColumn.DefaultCellStyle.Format = "N2";
            totalPriceDataGridViewTextBoxColumn.DefaultCellStyle.Format = "N2";
            vATDataGridViewTextBoxColumn.DefaultCellStyle.Format = "N2";
            createDateDataGridViewTextBoxColumn.DefaultCellStyle.Format = "dd'/'MM'/'yyyy";

            statusDataGridViewTextBoxColumn.DataSource = ResourceComboBoxBinding.OrderStatus;
            statusDataGridViewTextBoxColumn.DisplayMember = "Name";
            statusDataGridViewTextBoxColumn.ValueMember = "Value";

            // out
            finalPriceDataGridViewTextBoxColumn1.DefaultCellStyle.Format = "N2";
            totalPriceDataGridViewTextBoxColumn1.DefaultCellStyle.Format = "N2";
            vATDataGridViewTextBoxColumn1.DefaultCellStyle.Format = "N2";
            createDateDataGridViewTextBoxColumn1.DefaultCellStyle.Format = "dd'/'MM'/'yyyy";

            // feee
            fromDateDataGridViewTextBoxColumn.DefaultCellStyle.Format = "dd'/'MM'/'yyyy";
            toDateDataGridViewTextBoxColumn.DefaultCellStyle.Format = "dd'/'MM'/'yyyy";
            totalFeeDataGridViewTextBoxColumn.DefaultCellStyle.Format = "N2";

            statusDataGridViewTextBoxColumn1.DataSource = ResourceComboBoxBinding.OrderStatus;
            statusDataGridViewTextBoxColumn1.DisplayMember = "Name";
            statusDataGridViewTextBoxColumn1.ValueMember = "Value";

            //
            beginDateTimePicker.Value = sellManagementDbDataSet.Customer_Order_View.Select(o => o.CreateDate).Min();
            
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            customerOrderViewBindingSource.Filter = "(CreateDate >= #" + beginDateTimePicker.Value + "#) AND (CreateDate <= #" + endDateTimePicker.Value + "#)";

            businessFeeBindingSource.Filter = "(FromDate >= #" + beginDateTimePicker.Value + "#) OR (ToDate <= #" + endDateTimePicker.Value + "#)";

            vendorOrderViewBindingSource.Filter = "(CreateDate >= #" + beginDateTimePicker.Value + "#) AND (CreateDate <= #" + endDateTimePicker.Value + "#)";

            calculateRevenue();
        }

        private void calculateRevenue()
        {
            // in
            double sumIn = 0;
            if (incomeDataGridView.RowCount > 0)
            {
                foreach (DataGridViewRow item in incomeDataGridView.Rows)
                {
                    sumIn += (double)item.Cells[finalPriceDataGridViewTextBoxColumn.Index].Value;
                }

                incomeText.Text = string.Format("{0:#,##0.00}", sumIn);
                totalInLabel.Text = "Tổng số hóa đơn: " + incomeDataGridView.RowCount;
            }

            // out
            double sumOut = 0;
            if (dataGridView1.RowCount > 0)
            {
                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    sumOut += (double)item.Cells[finalPriceDataGridViewTextBoxColumn1.Index].Value;
                }

                totalOutLabel.Text = "Tổng số hóa đơn: " + dataGridView1.RowCount;
                totalOutText.Text = string.Format("{0:#,##0.00}", sumOut);
            }

            if (dataGridView2.RowCount > 0)
            {
                double temp = 0;
                foreach (DataGridViewRow item in dataGridView2.Rows)
                {
                    sumOut += (double)item.Cells[totalFeeDataGridViewTextBoxColumn.Index].Value;
                    temp += (double)item.Cells[totalFeeDataGridViewTextBoxColumn.Index].Value;
                }

                totalFeeLabel.Text = "Tổng số hóa đơn: " + dataGridView2.RowCount;
                totalFeeText.Text = string.Format("{0:#,##0.00}", temp);
            }

            outComeText.Text = string.Format("{0:#,##0.00}", sumOut);
            ratioText.Text = string.Format("{0:#,##0.00}", sumIn - sumOut);
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            var page = this.Parent as TabPage;
            if (page != null)
            {
                (page.Parent as TabControl).TabPages.Remove(page);
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
