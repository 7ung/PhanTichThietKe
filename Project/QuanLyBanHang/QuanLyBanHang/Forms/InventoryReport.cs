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
    public partial class InventoryReport : UserControl
    {
        public InventoryReport()
        {
            InitializeComponent();
        }

        private void InventoryReport_Load(object sender, EventArgs e)
        {
            iNVENTORYTableAdapter.Fill(sellManagementDbDataSet.INVENTORY);
            inventoryCAPABILITYTableAdapter.Fill(sellManagementDbDataSet.INVENTORY_CAPABILITY);
            pRODUCTTableAdapter.Fill(sellManagementDbDataSet.PRODUCT);
        }

        private void iNVENTORYCAPABILITYBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            totalProductLabel.Text = "Số lượng mặt hàng: " + dataGridView1.RowCount;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            var page = this.Parent as TabPage;
            if (page != null)
            {
                (page.Parent as TabControl).TabPages.Remove(page);
            }
        }
    }
}
