using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyCuaHangDienThoai.Controllers
{
    public class HomeUserController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Instalment()
        {
            //ViewBag.Message = "Your application description page.";

            return View();
        }
       
        public ActionResult Promotion()
        {
            return View();
        }
        

        public ActionResult Recruitment()
        {
            return View();
        }

        public ActionResult Introduce()
        {
            return View();
        }

        public ActionResult PurchasePolicy()
        {
            return View();
        }
        
        public ActionResult Score()
        {
            return View();
        }

        public ActionResult Repair()
        {
            return View();
        }

        public ActionResult SideMenu()
        {
            return PartialView("SideMenu");
        }

    }
}
