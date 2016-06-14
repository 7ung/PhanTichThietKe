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
    public partial class CustomerReport : UserControl
    {
        public CustomerReport()
        {
            InitializeComponent();
        }

        private void CustomerReport_Load(object sender, EventArgs e)
        {
            customer_Debt_ViewTableAdapter.Fill(sellManagementDbDataSet.Customer_Debt_View);
            customer_Order_ViewTableAdapter.Fill(sellManagementDbDataSet.Customer_Order_View);
            cUSTOMERTableAdapter.Fill(sellManagementDbDataSet.CUSTOMER);
            sTAFFTableAdapter.Fill(sellManagementDbDataSet.STAFF);

            debtMoneyDataGridViewTextBoxColumn.DefaultCellStyle.Format = "N2";
            paidDataGridViewTextBoxColumn.DefaultCellStyle.Format = "N2";
            remainDataGridViewTextBoxColumn.DefaultCellStyle.Format = "N2";
            extraPaidDataGridViewTextBoxColumn.DefaultCellStyle.Format = "N2";
            createDateDataGridViewTextBoxColumn.DefaultCellStyle.Format = "dd'/'MM'/'yyyy";
            datePaidDataGridViewTextBoxColumn.DefaultCellStyle.Format = "dd'/'MM'/'yyyy";
            
            statusDataGridViewTextBoxColumn.DataSource = ResourceComboBoxBinding.BillStatus;
            statusDataGridViewTextBoxColumn.DisplayMember = "Name";
            statusDataGridViewTextBoxColumn.ValueMember = "Value";

            createDateDataGridViewTextBoxColumn1.DefaultCellStyle.Format = "dd'/'MM'/'yyyy";
            totalPriceDataGridViewTextBoxColumn.DefaultCellStyle.Format = "N2";
            vATDataGridViewTextBoxColumn.DefaultCellStyle.Format = "N2";
            finalPriceDataGridViewTextBoxColumn.DefaultCellStyle.Format = "N2";

            statusDataGridViewTextBoxColumn1.DataSource = ResourceComboBoxBinding.OrderStatus;
            statusDataGridViewTextBoxColumn1.DisplayMember = "Name";
            statusDataGridViewTextBoxColumn1.ValueMember = "Value";

            customerDebtViewBindingSource.Filter = "Customer_id = " + customerComboBox.SelectedValue;
            customerOrderViewBindingSource.Filter = "Customer_id = " + customerComboBox.SelectedValue;

            calculateDebt();
        }

        private void customerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            customerDebtViewBindingSource.Filter = "Customer_id = " + customerComboBox.SelectedValue;
            customerOrderViewBindingSource.Filter = "Customer_id = " + customerComboBox.SelectedValue;

            calculateDebt();
        }

        private void calculateDebt()
        {
            totalOrderText.Text = dataGridView2.RowCount.ToString();
            totalOrderMoneyText.Text = "0";
            paidMoneyText.Text = "0";
            remainText.Text = "0";
            latestOrderDate.Text = "Không có.";

            if (dataGridView1.RowCount > 0)
            {
                numberofDebtText.Visible = true;
                numberofDebtText.Text = "Số danh sách nợ : " + dataGridView1.RowCount;

                double sum = 0;
                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    if(item.Cells[paidDataGridViewTextBoxColumn.Index].Value == null)
                    {
                        continue;
                    }
                    else
                    {
                        sum += (double)item.Cells[paidDataGridViewTextBoxColumn.Index].Value;
                    }
                    
                }

                paidMoneyText.Text = sum.ToString("N2");
                
                sum = 0;
                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    if (item.Cells[remainDataGridViewTextBoxColumn.Index].Value == null)
                    {
                        continue;
                    }
                    else
                    {
                        sum += (double)item.Cells[remainDataGridViewTextBoxColumn.Index].Value;
                    }
                }

                remainText.Text = sum.ToString("N2");
            }
            else
            {
                numberofDebtText.Visible = false;
            }


            if (dataGridView2.RowCount > 0)
            {
                double sum = 0;
                foreach (DataGridViewRow item in dataGridView2.Rows)
                {
                    if (item.Cells[finalPriceDataGridViewTextBoxColumn.Index].Value == null)
                    {
                        continue;
                    }
                    else
                    {
                        sum += (double)item.Cells[finalPriceDataGridViewTextBoxColumn.Index].Value;
                    }
                }

                totalOrderMoneyText.Text = sum.ToString("N2");

                if (customerComboBox.SelectedValue != null)
                {
                    var latest = sellManagementDbDataSet.Customer_Order_View.Where(o => o.Customer_id == (int)customerComboBox.SelectedValue).Select(o => o.CreateDate).Max();
                    latestOrderDate.Text = latest.ToString("dd'/'MM'/'yyyy");
                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var page = this.Parent as TabPage;
            if (page != null)
            {
                (page.Parent as TabControl).TabPages.Remove(page);
            }
        }
    }
}
