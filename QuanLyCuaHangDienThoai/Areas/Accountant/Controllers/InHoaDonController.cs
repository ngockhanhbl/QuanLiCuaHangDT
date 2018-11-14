using QuanLyCuaHangDienThoai.Areas.Accountant.Models;
using QuanLyCuaHangDienThoai.Models.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyCuaHangDienThoai.Areas.Accountant.Controllers
{
    public class InHoaDonController : Controller
    {
        // GET: Accountant/InHoaDon
        public ActionResult Index()
        {
            if (Session["username"] != null && (string)Session["quyen"] == "Accountant")
            {
                ViewBag.listSanPham = new SelectList(new AccountantInHoaDon().GetListSP(), "maSanPham", "tenSanPham");
                ViewBag.listFullSanPham = new SelectList(new AccountantInHoaDon().GetListSP());
                ViewBag.NextMaHoaDon = new ModifierHD().getNextMaHDon();
                ViewBag.listChiTietSanPham = new ModifierChiTietSanPham().getListFullSanPham();
                return View();
            }
            return RedirectToAction("Index", "Login", new { @area = "" });
        }

        public JsonResult JGetGiaSP(AccountantInHoaDon model)
        {
            double giaXuat = new ModifierChiTietSanPham().getGiaXuatByMaSp(model.Sanpham.maSanPham);
            return Json(giaXuat + "", JsonRequestBehavior.AllowGet);
        }
    }
}