using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyCuaHangDienThoai.Models.DAO
{
    public class ModifierNhaCC
    {
        public List<NhaCungCap> GetList()
        {
            return new QuanLyDTDBContent().NhaCungCaps.ToList();
        }
    }
}