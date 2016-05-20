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
using System.Diagnostics;

namespace QuanLyBanHang.Forms
{
    public partial class VendorList : UserControl
    {
        public VendorList()
        {
            InitializeComponent();

            vendorTableAdapter.Fill(sellManagementDbDataSet.VENDOR);

            updateState(eFormState.VIEW);
        }

        public eFormState State { get; set; }

        private bool canDelete = false;

        public void enableAllControls(bool enable, bool readOnly)
        {
            vendorAddress.Enabled = enable;
            vendorEmail.Enabled = enable;
            vendorName.Enabled = enable;
            vendorPhone.Enabled = enable;

            vendorAddress.ReadOnly = readOnly;
            vendorEmail.ReadOnly = readOnly;
            vendorName.ReadOnly = readOnly;
            vendorPhone.ReadOnly = readOnly;

            vendorAddress.ResetToNormal();
            vendorEmail.ResetToNormal();
            vendorName.ResetToNormal();
            vendorPhone.ResetToNormal();
        }

        public void updateState(eFormState state)
        {
            State = state;

            switch (State)
            {
                case eFormState.EDIT:
                    {
                        enableAllControls(true, false);
                        cancelBtn.Visible = true;
                        saveBtn.Visible = true;
                        editBtn.Visible = false;
                        break;
                    }
                case eFormState.CREATE_NEW:
                    {
                        vendorBindingSource.AddNew();
                        canDelete = true;

                        enableAllControls(true, false);
                        cancelBtn.Visible = true;
                        saveBtn.Visible = true;
                        saveBtn.Enabled = false;
                        editBtn.Visible = false;
                        break;
                    }
                case eFormState.VIEW:
                    {
                        enableAllControls(true, true);
                        cancelBtn.Visible = false;
                        saveBtn.Visible = false;
                        editBtn.Visible = true;
                        break;
                    }
                default:
                    break;
            }
        }

        private void newVendorBtn_Click(object sender, EventArgs e)
        {
            updateState(eFormState.CREATE_NEW);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            switch (State)
            {
                case eFormState.EDIT:
                    {
                        try
                        {
                            vendorBindingSource.EndEdit();

                            vendorTableAdapter.Update(sellManagementDbDataSet.VENDOR);
                            sellManagementDbDataSet.VENDOR.AcceptChanges();

                            vendorBindingSource.ResetBindings(false);

                            updateState(eFormState.VIEW);
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        break;
                    }
                case eFormState.CREATE_NEW:
                    {
                        try
                        {
                            vendorBindingSource.EndEdit();

                            vendorTableAdapter.Update(sellManagementDbDataSet.VENDOR);
                            sellManagementDbDataSet.AcceptChanges();

                            updateState(eFormState.VIEW);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                        break;
                    }
                case eFormState.VIEW:
                    break;
                default:
                    break;
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            if (State == eFormState.CREATE_NEW)
            {
                vendorBindingSource.RemoveAt(vendorBindingSource.Count - 1);
            }

            sellManagementDbDataSet.VENDOR.RejectChanges();
            vendorBindingSource.ResetBindings(false);

            updateState(eFormState.VIEW);
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            updateState(eFormState.EDIT);
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắt muốn xóa không?", "Cảnh báo", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                foreach (DataGridViewRow item in vendorDataGridView.SelectedRows)
                {
                    var datarow = sellManagementDbDataSet.VENDOR.Rows[item.Index];
                    datarow.Delete();
                }

                vendorBindingSource.EndEdit();

                vendorTableAdapter.Update(sellManagementDbDataSet.VENDOR);
                sellManagementDbDataSet.VENDOR.AcceptChanges();
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

        private void searchText_TextChanged(object sender, EventArgs e)
        {
            vendorBindingSource.Filter = vendorDataGridView.Columns["nameColumn"].DataPropertyName.ToString() + " LIKE '%" + searchText.Text + "%'" + "OR " +
                                         vendorDataGridView.Columns["phoneColumn"].DataPropertyName.ToString() + " LIKE '%" + searchText.Text + "%'" + "OR " +
                                         vendorDataGridView.Columns["emailColumn"].DataPropertyName.ToString() + " LIKE '%" + searchText.Text + "%'";
        }
        
        private void vendorDataGridView_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (State == eFormState.CREATE_NEW && canDelete)
            {
                canDelete = false;

                vendorBindingSource.RemoveAt(vendorBindingSource.Count - 1);

                sellManagementDbDataSet.VENDOR.RejectChanges();
                vendorBindingSource.ResetBindings(false);
            }
            else if (State == eFormState.EDIT)
            {
                sellManagementDbDataSet.VENDOR.RejectChanges();
                updateState(eFormState.VIEW);
            }
        }

        private void vendorName_xTextChanged(object sender, EventArgs e)
        {
            saveBtn.Enabled = IsValidInfomation();
        }

        private bool IsValidInfomation()
        {
            if (!vendorName.IsValid || !vendorEmail.IsValid || !vendorAddress.IsValid || !vendorAddress.IsValid)
                return false;

            return true;
        }
    }
}
