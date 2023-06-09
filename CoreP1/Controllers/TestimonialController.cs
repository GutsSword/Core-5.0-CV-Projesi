﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace CoreP1.Controllers
{
    [Authorize(Roles = "Admin")]
    public class TestimonialController : Controller
    {
        TestimonialManager testimonialManager = new TestimonialManager(new EFTestimonialDal());
        public IActionResult Index()
        {
            var values = testimonialManager.GetList();
            return View(values);
        }
        public IActionResult TestimonialDelete(int id)
        {
            var values = testimonialManager.GetByID(id);
            testimonialManager.Delete(values);
            return RedirectToAction("Index","Testimonial");
        }
        public IActionResult TestimonialDetail(int id)
        {
            var values = testimonialManager.GetByID(id);
            return View(values);
        }
    }
}
