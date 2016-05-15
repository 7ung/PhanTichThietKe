using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Models
{
    public class Gender
    {
        public Gender(string name, bool value)
        {
            Name = name;
            Value = value;
        }

        public bool Value { get; set; }
        public string Name { get; set; }
    }
}
