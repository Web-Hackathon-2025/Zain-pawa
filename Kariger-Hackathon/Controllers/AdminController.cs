using Microsoft.AspNetCore.Mvc;

namespace Kariger_Hackathon.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Reviews()
        {
            return View();
        }
    }
}
