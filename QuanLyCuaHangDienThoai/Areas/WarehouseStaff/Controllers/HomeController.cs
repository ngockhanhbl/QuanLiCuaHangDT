using QuanLyCuaHangDienThoai.Areas.WarehouseStaff.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyCuaHangDienThoai.Areas.WarehouseStaff.Controllers
{
    public class HomeController : Controller
    {
        // GET: WarehouseStaff/Home
        public ActionResult Index()
        {
            if (Session["username"] != null && (string)Session["quyen"] == "Warehouse")
            {
                ViewBag.listSanPham = new SelectList(new WarehouseNhapKho().GetListSP(), "maSanPham", "tenSanPham");
                ViewBag.listInfoTonKho = new WareHouseTonKho().GetListTK();
                return View();
            }

            return RedirectToAction("Index", "Login", new { @area = "" });
        }
        public JsonResult NhapKho(WarehouseNhapXuat model)
        {
            WarehouseNhapKho model1 = new WarehouseNhapKho();
            model1.InsertNhapKho(model.Nhap);
            return Json("true", JsonRequestBehavior.AllowGet);
        }


        public JsonResult XuatKho(WarehouseNhapXuat model)
        {
            WarehouseXuatKho model1 = new WarehouseXuatKho();
            if (model1.RemoveXuatKho(model.Xuat) == "false")
            {
                return Json("false", JsonRequestBehavior.AllowGet);
            }
            return Json("true", JsonRequestBehavior.AllowGet);

        }
    }
}