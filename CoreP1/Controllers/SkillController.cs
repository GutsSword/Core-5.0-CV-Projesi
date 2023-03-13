using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreP1.Controllers
{
    public class SkillController : Controller
    {
        SkillManager skillManager = new SkillManager(new EFSkillDal());
        public IActionResult Index()
        {
            ViewBag.v1 = "Beceri Listesi";
            ViewBag.v2 = "Ana Sayfa";
            ViewBag.v3 = "Beceri Listesi";
            var values = skillManager.GetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddSkill()
        {
            ViewBag.v1 = "Beceri Ekle";
            ViewBag.v2 = "Beceri Listesi";
            ViewBag.v3 = "Beceri Ekle";
            return View();
        }
        [HttpPost]
        public IActionResult AddSkill(Skill skill) 
        {
            skillManager.Tadd(skill);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteSkill(int id) 
        {
            var values=skillManager.TGetByID(id);
            skillManager.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateSkill(int id)
        {
            var values = skillManager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateSkill(Skill skill)
        {
            skillManager.TUpdate(skill);
            return RedirectToAction("Index");
        }
    }
}
