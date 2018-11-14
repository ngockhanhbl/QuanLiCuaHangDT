using QuanLyCuaHangDienThoai.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyCuaHangDienThoai.Areas.Accountant.Models
{
    public class AccountantInHoaDon
    {
        public string id { get; set; }
        public SANPHAM Sanpham { get; set; }
        public KHACHHANG KhachHang { get; set; }
        public NHANVIEN NhanVien { get; set; }
        public CHITIETSANPHAM ChiTietSanPham { get; set; }
        public HOADON HoaDon { get; set; }
        public TONKHO TonKho { get; set; }

        public List<SANPHAM> GetListSP()
        {
            QuanLyDTDBContent db = new QuanLyDTDBContent();
            List<SANPHAM> list = db.SANPHAMs.ToList();
            return list;
        }
    }
}