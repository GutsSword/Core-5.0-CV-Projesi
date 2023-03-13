using CoreP1.Areas.User.Models;
using DataAccessLayer.EntityFramwork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Threading.Tasks;

namespace CoreP1.Areas.User.Controllers
{
    [Area("User")]
    public class ProfileController : Controller
    {
        private readonly UserManager<UserUser> userManager;

        public ProfileController(UserManager<UserUser> userManager)
        {
            this.userManager = userManager;
        }

        [HttpGet]
        public async Task <IActionResult> Index()
        {
            var values=await userManager.FindByNameAsync(User.Identity.Name);
            UserEditViewModel model = new UserEditViewModel();
            model.Name = values.Name;
            model.Surname = values.Surname;
            model.PictureUrl = values.ImageUrl;
            return View(model); 
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserEditViewModel p)
        {
            var values = await userManager.FindByNameAsync(User.Identity.Name);
            if(p.Picture!=null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(p.Picture.FileName);
                var imagename = Guid.NewGuid() + extension;
                var savelocation = resource + "/wwwroot/UserImage/" + imagename;
                var stream = new FileStream(savelocation, FileMode.Create);
                await p.Picture.CopyToAsync(stream);
                values.ImageUrl = imagename;
            }
            values.Name=p.Name;
            values.Surname = p.Surname;
            var result=await userManager.UpdateAsync(values);
            if(result.Succeeded)
            {
                return RedirectToAction("Index","Profile");
            }
            ViewBag.userpic = values.ImageUrl;
            return View();
        }
    }
}
