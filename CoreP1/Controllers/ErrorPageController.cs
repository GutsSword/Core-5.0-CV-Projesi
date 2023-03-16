using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace CoreP1.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ErrorPageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
