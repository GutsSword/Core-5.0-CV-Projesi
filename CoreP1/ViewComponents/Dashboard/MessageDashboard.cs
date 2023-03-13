using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using Microsoft.AspNetCore.Mvc;

namespace CoreP1.ViewComponents.Dashboard
{
    public class MessageDashboard : ViewComponent 
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
