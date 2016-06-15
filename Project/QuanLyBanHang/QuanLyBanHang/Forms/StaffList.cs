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
using QuanLyBanHang.Properties;

namespace QuanLyBanHang.Forms
{
    public partial class StaffList : UserControl, IFormList
    {
        private bool _canDelete = false;

        private Gender[] _gender = new Gender[]
        {
            new Gender("Nam", true),
            new Gender("Nữ", false)
        };

        private static List<String> _func = new List<String>();
        
        public StaffList()
        {
            InitializeComponent();

            sTAFFTableAdapter.Fill(sellManagementDbDataSet.STAFF);
            var temp = sellManagementDbDataSet.STAFF.Select(row => row.Func);
            _func = temp.Distinct().ToList();

            this.cbbGender.DataSource = _gender;
            this.cbbGender.DisplayMember = "Name";
            this.cbbGender.ValueMember = "Value";

            this.cbbFunction.DataSource = _func;
           

            updateState(eFormState.VIEW);
        }

        public eFormState State
        {
            get; 
            set;
        }

        private string _staffPrefix = Resources.StaffPrefixKey;
        
        public void updateState(eFormState state)
        {
            State = state;

            switch (state)
            {
                case eFormState.CREATE_NEW:
                    enableAllControls(true, false);
                    _canDelete = true;

                    btnCancel.Visible = true;
                    btnSave.Visible = true;
                    //btnSave.Enabled = false;
                    btnEdit.Visible = false;
                    btnAdd.Visible = false;
                    break;                  

                case eFormState.EDIT:
                    enableAllControls(true, false);
                    btnCancel.Visible = true;
                    btnSave.Visible = true;
                    btnEdit.Visible = false;
                    btnAdd.Visible = false;
                    break;

                case eFormState.VIEW:
                    enableAllControls(true, true);
                    btnCancel.Visible = false;
                    btnSave.Visible = false;
                    btnEdit.Visible = true;
                    btnAdd.Visible = true;
                    break;
            }
        }

        public void enableAllControls(bool enable, bool readOnly)
        {
            this.tbAddress.Enabled = enable;
            this.dtpBirthday.Enabled = enable;
            this.cbbGender.Enabled = !readOnly;
            this.tbEmail.Enabled = enable;
            this.cbbFunction.Enabled = !readOnly;
            this.tbIdentifyNumber.Enabled = enable;
            this.tbNameStaff.Enabled = enable;
            this.tbPhone.Enabled = enable;
            this.tbSalary.Enabled = enable;
            this.tbStaffKey.Enabled = enable;
            
            this.tbAddress.ReadOnly = readOnly;
            this.tbEmail.ReadOnly = readOnly;
            this.tbIdentifyNumber.ReadOnly = readOnly;
            this.tbNameStaff.ReadOnly = readOnly;
            this.tbPhone.ReadOnly = readOnly;
            this.tbSalary.ReadOnly = readOnly;
          
            this.tbStaffKey.ReadOnly = readOnly;

            tbAddress.ResetToNormal();
            tbEmail.ResetToNormal();
            tbNameStaff.ResetToNormal();
            tbPhone.ResetToNormal();
            tbIdentifyNumber.ResetToNormal();
        }

        public bool IsValidInformation()
        {
            if (!tbAddress.IsValid || tbIdentifyNumber.IsValid || tbNameStaff.IsValid || tbPhone.IsValid)
                return false;
            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.sTAFFBindingSource.AddNew();
            updateState(eFormState.CREATE_NEW);
            this.tbStaffKey.Text = generateStaffKey();
            this.cbbFunction.SelectedIndex = 0;
            this.cbbGender.SelectedIndex = 0;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.Cancel)
                return;

            try
            {
                DataRowView row = (DataRowView)this.sTAFFBindingSource.CurrencyManager.Current;
                row.Delete();

                this.sTAFFBindingSource.EndEdit();
                this.sTAFFTableAdapter.Update(sellManagementDbDataSet.STAFF);
                this.sellManagementDbDataSet.STAFF.AcceptChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            updateState(eFormState.EDIT);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (State == eFormState.CREATE_NEW)
            {
                this.sTAFFBindingSource.RemoveAt(this.sTAFFBindingSource.Count - 1);
            }

            sellManagementDbDataSet.STAFF.RejectChanges();
            this.sTAFFBindingSource.ResetBindings(false);
            updateState(eFormState.VIEW);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            if (State == eFormState.CREATE_NEW)
            {
                try
                {
                    this.sTAFFBindingSource.EndEdit();
                    this.sTAFFTableAdapter.Update(sellManagementDbDataSet.STAFF);
                    sellManagementDbDataSet.STAFF.AcceptChanges();

                    updateState(eFormState.VIEW);
                }
                catch (NoNullAllowedException nullex)
                {
                    MessageBox.Show(nullex.Message);
                }
                catch(System.Data.SqlClient.SqlException sqlex)
                {
                    MessageBox.Show(sqlex.Message);
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
                    this.sTAFFBindingSource.EndEdit();
                    this.sTAFFTableAdapter.Update(sellManagementDbDataSet.STAFF);
                    sellManagementDbDataSet.STAFF.AcceptChanges();
                    this.sTAFFBindingSource.ResetBindings(false);

                    updateState(eFormState.VIEW);
                }
                catch (NoNullAllowedException nullex)
                {
                    MessageBox.Show(nullex.Message);
                }
                catch (System.Data.SqlClient.SqlException sqlex)
                {
                    MessageBox.Show(sqlex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            var page = this.Parent as TabPage;
            if (page != null)
            {
                (page.Parent as TabControl).TabPages.Remove(page);
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            this.sTAFFBindingSource.Filter = this.sTAFFDataGridView.Columns["nameColumn"].DataPropertyName.ToString() + " LIKE '%" + tbSearch.Text + "%'" + "OR " +
                                                this.sTAFFDataGridView.Columns["phoneColumn"].DataPropertyName.ToString() + " LIKE '%" + tbSearch.Text + "%'" + "OR " +
                                                this.sTAFFDataGridView.Columns["idColumn"].DataPropertyName.ToString() + " LIKE '%" + tbSearch.Text + "%'";
        }

        private string generateStaffKey()
        {
            int max = 0;

            foreach (DataRow item in sellManagementDbDataSet.STAFF.Where(c => c.StaffKey.Substring(0, 2) == _staffPrefix))
            {
                var value = item["StaffKey"].ToString().TrimStart(_staffPrefix.ToArray());
                max = Math.Max(max, Convert.ToInt32(value));
            }

            return _staffPrefix + String.Format("{0:D6}", max + 1);
        }

        private void sTAFFDataGridView_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (State == eFormState.CREATE_NEW && _canDelete)
            {
                _canDelete = false;

                this.sTAFFBindingSource.RemoveAt(this.sTAFFBindingSource.Count - 1);
                this.sellManagementDbDataSet.STAFF.RejectChanges();
                this.sTAFFBindingSource.ResetBindings(false);
                updateState(eFormState.VIEW);
            }
            else if (State == eFormState.EDIT)
            {
                this.sellManagementDbDataSet.STAFF.RejectChanges();
                updateState(eFormState.VIEW);
            }
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new AddFunction(_func)).ShowDialog();
            this.cbbFunction.DataSource = null;
            this.cbbFunction.DataSource = _func;
        }
    }
}
