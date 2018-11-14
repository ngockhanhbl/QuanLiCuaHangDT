using QuanLyCuaHangDienThoai.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyCuaHangDienThoai.Areas.Admin.Models
{
    public class AdminSanPhamMoi
    {
        public SANPHAM SanPham { get; set; }
        public CHITIETSANPHAM ChiTietSanPham { get; set; }

        public NhaCungCap NhaCungCap { get; set; }
    }
}