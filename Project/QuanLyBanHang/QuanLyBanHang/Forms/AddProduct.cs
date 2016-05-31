using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanHang.Models;

namespace QuanLyBanHang.Forms
{
    public partial class AddProduct : Form
    {

        // Duong dan toi thu muc chua hinh anh san pham
        const string directoryPath = "Picture\\Product";
        private bool _new = true;
        private int _id = -1;

        public AddProduct()
        {
            InitializeComponent();

            _new = true;
        }


        public AddProduct(int id)
        {
            InitializeComponent();

            this.Text = "Chỉnh sửa thông tin sản phẩm";
            _new = false;
            _id = id;
        }

        //Load
        private void AddProduct_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sellManagementDbDataSet.PRODUCT_METADATA' table. You can move, or remove it, as needed.
            this.pRODUCT_METADATATableAdapter.Fill(this.sellManagementDbDataSet.PRODUCT_METADATA);
            // TODO: This line of code loads data into the 'sellManagementDbDataSet.PRODUCT' table. You can move, or remove it, as needed.
            this.pRODUCTTableAdapter.Fill(this.sellManagementDbDataSet.PRODUCT);

            if (_new)
            {
                this.pRODUCTBindingSource.CurrencyManager.AddNew();
            }
            else
            {
                this.pRODUCTBindingSource.CurrencyManager.Position = _id;
                (this.pRODUCTBindingSource.CurrencyManager.Current as DataRowView).BeginEdit();
            }

        }

        //
        // Event Button 
        //
        #region eventButron

        private void btnAddPicture_Click(object sender, EventArgs e) //Them hinh anh
        {
            OpenFileDialog openFile = new OpenFileDialog();
            string pathImage = null;
            DialogResult result = openFile.ShowDialog();
            if (result == DialogResult.OK)
            {
                //Load anh len picturebox
                pathImage = openFile.FileName;
                //Thay doi kich thuoc hinh anh load vao phu hop voi picturebox
                this.ptrbPicture.Image = resizeImage(Image.FromFile(pathImage.ToString()),
                                                     this.ptrbPicture.Width,
                                                     this.ptrbPicture.Height);
                this.ptrbPicture.SizeMode = PictureBoxSizeMode.AutoSize;

                if (!System.IO.Directory.Exists(directoryPath))
                    System.IO.Directory.CreateDirectory(directoryPath);
                //Duong dan thu muc anh luu
                String name = null;
                if (_new)
                {
                    //Luu anh vao resource
                    name = getIdProduct().ToString();
                }
                else
                {
                    name = String.Format("{0:D6}", (((this.pRODUCTBindingSource.CurrencyManager.Current as DataRowView).Row as SellManagementDbDataSet.PRODUCTRow).Id));
                }

                string pathImageProduct = directoryPath + "\\" + name.ToString() + ".png";
                this.ptrbPicture.Image.Save(pathImageProduct);
                this.ptrbPicture.ImageLocation = pathImageProduct;
                ((this.pRODUCTBindingSource.CurrencyManager.Current as DataRowView).Row as SellManagementDbDataSet.PRODUCTRow).Picture = pathImageProduct;
                MessageBox.Show(pathImageProduct);
            }
        }

        private void btnDeletePicture_Click(object sender, EventArgs e) // Xoa hinh anh
        {
            this.ptrbPicture.ImageLocation = "";
            ((this.pRODUCTBindingSource.CurrencyManager.Current as DataRowView).Row as SellManagementDbDataSet.PRODUCTRow).Picture = "";

        }

        private void btnHelp_Click(object sender, EventArgs e) // Tro giup
        {

        }

        private void btnSave_Click(object sender, EventArgs e) // Luu va dong Form
        {
            if (_new)
            {
                try
                {
                    this.pRODUCT_METADATABindingSource.EndEdit();
                    this.pRODUCT_METADATATableAdapter.Update(sellManagementDbDataSet.PRODUCT_METADATA);
                    this.sellManagementDbDataSet.PRODUCT_METADATA.AcceptChanges();

                    this.pRODUCTBindingSource.EndEdit();
                    this.pRODUCTTableAdapter.Update(sellManagementDbDataSet.PRODUCT);
                    this.sellManagementDbDataSet.PRODUCT.AcceptChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    this.pRODUCT_METADATABindingSource.EndEdit();
                    this.pRODUCT_METADATATableAdapter.Update(sellManagementDbDataSet.PRODUCT_METADATA);
                    this.sellManagementDbDataSet.PRODUCT_METADATA.AcceptChanges();

                    (this.pRODUCTBindingSource.CurrencyManager.Current as DataRowView).EndEdit();
                    this.pRODUCTTableAdapter.Update(sellManagementDbDataSet.PRODUCT);
                    this.sellManagementDbDataSet.PRODUCT.AcceptChanges();
                    this.pRODUCTBindingSource.ResetBindings(false);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e) // Huy bo va dong Form
        {
            if (_new)
            {
                try
                {
                    if (((this.pRODUCTBindingSource.CurrencyManager.Current as DataRowView).Row as SellManagementDbDataSet.PRODUCTRow).Id >= 0)
                    {
                        DataRowView row = (DataRowView)this.pRODUCTBindingSource.CurrencyManager.Current;
                        row.Delete();
                    }
                    this.pRODUCTBindingSource.EndEdit();
                    this.pRODUCTTableAdapter.Update(this.sellManagementDbDataSet.PRODUCT);
                    this.sellManagementDbDataSet.AcceptChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                this.sellManagementDbDataSet.PRODUCT_METADATA.RejectChanges();
                this.sellManagementDbDataSet.PRODUCT.RejectChanges();
            }
            this.Close();
        }

        #endregion
        //
        // Load and Save Picture
        //
        #region LoadAndSavePicture

        //Thay doi kich thuoc anh goc theo kich thuoc dinh dang
        private Image resizeImage(Image img, int width, int height)
        {
            Bitmap b = new Bitmap(width, height);
            Graphics g = Graphics.FromImage((Image)b);

            g.DrawImage(img, 0, 0, width, height);
            g.Dispose();

            return (Image)b;
        }

        //Lay id cua san pham (Dung de gan ten cho san pham)
        private string getIdProduct()
        {
            int id = -1;

            try
            {
                id = ((this.pRODUCTBindingSource.CurrencyManager.Current as DataRowView).Row as SellManagementDbDataSet.PRODUCTRow).Id;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (id < 0)
            {
                int max = 0;
                foreach (DataRow item in sellManagementDbDataSet.PRODUCT.Rows)
                {
                    max = Math.Max(max, Convert.ToInt32(item["Id"]));
                }

                return String.Format("{0:D6}", max + 1);
            }
            else
            {
                return String.Format("{0:D6}", id.ToString());
            }
        }

        #endregion

        private void pRODUCT_METADATADataGridView_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            if (((this.pRODUCTBindingSource.CurrencyManager.Current as DataRowView).Row as SellManagementDbDataSet.PRODUCTRow).Id < 0)
            {
                try
                {
                    (this.pRODUCTBindingSource.CurrencyManager.Current as DataRowView).EndEdit();
                    this.pRODUCTTableAdapter.Update(sellManagementDbDataSet.PRODUCT);
                    this.sellManagementDbDataSet.PRODUCT.AcceptChanges();
                    this.pRODUCTBindingSource.ResetBindings(false);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

    }
}
