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
using QuanLyBanHang.Properties;

namespace QuanLyBanHang.Forms
{
    public partial class AddProduct : Form
    {

        // Duong dan toi thu muc chua hinh anh san pham
        const string directoryPath = "Picture\\Product";
        private bool _new = true;
        private int _id = -1;
        private double _interestRate = 0.1;

        private string _prefixKey = Resources.ProductPrefixKey;

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
            this.constantTableAdapter.Fill(sellManagementDbDataSet.CONSTANT);
            
            // binding combobox
            bindingTypeComboBox();
            bindingBrandComboBox();
            bindingUnitComboBox();

            // lấy interest rate
            _interestRate = Convert.ToDouble(sellManagementDbDataSet.CONSTANT.Where(c => c.Name == "interest_rate").First().Value);
            interestRateLabel.Text = "Tỉ lệ lợi nhuận: " + _interestRate * 100 + "%";
            
            tbInPrice.TextBox.Leave += inpriceTextBox_Leave;

            if (_new)
            {
                this.pRODUCTBindingSource.CurrencyManager.AddNew();
                productKeyText.Text = generateProductKey();
                tbBarCode.Text = "012345679";
            }
            else
            {
                this.pRODUCTBindingSource.Filter = "Id = " + _id;

                (this.pRODUCTBindingSource.CurrencyManager.Current as DataRowView).BeginEdit();

                // bind edit
                var typeRow = sellManagementDbDataSet.PRODUCT_METADATA.Where(p => (p.Product_id == _id && p.Key == Resources.ProductTypeKey)).Select(p => p.Value);

                if (typeRow.Count() > 0)
                    typeComboBox.Text = typeRow.First();

                var brandRow = sellManagementDbDataSet.PRODUCT_METADATA.Where(p => (p.Product_id == _id && p.Key == Resources.ProductBrandKey)).Select(p => p.Value);

                if (brandRow.Count() > 0)
                    brandComboBox.Text = brandRow.First();

                var unitRow = sellManagementDbDataSet.PRODUCT_METADATA.Where(p => (p.Product_id == _id && p.Key == Resources.ProductUnitKey)).Select(p => p.Value);

                if (unitRow.Count() > 0)
                    unitComboBox.Text = unitRow.First();
            }

        }

        private void inpriceTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                
                var cur = Convert.ToDouble(tbInPrice.Text);
                tbOutPrice.Text = (cur * (1 + _interestRate)).ToString();
            }
            catch(Exception ex)
            {
                tbOutPrice.Text = "0.00";
            }
        }

        private void bindingTypeComboBox()
        {
            var typeList = sellManagementDbDataSet.PRODUCT_METADATA.Where(p => p.Key == Resources.ProductTypeKey).Select(p => p.Value);

            if (typeList.Count() > 0)
            {
                var list = typeList.Distinct().ToList();
                typeComboBox.DataSource = list;
            }
        }

        private void bindingBrandComboBox()
        {
            var brandList = sellManagementDbDataSet.PRODUCT_METADATA.Where(p => p.Key == Resources.ProductBrandKey).Select(p => p.Value);

            if(brandList.Count() > 0)
            {
                var list = brandList.Distinct().ToList();
                brandComboBox.DataSource = list;
            }
        }

        private void bindingUnitComboBox()
        {
            var unitList = sellManagementDbDataSet.PRODUCT_METADATA.Where(p => p.Key == Resources.ProductUnitKey).Select(p => p.Value);

            if (unitList.Count() > 0)
            {
                var list = unitList.Distinct().ToList();
                unitComboBox.DataSource = list;
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

                MessageBox.Show("Thư mục lưu ảnh: " + pathImageProduct, "Thông báo", MessageBoxButtons.OK);
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
                    this.pRODUCTBindingSource.EndEdit();
                    this.pRODUCTTableAdapter.Update(sellManagementDbDataSet.PRODUCT);
                    this.sellManagementDbDataSet.PRODUCT.AcceptChanges();
                    
                    // lưu product meta data
                    // type row
                    var typerow = (pRODUCT_METADATABindingSource.AddNew() as DataRowView).Row as SellManagementDbDataSet.PRODUCT_METADATARow;
                    typerow.BeginEdit();

                    typerow.Key = Resources.ProductTypeKey;
                    typerow.Value = typeComboBox.Text;

                    typerow.EndEdit();

                    // brand row
                    var brandrow = (pRODUCT_METADATABindingSource.AddNew() as DataRowView).Row as SellManagementDbDataSet.PRODUCT_METADATARow;
                    brandrow.BeginEdit();

                    brandrow.Key = Resources.ProductBrandKey;
                    brandrow.Value = brandComboBox.Text;

                    brandrow.EndEdit();

                    // type row
                    var unitrow = (pRODUCT_METADATABindingSource.AddNew() as DataRowView).Row as SellManagementDbDataSet.PRODUCT_METADATARow;
                    unitrow.BeginEdit();

                    unitrow.Key = Resources.ProductUnitKey;
                    unitrow.Value = unitComboBox.Text;

                    unitrow.EndEdit();


                    this.pRODUCT_METADATABindingSource.EndEdit();
                    this.pRODUCT_METADATATableAdapter.Update(sellManagementDbDataSet.PRODUCT_METADATA);
                    this.sellManagementDbDataSet.PRODUCT_METADATA.AcceptChanges();

                    this.Close();

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
                    saveProductMetaData();

                    this.pRODUCT_METADATABindingSource.EndEdit();
                    this.pRODUCT_METADATATableAdapter.Update(sellManagementDbDataSet.PRODUCT_METADATA);
                    this.sellManagementDbDataSet.PRODUCT_METADATA.AcceptChanges();

                    (this.pRODUCTBindingSource.CurrencyManager.Current as DataRowView).EndEdit();
                    this.pRODUCTTableAdapter.Update(sellManagementDbDataSet.PRODUCT);
                    this.sellManagementDbDataSet.PRODUCT.AcceptChanges();
                    this.pRODUCTBindingSource.ResetBindings(false);
                    
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void saveProductMetaData()
        {
            // tìm coi có giá trị chưa
            var typeRow = sellManagementDbDataSet.PRODUCT_METADATA.Where(p => (p.Product_id == _id && p.Key == Resources.ProductTypeKey));

            // nếu có thì sửa
            if (typeRow.Count() > 0)
            {
                var row = sellManagementDbDataSet.PRODUCT_METADATA.FindById(typeRow.First().Id);
                row.BeginEdit();

                if(typeComboBox.Text.ToLower() != row.Value.ToLower())
                    row.Value = typeComboBox.Text;

                row.EndEdit();
            }
            else
            {
                // không thì add mới
                // type row
                var typerow = (pRODUCT_METADATABindingSource.AddNew() as DataRowView).Row as SellManagementDbDataSet.PRODUCT_METADATARow;
                typerow.BeginEdit();

                typerow.Key = Resources.ProductTypeKey;
                typerow.Value = typeComboBox.Text;

                typerow.EndEdit();
            }

            // brand
            var brandRow = sellManagementDbDataSet.PRODUCT_METADATA.Where(p => (p.Product_id == _id && p.Key == Resources.ProductBrandKey));

            // nếu có thì sửa
            if (brandRow.Count() > 0)
            {
                var row = sellManagementDbDataSet.PRODUCT_METADATA.FindById(brandRow.First().Id);
                row.BeginEdit();

                if (brandComboBox.Text.ToLower() != row.Value.ToLower())
                    row.Value = brandComboBox.Text;

                row.EndEdit();
            }
            else
            {
                // không thì add mới
                // brand row
                var brandrow = (pRODUCT_METADATABindingSource.AddNew() as DataRowView).Row as SellManagementDbDataSet.PRODUCT_METADATARow;
                brandrow.BeginEdit();

                brandrow.Key = Resources.ProductBrandKey;
                brandrow.Value = brandComboBox.Text;

                brandrow.EndEdit();
            }

            // tìm coi có giá trị chưa
            var unitRow = sellManagementDbDataSet.PRODUCT_METADATA.Where(p => (p.Product_id == _id && p.Key == Resources.ProductUnitKey));

            // nếu có thì sửa
            if (unitRow.Count() > 0)
            {
                var row = sellManagementDbDataSet.PRODUCT_METADATA.FindById(unitRow.First().Id);
                row.BeginEdit();

                if (unitComboBox.Text.ToLower() != row.Value.ToLower())
                    row.Value = unitComboBox.Text;

                row.EndEdit();
            }
            else
            {
                // không thì add mới
                // unit row
                var unitrow = (pRODUCT_METADATABindingSource.AddNew() as DataRowView).Row as SellManagementDbDataSet.PRODUCT_METADATARow;
                unitrow.BeginEdit();

                unitrow.Key = Resources.ProductUnitKey;
                unitrow.Value = unitComboBox.Text;

                unitrow.EndEdit();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) // Huy bo va dong Form
        {
            //if (_new)
            //{
            //    try
            //    {
            //        // hủy rồi save chi :v
            //        //if (((this.pRODUCTBindingSource.CurrencyManager.Current as DataRowView).Row as SellManagementDbDataSet.PRODUCTRow).Id >= 0)
            //        //{
            //        //    DataRowView row = (DataRowView)this.pRODUCTBindingSource.CurrencyManager.Current;
            //        //    row.Delete();
            //        //}
            //        //this.pRODUCTBindingSource.EndEdit();
            //        //this.pRODUCTTableAdapter.Update(this.sellManagementDbDataSet.PRODUCT);
            //        //this.sellManagementDbDataSet.AcceptChanges();

            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //    }
            //}
            //else
            //{
                
            //}

            this.sellManagementDbDataSet.PRODUCT_METADATA.RejectChanges();
            this.sellManagementDbDataSet.PRODUCT.RejectChanges();

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

        private string generateProductKey()
        {
            int max = 0;

            foreach (DataRow item in sellManagementDbDataSet.PRODUCT.Where(c => c.ProductKey.Substring(0, 2) == _prefixKey))
            {
                var value = item["ProductKey"].ToString().TrimStart(_prefixKey.ToArray());
                max = Math.Max(max, Convert.ToInt32(value));
            }

            return _prefixKey + String.Format("{0:D6}", max + 1);
        }

        private void tbInPrice_xTextChanged(object sender, EventArgs e)
        {

        }
    }
}
