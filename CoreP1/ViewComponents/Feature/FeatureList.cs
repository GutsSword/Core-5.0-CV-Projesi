using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using Microsoft.AspNetCore.Mvc;

namespace CoreP1.ViewComponents.Feature
{
    public class FeatureList : ViewComponent
    {
        FeatureManager featureManager = new FeatureManager(new EFFeatureDal());
        public IViewComponentResult Invoke()
        {
            var values = featureManager.GetList();
            return View(values);
        }
    }
}
