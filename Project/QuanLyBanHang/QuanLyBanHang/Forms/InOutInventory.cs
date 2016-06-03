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

namespace QuanLyBanHang.Forms
{
    public partial class InOutInventory : UserControl, IFormList
    {
        public InOutInventory()
        {
            InitializeComponent();

            this.inOut_Inventory_ViewTableAdapter.FillStaffName(sellManagementDbDataSet.InOut_Inventory_View);
            this.sTAFFTableAdapter.Fill(sellManagementDbDataSet.STAFF);
            this.iNVENTORYTableAdapter.Fill(sellManagementDbDataSet.INVENTORY);
        }



        public eFormState State
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public void updateState(eFormState state)
        {
            throw new NotImplementedException();
        }

        public void enableAllControls(bool enable, bool readOnly)
        {
            throw new NotImplementedException();
        }

        public bool IsValidInformation()
        {
            throw new NotImplementedException();
        }

        private void InOutInventory_Load(object sender, EventArgs e)
        {
            //refresh để checked list loại đơn cập nhật.
            //this.inOut_Inventory_ViewBindingSource.ResetCurrentItem();
            //this.inOutTypeCheckBox.Checked = ((this.inOut_Inventory_ViewBindingSource.CurrencyManager.Current as DataRowView)
            //    .Row as SellManagementDbDataSet.InOut_Inventory_ViewRow).InOutType;

            if (inOutTypeCheckBox.Checked == false)
            {
                inOutTypeCheckBox.BackColor = Color.FromArgb(255, 153, 51);
                inOutTypeCheckBox.Text = "Nhập hàng";
                inOutTypeCheckBox.TextAlign = ContentAlignment.MiddleRight;
            }
            else
            {
                inOutTypeCheckBox.BackColor = Color.FromArgb(153, 204, 255);
                inOutTypeCheckBox.Text = "Xuất hàng";
                inOutTypeCheckBox.TextAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void inOutTypeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            var checkbox = sender as CheckBox;
            if (checkbox.Checked == false)
            {
                checkbox.BackColor = Color.FromArgb(255, 153, 51);
                checkbox.Text = "Nhập hàng";
                checkbox.TextAlign = ContentAlignment.MiddleRight;
            }
            else
            {
                checkbox.BackColor = Color.FromArgb(153, 204, 255);
                checkbox.Text = "Xuất hàng";
                checkbox.TextAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void inOut_Inventory_ViewBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            int id = (((sender as BindingSource).CurrencyManager.Current as DataRowView)
                .Row as SellManagementDbDataSet.InOut_Inventory_ViewRow).Id;
            this.inOutInventory_Detail_ProductQuantity_ViewTableAdapter.FillByInOutId(
                sellManagementDbDataSet.InOutInventory_Detail_ProductQuantity_View, id);
            
        }

    }
}
