using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramwork;
using Microsoft.AspNetCore.Mvc;

namespace CoreP1.ViewComponents.Dashboard
{
    public class TodoList : ViewComponent
    {
        ToDoListManager toDoListManager = new ToDoListManager(new EFToDoListDal());
        public IViewComponentResult Invoke()
        {
            var values = toDoListManager.GetList();
            return View(values);
        }
    }
}
