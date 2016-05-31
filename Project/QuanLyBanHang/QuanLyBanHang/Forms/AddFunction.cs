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

namespace QuanLyBanHang
{
    public partial class AddFunction : Form
    {
        List<String> _func;
        public AddFunction(List<String> func)
        {
            InitializeComponent();
            _func = func;
            this.Load += new System.EventHandler(LoadListbox);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.tbFunction.Text != "")
            {
                this._func.Add(this.tbFunction.Text);
                this.tbFunction.Text = "";
                this.lbFunction.DataSource = null;
                this.lbFunction.DataSource = _func;
            }
        }

        private void LoadListbox(Object sender, EventArgs e)
        {
            this.lbFunction.DataSource = _func;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
