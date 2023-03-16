using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace CoreP1.Controllers
{
    [Authorize(Roles = "Admin")]
    public class SubContentController : Controller
    {
        ContactManager contactManager = new ContactManager(new EFContactDal());

        [HttpGet]
        public IActionResult Index()
        {
            var values = contactManager.TGetByID(1);
            return View(values);
        }
        [HttpPost]
        public IActionResult Index(Contact p)
        {
            contactManager.TUpdate(p);
            return RedirectToAction("Index","SubContent");
        }
    }
}
