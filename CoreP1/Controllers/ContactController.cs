using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using Microsoft.AspNetCore.Mvc;

namespace CoreP1.Controllers
{
    public class ContactController : Controller
    {
        MessageManager messageManager = new MessageManager(new EFMessageDal());
        public IActionResult Index()
        {
            var values = messageManager.GetList();
            return View(values);
        }
        public IActionResult DeleteMessage(int id)
        {
            var values = messageManager.TGetByID(id);
            messageManager.TDelete(values);
            return RedirectToAction("Index");
        }
        public IActionResult MessageDetail(int id)
        {
            var values = messageManager.TGetByID(id);
            return View(values);
        }
    }
}
