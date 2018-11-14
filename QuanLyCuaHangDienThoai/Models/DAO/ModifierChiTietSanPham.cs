using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QuanLyCuaHangDienThoai.Models.DAO
{
    public class ModifierChiTietSanPham
    {
        [Required]
        public string maSanPham { get; set; }
        [Required]
        public double donGiaNhap { get; set; }
        [Required]
        public double donGiaXuat { get; set; }
        public string tenSanPham { get; set; }

        public void ThemChiTietSanPhamMoi(CHITIETSANPHAM modifier, string maSanPham)
        {
            QuanLyDTDBContent db = new QuanLyDTDBContent();
            CHITIETSANPHAM sp = new CHITIETSANPHAM();
            sp.maSanPham = maSanPham;
            sp.donGiaNhap = modifier.donGiaNhap;
            sp.donGiaXuat = modifier.donGiaXuat;
            db.CHITIETSANPHAMs.Add(sp);
            db.SaveChanges();

        }
        public List<CHITIETSANPHAM> getListSanPham()
        {
            QuanLyDTDBContent db = new QuanLyDTDBContent();
            List<CHITIETSANPHAM> list = db.CHITIETSANPHAMs.ToList();
            return list;
        }

        public double getGiaXuatByMaSp(string maSanPham)
        {
            QuanLyDTDBContent db = new QuanLyDTDBContent();
            CHITIETSANPHAM chitietSp = db.CHITIETSANPHAMs.SingleOrDefault(x => x.maSanPham == maSanPham);
            return (double)chitietSp.donGiaXuat;
        }



        public List<ModifierChiTietSanPham> getListFullSanPham()
        {
            return new QuanLyDTDBContent().CHITIETSANPHAMs.Select(x => new ModifierChiTietSanPham { maSanPham = x.maSanPham, tenSanPham = x.SANPHAM.tenSanPham, donGiaNhap = (double)x.donGiaNhap, donGiaXuat = (double)x.donGiaXuat }).ToList();
        }
    }
}