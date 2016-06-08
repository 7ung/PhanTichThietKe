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
    public partial class ProductList : UserControl
    {
        //Init
        public ProductList()
        {
            InitializeComponent();

            pRODUCTTableAdapter.Fill(sellManagementDbDataSet.PRODUCT);
            pRODUCT_METADATATableAdapter.Fill(sellManagementDbDataSet.PRODUCT_METADATA);

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
                    row.Delete();

                    this.pRODUCTBindingSource.EndEdit();
                    this.pRODUCTTableAdapter.Update(sellManagementDbDataSet.PRODUCT);
                    this.sellManagementDbDataSet.PRODUCT.AcceptChanges();

                }
                catch (System.Data.SqlClient.SqlException sqlex)
                {
                    MessageBox.Show("Khong the xoa!" + sqlex.Message, "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa thất bại! - " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            int id = ((this.pRODUCTBindingSource.CurrencyManager.Current as DataRowView).Row as SellManagementDbDataSet.PRODUCTRow).Id - 1;
            (new AddProduct(id)).ShowDialog();

            this.pRODUCT_METADATATableAdapter.Fill(sellManagementDbDataSet.PRODUCT_METADATA);
            this.pRODUCT_METADATABindingSource.ResetBindings(true);
            //this.pRODUCT_METADATADataGridView.Refresh();

            this.pRODUCTTableAdapter.Fill(sellManagementDbDataSet.PRODUCT);
            this.pRODUCTBindingSource.ResetBindings(false);
        }
    }
}
