using QuanLyCuaHangDienThoai.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyCuaHangDienThoai.Areas.Admin.Models
{
    public class MDeXuatNhapKho
    {
        public string id { get; set; }

        public string maSanPham { get; set; }

        public int soLuong { get; set; }

        public DateTime ngayNhap { get; set; }

        public int TrangThai { get; set; }

        public string tenSanPham { get; set; }

        public string size { get; set; }
        public List<MDeXuatNhapKho> getListNhapKho()
        {
            QuanLyDTDBContent db = new QuanLyDTDBContent();
            List<MDeXuatNhapKho> list = db.nhapKhoes.Select(x => new MDeXuatNhapKho { TrangThai = (int)x.TrangThai, id = x.id, soLuong = (int)x.soLuong, ngayNhap = (DateTime)x.ngayNhap, tenSanPham = x.SANPHAM.tenSanPham,  maSanPham = x.maSanPham }).Where(x => x.TrangThai == 0).ToList();
            return list;
        }
    }
}