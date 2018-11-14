using QuanLyCuaHangDienThoai.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QuanLyCuaHangDienThoai.Areas.WarehouseStaff.Models
{
    public class WareHouseTonKho
    {
        [Required]
        public string maHang { get; set; }
        [Required]
        public int soLuong { get; set; }
        [Required]
        public string XuatXu { get; set; }
        [Required]
        public string TenSP { get; set; }

        public List<WareHouseTonKho> GetListTK()
        {
            QuanLyDTDBContent db = new QuanLyDTDBContent();
            List<WareHouseTonKho> list = db.TONKHOes.Select(x => new WareHouseTonKho { maHang = x.maSanPham, soLuong = (int)x.soLuong, TenSP = x.SANPHAM.tenSanPham}).ToList();
            return list;
        }
    }
}