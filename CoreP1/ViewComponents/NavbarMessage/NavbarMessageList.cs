using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreP1.ViewComponents.NavbarMessage
{
    public class NavbarMessageList : ViewComponent
    {
        UserMessageNewManager userMessageNewManager = new UserMessageNewManager(new EFUserMessageNewDal());
        public IViewComponentResult Invoke(UserMessageNew p)
        {
            Context c = new Context();
            string m = "admin@gmail.com";
            var values = userMessageNewManager.GetListReceiverMessage(m).OrderByDescending(x=>x.ID).Take(3).ToList();
            var img1 = c.UserMessageNews.Where(x => x.Receiver == m).Select(z=>z.Sender).FirstOrDefault();
            var img2 = c.Users.Where(x => x.Email == img1).Select(z => z.ImageUrl).FirstOrDefault();

            ViewBag.v1 = img2;
            return View(values);
        }

    }
}
