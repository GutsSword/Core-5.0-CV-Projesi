using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace CoreP1.Areas.User.Controllers
{
    [Area("User")]
    [Route("User/Message")]
    public class MessageController : Controller
    {
        UserMessageNewManager _userMessageNewManager= new UserMessageNewManager(new EFUserMessageNewDal());
        private readonly UserManager<UserUser> userManager;

        public MessageController(UserManager<UserUser> userManager)
        {
            this.userManager = userManager;
        }
        [Route("")]
        [Route("ReceiverMessage")]
        public async Task<IActionResult> ReceiverMessage(string p)
        {
            var values = await userManager.FindByNameAsync(User.Identity.Name);
            p = values.Email;
            var messagelist=_userMessageNewManager.GetListReceiverMessage(p);
            return View(messagelist);
        }
        [Route("ReceiverMessageDetails/{id}")]
        public IActionResult ReceiverMessageDetails(int id)
        {
            UserMessageNew userMessageNew = _userMessageNewManager.TGetByID(id);
             return View(userMessageNew);
        }
        [Route("")]
        [Route("SenderMessage")]
        public async Task<IActionResult> SenderMessage(string p)
        {
            var values = await userManager.FindByNameAsync(User.Identity.Name);
            p = values.Email;
            var messagelist = _userMessageNewManager.GetListSenderMessage(p);
            return View(messagelist);
        }
        [Route("SenderMessageDetails/{id}")]
        public IActionResult SenderMessageDetails(int id)
        {
            UserMessageNew userMessageNew = _userMessageNewManager.TGetByID(id);
            return View(userMessageNew);
        }
        [Route("")]
        [Route("CreateMessage")]
        [HttpGet]
        public IActionResult CreateMessage()
        {
            return View();
        }
        [HttpPost]
        [Route("")]
        [Route("CreateMessage")]
        public async Task<IActionResult> CreateMessage(UserMessageNew p)
        {
            var values = await userManager.FindByNameAsync(User.Identity.Name);
            string mail = values.Email;
            string name = values.Name + " " + values.Surname;
            p.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            p.Sender = mail;
            p.SenderName = name;
            Context c = new Context();
            var usernamesurname = c.Users.Where(x => x.Email == p.Receiver).Select(y => y.Name + " " + y.Surname).FirstOrDefault();
            p.ReceiverName = usernamesurname;
            _userMessageNewManager.Tadd(p);
            return RedirectToAction("SenderMessage");
        }
    }
}
