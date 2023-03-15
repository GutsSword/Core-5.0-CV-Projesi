using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace CoreP1.Controllers
{
    public class AdminMessageController : Controller
    {
        UserMessageNewManager userMessageNewManager = new UserMessageNewManager(new EFUserMessageNewDal());
        public IActionResult ReceiverMessageList()
        {
            string p;
            p = "admin@gmail.com";
            var values = userMessageNewManager.GetListReceiverMessage(p);
            return View(values);
        }
        public IActionResult ReceiverMessageDelete(int id)
        {
            var values = userMessageNewManager.TGetByID(id);
            userMessageNewManager.TDelete(values);
            return RedirectToAction("ReceiverMessageList","AdminMessage");
        }
        public IActionResult SenderMessageList()
        {
            string p;
            p = "admin@gmail.com";
            var values = userMessageNewManager.GetListSenderMessage(p);
            return View(values);
        }
        public IActionResult SenderMessageDelete(int id)
        {
            var values = userMessageNewManager.TGetByID(id);
            userMessageNewManager.TDelete(values);
            return RedirectToAction("SenderMessageList", "AdminMessage");
        }
        public IActionResult MessageDetail(int id)
        {
            var values = userMessageNewManager.TGetByID(id);
            return View(values);
        }
        public IActionResult SenderMessageDetail(int id)
        {
            var values = userMessageNewManager.TGetByID(id);
            return View(values);
        }
        [HttpGet]
        public IActionResult SendMessageList()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SendMessageList(UserMessageNew p)
        {
            p.SenderName = "Admin";
            p.Date = DateTime.Now;
            p.Sender = "admin@gmail.com";
            Context c = new Context();
            var username = c.Users.Where(x => x.Email == p.Receiver).Select(y => y.Name + " " + y.Surname).FirstOrDefault();
            p.ReceiverName = username;
            userMessageNewManager.Tadd(p);
            return RedirectToAction("SenderMessageList", "AdminMessage");
        }
        public IActionResult SendMessageDetail(int id)
        {
            var values = userMessageNewManager.TGetByID(id);
            return View(values);
        }
    }
}
