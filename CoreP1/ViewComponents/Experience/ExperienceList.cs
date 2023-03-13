using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using Microsoft.AspNetCore.Mvc;

namespace CoreP1.ViewComponents.ExperienceList
{
    public class ExperienceList : ViewComponent
    {
        ExperienceManager experienceManager = new ExperienceManager(new EFExperienceDal());
        public IViewComponentResult Invoke()
        {
            var value=experienceManager.GetList();
            return View(value);
        }
    }
}
