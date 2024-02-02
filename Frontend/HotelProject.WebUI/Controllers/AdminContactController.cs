using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.Controllers
{
    public class AdminContactController : Controller
    {
        public IActionResult Inbox()
        {
            return View();
        }
    }
}
