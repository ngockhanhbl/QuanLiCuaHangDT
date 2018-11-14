using QuanLyCuaHangDienThoai.Areas.Accountant.Models;
using QuanLyCuaHangDienThoai.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyCuaHangDienThoai.Areas.Accountant.Controllers
{
    public class QuanLiHoaDonController : Controller
    {
        // GET: Accountant/QuanLiHoaDon
        public ActionResult Index()
        {
            QuanLyDTDBContent db = new QuanLyDTDBContent();

            if (Session["username"] != null && (string)Session["quyen"] == "Accountant")
            {
                //ViewBag.listInfoHoaDon = new AccountantQuanLiHoaDon().GetListHDon();
                List<AccountantQuanLiHoaDon> list = db.HOADONs.Select(x => new AccountantQuanLiHoaDon { MaHoaDon = x.maHoaDon, MaNVienLapHDon = x.maNhanVien, ThanhTien = (float)x.thanhTien, NgayLapHoaDon = x.ngayLapHoaDon }).ToList();
                ViewBag.listInfoHoaDon = list;
                return View();

            }

            return RedirectToAction("Index", "Login", new { @area = "" });
        }

        public ActionResult GetSearchRecord(string SearchText)
        {
            //      DateTime time = DateTime.Parse(SearchText);
            //      int Nam = time.Year;
            //      int Thang = time.Month;
            //      int Ngay = time.Day;
            QuanLyDTDBContent db = new QuanLyDTDBContent();
            //List<HOADON> list = db.HOADONs.Where(x => x.ngayLapHoaDon.Year == Nam  &&  x.ngayLapHoaDon.Month == Thang && x.ngayLapHoaDon.Day == Ngay).Select(x => new HOADON { maHoaDon = x.maHoaDon, ngayLapHoaDon = x.ngayLapHoaDon, thanhTien = x.thanhTien }).ToList();
            //List<HOADON> list = db..Where(x => x.maHoaDon == SearchText).ToList();
            List<AccountantQuanLiHoaDon> list = db.HOADONs.Where(x => x.maHoaDon.Contains(SearchText) || x.maNhanVien.Contains(SearchText)).Select(x => new AccountantQuanLiHoaDon { MaHoaDon = x.maHoaDon, MaNVienLapHDon = x.maNhanVien, ThanhTien = (float)x.thanhTien, NgayLapHoaDon = x.ngayLapHoaDon }).ToList();
            return PartialView("SearchPartial", list);

        }
    }
}