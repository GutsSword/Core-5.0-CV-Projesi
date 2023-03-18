using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Migrations;
using System.Linq;
using System.Runtime.Intrinsics;
using System.Security.Cryptography.X509Certificates;

namespace CoreP1.ViewComponents.Dashboard
{
    public class MessageDashboard : ViewComponent 
    {
        MessageManager messageManager = new MessageManager(new EFMessageDal());
        public IViewComponentResult Invoke()
        {
            var values = messageManager.GetList();
            return View(values);
        }
    }
}
