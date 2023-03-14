using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using Microsoft.AspNetCore.Mvc;

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
        public IActionResult SenderMessageList()
        {
            string p;
            p = "admin@gmail.com";
            var values = userMessageNewManager.GetListSenderMessage(p);
            return View(values);
        }
    }
}
