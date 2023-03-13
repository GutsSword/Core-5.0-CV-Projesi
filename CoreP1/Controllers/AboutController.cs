using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreP1.Controllers
{
    public class AboutController : Controller
    {
        AboutManager aboutManager = new AboutManager(new EFAboutDal());
        [HttpGet]
        public IActionResult Index()
        {
            var values = aboutManager.TGetByID(1);
            return View(values);
        }
        [HttpPost]
        public IActionResult Index(About p)
        {
            aboutManager.TUpdate(p);
            return RedirectToAction("Index");
        }
    }
}
