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
    public partial class AddInventory : Form
    {
        private bool _new = true;
        private int _id = -1;

        public AddInventory()
        {
            InitializeComponent();

            _new = true;
        }

        public AddInventory(int id)
        {
            InitializeComponent();

            this.Text = "Chỉnh sửa thông tin kho";
            _new = false;
            _id = id;
        }

        private void AddInventory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sellManagementDbDataSet.PRODUCT' table. You can move, or remove it, as needed.
            this.pRODUCTTableAdapter.Fill(this.sellManagementDbDataSet.PRODUCT);
            // TODO: This line of code loads data into the 'sellManagementDbDataSet.INVENTORY' table. You can move, or remove it, as needed.
            this.iNVENTORYTableAdapter.Fill(this.sellManagementDbDataSet.INVENTORY);
            
            if (_new)
            {
                this.iNVENTORYBindingSource.CurrencyManager.AddNew();
                tbInventoryKey.Text = generateKey();
            }
            else
            {
                // TODO: This line of code loads data into the 'sellManagementDbDataSet.INVENTORY_CAPABILITY' table. You can move, or remove it, as needed.
                this.iNVENTORY_CAPABILITYTableAdapter.Fill(this.sellManagementDbDataSet.INVENTORY_CAPABILITY);

                this.iNVENTORYBindingSource.CurrencyManager.Position = _id;
                var currentRow = (this.iNVENTORYBindingSource.CurrencyManager.Current as DataRowView);
                currentRow.BeginEdit();
                iNVENTORY_CAPABILITYBindingSource.Filter = "Inventory_id = " + currentRow["Id"];
            }

        }

        private string generateKey()
        {
            int max = 0;

            foreach (DataRow item in sellManagementDbDataSet.INVENTORY.Where(c => c.InventoryKey.Substring(0, 2) == "IV"))
            {
                var value = item["InventoryKey"].ToString().TrimStart(new char[] { 'I', 'V' });
                max = Math.Max(max, Convert.ToInt32(value));
            }

            return "IV" + String.Format("{0:D6}", max + 1);
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_new)
            {
                try
                {
                    var curRow = ((this.iNVENTORYBindingSource.Current as DataRowView).Row as SellManagementDbDataSet.INVENTORYRow);
                    //ko biết tại sao bind mà termNumerric thay có giá trị nếu ko thay đổi nó báo null -_-
                    {
                        curRow.Term = (int)termNumericUpDown.Value;
                    }

                    this.iNVENTORYBindingSource.EndEdit();
                    this.iNVENTORYTableAdapter.Update(sellManagementDbDataSet.INVENTORY);
                    sellManagementDbDataSet.INVENTORY.AcceptChanges();

                    // lấy id row mới
                    var lastRow = sellManagementDbDataSet.INVENTORY.Last();

                    // gán id inventory cho mấy cái row mới add
                    foreach (DataGridViewRow item in iNVENTORY_CAPABILITYDataGridView.Rows)
                    {
                        item.Cells["idColumn"].Value = lastRow["Id"];
                    }

                    this.iNVENTORY_CAPABILITYBindingSource.EndEdit();
                    this.iNVENTORY_CAPABILITYTableAdapter.Update(sellManagementDbDataSet.INVENTORY_CAPABILITY);
                    sellManagementDbDataSet.INVENTORY_CAPABILITY.AcceptChanges();
                    
                    this.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra rồi. :( \n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    this.iNVENTORY_CAPABILITYBindingSource.EndEdit();
                    this.iNVENTORY_CAPABILITYTableAdapter.Update(sellManagementDbDataSet.INVENTORY_CAPABILITY);
                    sellManagementDbDataSet.INVENTORY_CAPABILITY.AcceptChanges();

                    (this.iNVENTORYBindingSource.CurrencyManager.Current as DataRowView).EndEdit();
                    this.iNVENTORYBindingSource.EndEdit();
                    this.iNVENTORYTableAdapter.Update(sellManagementDbDataSet.INVENTORY);
                    sellManagementDbDataSet.INVENTORY.AcceptChanges();
                    
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra rồi. :( \n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //if (_new)
            //{
            //    try
            //    {
            //        if (((this.iNVENTORYBindingSource.CurrencyManager.Current as DataRowView).Row as SellManagementDbDataSet.INVENTORYRow).Id >= 0)
            //        {
            //            DataRowView row = (DataRowView)this.iNVENTORYBindingSource.CurrencyManager.Current;
            //            row.Delete();
            //        }

            //        this.sellManagementDbDataSet.INVENTORY_CAPABILITY.RejectChanges();

            //        this.iNVENTORYBindingSource.EndEdit();
            //        this.iNVENTORYTableAdapter.Update(sellManagementDbDataSet.INVENTORY);
            //        this.sellManagementDbDataSet.INVENTORY.AcceptChanges();
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Có lỗi xảy ra rồi. :( \n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
            //else
            //{
            //    this.sellManagementDbDataSet.INVENTORY_CAPABILITY.RejectChanges();
            //    this.sellManagementDbDataSet.INVENTORY.RejectChanges();              
            //}

            this.sellManagementDbDataSet.INVENTORY_CAPABILITY.RejectChanges();
            this.sellManagementDbDataSet.INVENTORY.RejectChanges();          
            this.Close();
        }

        private void iNVENTORY_CAPABILITYDataGridView_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            //if (((this.iNVENTORYBindingSource.CurrencyManager.Current as DataRowView).Row as SellManagementDbDataSet.INVENTORYRow).Id < 0)
            {
                try
                {
                    //this.iNVENTORYBindingSource.EndEdit();
                    //this.iNVENTORYTableAdapter.Update(sellManagementDbDataSet.INVENTORY);
                    //sellManagementDbDataSet.AcceptChanges();
                    //this.iNVENTORYBindingSource.ResetBindings(false);

                    // gán id inventory tạm cho nó
                    var newRow = iNVENTORY_CAPABILITYDataGridView.Rows[iNVENTORY_CAPABILITYDataGridView.Rows.Count - 2];
                    newRow.Cells["idColumn"].Value = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra rồi. :( \n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tbRentPrice_xTextChanged(object sender, EventArgs e)
        {
            if (tbRentPrice.Text == "")
                return;

            try
            {
                var value = Convert.ToDouble(tbRentPrice.Text);
                btnSave.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Giá trị không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnSave.Enabled = false;
                return;
            }
        }

        private void iNVENTORY_CAPABILITYDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            
        }
    }
}
