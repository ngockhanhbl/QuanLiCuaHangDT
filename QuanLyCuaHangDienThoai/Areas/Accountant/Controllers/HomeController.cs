using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyCuaHangDienThoai.Areas.Accountant.Controllers
{
    public class HomeController : Controller
    {
        // GET: Accountant/Home
        public ActionResult Index()
        {
            if (Session["username"] != null && (string)Session["quyen"] == "Accountant")
            {
                return View();
            }

            return RedirectToAction("Index", "Login", new { @area = "" });
        }
    }
}