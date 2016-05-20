using QuanLyBanHang.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Models
{
    interface IFormList
    {
        eFormState State { get; set; }

        void updateState(eFormState state);

        void enableAllControls(bool enable, bool readOnly);

        bool IsValidInformation();
    }
}
