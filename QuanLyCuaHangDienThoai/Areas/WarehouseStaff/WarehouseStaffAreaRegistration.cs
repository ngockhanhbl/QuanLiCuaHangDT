using System.Web.Mvc;

namespace QuanLyCuaHangDienThoai.Areas.WarehouseStaff
{
    public class WarehouseStaffAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "WarehouseStaff";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "WarehouseStaff_default",
                "WarehouseStaff/{controller}/{action}/{id}",
                new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}