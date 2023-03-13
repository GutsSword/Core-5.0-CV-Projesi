using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreP1.Areas.Writer.Controllers
{
    [Area("User")]
    [Authorize]
    public class DefaultController : Controller
    {
        AnnouncementManager announcementManager = new AnnouncementManager(new EFAnnouncementDal());
        public IActionResult Index()
        {
            var values=announcementManager.GetList();
            return View(values);
        }
        public IActionResult AnnouncementDetailes(int id) 
        {
            var values=announcementManager.TGetByID(id);
            return View(values);
        }
    }
}
