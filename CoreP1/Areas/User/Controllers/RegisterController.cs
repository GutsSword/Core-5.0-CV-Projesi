using CoreP1.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc;
using System.Threading.Tasks;

namespace CoreP1.Areas.User.Controllers
{
    [Area("User")]
    public class RegisterController : Controller
    {
        private readonly UserManager<UserUser> _userManager;

        public RegisterController(UserManager<UserUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserRegisterViewModel p)
        {
            if (ModelState.IsValid)
            {
                UserUser x = new UserUser()
                {
                   Name = p.Name,
                   Surname = p.Surname,
                   Email = p.Mail,
                   UserName = p.UserName,
                   ImageUrl = p.ImageUrl,
                };
                var result = await _userManager.CreateAsync(x, p.Password);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index","Login");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
            return View(p);
        }

    }
}
