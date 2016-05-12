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

    public partial class CustomerList : UserControl
    {
        private eFormState _state = eFormState.VIEW;

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

        private void updateState(eFormState state)
        {
            _state = state;

            switch (_state)
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

        private void enableAllControls(bool enable, bool readOnly)
        {
            customerAddText.Enabled = enable;
            customerBirthdayText.Enabled = enable;
            customerEmailText.Enabled = enable;
            customerGenderComboBox.Enabled = enable;
            customerIdText.Enabled = enable;
            //customerKeyText.Enabled = enable;
            customerNameText.Enabled = enable;
            customerPhoneText.Enabled = enable;
            customerTypeComboBox.Enabled = enable;

            customerAddText.ReadOnly = readOnly;
            customerBirthdayText.ReadOnly = readOnly;
            customerEmailText.ReadOnly = readOnly;
            customerGenderComboBox.Enabled = !readOnly;
            customerIdText.ReadOnly = readOnly;
            //customerKeyText.ReadOnly = readOnly;
            customerNameText.ReadOnly = readOnly;
            customerPhoneText.ReadOnly = readOnly;
            customerTypeComboBox.Enabled = !readOnly;
        }

        private void clearAllText()
        {
            customerAddText.DataBindings.Clear();
            customerBirthdayText.DataBindings.Clear();
            customerEmailText.DataBindings.Clear();
            customerGenderComboBox.DataBindings.Clear();
            customerIdText.DataBindings.Clear();
            customerKeyText.DataBindings.Clear();
            customerNameText.DataBindings.Clear();
            customerPhoneText.DataBindings.Clear();
            customerTypeComboBox.DataBindings.Clear();

            customerAddText.Text = "";
            customerBirthdayText.Text = "";
            customerEmailText.Text = "";
            customerGenderComboBox.SelectedValue = true;
            customerIdText.Text = "";
            //customerKeyText.Text = "";
            customerNameText.Text = "";
            customerPhoneText.Text = "";
            customerTypeComboBox.SelectedValue = 1;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if(_state == eFormState.CREATE_NEW)
            {
                try
                {
                    var newCustomer = sellManagementDbDataSet.CUSTOMER.NewCUSTOMERRow();

                    newCustomer.Name = customerNameText.Text;
                    newCustomer.CustomerKey = customerKeyText.Text;
                    newCustomer.Address = customerAddText.Text;
                    newCustomer.Email = customerEmailText.Text;
                    newCustomer.IdentifyNumber = customerIdText.Text;
                    newCustomer.Phone = customerPhoneText.Text;
                    newCustomer.Group_id = Convert.ToInt32(customerTypeComboBox.SelectedValue);
                    newCustomer.Gender = Convert.ToBoolean(customerGenderComboBox.SelectedValue);
                    newCustomer.BirthDay = Convert.ToDateTime(customerBirthdayText.Text);

                    sellManagementDbDataSet.CUSTOMER.Rows.Add(newCustomer);

                    customerTableAdapter.Update(sellManagementDbDataSet.CUSTOMER);
                    sellManagementDbDataSet.CUSTOMER.AcceptChanges();
                    
                    bindingAllText();
                    updateState(eFormState.VIEW);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (_state == eFormState.EDIT)
            {
                updateState(eFormState.VIEW);

                customerTableBindingSource.EndEdit();

                customerTableAdapter.Update(sellManagementDbDataSet.CUSTOMER);
                sellManagementDbDataSet.CUSTOMER.AcceptChanges();

                customerTableBindingSource.ResetBindings(false);
            }
        }
        
        private void addNewCustomerBtn_Click(object sender, EventArgs e)
        {
            updateState(eFormState.CREATE_NEW);

            customerKeyText.Text = generateCustomerKey();
        }

        private void bindingAllText()
        {
            customerAddText.DataBindings.Add("Text", customerTableBindingSource, "Address");
            customerBirthdayText.DataBindings.Add("Text", customerTableBindingSource, "BirthDay");
            customerEmailText.DataBindings.Add("Text", customerTableBindingSource, "Email");
            customerGenderComboBox.DataBindings.Add("SelectedValue", customerTableBindingSource, "Gender");
            customerIdText.DataBindings.Add("Text", customerTableBindingSource, "IdentifyNumber");
            customerKeyText.DataBindings.Add("Text", customerTableBindingSource, "CustomerKey");
            customerNameText.DataBindings.Add("Text", customerTableBindingSource, "Name");
            customerPhoneText.DataBindings.Add("Text", customerTableBindingSource, "Phone");
            customerTypeComboBox.DataBindings.Add("SelectedValue", customerTableBindingSource, "Group_id");
        }

        private string generateCustomerKey()
        {
            // tạm thời tăng theo thứ tự
            int max = 0;

            foreach (DataRow item in sellManagementDbDataSet.CUSTOMER.Rows)
            {
                max = Math.Max(max, Convert.ToInt32(item["CustomerKey"]));
            }

            return String.Format("{0:D6}", max + 1);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            if(_state == eFormState.CREATE_NEW)
            {
                bindingAllText();
            }
            else if (_state == eFormState.EDIT)
            {
                sellManagementDbDataSet.CUSTOMER.RejectChanges();
                customerTableBindingSource.ResetBindings(false);
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
    }
}
