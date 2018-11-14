using QuanLyCuaHangDienThoai.Models;
using QuanLyCuaHangDienThoai.Models.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QuanLyCuaHangDienThoai.Areas.WarehouseStaff.Models
{
    public class WarehouseXuatKho
    {
        [Required]
        public string maHang { get; set; }
        [Required]
        public int soLuong { get; set; }
        public List<SANPHAM> GetListSP()
        {
            QuanLyDTDBContent db = new QuanLyDTDBContent();
            List<SANPHAM> list = db.SANPHAMs.ToList();
            return list;
        }


        public string getNextId()
        {
            QuanLyDTDBContent db = new QuanLyDTDBContent();
            List<XUATKHO> c = db.XUATKHOes.ToList();
            int max = 0;
            for (int i = 0; i < c.Count; i++)
            {
                if (int.Parse(c[i].id) > max)
                {
                    max = int.Parse(c[i].id);
                }
            }
            if (c.Count() == 0)
                return "1";
            else
            {
                return (max + 1).ToString();
            }


        }


        public string RemoveXuatKho(WarehouseXuatKho model)
        {
            QuanLyDTDBContent db = new QuanLyDTDBContent();
            XUATKHO xuat = new XUATKHO();
            xuat.ngayXuat = DateTime.Now;
            xuat.id = getNextId();
            xuat.soLuong = model.soLuong;
            xuat.maSanPham = model.maHang;
            db.XUATKHOes.Add(xuat);

            ModifierTonKho mtk = new ModifierTonKho();
            if (mtk.UpdateXuatTonKho(model.maHang, model.soLuong) == "false")
            {
                return "false";
            };
            db.SaveChanges();
            return "true";

        }
    }
}