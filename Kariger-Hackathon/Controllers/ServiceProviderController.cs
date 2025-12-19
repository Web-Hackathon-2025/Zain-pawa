using Microsoft.AspNetCore.Mvc;

namespace Kariger_Hackathon.Controllers
{
    public class ServiceProviderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ServiceProvider()
        {
            return View();
        }
        public IActionResult Bookings()
        {
            return View();
        }

    }
}
