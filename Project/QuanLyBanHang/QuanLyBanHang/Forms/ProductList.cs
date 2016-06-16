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
using QuanLyBanHang.Properties;

namespace QuanLyBanHang.Forms
{
    public partial class ProductList : UserControl
    {
        //Init
        public ProductList()
        {
            InitializeComponent();

            pRODUCTTableAdapter.Fill(sellManagementDbDataSet.PRODUCT);
            pRODUCT_METADATATableAdapter.Fill(sellManagementDbDataSet.PRODUCT_METADATA);

            ordeR_DETAILTableAdapter.Fill(sellManagementDbDataSet.ORDER_DETAIL);
            inventorY_CAPABILITYTableAdapter.Fill(sellManagementDbDataSet.INVENTORY_CAPABILITY);

            this.tbBarCode.ReadOnly = true;
            this.tbInPrice.ReadOnly = true;
            this.tbName.ReadOnly = true;
            this.tbOurPrice.ReadOnly = true;
            this.tbProductKey.ReadOnly = true;
            this.btnAdd.Click += btAdd_Click;
            this.btnAdd.Click += showDialogAddProduct;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            (new AddProduct()).ShowDialog();
            
        }

        public void showDialogAddProduct(object sender, EventArgs e)
        {
            this.pRODUCT_METADATATableAdapter.Fill(sellManagementDbDataSet.PRODUCT_METADATA);
            this.pRODUCT_METADATABindingSource.ResetBindings(true);
            //this.pRODUCT_METADATADataGridView.Refresh();

            this.pRODUCTTableAdapter.Fill(sellManagementDbDataSet.PRODUCT);
            this.pRODUCTBindingSource.ResetBindings(false);

            
        }


        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            pRODUCTBindingSource.Filter = pRODUCTDataGridView.Columns["dataGridViewTextBoxColumn2"].DataPropertyName.ToString() + " LIKE '%" + tbSearch.Text + "%'" + "OR " +
                                               pRODUCTDataGridView.Columns["dataGridViewTextBoxColumn3"].DataPropertyName.ToString() + " LIKE '%" + tbSearch.Text + "%'" + "OR " +
                                               pRODUCTDataGridView.Columns["dataGridViewTextBoxColumn4"].DataPropertyName.ToString() + " LIKE '%" + tbSearch.Text + "%'";
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            var tab = this.Parent as TabPage;
            if (tab != null)
            {
                ((tab.Parent as TabControl).FindForm() as Main).remove_refresh(showDialogAddProduct);
                (tab.Parent as TabControl).TabPages.Remove(tab);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                try
                {
                    DataRowView row = (DataRowView)this.pRODUCTBindingSource.CurrencyManager.Current;
                    int curId = (int)row.Row["Id"];

                    // check coi có trong đơn hàng hay kho ko -_-
                    var listInven = sellManagementDbDataSet.INVENTORY_CAPABILITY.Where(p => p.Product_id == curId);
                    if(listInven.Count() > 0)
                    {
                        throw new Exception("Sản phẩm đang được dùng trong kho.");
                    }

                    var listOrder = sellManagementDbDataSet.ORDER_DETAIL.Where(p => p.Product_id == curId);
                    if (listOrder.Count() > 0)
                    {
                        throw new Exception("Sản phẩm đang được dùng trong đơn hàng.");
                    }

                    // xóa mấy cái meta đi -_-
                    var listmeta = sellManagementDbDataSet.PRODUCT_METADATA.Where(p => p.Product_id == curId);
                    foreach (var item in listmeta)
                    {
                        item.Delete();
                    }

                    pRODUCT_METADATABindingSource.EndEdit();
                    pRODUCT_METADATATableAdapter.Update(sellManagementDbDataSet.PRODUCT_METADATA);
                    sellManagementDbDataSet.PRODUCT_METADATA.AcceptChanges();

                    row.Delete();

                    this.pRODUCTBindingSource.EndEdit();
                    this.pRODUCTTableAdapter.Update(sellManagementDbDataSet.PRODUCT);
                    this.sellManagementDbDataSet.PRODUCT.AcceptChanges();

                }
                catch (System.Data.SqlClient.SqlException sqlex)
                {
                    MessageBox.Show("Sản phẩm đang được dùng.", "Không thể xóa!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    this.pRODUCT_METADATATableAdapter.Fill(sellManagementDbDataSet.PRODUCT_METADATA);
                    this.pRODUCTTableAdapter.Fill(sellManagementDbDataSet.PRODUCT);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Chi tiết: " + ex.Message, "Không thể xóa!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.pRODUCT_METADATATableAdapter.Fill(sellManagementDbDataSet.PRODUCT_METADATA);
                    this.pRODUCTTableAdapter.Fill(sellManagementDbDataSet.PRODUCT);
                }
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            int id = ((this.pRODUCTBindingSource.CurrencyManager.Current as DataRowView).Row as SellManagementDbDataSet.PRODUCTRow).Id;
            (new AddProduct(id)).ShowDialog();

            this.pRODUCT_METADATATableAdapter.Fill(sellManagementDbDataSet.PRODUCT_METADATA);
            this.pRODUCT_METADATABindingSource.ResetBindings(true);
            //this.pRODUCT_METADATADataGridView.Refresh();

            this.pRODUCTTableAdapter.Fill(sellManagementDbDataSet.PRODUCT);
            this.pRODUCTBindingSource.ResetBindings(false);
        }

        private void ProductList_Load(object sender, EventArgs e)
        {
            
        }

        private void pRODUCTDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (this.pRODUCTBindingSource.Count <= 0)
                return;

            int id = ((this.pRODUCTBindingSource.CurrencyManager.Current as DataRowView).Row as SellManagementDbDataSet.PRODUCTRow).Id;

            // bind
            var typeRow = sellManagementDbDataSet.PRODUCT_METADATA.Where(p => (p.Product_id == id && p.Key == Resources.ProductTypeKey)).Select(p => p.Value);

            if (typeRow.Count() > 0)
                typeText.Text = typeRow.First();
            else
                typeText.Text = Resources.NoValueText;

            var brandRow = sellManagementDbDataSet.PRODUCT_METADATA.Where(p => (p.Product_id == id && p.Key == Resources.ProductBrandKey)).Select(p => p.Value);

            if (brandRow.Count() > 0)
                brandText.Text = brandRow.First();
            else
                brandText.Text = Resources.NoValueText;

            var unitRow = sellManagementDbDataSet.PRODUCT_METADATA.Where(p => (p.Product_id == id && p.Key == Resources.ProductUnitKey)).Select(p => p.Value);

            if (unitRow.Count() > 0)
                unitText.Text = unitRow.First();
            else
                unitText.Text = Resources.NoValueText;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
