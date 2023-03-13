using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreP1.Areas.User.ViewComponents
{
    public class Notification : ViewComponent
    {
        AnnouncementManager announcementManager = new AnnouncementManager( new EFAnnouncementDal());
        public IViewComponentResult Invoke()
        {
            var values = announcementManager.GetList().Take(5).ToList();
            
            return View(values);
        }
    }
}
