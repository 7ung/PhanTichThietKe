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
    public partial class CreateCustomerOrderForm : Form
    {
        public int OrderId { get; set; }

        public CreateCustomerOrderForm()
        {
            InitializeComponent();
        }

        private void CreateCustomerOrderForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sellManagementDbDataSet.CUSTOMER' table. You can move, or remove it, as needed.
            this.cUSTOMERTableAdapter.Fill(this.sellManagementDbDataSet.CUSTOMER);
            // TODO: This line of code loads data into the 'sellManagementDbDataSet.STAFF' table. You can move, or remove it, as needed.
            this.sTAFFTableAdapter.Fill(this.sellManagementDbDataSet.STAFF);

            documentTableAdapter.Fill(sellManagementDbDataSet.DOCUMENT);

            documentKeyText.Text = generateDocumentKey();
        }

        private string generateDocumentKey()
        {
            int max = 0;

            foreach (DataRow item in sellManagementDbDataSet.DOCUMENT.Where(c => c.DocumentKey.Substring(0, 2) == "CO")) 
            {
                var value = item["DocumentKey"].ToString().TrimStart(new char[] {'C', 'O'});
                max = Math.Max(max, Convert.ToInt32(value));
            }

            return "CO" + String.Format("{0:D6}", max + 1);
        }

        private void createCustomerOrder()
        {
            try
            {
                queriesTableAdapter.Insert_Customer_Order(documentKeyText.Text, (int)staffComboBox.SelectedValue, createDatePicker.Value, transactionPicker.Value, (int)customerComboBox.SelectedValue, 0, false, createDatePicker.Value);
                
                documentTableAdapter.Fill(sellManagementDbDataSet.DOCUMENT);

                var doc = sellManagementDbDataSet.DOCUMENT.Where(d => d.DocumentKey == documentKeyText.Text);

                if(doc.Count() > 0)
                    OrderId = doc.First().Id;
                else
                {
                    throw new Exception("Tạo không thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            createCustomerOrder();

            this.Close();
            DialogResult = DialogResult.OK;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            DialogResult = DialogResult.Cancel;
        }
    }
}
