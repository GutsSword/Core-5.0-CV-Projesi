using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreP1.Controllers
{
    public class FeatureController : Controller
    {
        FeatureManager featureManager = new FeatureManager(new EFFeatureDal());
        [HttpGet]
        public IActionResult Index()
        {
            var values = featureManager.TGetByID(1);
            return View(values);
        }
        [HttpPost]
        public IActionResult Index(Feature p )
        {
            featureManager.TUpdate(p);
            return RedirectToAction("Index");
        }

    }
}
