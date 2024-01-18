using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.ViewComponents.Default.Booking
{
    public class _BookingCoverPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
