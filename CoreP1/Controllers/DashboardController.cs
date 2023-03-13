using Microsoft.AspNetCore.Mvc;

namespace CoreP1.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
