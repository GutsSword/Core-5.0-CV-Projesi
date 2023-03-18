using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Linq;

namespace CoreP1.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        public PartialViewResult PartialSideBar()
        {
            return PartialView();
        }
        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }
        public PartialViewResult PartialScript()
        {
            return PartialView();
        }
        public PartialViewResult NavigationPartial()
        {
            return PartialView();   
        }
        public PartialViewResult NewSideBar()
        {
            Context c = new Context();
            var x = c.Users.Where(x => x.Email == "admin@gmail.com").Select(z => z.UserName).FirstOrDefault();
            ViewBag.v1 = x;
            return PartialView();
        }
    }
}
