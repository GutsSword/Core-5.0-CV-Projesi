using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using Microsoft.AspNetCore.Mvc;

namespace CoreP1.ViewComponents.Skill
{
    public class SkillList : ViewComponent
    {
        SkillManager skillManager = new SkillManager(new EFSkillDal());
        public IViewComponentResult Invoke()
        {
            var values = skillManager.GetList();
            return View(values);
        }
    }
}
