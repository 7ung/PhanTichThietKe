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

            statusDataGridViewTextBoxColumn1.DataSource = ResourceComboBoxBinding.OrderStatus;
            statusDataGridViewTextBoxColumn1.DisplayMember = "Name";
            statusDataGridViewTextBoxColumn1.ValueMember = "Value";

            //
            beginDateTimePicker.Value = sellManagementDbDataSet.Customer_Order_View.Select(o => o.CreateDate).Min();
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            customerOrderViewBindingSource.Filter = "(CreateDate >= #" + beginDateTimePicker.Value + "#) AND (CreateDate <= #" + endDateTimePicker.Value + "#)";

            calculateRevenue();
        }

        private void calculateRevenue()
        {
            if(incomeDataGridView.RowCount > 0)
            {
                double sum = 0;
                foreach (DataGridViewRow item in incomeDataGridView.Rows)
                {
                    sum += (double)item.Cells[finalPriceDataGridViewTextBoxColumn.Index].Value;
                }

                incomeText.Text = string.Format("{0:#,##0.00}", sum);
            }
        }
    }
}
