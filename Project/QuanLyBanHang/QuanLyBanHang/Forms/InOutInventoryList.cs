﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang.Forms
{
    public partial class InOutInventoryList : UserControl
    {
        public InOutInventoryList()
        {
            InitializeComponent();
        }

        private void InOutInventoryList_Load(object sender, EventArgs e)
        {
            inOutInventory_Detail_ProductQuantity_ViewTableAdapter.Fill(sellManagementDbDataSet.InOutInventory_Detail_ProductQuantity_View);
            inOut_Inventory_ViewTableAdapter.Fill(sellManagementDbDataSet.InOut_Inventory_View);
            pRODUCTTableAdapter.Fill(sellManagementDbDataSet.PRODUCT);
            sTAFFTableAdapter.Fill(sellManagementDbDataSet.STAFF);
            iNVENTORYTableAdapter.Fill(sellManagementDbDataSet.INVENTORY);

            if (inOutTypeCheckBox.Checked == false)
            {
                inOutTypeCheckBox.BackColor = Color.FromArgb(255, 153, 51);
                inOutTypeCheckBox.Text = "Xuất hàng";
                inOutTypeCheckBox.TextAlign = ContentAlignment.MiddleRight;
            }
            else
            {
                inOutTypeCheckBox.BackColor = Color.FromArgb(153, 204, 255);
                inOutTypeCheckBox.Text = "Nhập hàng";
                inOutTypeCheckBox.TextAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;
        }

        private void inOutInventoryViewBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            var curRow = (inOutInventoryViewBindingSource.Current as DataRowView).Row as SellManagementDbDataSet.InOut_Inventory_ViewRow;

            inOutInventoryDetailProductQuantityViewBindingSource.Filter = "InOutInventory_id = " + curRow.Id;
        }

        private void inOutTypeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            var checkbox = sender as CheckBox;
            if (checkbox.Checked == false)
            {
                checkbox.BackColor = Color.FromArgb(255, 153, 51);
                checkbox.Text = "Xuất hàng";
                checkbox.TextAlign = ContentAlignment.MiddleRight;
            }
            else
            {
                checkbox.BackColor = Color.FromArgb(153, 204, 255);
                checkbox.Text = "Nhập hàng";
                checkbox.TextAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            var page = this.Parent as TabPage;
            if (page != null)
            {
                (page.Parent as TabControl).TabPages.Remove(page);
            }
        }
    }
}
