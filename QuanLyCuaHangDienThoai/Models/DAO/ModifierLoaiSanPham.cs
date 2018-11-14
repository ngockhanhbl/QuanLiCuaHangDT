using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyCuaHangDienThoai.Models.DAO
{
    public class ModifierLoaiSanPham
    {
        public List<LoaiSanPham> GetList()
        {
            return new QuanLyDTDBContent().LoaiSanPhams.ToList();
        }
    }
}