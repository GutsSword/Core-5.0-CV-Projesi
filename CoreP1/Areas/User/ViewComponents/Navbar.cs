using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Threading.Tasks;

namespace CoreP1.Areas.User.ViewComponents
{
    public class Navbar : ViewComponent
    {
        private readonly UserManager<UserUser> userManager;

        public Navbar(UserManager<UserUser> userManager)
        {
            this.userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.img = values.ImageUrl;
            return View(values);
        }
    }
}
