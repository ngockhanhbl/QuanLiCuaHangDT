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
    public class HomeController : Controller
    {
        // GET: Admin/Home
        public ActionResult Index()
        {
            ViewBag.listNhaSanXuat = new SelectList(new ModifierNhaCC().GetList(), "MaNhaCC", "TenNhaCC");
            ViewBag.listLoaiSanPham= new SelectList(new ModifierLoaiSanPham().GetList(), "ID", "Ten");
            if (Session["username"] != null && (string)Session["quyen"] == "Admin")
            {
                return View();
            }

            return RedirectToAction("Index", "Login", new { @area = "" });
        }
        public JsonResult JThemSPMoi(AdminSanPhamMoi model)
        {
            QuanLyDTDBContent db = new QuanLyDTDBContent();
            ModifierSP modifySP = new ModifierSP();
            ModifierChiTietSanPham modifierCTSP = new ModifierChiTietSanPham();

            string masp = modifySP.getNextMaSP();
            modifySP.ThemSPMoi(model.SanPham);
            modifierCTSP.ThemChiTietSanPhamMoi(model.ChiTietSanPham, masp);
            new ModifierTonKho().InsertTonKho(masp);
            return Json("true", JsonRequestBehavior.AllowGet);
        }

        public JsonResult InsertProduct(ProductManager model)
        {
            new ProductManager().InsertProduct(model);
            return Json("", JsonRequestBehavior.AllowGet);
        }


    }
}
