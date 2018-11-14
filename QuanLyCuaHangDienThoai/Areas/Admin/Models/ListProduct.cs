using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QuanLyCuaHangDienThoai.Areas.Admin.Models
{
    public class ListProduct
    {
        public string ID { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập tên sản phẩm")]
        public string Name { get; set; }
        public string Producer { get; set; }
        public string ProductType { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập giá gốc")]
        [RegularExpression("^[1-9][0-9]{2,}[0][0][0]$", ErrorMessage = "Nhập sai định dạng")]
        public decimal OriginalPrice { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập giá bán")]
        [RegularExpression("^[1-9][0-9]{2,}[0][0][0]$", ErrorMessage = "Nhập sai định dạng")]
        public decimal SellPrice { get; set; }
        public byte[] Image { get; set; }
    }
}