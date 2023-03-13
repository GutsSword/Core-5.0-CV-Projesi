using Microsoft.AspNetCore.Mvc;

namespace CoreP1.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
