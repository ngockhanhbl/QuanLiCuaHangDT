using QuanLyCuaHangDienThoai.Areas.Admin.Models;
using QuanLyCuaHangDienThoai.Models.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace QuanLyCuaHangDienThoai.Areas.Admin.Controllers
{
    public class DeXuatNhapKhoController : Controller
    {
        // GET: Admin/DeXuatNhapKho
        public ActionResult Index()
        {
            ViewBag.listNhapKho = new MDeXuatNhapKho().getListNhapKho();
            if (Session["username"] != null && (string)Session["quyen"] == "Admin")
            {
                return View();
            }

            return RedirectToAction("Index", "Login", new { @area = "" });
        }

        public JsonResult updateTonKho(string NKID, string maSP)
        {
            new ModifierNhapKho().updateTrangThai(NKID);
            new ModifierTonKho().UpdateTonKhoNhap(NKID, maSP);
            return Json("true", JsonRequestBehavior.AllowGet);
        }
        public JsonResult HuyDeXuatNhapKho(string NKID)
        {
            new ModifierNhapKho().deleteDeXuatNhapKho(NKID);
            return Json("true", JsonRequestBehavior.AllowGet);
        }
    }
}