using Microsoft.AspNetCore.Mvc;

namespace Pronia_HW.Areas.Admin.Controllers
{
    [Area ("Admin")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
