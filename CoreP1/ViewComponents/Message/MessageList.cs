using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CoreP1.ViewComponents.Message
{
    public class MessageList : ViewComponent
    {
        MessageManager messageManager = new MessageManager(new EFMessageDal());
        [HttpGet]
        public IViewComponentResult Invoke()
        {
            return View();
        }

    }
}
