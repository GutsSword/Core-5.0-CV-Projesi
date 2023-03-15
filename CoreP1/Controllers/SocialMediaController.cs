using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreP1.Controllers
{
    public class SocialMediaController : Controller
    {
        SocialMediaManager socialMediaManager = new SocialMediaManager(new EFSocialMediaDal());

        public IActionResult Index()
        {
            var values = socialMediaManager.GetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddMedia()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddMedia(SocialMedia p)
        {
            socialMediaManager.Tadd(p);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteMedia(int id) 
        {
            var values = socialMediaManager.TGetByID(id);
            socialMediaManager.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateMedia(int id)
        {
            var values = socialMediaManager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateMedia(SocialMedia p)
        {
            socialMediaManager.TUpdate(p);
            return RedirectToAction("Index");
        }
    }
}
