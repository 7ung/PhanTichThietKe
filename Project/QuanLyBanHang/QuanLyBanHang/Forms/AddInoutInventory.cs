using QuanLyBanHang.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang.Forms
{
    public partial class AddInoutInventory : Form
    {
        private bool _isAddNew = true;
        private bool _canClearList = false;
        private string _currentDocumentKey = "";

        public bool IsImport { get; set; }
        public int DocumentId { get; set; }

        public int InventoryId { get; set; }

        public AddInoutInventory()
        {
            InitializeComponent();

            IsImport = false;
        }

        public AddInoutInventory(bool isImport)
        {
            InitializeComponent();

            IsImport = isImport;
        }


        public AddInoutInventory(int documentId)
        {
            InitializeComponent();

            DocumentId = documentId;
            _isAddNew = false;
        }

        private void AddInoutInventory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sellManagementDbDataSet.INVENTORY_CAPABILITY' table. You can move, or remove it, as needed.
            this.iNVENTORY_CAPABILITYTableAdapter.Fill(this.sellManagementDbDataSet.INVENTORY_CAPABILITY);
            // TODO: This line of code loads data into the 'sellManagementDbDataSet.INVENTORY' table. You can move, or remove it, as needed.
            this.iNVENTORYTableAdapter.Fill(this.sellManagementDbDataSet.INVENTORY);
            // TODO: This line of code loads data into the 'sellManagementDbDataSet.STAFF' table. You can move, or remove it, as needed.
            this.sTAFFTableAdapter.Fill(this.sellManagementDbDataSet.STAFF);
            // TODO: This line of code loads data into the 'sellManagementDbDataSet.DOCUMENT' table. You can move, or remove it, as needed.
            this.dOCUMENTTableAdapter.Fill(this.sellManagementDbDataSet.DOCUMENT);
            // TODO: This line of code loads data into the 'sellManagementDbDataSet.PRODUCT' table. You can move, or remove it, as needed.
            this.pRODUCTTableAdapter.Fill(this.sellManagementDbDataSet.PRODUCT);
            // TODO: This line of code loads data into the 'sellManagementDbDataSet.ORDER_DETAIL' table. You can move, or remove it, as needed.
            this.oRDER_DETAILTableAdapter.Fill(this.sellManagementDbDataSet.ORDER_DETAIL);


            if (_isAddNew)
            {
                RemoveBindingControls();

                // check
                isInCheckBox.Checked = IsImport;

                documentKeyTextBox.Text = generateDocumentKey(isInCheckBox.Checked);
                carryFeeTextBox.Text = "0";
            }
            else
            {
                // TODO: This line of code loads data into the 'sellManagementDbDataSet.INOUT_INVENTORY_DETAIL' table. You can move, or remove it, as needed.
                this.iNOUT_INVENTORY_DETAILTableAdapter.Fill(this.sellManagementDbDataSet.INOUT_INVENTORY_DETAIL);
                // TODO: This line of code loads data into the 'sellManagementDbDataSet.INOUTINVENTORY' table. You can move, or remove it, as needed.
                this.iNOUTINVENTORYTableAdapter.Fill(this.sellManagementDbDataSet.INOUTINVENTORY);

                SelectById(this.DocumentId);

                InventoryId = (int)inventoryComboBox.SelectedValue;
            }

            SelectDocumentBindToComboBox(isInCheckBox.Checked);

            if (isInCheckBox.Checked == false)
            {
                isInCheckBox.BackColor = Color.FromArgb(255, 153, 51);
                isInCheckBox.Text = "Xuất hàng";
                isInCheckBox.TextAlign = ContentAlignment.MiddleRight;
            }
            else
            {
                isInCheckBox.BackColor = Color.FromArgb(153, 204, 255);
                isInCheckBox.Text = "Nhập hàng";
                isInCheckBox.TextAlign = ContentAlignment.MiddleLeft;
            }

            updateControls();

            // load xong hết thì mới có thể xóa list
            _canClearList = true;
        }

        private void updateControls()
        {
            iNVENTORYBindingSource.Filter = "Id = " + InventoryId;
            iNVENTORYCAPABILITYBindingSource.Filter = "Inventory_id = " + InventoryId;

            var current = (iNVENTORYBindingSource.Current as DataRowView).Row as SellManagementDbDataSet.INVENTORYRow;
            var text = "xuất";
            if(isInCheckBox.Checked)
                text = "nhập";

            if (_isAddNew)
            {
                createBtn.Text = "Tạo";
                this.Text = "Tạo đơn " + text + " hàng | Kho " + current.Name;
            }
            else
            {
                createBtn.Text = "Lưu";
                this.Text = "Chỉnh sửa đơn " + documentKeyTextBox.Text + " | Kho " + current.Name;
            }
            
        }

        private void RemoveBindingControls()
        {
            documentKeyTextBox.DataBindings.Clear();
            createDateDateTimePicker.DataBindings.Clear();
            creatorComboBox.DataBindings.Clear();
        }

        private void SelectById(int id)
        {
            documentBindingSourceForEdit.Filter = "Id = " + id;

            var curRow = (documentBindingSourceForEdit.Current as DataRowView).Row as SellManagementDbDataSet.DOCUMENTRow;
            if (curRow == null)
                return;

            iNOUTINVENTORYDETAILBindingSource.Filter = "InOutInventory_id = " + curRow.Id;
            iNOUTINVENTORYBindingSource.Filter = "Id = " + curRow.Id;
        }

        private void SelectDocumentBindToComboBox(bool isImport)
        {
            // lọc document là order
            var prefix = "CO";
            if (isImport)
                prefix = "VO";

            var doc = sellManagementDbDataSet.DOCUMENT.Where(d => (d.DocumentKey.Substring(0,2).Contains(prefix))).ToList();

            SellManagementDbDataSet.INOUT_INVENTORY_DETAILDataTable tempTable = new SellManagementDbDataSet.INOUT_INVENTORY_DETAILDataTable();
            iNOUT_INVENTORY_DETAILTableAdapter.Fill(tempTable);
            var orderIds = tempTable.Select(o => o.Order_id);
            
            for (int i = 0; i < doc.Count; i++)
            {
                var item = doc[i];

                if (orderIds.Contains(item.Id))
                {
                    doc.Remove(item);
                    i--;
                }
            }
            
            listBox1.DataSource = doc;
            listBox1.DisplayMember = "DocumentKey";
            listBox1.ValueMember = "Id";

            if(listBox1.SelectedValue != null)
                oRDERDETAILBindingSource.Filter = "Order_id = " + listBox1.SelectedValue;
            else
            {
                oRDERDETAILBindingSource.Filter = "Order_id = -1";
            }

            if (doc.Count == 0)
                addOrderBtn.Enabled = false;
            else
                addOrderBtn.Enabled = true;

            if (dataGridView1.Rows.Count > 0)
                removeOrderBtn.Enabled = true;
            else
                removeOrderBtn.Enabled = false;
        }

        private string generateDocumentKey(bool isImport)
        {
            int max = 0;
            string prefix = "OUT";
            if (isImport)
                prefix = "IN";

            foreach (DataRow item in sellManagementDbDataSet.DOCUMENT.Where(c => c.DocumentKey.Substring(0, prefix.Length) == prefix))
            {
                var value = item["DocumentKey"].ToString().TrimStart(prefix.ToArray());
                max = Math.Max(max, Convert.ToInt32(value));
            }

            _currentDocumentKey = prefix + String.Format("{0:D6}", max + 1);

            return _currentDocumentKey;
        }

        private void iNOUTINVENTORYDETAILBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                var curRow = (iNOUTINVENTORYDETAILBindingSource.Current as DataRowView).Row as SellManagementDbDataSet.INOUT_INVENTORY_DETAILRow;
                if (curRow == null)
                    return;

                oRDERDETAILBindingSource.Filter = "Id = " + curRow.Order_id;
            }
            catch (Exception)
            {
                
            }
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedValue == null)
                return;

            try
            {
                oRDERDETAILBindingSource.Filter = "Order_id = " + listBox1.SelectedValue;
            }
            catch (Exception)
            {

            }
        }

        private void listBox1_SizeChanged(object sender, EventArgs e)
        {
            dataGridView2.Size = new Size(dataGridView2.Size.Width, listBox1.Size.Height);
            dataGridView1.Size = new Size(dataGridView1.Size.Width, listBox1.Size.Height);
        }

        private void addOrderBtn_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedValue == null)
                return;

            addNewInOutDetailRow((int)listBox1.SelectedValue);
            updateLabels();
        }

        private void addNewInOutDetailRow(int orderId)
        {
            var newRow = (iNOUTINVENTORYDETAILBindingSource.AddNew() as DataRowView).Row as SellManagementDbDataSet.INOUT_INVENTORY_DETAILRow;

            newRow.BeginEdit();
            newRow.Order_id = orderId;
            if (_isAddNew)
                newRow.InOutInventory_id = 0; // tạm
            else
                newRow.InOutInventory_id = this.DocumentId;
            newRow.EndEdit();

            iNOUTINVENTORYDETAILBindingSource.Position = -1;
            dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells["detailBtn"].Value = "Xem";
            
            // xóa order ra khỏi list
            var x = (listBox1.DataSource as List<SellManagementDbDataSet.DOCUMENTRow>);
            x.RemoveAt(listBox1.SelectedIndex);

            // bind lại
            listBox1.DataSource = null;
            listBox1.DataSource = x;
            listBox1.DisplayMember = "DocumentKey";
            listBox1.ValueMember = "Id";

            if (x.Count == 0)
                addOrderBtn.Enabled = false;

            if (!removeOrderBtn.Enabled)
                removeOrderBtn.Enabled = true;
        }

        private void removeCurrentRow()
        {
            try
            {
                var current = (iNOUTINVENTORYDETAILBindingSource.Current as DataRowView).Row as SellManagementDbDataSet.INOUT_INVENTORY_DETAILRow;
                if (current == null)
                    return;
                
                int id = (int)current["Order_id"];
                iNOUTINVENTORYDETAILBindingSource.RemoveCurrent();

                var removedDocRow = sellManagementDbDataSet.DOCUMENT.Where(d => d.Id == id);
                if (removedDocRow.Count() == 0)
                    return;

                // xóa order ra khỏi list
                var x = (listBox1.DataSource as List<SellManagementDbDataSet.DOCUMENTRow>);
                x.Add(removedDocRow.First());

                // bind lại
                listBox1.DataSource = null;
                listBox1.DataSource = x;
                listBox1.DisplayMember = "DocumentKey";
                listBox1.ValueMember = "Id";

                //
                if (dataGridView1.Rows.Count == 0)
                    removeOrderBtn.Enabled = false;

                if (!addOrderBtn.Enabled)
                    addOrderBtn.Enabled = true;
            }
            catch (Exception)
            {
                // hihi
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                var current = (iNOUTINVENTORYDETAILBindingSource.Current as DataRowView).Row as SellManagementDbDataSet.INOUT_INVENTORY_DETAILRow;
                if (current == null)
                    return;

                oRDERDETAILBindingSource.Filter = "Order_id = " + current["Order_id"];
            }
            catch (Exception)
            {
                // hihi
            }
        }

        private void removeOrderBtn_Click(object sender, EventArgs e)
        {
            removeCurrentRow();
            updateLabels();
        }

        private void updateLabels()
        {
            totalOrderLabel.Text = String.Format("Số đơn hàng: {0}", dataGridView1.Rows.Count);

            //int sum = 0;
            //foreach (DataGridViewRow item in dataGridView1.Rows)
            //{
            //    sum += (int)item.Cells[""].Value;
            //}
            //totalProductLabel.Text = String.Format("Tổng hóa đơn: {0}");
        }

        private void inOutTypeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            var checkbox = sender as CheckBox;
            if (checkbox.Checked == false)
            {
                checkbox.BackColor = Color.FromArgb(255, 153, 51);
                checkbox.Text = "Xuất hàng";
                checkbox.TextAlign = ContentAlignment.MiddleRight;
            }
            else
            {
                checkbox.BackColor = Color.FromArgb(153, 204, 255);
                checkbox.Text = "Nhập hàng";
                checkbox.TextAlign = ContentAlignment.MiddleLeft;
            }

            if (_canClearList)
                clearDetailOrdersList();
                

            // get lại đơn hàng
            SelectDocumentBindToComboBox(checkbox.Checked);
        }

        private void clearDetailOrdersList()
        {
            if (_isAddNew)
            {
                // generate key
                documentKeyTextBox.Text = generateDocumentKey(isInCheckBox.Checked);

                if (dataGridView1.Rows.Count > 0)
                {
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        if ((int)dataGridView1.Rows[i].Cells["inOutInventoryidColumn"].Value == 0)
                        {
                            dataGridView1.Rows.RemoveAt(i);
                            i--;
                        }
                    }
                }
            }
            else
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        if ((int)dataGridView1.Rows[i].Cells["inOutInventoryidColumn"].Value == this.DocumentId)
                        {
                            dataGridView1.Rows.RemoveAt(i);
                            i--;
                        }
                    }
                }
            }
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            if (_isAddNew)
            {
                createInOutInventory();
            }
            else
            {
                saveData();
            }
        }

        private void saveData()
        {
            try
            {
                documentBindingSourceForEdit.EndEdit();
                dOCUMENTTableAdapter.Update(sellManagementDbDataSet.DOCUMENT);
                sellManagementDbDataSet.DOCUMENT.AcceptChanges();

                iNOUTINVENTORYBindingSource.EndEdit();
                iNOUTINVENTORYTableAdapter.Update(sellManagementDbDataSet.INOUTINVENTORY);
                sellManagementDbDataSet.INOUTINVENTORY.AcceptChanges();

                iNOUTINVENTORYDETAILBindingSource.EndEdit();
                iNOUT_INVENTORY_DETAILTableAdapter.Update(sellManagementDbDataSet.INOUT_INVENTORY_DETAIL);
                sellManagementDbDataSet.INOUT_INVENTORY_DETAIL.AcceptChanges();
                
                this.Close();
            }
            catch (SqlException ex)
            {
                SQLExceptionHandler(ex);

                // fill lại
                iNOUT_INVENTORY_DETAILTableAdapter.Fill(sellManagementDbDataSet.INOUT_INVENTORY_DETAIL);
                iNOUTINVENTORYTableAdapter.Fill(sellManagementDbDataSet.INOUTINVENTORY);
                dOCUMENTTableAdapter.Fill(sellManagementDbDataSet.DOCUMENT);

                // bind lại
                SelectDocumentBindToComboBox(isInCheckBox.Checked);

                updateLabels();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra. \n\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                return;
            }
        }

        private void createInOutInventory()
        {
            int docId = -1;

            try
            {
                var current = (iNVENTORYBindingSource.Current as DataRowView).Row as SellManagementDbDataSet.INVENTORYRow;

                queriesTableAdapter.Insert_InoutInventory(documentKeyTextBox.Text, 
                    (int)creatorComboBox.SelectedValue,
                    createDateDateTimePicker.Value,
                    (int)respondComboBox.SelectedValue,
                    (int)inventoryComboBox.SelectedValue,
                    Convert.ToDouble(carryFeeTextBox.Text),
                    current.Term,
                    isInCheckBox.Checked);

                // update detail
                dOCUMENTTableAdapter.Fill(sellManagementDbDataSet.DOCUMENT);
                var resultDoc = sellManagementDbDataSet.DOCUMENT.Where(d => d.DocumentKey == _currentDocumentKey);

                if (resultDoc.Count() == 0)
                    throw new Exception("Không tạo được đơn hàng. :(");

                docId = resultDoc.First().Id;

                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    item.Cells["inOutInventoryidColumn"].Value = docId;
                }

                // save
                iNOUTINVENTORYDETAILBindingSource.EndEdit();
                iNOUT_INVENTORY_DETAILTableAdapter.Update(sellManagementDbDataSet.INOUT_INVENTORY_DETAIL);
                sellManagementDbDataSet.INOUT_INVENTORY_DETAIL.AcceptChanges();
                
                this.Close();
            }
            catch(SqlException ex)
            {
                SQLExceptionHandler(ex);

                // xóa cái tạo bị lỗi đi
                if (docId != -1)
                    queriesTableAdapter.Delete_InoutInventory(docId);

                // bind lại
                SelectDocumentBindToComboBox(isInCheckBox.Checked);

                sellManagementDbDataSet.INOUT_INVENTORY_DETAIL.Clear();
                removeOrderBtn.Enabled = false;
                updateLabels();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra. \n\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                return;
            }
        }

        private void SQLExceptionHandler(SqlException ex)
        {
            if(ex.Message.Contains("R19"))
            {
                if(isInCheckBox.Checked)
                    MessageBox.Show("Số lượng sản phẩm nhập vào kho hàng quá sức chứa. \nErrors:\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Không đủ số lượng để xuất hàng. \nErrors:\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

            }
        }

        private void carryFeeTextBox_xTextChanged(object sender, EventArgs e)
        {
            if (carryFeeTextBox.Text == "")
                return;

            try
            {
                var value = Convert.ToDouble(carryFeeTextBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Giá trị không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void inventoryComboBox_TextChanged(object sender, EventArgs e)
        {
            //iNVENTORYBindingSource.Filter = "Name LIKE '%" + inventoryComboBox.Text + "%'";
        }

        private void carryFeeTextBox_Leave(object sender, EventArgs e)
        {
        }
    }
}
