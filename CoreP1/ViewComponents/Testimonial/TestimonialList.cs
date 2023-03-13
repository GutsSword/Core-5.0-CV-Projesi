using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using Microsoft.AspNetCore.Mvc;

namespace CoreP1.ViewComponents.Testimonial
{
    public class TestimonialList : ViewComponent
    {
        TestimonialManager testimonialManager = new TestimonialManager(new EFTestimonialDal());
        public IViewComponentResult Invoke()
        {
            var value = testimonialManager.GetList();
            return View(value);
        }
    }
}
