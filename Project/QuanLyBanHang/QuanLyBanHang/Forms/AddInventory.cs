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
        }

        public AddInventory(int id)
        {
            InitializeComponent();

            this.Text = "Chinh sua thong tin kho";
            _new = false;
            _id = id;
        }

        private void iNVENTORY_CAPABILITYBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.iNVENTORY_CAPABILITYBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sellManagementDbDataSet);

        }

        private void AddInventory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sellManagementDbDataSet.INVENTORY' table. You can move, or remove it, as needed.
            this.iNVENTORYTableAdapter.Fill(this.sellManagementDbDataSet.INVENTORY);
            // TODO: This line of code loads data into the 'sellManagementDbDataSet.INVENTORY_CAPABILITY' table. You can move, or remove it, as needed.
            this.iNVENTORY_CAPABILITYTableAdapter.Fill(this.sellManagementDbDataSet.INVENTORY_CAPABILITY);

            if (_new)
            {
                this.iNVENTORYBindingSource.CurrencyManager.AddNew();
            }
            else
            {
                this.iNVENTORYBindingSource.CurrencyManager.Position = _id;
                (this.iNVENTORYBindingSource.CurrencyManager.Current as DataRowView).BeginEdit();
            }

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
                    this.iNVENTORY_CAPABILITYBindingSource.EndEdit();
                    this.iNVENTORY_CAPABILITYTableAdapter.Update(sellManagementDbDataSet.INVENTORY_CAPABILITY);
                    sellManagementDbDataSet.INVENTORY_CAPABILITY.AcceptChanges();

                    this.iNVENTORYBindingSource.EndEdit();
                    this.iNVENTORYTableAdapter.Update(sellManagementDbDataSet.INVENTORY);
                    sellManagementDbDataSet.INVENTORY.AcceptChanges();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
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
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (_new)
            {
                try
                {
                    DataRowView row = (DataRowView)this.iNVENTORYBindingSource.CurrencyManager.Current;
                    row.Delete();

                    this.sellManagementDbDataSet.INVENTORY_CAPABILITY.RejectChanges();

                    this.iNVENTORYBindingSource.EndEdit();
                    this.iNVENTORYTableAdapter.Update(sellManagementDbDataSet.INVENTORY);
                    this.sellManagementDbDataSet.INVENTORY.AcceptChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                this.sellManagementDbDataSet.INVENTORY_CAPABILITY.RejectChanges();
                this.sellManagementDbDataSet.INVENTORY.RejectChanges();              
            }
        }
    }
}
