using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Models
{
    static class ResourceComboBoxBinding
    {
        public static StringNStringBindingData[] OrderStatus = new StringNStringBindingData[]
           {
                new StringNStringBindingData("Hoàn thành" ,"complete"),
                new StringNStringBindingData("Hết hàng", "outofstock"),
                new StringNStringBindingData("Đang giao hàng", "shipping")
           };

        public static StringNStringBindingData[] BillStatus = new StringNStringBindingData[]
           {
                new StringNStringBindingData("Một phần" ,"apart"),
                new StringNStringBindingData("Hoàn thành", "finish"),
                new StringNStringBindingData("Quá hạng", "expired"),
                new StringNStringBindingData("Chưa thanh toán", "nopaid"),
                new StringNStringBindingData("Không có", ""),
           };

        public static StringNStringBindingData[] BillType = new StringNStringBindingData[]
          {
                new StringNStringBindingData("Tiền mặt" ,"cash"),
                new StringNStringBindingData("Thẻ", "credit"),
                new StringNStringBindingData("Online", "online")
          };
    }
}
