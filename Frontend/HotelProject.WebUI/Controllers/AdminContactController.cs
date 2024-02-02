using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.Controllers
{
    public class AdminContactController : Controller
    {
        public IActionResult Inbox()
        {
            return View();
        }
        public PartialViewResult SideBarAdminContactPartial()
        {
            return PartialView();
        }
        public PartialViewResult SideBarAdminContactCategoryPartial()
        {
            return PartialView();
        }
    }
}
