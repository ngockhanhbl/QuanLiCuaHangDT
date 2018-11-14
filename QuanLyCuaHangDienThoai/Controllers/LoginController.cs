using QuanLyCuaHangDienThoai.Models.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace QuanLyCuaHangDienThoai.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public JsonResult KiemTraDangNhap(Login model)
        {
            Login login = new Login();
            string s = login.KTuserpass(model.username, model.password);
            if (s == "0")
            {
                //
            }
            else
            {
                Session["username"] = model.username;
                Session["quyen"] = s;
            }
            return Json(s, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Logout()
        {
            Session.Abandon();
            Session.Clear();
            return RedirectToAction("Index", "Login", new { @area = "" });
        }
    }
}