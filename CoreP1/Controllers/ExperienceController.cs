using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreP1.Controllers
{
    public class ExperienceController : Controller
    {
        ExperienceManager experienceManager = new ExperienceManager(new EFExperienceDal());
        public IActionResult Index()
        {
            var values = experienceManager.GetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddExperience()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddExperience(Experience experience)
        {
            experienceManager.Tadd(experience);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteExperience(int id) 
        {
            var values=experienceManager.TGetByID(id);
            experienceManager.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateExperience(int id)
        {
            var value = experienceManager.TGetByID(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateExperience(Experience experience)
        {
            experienceManager.TUpdate(experience);
            return RedirectToAction("Index");
        }
    }
}
