using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QuanLyCuaHangDienThoai.Models.DAO
{
    public class Login
    {
        [Required(ErrorMessage = "Chưa Nhập Username"), MinLength(4)]
        public string username { get; set; }
        [Required(ErrorMessage = "Chưa Nhập PassWord"), MinLength(4)]
        public string password { get; set; }
        public string KTuserpass(string username, string password)
        {
            QuanLyDTDBContent db = new QuanLyDTDBContent();
            account a = db.accounts.SingleOrDefault(x => x.username == username);
            if (a == null)
            {
                return "Username Không Tồn Tại";
            }
            else
            {
                if (a.password == password)
                {
                    return a.position;
                }
                else
                {
                    return "Sai PassWord";
                }
            }
        }
    }
}