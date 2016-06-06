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
    public partial class CreateVendorOrderForm : Form
    {
        public int OrderId { get; set; }
        public string DocumentKey { get; set; }

        public CreateVendorOrderForm()
        {
            InitializeComponent();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            createVendorOrder();
            this.Close();
            DialogResult = DialogResult.OK;
        }

        private void CreateVendorOrderForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sellManagementDbDataSet.STAFF' table. You can move, or remove it, as needed.
            this.sTAFFTableAdapter.Fill(this.sellManagementDbDataSet.STAFF);
            // TODO: This line of code loads data into the 'sellManagementDbDataSet.VENDOR' table. You can move, or remove it, as needed.
            this.vENDORTableAdapter.Fill(this.sellManagementDbDataSet.VENDOR);

            this.documentTableAdapter.Fill(this.sellManagementDbDataSet.DOCUMENT);

            // tạo vendor document order key
            documentKeyText.Text = generateDocumentKey();
        }

        private string generateDocumentKey()
        {
            int max = 0;

            foreach (DataRow item in sellManagementDbDataSet.DOCUMENT.Where(c => c.DocumentKey.Substring(0, 3) == "VO_"))
            {
                var value = item["DocumentKey"].ToString().TrimStart(new char[] { 'V', 'O', '_' });
                max = Math.Max(max, Convert.ToInt32(value));
            }

            return "VO_" + String.Format("{0:D6}", max + 1);
        }

        private void createVendorOrder()
        {
            try
            {
                queriesTableAdapter.Insert_Vendor_Order(documentKeyText.Text,
                                                    (int)staffComboBox.SelectedValue,
                                                    createDatePicker.Value,
                                                    transactionPicker.Value,
                                                    (int)customerComboBox.SelectedValue,
                                                    transactionPicker.Value);

                documentTableAdapter.Fill(sellManagementDbDataSet.DOCUMENT);

                var doc = sellManagementDbDataSet.DOCUMENT.Where(d => d.DocumentKey == documentKeyText.Text);

                if (doc.Count() > 0)
                {
                    OrderId = doc.First().Id;
                    DocumentKey = doc.First().DocumentKey;
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Tạo đơn hàng không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            DialogResult = DialogResult.Cancel;
        }

        private void createVendorBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            DialogResult = DialogResult.Retry;
        }
    }
}
