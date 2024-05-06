using Microsoft.AspNetCore.Mvc;

namespace Hosipital.Areas.Patient.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
