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
    public partial class InventoryList : UserControl
    {
        public InventoryList()
        {
            InitializeComponent();

            this.iNVENTORYTableAdapter.Fill(sellManagementDbDataSet.INVENTORY);
            this.iNVENTORY_CAPABILITYTableAdapter.Fill(sellManagementDbDataSet.INVENTORY_CAPABILITY);
            this.pRODUCTTableAdapter.Fill(sellManagementDbDataSet.PRODUCT);

            inoutinventoryTableAdapter.Fill(sellManagementDbDataSet.INOUTINVENTORY);
            invenFeeTableAdapter.Fill(sellManagementDbDataSet.InvenFee);

            this.tbAddress.ReadOnly = true;
            this.tbInventoryKey.ReadOnly = true;
            this.tbName.ReadOnly = true;
            this.tbRentPrice.ReadOnly = true;
            this.termTextBox.ReadOnly = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            (new AddInventory()).ShowDialog();

            this.iNVENTORY_CAPABILITYTableAdapter.Fill(sellManagementDbDataSet.INVENTORY_CAPABILITY);
            this.iNVENTORY_CAPABILITYBindingSource.ResetBindings(false);
            this.iNVENTORY_CAPABILITYDataGridView.Refresh();

            this.iNVENTORYTableAdapter.Fill(sellManagementDbDataSet.INVENTORY);
            this.iNVENTORYBindingSource.ResetBindings(false);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                try
                {

                    DataRowView row = (DataRowView)this.iNVENTORYBindingSource.CurrencyManager.Current;
                    var curId = (int)row["Id"];
                    // check trước
                    var checkInout = sellManagementDbDataSet.INOUTINVENTORY.Where(p => p.Inventory_id == curId);
                    if(checkInout.Count() > 0)
                    {
                        throw new Exception("Kho hàng đang được sử dụng trong đơn nhập xuất.");
                    }

                    var checkFee = sellManagementDbDataSet.InvenFee.Where(p => p.Inventory_id == curId);
                    if (checkFee.Count() > 0)
                    {
                        throw new Exception("Kho hàng đang được sử dụng trong báo cáo chi phí bán hàng.");
                    }

                    // xóa mấy cái trong INVENTORY_CAPABILITY
                    foreach (var item in sellManagementDbDataSet.INVENTORY_CAPABILITY.Where(i => i.Inventory_id == (int)row["Id"]))
                    {
                        item.Delete();
                    }

                    iNVENTORY_CAPABILITYTableAdapter.Update(sellManagementDbDataSet.INVENTORY_CAPABILITY);
                    sellManagementDbDataSet.INVENTORY_CAPABILITY.AcceptChanges();

                    row.Delete();

                    this.iNVENTORYBindingSource.EndEdit();
                    this.iNVENTORYTableAdapter.Update(sellManagementDbDataSet.INVENTORY);
                    this.sellManagementDbDataSet.INVENTORY.AcceptChanges();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Chi tiết: " + ex.Message, "Xóa thất bại!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                    this.iNVENTORYTableAdapter.Fill(sellManagementDbDataSet.INVENTORY);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id = ((this.iNVENTORYBindingSource.CurrencyManager.Current as DataRowView).Row as SellManagementDbDataSet.INVENTORYRow).Id - 1;
            (new AddInventory(id)).ShowDialog();

            this.iNVENTORY_CAPABILITYTableAdapter.Fill(sellManagementDbDataSet.INVENTORY_CAPABILITY);
            this.iNVENTORY_CAPABILITYBindingSource.ResetBindings(false);
            this.iNVENTORY_CAPABILITYDataGridView.Refresh();

            this.iNVENTORYTableAdapter.Fill(sellManagementDbDataSet.INVENTORY);
            this.iNVENTORYBindingSource.ResetBindings(false);
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            var tab = this.Parent as TabPage;
            if (tab != null)
            {
                (tab.Parent as TabControl).TabPages.Remove(tab);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.iNVENTORYBindingSource.Filter = this.iNVENTORYDataGridView.Columns[0].DataPropertyName.ToString() + " LIKE '%" + this.tbSearch.Text + "%' OR " +
                                                    this.iNVENTORYDataGridView.Columns[1].DataPropertyName.ToString() + " LIKE '%" + this.tbSearch.Text + "%' OR " +
                                                    this.iNVENTORYDataGridView.Columns[2].DataPropertyName.ToString() + " LIKE '%" + this.tbSearch.Text + "%'";

        }
    }
}
