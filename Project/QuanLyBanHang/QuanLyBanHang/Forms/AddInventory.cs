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
            // TODO: This line of code loads data into the 'sellManagementDbDataSet.INVENTORY_CAPABILITY' table. You can move, or remove it, as needed.
            this.iNVENTORY_CAPABILITYTableAdapter.Fill(this.sellManagementDbDataSet.INVENTORY_CAPABILITY);

            if (_new)
            {
                this.iNVENTORYBindingSource.CurrencyManager.AddNew();
                tbInventoryKey.Text = generateKey();

            }
            else
            {
                this.iNVENTORYBindingSource.CurrencyManager.Position = _id;
                var currentRow = (this.iNVENTORYBindingSource.CurrencyManager.Current as DataRowView);
                currentRow.BeginEdit();
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

                    var capability = sellManagementDbDataSet.INVENTORY_CAPABILITY.Where(i => i.Inventory_id == -1).Select(i => i);
                    foreach (var item in capability)
                    {
                        item.Inventory_id = curRow.Id;
                    }
                    
                    this.iNVENTORY_CAPABILITYTableAdapter.Update(sellManagementDbDataSet.INVENTORY_CAPABILITY);
                    sellManagementDbDataSet.INVENTORY_CAPABILITY.AcceptChanges();
                    
                    this.Close();
                    DialogResult = DialogResult.OK;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(Resources.ErrorMessage + "\n" + ex.Message, Resources.ErrorLabel, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    this.iNVENTORY_CAPABILITYBindingSource1.EndEdit();
                    this.iNVENTORY_CAPABILITYTableAdapter.Update(sellManagementDbDataSet.INVENTORY_CAPABILITY);
                    sellManagementDbDataSet.INVENTORY_CAPABILITY.AcceptChanges();

                    (this.iNVENTORYBindingSource.CurrencyManager.Current as DataRowView).EndEdit();
                    this.iNVENTORYBindingSource.EndEdit();
                    this.iNVENTORYTableAdapter.Update(sellManagementDbDataSet.INVENTORY);
                    sellManagementDbDataSet.INVENTORY.AcceptChanges();
                    
                    this.Close();

                    DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Resources.InvalidValueMessage + "\n\nChi tiết: " + ex.Message, Resources.ErrorLabel, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.sellManagementDbDataSet.INVENTORY_CAPABILITY.RejectChanges();
            this.sellManagementDbDataSet.INVENTORY.RejectChanges();          
            this.Close();

            DialogResult = DialogResult.Cancel;
        }

        private void iNVENTORY_CAPABILITYDataGridView_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
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
                MessageBox.Show(Resources.InvalidValueMessage, Resources.ErrorLabel, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnSave.Enabled = false;
                return;
            }
        }

        private void iNVENTORY_CAPABILITYDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            
        }

        private void iNVENTORY_CAPABILITYDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show(Resources.InvalidValueMessage + "\n\nChi tiết: " + e.Exception.Message, Resources.ErrorLabel, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
