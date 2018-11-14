using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyCuaHangDienThoai.Models.DAO
{
    public class ModifierAccount
    {
        public account Select(string username)
        {
            QuanLyDTDBContent db = new QuanLyDTDBContent();
            account account = db.accounts.SingleOrDefault(x => x.username == username);
            return account;
        }
        public void ThemAccount(account acc)
        {
            QuanLyDTDBContent db = new QuanLyDTDBContent();
            account acc1 = new account();
            acc1.username = acc.username;
            acc1.password = acc.password;
            acc1.position = acc.position;
            db.accounts.Add(acc1);
            db.SaveChanges();
        }
        public bool CheckUsername(string username)
        {
            if (new QuanLyDTDBContent().accounts.SingleOrDefault(x => x.username == username) == null)
            {
                return true;
            }
            else
                return false;
        }
        public void DeleteAccount(string username)
        {
            QuanLyDTDBContent db = new QuanLyDTDBContent();
            account a = db.accounts.SingleOrDefault(x => x.username == username);
            db.accounts.Remove(a);
            db.SaveChanges();

        }
    }
}