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
    public partial class SelectProductForm : Form
    {
        public int OrderId { get; set; }

        public SellManagementDbDataSet.ORDER_DETAILRow ResultOrderDetailRow { get; set; } 

        public SelectProductForm()
        {
            InitializeComponent();
        }

        public SelectProductForm(int orderId)
        {
            OrderId = orderId;

            InitializeComponent();
        }

        private void SelectProductForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sellManagementDbDataSet.INVENTORY_CAPABILITY' table. You can move, or remove it, as needed.
            this.iNVENTORY_CAPABILITYTableAdapter.Fill(this.sellManagementDbDataSet.INVENTORY_CAPABILITY);
            // TODO: This line of code loads data into the 'sellManagementDbDataSet.PRODUCT' table. You can move, or remove it, as needed.
            this.pRODUCTTableAdapter.Fill(this.sellManagementDbDataSet.PRODUCT);

            // FORMAT
            outPriceColumn.DefaultCellStyle.Format = "N2";
        }

        private void SelectOrderById(int id)
        {
            
        }

        private void searchText_TextChanged(object sender, EventArgs e)
        {
            pRODUCTBindingSource.Filter = productDataGridView.Columns["ProductKey"].DataPropertyName.ToString() + " LIKE '%" + searchText.Text + "%'" + "OR " +
                                    productDataGridView.Columns["nameColumn"].DataPropertyName.ToString() + " LIKE '%" + searchText.Text + "%'";

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

            var current = (pRODUCTBindingSource.Current as DataRowView).Row as SellManagementDbDataSet.PRODUCTRow;

            this.ResultOrderDetailRow = sellManagementDbDataSet.ORDER_DETAIL.NewORDER_DETAILRow();

            ResultOrderDetailRow.BeginEdit();

            ResultOrderDetailRow.Order_id = OrderId;
            ResultOrderDetailRow.Product_id = current.Id;
            ResultOrderDetailRow.Quantity = Convert.ToInt32(productQuantityText.Text);
            ResultOrderDetailRow.Price = current.OutPrice;
            ResultOrderDetailRow.Result = ResultOrderDetailRow.Quantity * ResultOrderDetailRow.Price;

            ResultOrderDetailRow.EndEdit();

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
