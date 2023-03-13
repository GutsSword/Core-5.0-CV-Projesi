using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace CoreP1.ViewComponents.Service
{
    public class ServiceList : ViewComponent
    {
        ServiceManager serviceManager = new ServiceManager(new EFServiceDal());
        
        public IViewComponentResult Invoke()
        {
            var values = serviceManager.GetList();
            return View(values);
        }
    }
    
}
