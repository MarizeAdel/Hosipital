using Microsoft.AspNetCore.Mvc;

namespace Hosipital.Areas.Admin.Controllers
{
    public class HospitalsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
