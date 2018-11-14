using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QuanLyCuaHangDienThoai.Models.DAO
{
    public class ModifierNhanVien
    {
        public string maNV { get; set; }
        [Required(ErrorMessage = "Chua Nhap Ten Nhan Vien")]
        public string tenNhanVien { get; set; }
        [Required(ErrorMessage = "Chua Nhap Ngay Sinh")]
        public DateTime NgaySinh { get; set; }
        [Required(ErrorMessage = "Chua Nhap Gioi Tinh")]
        public string GioiTinh { get; set; }
        [Required(ErrorMessage = "Chua Nhap CMND")]
        public string Cmnd { get; set; }
        [Required(ErrorMessage = "Chua Nhap So Dien Thoai")]
        public string SDT { get; set; }
        [Required(ErrorMessage = "Chua Nhap Dia Chi")]
        public string DiaChi { get; set; }
        [Required(ErrorMessage = "Chua Nhap Ten Dang Nhap")]
        public string TenDangNhap { get; set; }
        [Required(ErrorMessage = "Chua Nhap Mat Khau")]
        public string MatKhau { get; set; }
        [Required(ErrorMessage = "Chua Nhap Vi Tri")]
        public string ViTri { get; set; }
        public List<NHANVIEN> GetListNV()
        {
            QuanLyDTDBContent db = new QuanLyDTDBContent();
            List<NHANVIEN> list = db.NHANVIENs.ToList();
            return list;
        }

        public string getNextId()
        {
            QuanLyDTDBContent db = new QuanLyDTDBContent();
            List<NHANVIEN> c = db.NHANVIENs.ToList();
            int max = 0;
            for (int i = 0; i < c.Count; i++)
            {
                if (int.Parse(c[i].maNhanVien) > max)
                {
                    max = int.Parse(c[i].maNhanVien);
                }
            }

            if (c.Count() == 0)
                return "1";
            else
            {
                return (max + 1).ToString();
            }
        }



        public void ThemNhanVien(ModifierNhanVien model)
        {
            QuanLyDTDBContent db = new QuanLyDTDBContent();
            NHANVIEN nv = new NHANVIEN();
            nv.tenNhanVien = model.tenNhanVien;
            nv.maNhanVien = getNextId();
            nv.ngaySinh = model.NgaySinh;
            nv.gioiTinh = model.GioiTinh;
            nv.cmnd = model.Cmnd;
            nv.soDienThoai = model.SDT;
            nv.diaChi = model.DiaChi;
            nv.tenDangNhap = model.TenDangNhap;
            nv.chucVu = model.ViTri;
            db.NHANVIENs.Add(nv);
            db.SaveChanges();
        }
        public void DeleteByID(string NVID)
        {
            QuanLyDTDBContent db = new QuanLyDTDBContent();
            NHANVIEN nv = db.NHANVIENs.SingleOrDefault(x => x.maNhanVien == NVID);


            db.NHANVIENs.Remove(nv);
            db.SaveChanges();

        }
    }
}