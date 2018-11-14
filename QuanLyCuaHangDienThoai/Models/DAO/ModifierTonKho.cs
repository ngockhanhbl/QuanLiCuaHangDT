using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyCuaHangDienThoai.Models.DAO
{
    public class ModifierTonKho
    {

        public void Insert(string productID)
        {
            QuanLyDTDBContent db = new QuanLyDTDBContent();
            TONKHO wh = new TONKHO();
            wh.maSanPham = productID;
            wh.soLuong = 0;
            db.TONKHOes.Add(wh);
            db.SaveChanges();
        }


        public string UpdateTonKho(string ma, int sl)
        {
            string temp;
            QuanLyDTDBContent db = new QuanLyDTDBContent();
            TONKHO tk = db.TONKHOes.SingleOrDefault(x => x.maSanPham == ma);

            tk.soLuong = tk.soLuong + sl;

            db.SaveChanges();
            temp = "true";

            return temp;
        }

        public string UpdateXuatTonKho(string ma, int sl)
        {
            string temp;
            QuanLyDTDBContent db = new QuanLyDTDBContent();
            TONKHO tk = db.TONKHOes.SingleOrDefault(x => x.maSanPham == ma);

            if (tk.soLuong >= sl)
            {
                tk.soLuong = tk.soLuong - sl;

                db.SaveChanges();
                temp = "true";

                return temp;
            }
            else
            {
                return "false";
            }

        }



        public void UpdateTonKhoNhap(string id, string maSP)
        {
            QuanLyDTDBContent db = new QuanLyDTDBContent();
            int soluong = new ModifierNhapKho().GetSoLuongByID(id);
            TONKHO tk = db.TONKHOes.SingleOrDefault(x => x.maSanPham == maSP);
            tk.soLuong += soluong;
            db.SaveChanges();
        }
        public void InsertTonKho(string maSP)
        {
            QuanLyDTDBContent db = new QuanLyDTDBContent();
            TONKHO tk = new TONKHO();
            tk.maSanPham = maSP;
            tk.soLuong = 0;
            db.TONKHOes.Add(tk);
            db.SaveChanges();
        }
    }
}