using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using Microsoft.AspNetCore.Mvc;

namespace CoreP1.ViewComponents.Contact
{
    public class ContactList : ViewComponent
    {
        ContactManager contactManager = new ContactManager(new EFContactDal());
        public IViewComponentResult Invoke()
        {
            var values = contactManager.GetList();
            return View(values);
        }
    }
}
