using QuanLyCuaHangDienThoai.Areas.Admin.Models;
using QuanLyCuaHangDienThoai.Models;
using QuanLyCuaHangDienThoai.Models.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyCuaHangDienThoai.Areas.Admin.Controllers
{
    public class QLyNhanVienController : Controller
    {
        // GET: Admin/QLyNhanVien
        public ActionResult Index()
        {
            if (Session["username"] != null && (string)Session["quyen"] == "Admin")
            {
                ViewBag.listInfoNhanVien = new AdminNhanVienMoi().GetListNhanVien();
                return View();

            }

            return RedirectToAction("Index", "Login", new { @area = "" });
        }

        public JsonResult JThemNVMoi(ModifierNhanVien nv)
        {
            return Json(new AdminNhanVienMoi().InsertNV(nv), JsonRequestBehavior.AllowGet);
        }

        public JsonResult DeleteNhanVien(string maNhanVien)
        {
            QuanLyDTDBContent db = new QuanLyDTDBContent();
            NHANVIEN nv = db.NHANVIENs.SingleOrDefault(x => x.maNhanVien == maNhanVien);
            string username = nv.tenDangNhap;
            new ModifierHD().UpdateHDForDeleteNV(maNhanVien);

            new ModifierNhanVien().DeleteByID(maNhanVien);

            new ModifierAccount().DeleteAccount(username);

            return Json("", JsonRequestBehavior.AllowGet);
        }
    }
}