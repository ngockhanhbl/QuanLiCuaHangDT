using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyCuaHangDienThoai.Models.DAO
{
    public class ModifierNhapKho
    {
        public int trangthai { get; set; }
        public List<nhapKho> getListNhapKho()
        {
            QuanLyDTDBContent db = new QuanLyDTDBContent();
            List<nhapKho> list = db.nhapKhoes.ToList();
            return list;
        }

        public void updateTrangThai(string id)
        {
            QuanLyDTDBContent db = new QuanLyDTDBContent();
            nhapKho nhapKho = db.nhapKhoes.SingleOrDefault(x => x.id == id);
            nhapKho.TrangThai = 1;
            db.SaveChanges();
        }

        public void deleteDeXuatNhapKho(string id)
        {
            QuanLyDTDBContent db = new QuanLyDTDBContent();
            nhapKho nk = db.nhapKhoes.SingleOrDefault(x => x.id == id);
            db.nhapKhoes.Remove(nk);
            db.SaveChanges();
        }



        public int GetSoLuongByID(string id)
        {
            nhapKho nk = new QuanLyDTDBContent().nhapKhoes.SingleOrDefault(x => x.id == id);
            return (int)nk.soLuong;
        }
    }
}