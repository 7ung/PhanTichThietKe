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
    public partial class VendorList : UserControl, IFormList
    {
        public VendorList()
        {
            InitializeComponent();

            vendorTableAdapter.Fill(sellManagementDbDataSet.VENDOR);

            updateState(eFormState.VIEW);
        }

        public eFormState State { get; set; }

        public void bindingAllText()
        {
            vendorIdText.DataBindings.Add("Text", vendorBindingSource, "Id");
            vendorAddressText.DataBindings.Add("Text", vendorBindingSource, "Address"); ;
            vendorEmailText.DataBindings.Add("Text", vendorBindingSource, "Email"); ;
            vendorNameText.DataBindings.Add("Text", vendorBindingSource, "Name"); ;
            vendorPhoneText.DataBindings.Add("Text", vendorBindingSource, "Phone"); ;
            
        }

        public void clearAllText()
        {
            vendorIdText.DataBindings.Clear();
            vendorAddressText.DataBindings.Clear();
            vendorEmailText.DataBindings.Clear();
            vendorNameText.DataBindings.Clear();
            vendorPhoneText.DataBindings.Clear();

            vendorAddressText.Text = "";
            vendorEmailText.Text = "";
            vendorNameText.Text = "";
            vendorPhoneText.Text = "";
        }

        public void enableAllControls(bool enable, bool readOnly)
        {
            vendorAddressText.Enabled = enable;
            vendorEmailText.Enabled = enable;
            vendorNameText.Enabled = enable;
            vendorPhoneText.Enabled = enable;

            vendorAddressText.ReadOnly = readOnly;
            vendorEmailText.ReadOnly = readOnly;
            vendorNameText.ReadOnly = readOnly;
            vendorPhoneText.ReadOnly = readOnly;
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
                        clearAllText();
                        enableAllControls(true, false);
                        cancelBtn.Visible = true;
                        saveBtn.Visible = true;
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
                        updateState(eFormState.VIEW);

                        vendorBindingSource.EndEdit();

                        vendorTableAdapter.Update(sellManagementDbDataSet.VENDOR);
                        sellManagementDbDataSet.VENDOR.AcceptChanges();

                        vendorBindingSource.ResetBindings(false);
                        break;
                    }
                case eFormState.CREATE_NEW:
                    {
                        try
                        {
                            var newVendor = sellManagementDbDataSet.VENDOR.NewVENDORRow();

                            newVendor.Name = vendorNameText.Text;
                            newVendor.Phone = vendorPhoneText.Text;
                            newVendor.Email = vendorEmailText.Text;
                            newVendor.Address = vendorAddressText.Text;

                            sellManagementDbDataSet.VENDOR.Rows.Add(newVendor);

                            vendorTableAdapter.Update(sellManagementDbDataSet.VENDOR);
                            sellManagementDbDataSet.AcceptChanges();


                            bindingAllText();
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
                bindingAllText();
            }
            else if (State == eFormState.EDIT)
            {
                sellManagementDbDataSet.VENDOR.RejectChanges();
                vendorBindingSource.ResetBindings(false);
            }

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
    }
}
