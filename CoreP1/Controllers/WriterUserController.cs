using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CoreP1.Controllers
{
    public class WriterUserController : Controller
    {
        WriterManager writerManager = new WriterManager(new EFWriterDal());
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ListUser()
        {
            var values = JsonConvert.SerializeObject(writerManager.GetList());
            return Json(values);
        }
        [HttpGet]
        public IActionResult AddUser(UserUser p)
        {
            writerManager.Tadd(p);
            var values = JsonConvert.SerializeObject(p);
            return Json(values);
        }
    }
}
