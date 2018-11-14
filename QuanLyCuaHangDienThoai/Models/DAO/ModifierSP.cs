using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using QuanLyCuaHangDienThoai.Areas.Admin.Models;

namespace QuanLyCuaHangDienThoai.Models.DAO
{
    public class ModifierSP
    {
        [Required]
        public string maSanPham { get; set; }
        [Required]
        public string tenSanPham { get; set; }
        [Required]
        public string size { get; set; }

        public string getNextMaSP()
        {
            QuanLyDTDBContent db = new QuanLyDTDBContent();
            List<SANPHAM> c = db.SANPHAMs.ToList();
            int max = 0;
            for (int i = 0; i < c.Count; i++)
            {
                if (int.Parse(c[i].maSanPham) > max)
                {
                    max = int.Parse(c[i].maSanPham);
                }
            }

            if (c.Count() == 0)
                return "1";
            else
            {
                return (max + 1).ToString();
            }
        }


        public void ThemSPMoi(SANPHAM modifier)
        {
            QuanLyDTDBContent db = new QuanLyDTDBContent();
            SANPHAM sp = new SANPHAM();
            sp.tenSanPham = modifier.tenSanPham;
            sp.maSanPham = getNextMaSP();
            db.SANPHAMs.Add(sp);
            db.SaveChanges();

        }


        public void Insert(ListProduct model)
        {
            QuanLyDTDBContent db = new QuanLyDTDBContent();
            SANPHAM p = new SANPHAM();
            string ID = getNextMaSP();
            CHITIETSANPHAM chitietSP = new CHITIETSANPHAM();
            LoaiSanPham loaiSP = new LoaiSanPham();
            p.maSanPham = getNextMaSP();
            p.tenSanPham = model.Name;
            p.MaNhaCC = model.Producer;
            p.ProductTypeID = model.ProductType;
            chitietSP.donGiaNhap = (double)model.OriginalPrice;
            chitietSP.donGiaXuat = (double) model.SellPrice; 
            p.Images = model.Image;
            db.SANPHAMs.Add(p);
            db.SaveChanges();
            new ModifierTonKho().Insert(ID);
        }

        public void Update(ListProduct model)
        {
            QuanLyDTDBContent db = new QuanLyDTDBContent();
            SANPHAM p = db.SANPHAMs.SingleOrDefault(x => x.maSanPham == model.ID);
            p.tenSanPham = model.Name;
            p.MaNhaCC = model.Producer;
            p.ProductTypeID = model.ProductType;
            p.CHITIETSANPHAM.donGiaNhap =(double) model.OriginalPrice;
            p.CHITIETSANPHAM.donGiaXuat =(double) model.SellPrice;
            if (model.Image != null)
            {
                p.Images = model.Image;
            }
            db.SaveChanges();
        }

        public List<SANPHAM> getListSanPham()
        {
            QuanLyDTDBContent db = new QuanLyDTDBContent();
            List<SANPHAM> list = db.SANPHAMs.ToList();
            return list;
        }

        public SANPHAM GetSanPhamBytenSP(string tenSP)
        {
            SANPHAM sp = new QuanLyDTDBContent().SANPHAMs.SingleOrDefault(x => x.tenSanPham == tenSP);
            return sp;
        }
    }
}