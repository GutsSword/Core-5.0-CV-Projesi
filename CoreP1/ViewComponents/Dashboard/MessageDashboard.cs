using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using Microsoft.AspNetCore.Mvc;

namespace CoreP1.ViewComponents.Dashboard
{
    public class MessageDashboard : ViewComponent
      
    {
        UserMessageManager messageManager = new UserMessageManager(new EFUserMessageDal());
        public IViewComponentResult Invoke()
        {
            var values = messageManager.GetUserMessageWithUserService();
            return View(values);
        }
    }
}
