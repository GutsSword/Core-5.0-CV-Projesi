using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Update.Internal;
using System.Data;

namespace CoreP1.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ServiceController : Controller
    {
        ServiceManager serviceManager = new ServiceManager(new EFServiceDal());

        public IActionResult Index()
        {
            var value = serviceManager.GetList();
            return View(value);
        }
        [HttpGet]
        public IActionResult AddService()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddService(Service p)
        {
            serviceManager.Tadd(p);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteService(int id)
        {
            var values=serviceManager.TGetByID(id);
            serviceManager.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateService(int id)
        {
            var values = serviceManager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateService(Service p)
        {
            serviceManager.TUpdate(p);
            return RedirectToAction("Index");
        }
    }
}
