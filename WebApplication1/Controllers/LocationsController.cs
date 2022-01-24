using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class LocationsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Stockholm()
        {
            return View();
        }

        public IActionResult Malmo()
        {
            return View();
        }
    }
}
