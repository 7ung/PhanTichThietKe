using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang.Forms
{
    public partial class InOutInventoryList : UserControl
    {
        public InOutInventoryList()
        {
            InitializeComponent();
        }

        private void InOutInventoryList_Load(object sender, EventArgs e)
        {
            inOutInventory_Detail_ProductQuantity_ViewTableAdapter.Fill(sellManagementDbDataSet.InOutInventory_Detail_ProductQuantity_View);
            inOut_Inventory_ViewTableAdapter.Fill(sellManagementDbDataSet.InOut_Inventory_View);
            pRODUCTTableAdapter.Fill(sellManagementDbDataSet.PRODUCT);
            sTAFFTableAdapter.Fill(sellManagementDbDataSet.STAFF);
            iNVENTORYTableAdapter.Fill(sellManagementDbDataSet.INVENTORY);
            inouT_INVENTORY_DETAILTableAdapter.Fill(sellManagementDbDataSet.INOUT_INVENTORY_DETAIL);

            if (inOutTypeCheckBox.Checked == false)
            {
                inOutTypeCheckBox.BackColor = Color.FromArgb(255, 153, 51);
                inOutTypeCheckBox.Text = "Xuất hàng";
                inOutTypeCheckBox.TextAlign = ContentAlignment.MiddleRight;
            }
            else
            {
                inOutTypeCheckBox.BackColor = Color.FromArgb(153, 204, 255);
                inOutTypeCheckBox.Text = "Nhập hàng";
                inOutTypeCheckBox.TextAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;
        }

        private void inOutInventoryViewBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (inOutInventoryViewBindingSource.Current == null)
            {
                return;
            }

            var curRow = (inOutInventoryViewBindingSource.Current as DataRowView).Row as SellManagementDbDataSet.InOut_Inventory_ViewRow;

            inOutInventoryDetailProductQuantityViewBindingSource.Filter = "InOutInventory_id = " + curRow.Id;
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
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            var page = this.Parent as TabPage;
            if (page != null)
            {
                (page.Parent as TabControl).TabPages.Remove(page);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            
            var result = MessageBox.Show("Bạn có chắt muốn xóa không?", "Cảnh báo", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                try {
                    var curRow = (inOutInventoryViewBindingSource.Current as DataRowView).Row as SellManagementDbDataSet.InOut_Inventory_ViewRow;

                    // check coi nó có trong cái báo cáo phí ko -_-
                    tranferFeeTableAdapter.Fill(sellManagementDbDataSet.TranferFee);
                    var checkedList = sellManagementDbDataSet.TranferFee.Where(t => t.InoutInventory_Id == curRow.Id);
                    if(checkedList.Count() > 0)
                    {
                        // ơ có thì ếu cho xóa nhé
                        throw new Exception("Đơn hàng này đã nằm trong báo cáo chi phí bán hàng.");
                    }

                    // xóa mấy cái trong detail trước -_-
                    var details = sellManagementDbDataSet.INOUT_INVENTORY_DETAIL.Where(d => d.InOutInventory_id == curRow.Id);
                    foreach (SellManagementDbDataSet.INOUT_INVENTORY_DETAILRow item in details)
                    {
                        // kiểm tra số lượng xóa đi có lố với số lượng hiện tại ko mới xóa
                        // vd: số lượng nhập vô nhiều hơn hiện tại thì xóa trigger nó trả lại làm âm gây ra lỗi
                        // nếu nhập hàng
                        if (curRow.InOutType)
                        {
                            ordeR_DETAILTableAdapter.Fill(sellManagementDbDataSet.ORDER_DETAIL);
                            inventorY_CAPABILITYTableAdapter.Fill(sellManagementDbDataSet.INVENTORY_CAPABILITY);

                            var products = sellManagementDbDataSet.ORDER_DETAIL.Where(o => o.Order_id == item.Order_id);
                            if(products.Count() > 0)
                            {
                                foreach (var product in products)
                                {
                                    var inven = sellManagementDbDataSet.INVENTORY_CAPABILITY.Where(i => i.Inventory_id == curRow.Inventory_id && i.Product_id == product.Product_id);
                                    if (inven.Count() > 0)
                                    {
                                        if (product.Quantity > inven.First().CurrentCount)
                                        {
                                            throw new Exception(String.Format("Số lượng hiện tại còn lại của sản phẩm trong kho hàng ít hơn số lượng trong đơn hàng."));
                                        }
                                    }
                                }
                            }
                        }

                        item.Delete();
                    }

                    inouT_INVENTORY_DETAILTableAdapter.Update(sellManagementDbDataSet.INOUT_INVENTORY_DETAIL);
                    sellManagementDbDataSet.INOUT_INVENTORY_DETAIL.AcceptChanges();

                    queriesTableAdapter.Delete_InoutInventory(curRow.Id);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa không thành công. \n\nChi tiết: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // fill lại nè
                inOut_Inventory_ViewTableAdapter.Fill(sellManagementDbDataSet.InOut_Inventory_View);
                inOutInventory_Detail_ProductQuantity_ViewTableAdapter.Fill(sellManagementDbDataSet.InOutInventory_Detail_ProductQuantity_View);
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (inOutInventoryViewBindingSource.Current == null)
            {
                return;
            }

            var curRow = (inOutInventoryViewBindingSource.Current as DataRowView).Row as SellManagementDbDataSet.InOut_Inventory_ViewRow;

            var editForm = new AddInoutInventory(curRow.Id);
            editForm.ShowDialog();

            // fill lại
            fillData();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            var addForm = new AddInoutInventory(false);
            addForm.ShowDialog();

            // fill lại
            fillData();
        }

        private void fillData()
        {
            // fill lại
            inOutInventory_Detail_ProductQuantity_ViewTableAdapter.Fill(sellManagementDbDataSet.InOutInventory_Detail_ProductQuantity_View);
            inOut_Inventory_ViewTableAdapter.Fill(sellManagementDbDataSet.InOut_Inventory_View);
        }
    }
}
