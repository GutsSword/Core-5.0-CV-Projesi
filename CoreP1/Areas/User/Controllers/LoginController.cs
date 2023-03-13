using CoreP1.Areas.User.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CoreP1.Areas.User.Controllers
{
    [Area("User")]
    [Route("User/[controller]/[action]")]
    public class LoginController : Controller
    {
        private readonly SignInManager<UserUser> signInManager;

        public LoginController(SignInManager<UserUser> signInManager)
        {
            this.signInManager = signInManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task <IActionResult> Index(UserLoginViewModel p)
        {
            if(ModelState.IsValid)
            {
                var result = await signInManager.PasswordSignInAsync(p.Username, p.Password, true, false);
                if (result.Succeeded) 
                {
                    return RedirectToAction("Index", "Profile");
                }
                else
                {
                    ModelState.AddModelError("", "Hatalı kullanıcı adı veya şifre.");
                }
            }
            return View();
        }
        public async Task<IActionResult> LogOut()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Login");
        }
    }
}
