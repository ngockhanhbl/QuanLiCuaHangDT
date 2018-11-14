using QuanLyCuaHangDienThoai.Models;
using QuanLyCuaHangDienThoai.Models.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyCuaHangDienThoai.Areas.Admin.Models
{
    public class AdminNhanVienMoi
    {
        public string InsertNV(ModifierNhanVien model)
        {
            account a = new account();
            a.username = model.TenDangNhap;
            a.password = model.MatKhau;
            a.position = model.ViTri;
            if (new ModifierAccount().CheckUsername(model.TenDangNhap))
            {
                new ModifierAccount().ThemAccount(a);
                new ModifierNhanVien().ThemNhanVien(model);
                return "Them nv thanh cong";
            }
            else
            {
                return "false";
            }
        }
        public List<NHANVIEN> GetListNhanVien()
        {
            QuanLyDTDBContent db = new QuanLyDTDBContent();
            List<NHANVIEN> list = db.NHANVIENs.ToList();
            return list;
        }

    }
}