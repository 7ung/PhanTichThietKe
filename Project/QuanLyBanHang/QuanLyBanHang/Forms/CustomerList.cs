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
    public enum eFormState
    {
        EDIT,
        CREATE_NEW,
        VIEW
    }

    public partial class CustomerList : UserControl, IFormList
    {
        public eFormState State { set; get; }
        private bool _canDelete = false;

        private Gender[] _gender = new Gender[]
        {
            new Gender("Nam", true),
            new Gender("Nữ", false)
        };

        private IntNStringBindingData[] _customerGroup = new IntNStringBindingData[]
        {
            new IntNStringBindingData("Nhóm 1", 1),
            new IntNStringBindingData("Nhóm 2", 2),
            new IntNStringBindingData("Nhóm 3", 3),
        };

        public CustomerList()
        {
            InitializeComponent();

            // Fill dữ liệu
            customerTableAdapter.Fill(sellManagementDbDataSet.CUSTOMER);

            // Bind Combobox
            customerGenderComboBox.DataSource = _gender;
            customerGenderComboBox.DisplayMember = "Name";
            customerGenderComboBox.ValueMember = "Value";

            customerTypeComboBox.DataSource = _customerGroup;
            customerTypeComboBox.DisplayMember = "Name";
            customerTypeComboBox.ValueMember = "Value";

            // 
            updateState(eFormState.VIEW);
            
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
                        enableAllControls(true, false);
                        _canDelete = true;

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

        public void enableAllControls(bool enable, bool readOnly)
        {
            customerAddress.Enabled = enable;
            birthdayPicker.Enabled = enable;
            customerEmail.Enabled = enable;
            customerGenderComboBox.Enabled = enable;
            customerId.Enabled = enable;
            //customerKeyText.Enabled = enable;
            customerName.Enabled = enable;
            customerPhone.Enabled = enable;
            customerTypeComboBox.Enabled = enable;

            customerAddress.ReadOnly = readOnly;
            birthdayPicker.Enabled = !readOnly;
            customerEmail.ReadOnly = readOnly;
            customerGenderComboBox.Enabled = !readOnly;
            customerId.ReadOnly = readOnly;
            //customerKeyText.ReadOnly = readOnly;
            customerName.ReadOnly = readOnly;
            customerPhone.ReadOnly = readOnly;
            customerTypeComboBox.Enabled = !readOnly;

            customerAddress.ResetToNormal();
            customerEmail.ResetToNormal();
            customerId.ResetToNormal();
            customerName.ResetToNormal();
            customerPhone.ResetToNormal();
        }
        
        private void saveBtn_Click(object sender, EventArgs e)
        {
            if(State == eFormState.CREATE_NEW)
            {
                try
                {
                    customerTableBindingSource.EndEdit();

                    customerTableAdapter.Update(sellManagementDbDataSet.CUSTOMER);
                    sellManagementDbDataSet.CUSTOMER.AcceptChanges();
                    
                    updateState(eFormState.VIEW);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (State == eFormState.EDIT)
            {
                try
                {
                    customerTableBindingSource.EndEdit();

                    customerTableAdapter.Update(sellManagementDbDataSet.CUSTOMER);
                    sellManagementDbDataSet.CUSTOMER.AcceptChanges();

                    customerTableBindingSource.ResetBindings(false);

                    updateState(eFormState.VIEW);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        
        private void addNewCustomerBtn_Click(object sender, EventArgs e)
        {
            customerTableBindingSource.AddNew();

            updateState(eFormState.CREATE_NEW);

            customerKeyText.Text = generateCustomerKey();
        }

        private string generateCustomerKey()
        {
            // tạm thời tăng theo thứ tự
            int max = 0;
            // Tùng
            // thanh niên rảnh :v
            // tính max chi hen. lấy last là max rồi.

            // Try it:
            // max = (sellManagementDbDataSet.CUSTOMER as SellManagementDbDataSet.CUSTOMERDataTable).Last().Id;
            foreach (DataRow item in sellManagementDbDataSet.CUSTOMER.Rows)
            {
                max = Math.Max(max, Convert.ToInt32(item["CustomerKey"]));
            }

            return String.Format("{0:D6}", max + 1);

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            if(State == eFormState.CREATE_NEW)
            {
                customerTableBindingSource.RemoveAt(customerTableBindingSource.Count - 1);
            }

            sellManagementDbDataSet.CUSTOMER.RejectChanges();
            customerTableBindingSource.ResetBindings(false);
            updateState(eFormState.VIEW);
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            updateState(eFormState.EDIT);
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắt muốn xóa không?", "Cảnh báo", MessageBoxButtons.OKCancel);

            if(result == DialogResult.OK)
            {
                foreach (DataGridViewRow item in customerDataGridView.SelectedRows)
                {
                    var datarow = sellManagementDbDataSet.CUSTOMER.Rows[item.Index];
                    datarow.Delete();
                }

                customerTableBindingSource.EndEdit();

                customerTableAdapter.Update(sellManagementDbDataSet.CUSTOMER);
                sellManagementDbDataSet.CUSTOMER.AcceptChanges();
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            var page = this.Parent as TabPage;
            if(page != null)
            {
                (page.Parent as TabControl).TabPages.Remove(page);
            }
        }

        private void searchText_TextChanged(object sender, EventArgs e)
        {
            customerTableBindingSource.Filter = customerDataGridView.Columns["nameColumn"].DataPropertyName.ToString() + " LIKE '%" + searchText.Text + "%'" + "OR " +
                                                customerDataGridView.Columns["phoneColumn"].DataPropertyName.ToString() + " LIKE '%" + searchText.Text + "%'" + "OR " +
                                                customerDataGridView.Columns["idColumn"].DataPropertyName.ToString() + " LIKE '%" + searchText.Text + "%'";
        }

        private void customerName_xTextChanged(object sender, EventArgs e)
        {
            saveBtn.Enabled = IsValidInformation();
        }

        public bool IsValidInformation()
        {
            if (!customerName.IsValid || !customerId.IsValid || !customerEmail.IsValid || !customerPhone.IsValid)
                return false;

            return true;
        }

        private void customerDataGridView_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (State == eFormState.CREATE_NEW && _canDelete)
            {
                _canDelete = false;

                customerTableBindingSource.RemoveAt(customerTableBindingSource.Count - 1);

                sellManagementDbDataSet.CUSTOMER.RejectChanges();
                customerTableBindingSource.ResetBindings(false);

                updateState(eFormState.VIEW);
            }
            else if (State == eFormState.EDIT)
            {
                sellManagementDbDataSet.CUSTOMER.RejectChanges();
                updateState(eFormState.VIEW);
            }
        }
    }
}
