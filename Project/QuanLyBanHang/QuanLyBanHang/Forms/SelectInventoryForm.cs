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
    public partial class SelectInventoryForm : Form
    {
        public int InventoryId { get; set; }

        public SelectInventoryForm()
        {
            InitializeComponent();
        }

        private void SelectInventoryForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sellManagementDbDataSet.INVENTORY' table. You can move, or remove it, as needed.
            this.iNVENTORYTableAdapter.Fill(this.sellManagementDbDataSet.INVENTORY);

        }

        private void selectBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            DialogResult = DialogResult.OK;

            var current = (iNVENTORYBindingSource.Current as DataRowView).Row as SellManagementDbDataSet.INVENTORYRow;
            InventoryId = current.Id;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            DialogResult = DialogResult.Cancel;
        }
    }
}
