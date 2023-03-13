using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using Microsoft.AspNetCore.Mvc;

namespace CoreP1.ViewComponents.About
{
    public class AboutList : ViewComponent
    {
        AboutManager aboutManager = new AboutManager(new EFAboutDal());
        public IViewComponentResult Invoke()
        {
            var values = aboutManager.GetList();
            return View(values);
        }
    }
}
