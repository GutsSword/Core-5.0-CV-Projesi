using Microsoft.AspNetCore.Mvc;

namespace CoreP1.Controllers
{
    public class denemeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
