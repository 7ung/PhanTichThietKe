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
    public partial class AddInoutInventory : Form
    {
        private bool _isAddNew = true;

        public bool IsImport { get; set; }
        public int DocumentId { get; set; }

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
                documentKeyTextBox.Text = generateDocumentKey(isInCheckBox.Checked);

                // check
                isInCheckBox.Checked = IsImport;
            }
            else
            {
                // TODO: This line of code loads data into the 'sellManagementDbDataSet.INOUT_INVENTORY_DETAIL' table. You can move, or remove it, as needed.
                this.iNOUT_INVENTORY_DETAILTableAdapter.Fill(this.sellManagementDbDataSet.INOUT_INVENTORY_DETAIL);
                // TODO: This line of code loads data into the 'sellManagementDbDataSet.INOUTINVENTORY' table. You can move, or remove it, as needed.
                this.iNOUTINVENTORYTableAdapter.Fill(this.sellManagementDbDataSet.INOUTINVENTORY);

                SelectById(this.DocumentId);
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
        }

        private void updateControls()
        {
            if(_isAddNew)
            {
                createBtn.Text = "Tạo";
                this.Text = "Tạo đơn nhập xuất";
            }
            else
            {
                createBtn.Text = "Lưu";
                this.Text = "Chỉnh sửa đơn " + documentKeyTextBox.Text;
            }
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

        private void SelectDocumentBindToComboBox(bool isIn)
        {
            // lọc document là order
            var prefix = "CO";
            if (isIn)
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

            //oRDERDETAILBindingSource.Filter = "Order_id = " + listBox1.SelectedValue;
        }

        private string generateDocumentKey(bool isIn)
        {
            int max = 0;
            string prefix = "OUT";
            if (isIn)
                prefix = "IN";

            foreach (DataRow item in sellManagementDbDataSet.DOCUMENT.Where(c => c.DocumentKey.Substring(0, prefix.Length) == prefix))
            {
                var value = item["DocumentKey"].ToString().TrimStart(prefix.ToArray());
                max = Math.Max(max, Convert.ToInt32(value));
            }

            return prefix + String.Format("{0:D6}", max + 1);
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

            // generate key
            if (_isAddNew)
                documentKeyTextBox.Text = generateDocumentKey(checkbox.Checked);

            // get lại đơn hàng
            SelectDocumentBindToComboBox(checkbox.Checked);
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
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra rồi rồi. \n\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
        }

        private void createInOutInventory()
        {
            try
            {
                queriesTableAdapter.Insert_InoutInventory(documentKeyTextBox.Text, 
                    (int)creatorComboBox.SelectedValue,
                    createDateDateTimePicker.Value,
                    (int)respondComboBox.SelectedValue,
                    (int)inventoryComboBox.SelectedValue,
                    Convert.ToDouble(carryFeeTextBox.Text),
                    (int)termNumericUpDown.Value,
                    isInCheckBox.Checked);

                // update detail
                dOCUMENTTableAdapter.Fill(sellManagementDbDataSet.DOCUMENT);
                var resultDoc = sellManagementDbDataSet.DOCUMENT.Where(d => d.DocumentKey == documentKeyTextBox.Text);

                if (resultDoc.Count() == 0)
                    throw new Exception("Không tạo được chi đơn hàng. :(");

                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    item.Cells["inOutInventoryidColumn"].Value = resultDoc.First().Id;
                }

                // save
                iNOUTINVENTORYDETAILBindingSource.EndEdit();
                iNOUT_INVENTORY_DETAILTableAdapter.Update(sellManagementDbDataSet.INOUT_INVENTORY_DETAIL);
                sellManagementDbDataSet.INOUT_INVENTORY_DETAIL.AcceptChanges();

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra rồi rồi. \n\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void carryFeeTextBox_xTextChanged(object sender, EventArgs e)
        {
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
    }
}
