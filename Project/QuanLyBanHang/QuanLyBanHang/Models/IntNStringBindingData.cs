﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Models
{
    class IntNStringBindingData
    {
        public IntNStringBindingData(string name, int value)
        {
            Name = name;
            Value = value;
        }

        public int Value { get; set; }
        public string Name { get; set; }
    }
}
