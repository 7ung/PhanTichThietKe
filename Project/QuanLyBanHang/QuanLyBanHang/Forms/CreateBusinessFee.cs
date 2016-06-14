using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanHang.Properties;

namespace QuanLyBanHang.Forms
{
    public partial class CreateBusinessFee : UserControl
    {
        private bool _isNew = true;
        private string _prefix = Resources.ReportPrefixKey;

        public CreateBusinessFee()
        {
            InitializeComponent();
        }

        private void CreateBusinessFee_Load(object sender, EventArgs e)
        {
            sTAFFTableAdapter.Fill(sellManagementDbDataSet.STAFF);
            dOCUMENTTableAdapter.Fill(sellManagementDbDataSet.DOCUMENT);
            iNOUTINVENTORYTableAdapter.Fill(sellManagementDbDataSet.INOUTINVENTORY);
            iNVENTORYTableAdapter.Fill(sellManagementDbDataSet.INVENTORY);
            businessFeeTableAdapter.Fill(sellManagementDbDataSet.BusinessFee);

            // bind combobox
            staffIdDataGridViewTextBoxColumn.DataSource = sellManagementDbDataSet.STAFF.CopyToDataTable();
            staffIdDataGridViewTextBoxColumn.DisplayMember = "StaffKey";
            staffIdDataGridViewTextBoxColumn.ValueMember = "Id";

            inventoryidDataGridViewTextBoxColumn.DataSource = sellManagementDbDataSet.INVENTORY.CopyToDataTable();
            inventoryidDataGridViewTextBoxColumn.DisplayMember = "InventoryKey";
            inventoryidDataGridViewTextBoxColumn.ValueMember = "Id";

            creatorComboBox.DataSource = sellManagementDbDataSet.STAFF.CopyToDataTable();
            creatorComboBox.DisplayMember = "Name";
            creatorComboBox.ValueMember = "Id";

            // format
            carryFeeDataGridViewTextBoxColumn.DefaultCellStyle.Format = "N2";
            feeDataGridViewTextBoxColumn.DefaultCellStyle.Format = "N2";
            feeDataGridViewTextBoxColumn1.DefaultCellStyle.Format = "N2";
            feeDataGridViewTextBoxColumn2.DefaultCellStyle.Format = "N2";
            rentPriceDataGridViewTextBoxColumn.DefaultCellStyle.Format = "N2";
            salaryDataGridViewTextBoxColumn.DefaultCellStyle.Format = "N2";

            //
            if (_isNew)
            {
                dOCUMENTBindingSource.AddNew();
                businessFeeBindingSource.AddNew();

                documentKeyText.Text = generateKey();
            }

            calculateFee();
        }

        private void addInOutBtn_Click(object sender, EventArgs e)
        {
            if(dataGridView1.RowCount > 0 && dataGridView1.SelectedRows.Count > 0)
            {
                var id = (int)dataGridView1.SelectedRows[0].Cells[idDataGridViewTextBoxColumn.Index].Value;
                var fee = (double)dataGridView1.SelectedRows[0].Cells[carryFeeDataGridViewTextBoxColumn.Index].Value;

                addNewTransferFee(id, fee);
                
            }
        }

        private void addNewTransferFee(int inoutId, double fee)
        {
            var newRow = (transferFeeBindingSource1.AddNew() as DataRowView).Row as SellManagementDbDataSet.TranferFeeRow;
            var curId = (businessFeeBindingSource.Current as DataRowView).Row as SellManagementDbDataSet.BusinessFeeRow;

            newRow.BeginEdit();
            newRow.BusinessFee_Id = curId.Id;
            newRow.Fee = fee;
            newRow.InoutInventory_Id = inoutId;
            newRow.EndEdit();

            transferFeeBindingSource1.Position = 0;

            // remove nó đi
            iNOUTINVENTORYBindingSource.RemoveCurrent();

            // enable nút
            calculateFee();
        }

        private void removeCurrentTransferFee()
        {
            if (transferFeeBindingSource1.Current == null || dataGridView2.RowCount <= 0)
                return;

            transferFeeBindingSource1.RemoveCurrent();

            // fill lại, remove mấy cái có trong list rồi
            iNOUTINVENTORYTableAdapter.Fill(sellManagementDbDataSet.INOUTINVENTORY);
            var rowsAdded = sellManagementDbDataSet.TranferFee.Select(r => r.InoutInventory_Id);

            if (rowsAdded.Count() > 0)
            {
                for (int i = 0; i < iNOUTINVENTORYBindingSource.Count; i++)
                {
                    var row = ((iNOUTINVENTORYBindingSource[i] as DataRowView).Row as SellManagementDbDataSet.INOUTINVENTORYRow);
                    if (rowsAdded.Contains(row.Id))
                    {
                        iNOUTINVENTORYBindingSource.RemoveAt(i);
                        i--;
                    }
                }
            }

            // enable nút
            calculateFee();
        }

        private string generateKey()
        {
            int max = 0;

            foreach (DataRow item in sellManagementDbDataSet.DOCUMENT.Where(c => c.DocumentKey.Substring(0, 2) == _prefix))
            {
                var value = item["DocumentKey"].ToString().TrimStart(_prefix.ToArray());
                max = Math.Max(max, Convert.ToInt32(value));
            }

            return _prefix + String.Format("{0:D6}", max + 1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                createReport();
            }
            catch (Exception)
            {
                MessageBox.Show("Đã có lỗi xảy ra trong quá trình báo cáo. Tab sẽ đóng, bạn vui lòng tạo lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            var page = this.Parent as TabPage;
            if (page != null)
            {
                (page.Parent as TabControl).TabPages.Remove(page);
            }
        }

        private void createReport()
        {
            // gán type cho document
            var curRow = (dOCUMENTBindingSource.Current as DataRowView).Row as SellManagementDbDataSet.DOCUMENTRow;
            curRow.BeginEdit();
            curRow.DocumentKey = documentKeyText.Text;
            curRow.Type = "reportbusinessfee";
            curRow.CreateDate = dateTimePicker1.Value;
            curRow.Creator = (int)creatorComboBox.SelectedValue;
            curRow.EndEdit();

            // phí mặt định = 0
            var curFee = (businessFeeBindingSource.Current as DataRowView).Row as SellManagementDbDataSet.BusinessFeeRow;
            curFee.BeginEdit();
            curFee.TotalFee = 0;
            curFee.ToDate = todateTimePicker.Value;
            curFee.FromDate = fromdateTimePicker.Value;
            curFee.Term = (int)numericUpDown.Value;

            invenFeeBindingSource.EndEdit();
            sTAFFBindingSource1.EndEdit();
            transferFeeBindingSource1.EndEdit();
            businessFeeBindingSource.EndEdit();
            dOCUMENTBindingSource.EndEdit();

            dOCUMENTTableAdapter.Update(sellManagementDbDataSet.DOCUMENT);
            sellManagementDbDataSet.DOCUMENT.AcceptChanges();

            // cập nhật id theo document
            curFee.Id = curRow.Id;
            curFee.EndEdit();

            businessFeeTableAdapter.Update(sellManagementDbDataSet.BusinessFee);
            sellManagementDbDataSet.BusinessFee.AcceptChanges();

            // cập nhật id theo business fee
            var fee = sellManagementDbDataSet.TranferFee.Where(t => t.BusinessFee_Id == -1);
            if (fee.Count() > 0)
            {
                foreach (var item in fee.Select(t => t))
                {
                    item.BusinessFee_Id = curFee.Id;
                }
            }

            // cập nhật id invnetory fee
            var invenfee = sellManagementDbDataSet.InvenFee.Where(t => t.BusinessFee_id == -1);
            if (invenfee.Count() > 0)
            {
                foreach (var item in invenfee.Select(t => t))
                {
                    item.BusinessFee_id = curFee.Id;
                }
            }

            // cập nhật id taff fee
            var stafffee = sellManagementDbDataSet.StaffFee.Where(t => t.BusinessFee_Id == -1);
            if (stafffee.Count() > 0)
            {
                foreach (var item in stafffee.Select(t => t))
                {
                    item.BusinessFee_Id = curFee.Id;
                }
            }

            staffFeeTableAdapter.Update(sellManagementDbDataSet.StaffFee);
            sellManagementDbDataSet.StaffFee.AcceptChanges();

            invenFeeTableAdapter.Update(sellManagementDbDataSet.InvenFee);
            sellManagementDbDataSet.InvenFee.AcceptChanges();

            tranferFeeTableAdapter.Update(sellManagementDbDataSet.TranferFee);
            sellManagementDbDataSet.TranferFee.AcceptChanges();
        }

        private void removeInOutBtn_Click(object sender, EventArgs e)
        {
            removeCurrentTransferFee();
        }

        private void addInventoryBtn_Click(object sender, EventArgs e)
        {
            addNewInventoryFee();
        }

        private void addNewInventoryFee()
        {
            if (inventoryDataGridView.RowCount <= 0 || inventoryDataGridView.SelectedRows.Count <= 0)
                return;
            
            var id = (int)inventoryDataGridView.SelectedRows[0].Cells[inventoryIdColumn.Index].Value;
            var fee = (double)inventoryDataGridView.SelectedRows[0].Cells[rentPriceDataGridViewTextBoxColumn.Index].Value;

            var newRow = (invenFeeBindingSource.AddNew() as DataRowView).Row as SellManagementDbDataSet.InvenFeeRow;
            var curId = (businessFeeBindingSource.Current as DataRowView).Row as SellManagementDbDataSet.BusinessFeeRow;

            newRow.BeginEdit();
            newRow.BusinessFee_id = curId.Id;
            newRow.Fee = fee;
            newRow.Inventory_id = id;
            newRow.EndEdit();

            invenFeeBindingSource.Position = 0;

            // remove nó đi
            iNVENTORYBindingSource.RemoveCurrent();

            // enable nút
            calculateFee();
        }

        private void removeInventoryBtn_Click(object sender, EventArgs e)
        {
            removeCurrentInventoryFee();
        }

        private void removeCurrentInventoryFee()
        {
            if (invenFeeBindingSource.Current == null || inventoryFeeDataGridView.RowCount <= 0)
                return;

            invenFeeBindingSource.RemoveCurrent();

            // fill lại, remove mấy cái có trong list rồi
            iNVENTORYTableAdapter.Fill(sellManagementDbDataSet.INVENTORY);
            var rowsAdded = sellManagementDbDataSet.InvenFee.Select(r => r.Inventory_id);

            if (rowsAdded.Count() > 0)
            {
                for (int i = 0; i < iNVENTORYBindingSource.Count; i++)
                {
                    var row = ((iNVENTORYBindingSource[i] as DataRowView).Row as SellManagementDbDataSet.INVENTORYRow);
                    if (rowsAdded.Contains(row.Id))
                    {
                        iNVENTORYBindingSource.RemoveAt(i);
                        i--;
                    }
                }
            }

            // check nút
            calculateFee();
        }

        private void addNewStaffFee()
        {
            if (staffGridView.RowCount <= 0 || staffGridView.SelectedRows.Count <= 0)
                return;

            var id = (int)staffGridView.SelectedRows[0].Cells[staffIdColumn.Index].Value;
            var fee = (double)staffGridView.SelectedRows[0].Cells[salaryDataGridViewTextBoxColumn.Index].Value;

            var newRow = (staffFeeBindingSource.AddNew() as DataRowView).Row as SellManagementDbDataSet.StaffFeeRow;
            var curId = (businessFeeBindingSource.Current as DataRowView).Row as SellManagementDbDataSet.BusinessFeeRow;

            newRow.BeginEdit();
            newRow.BusinessFee_Id = curId.Id;
            newRow.Fee = fee;
            newRow.Staff_Id = id;
            newRow.EndEdit();

            staffFeeBindingSource.Position = 0;

            // remove nó đi
            sTAFFBindingSource1.RemoveCurrent();

            // enable nút
            calculateFee();
        }

        private void removeCurrentStaffFee()
        {
            if (staffFeeBindingSource.Current == null || staffFeeGridView.RowCount <= 0)
                return;

            staffFeeBindingSource.RemoveCurrent();

            // fill lại, remove mấy cái có trong list rồi
            sTAFFTableAdapter.Fill(sellManagementDbDataSet.STAFF);
            var rowsAdded = sellManagementDbDataSet.StaffFee.Select(r => r.Staff_Id);

            if (rowsAdded.Count() > 0)
            {
                for (int i = 0; i < sTAFFBindingSource1.Count; i++)
                {
                    var row = ((sTAFFBindingSource1[i] as DataRowView).Row as SellManagementDbDataSet.STAFFRow);
                    if (rowsAdded.Contains(row.Id))
                    {
                        sTAFFBindingSource1.RemoveAt(i);
                        i--;
                    }
                }
            }

            calculateFee();
        }

        private void addStaffBtn_Click(object sender, EventArgs e)
        {
            addNewStaffFee();
        }

        private void removeStaffBtn_Click(object sender, EventArgs e)
        {
            removeCurrentStaffFee();
        }

        private void calculateFee()
        {
            double totalFee = 0;

            // nút staff
            if (staffFeeGridView.RowCount <= 0)
            {
                removeStaffBtn.Enabled = false;
                totalStaffLabel.Text = "Tổng số nhân viên: 0";
                staffFeeText.Text = "0.00";
            }
            else
            {
                removeStaffBtn.Enabled = true;
                totalStaffLabel.Text = "Tổng số nhân viên: " + staffFeeGridView.RowCount;

                // tính fee
                double sum = 0;
                foreach (DataGridViewRow item in staffFeeGridView.Rows)
                {
                    sum += (double)item.Cells[feeDataGridViewTextBoxColumn2.Index].Value;
                }

                totalFee += sum;
                staffFeeText.Text = string.Format(Resources.CurrencyFormat, sum);
            }

            if (staffGridView.RowCount <= 0)
                addStaffBtn.Enabled = false;
            else
                addStaffBtn.Enabled = true;

            // nút inventory
            if (inventoryFeeDataGridView.RowCount <= 0)
            {
                removeInventoryBtn.Enabled = false;
                totalInvenLabel.Text = "Tổng số kho hàng : 0";
                inventoryFeeText.Text = "0.00";
            }
            else
            {
                removeInventoryBtn.Enabled = true;
                totalInvenLabel.Text = "Tổng số kho hàng : " + inventoryFeeDataGridView.RowCount;

                // tính fee
                double sum = 0;
                foreach (DataGridViewRow item in inventoryFeeDataGridView.Rows)
                {
                    sum += (double)item.Cells[feeDataGridViewTextBoxColumn1.Index].Value;
                }

                totalFee += sum;
                inventoryFeeText.Text = string.Format(Resources.CurrencyFormat, sum);
            }

            if (inventoryDataGridView.RowCount <= 0)
                addInventoryBtn.Enabled = false;
            else
                addInventoryBtn.Enabled = true;

            // nút in out
            if (dataGridView2.RowCount <= 0)
            {
                removeInOutBtn.Enabled = false;
                totalInOutLabel.Text = "Tổng số đơn hàng: 0";
                inoutFeeText.Text = "0.00";
            }
            else
            {
                removeInOutBtn.Enabled = true;
                totalInOutLabel.Text = "Tổng số đơn hàng: " + dataGridView2.RowCount;

                // tính fee
                double sum = 0;
                foreach (DataGridViewRow item in dataGridView2.Rows)
                {
                    sum += (double)item.Cells[feeDataGridViewTextBoxColumn.Index].Value;
                }

                totalFee += sum;
                inoutFeeText.Text = string.Format(Resources.CurrencyFormat, sum);
            }

            if (dataGridView1.RowCount <= 0)
                addInOutBtn.Enabled = false;
            else
                addInOutBtn.Enabled = true;

            // total fee
            totalFeeText.Text = string.Format(Resources.CurrencyFormat, totalFee);
        }

        private void dataGridView2_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
             MessageBox.Show(Resources.InvalidValueMessage + "\n\nChi tiết: " + e.Exception.Message, Resources.ErrorMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            calculateFee();
        }
    }
}
