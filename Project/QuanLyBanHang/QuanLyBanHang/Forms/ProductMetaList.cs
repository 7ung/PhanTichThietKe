using QuanLyBanHang.Properties;
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
    public partial class ProductMetaList : Form
    {
        public enum eProductType {
            TYPE,
            BRAND,
            UNIT,
            ALL
        }

        public eProductType ProductType { get; set; }

        public ProductMetaList()
        {
            InitializeComponent();

            ProductType = eProductType.ALL;
        }

        public ProductMetaList( eProductType type)
        {
            InitializeComponent();

            ProductType = type;
        }

        private void ProductMetaList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sellManagementDbDataSet.PRODUCT_METADATA' table. You can move, or remove it, as needed.
            this.pRODUCT_METADATATableAdapter.Fill(this.sellManagementDbDataSet.PRODUCT_METADATA);

            if (ProductType == eProductType.ALL)
            {
                var list = sellManagementDbDataSet.PRODUCT_METADATA.GroupBy(g => g.Value).Select(m =>
                                new
                                {
                                    Name = m.Key,
                                    Count = m.Distinct().Count()
                                });

                bindingSource.DataSource = list;
            }
            else
            {
                string key = Resources.ProductTypeKey;
                switch (ProductType)
                {
                    case eProductType.TYPE:
                        {
                            key = Resources.ProductTypeKey;
                            this.Text = "Danh sách loại sản phẩm";
                            break;
                        }
                    case eProductType.BRAND:
                        {
                            key = Resources.ProductBrandKey;
                            this.Text = "Danh sách hãng sản phẩm";
                            break;
                        }
                    case eProductType.UNIT:
                        {
                            key = Resources.ProductUnitKey;
                            this.Text = "Danh sách đơn vị sản phẩm";
                            break;
                        }
                    default:
                        break;
                }

                var list = sellManagementDbDataSet.PRODUCT_METADATA.Where(t => t.Key == key).GroupBy(g => g.Value).Select(m =>
                                new
                                {
                                    Name = m.Key,
                                    Count = m.Distinct().Count()
                                });
                
                bindingSource.DataSource = list;
                
            }

            dataGridView1.DataSource = bindingSource;
            
        }

        private void searchText_TextChanged(object sender, EventArgs e)
        {
            bindingSource.Filter = "Name LIKE '%" + searchText.Text + "%'";
        }
    }
}
