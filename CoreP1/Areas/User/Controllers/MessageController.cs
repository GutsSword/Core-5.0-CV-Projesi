using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace CoreP1.Areas.User.Controllers
{
    [Area("User")]
    public class MessageController : Controller
    {
        UserMessageNewManager _userMessageNewManager= new UserMessageNewManager(new EFUserMessageNewDal());
        private readonly UserManager<UserUser> userManager;

        public MessageController(UserManager<UserUser> userManager)
        {
            this.userManager = userManager;
        }

        public async Task<IActionResult> Index(string p)
        {
            var values = await userManager.FindByNameAsync(User.Identity.Name);
            p = values.Email;
            var messagelist=_userMessageNewManager.TGetListByFilter(p);
            return View(messagelist);
        }
    }
}
