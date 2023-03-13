using Microsoft.AspNetCore.Mvc;

namespace CoreP1.Controllers
{
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
            return PartialView();
        }
    }
}
