using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ToDoListManager : IToDoListService
    {
        IToDoListDal toDoListDal;

        public ToDoListManager(IToDoListDal toDoListDal)
        {
            this.toDoListDal = toDoListDal;
        }

        public List<ToDoList> GetList()
        {
            return toDoListDal.GetList();
        }

        public void Tadd(ToDoList t)
        {
            toDoListDal.Insert(t);
        }

        public void TDelete(ToDoList t)
        {
            toDoListDal.Delete(t);
        }

        public ToDoList TGetByID(int id)
        {
           return toDoListDal.GetByID(id);
        }

        public List<ToDoList> TGetListByFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(ToDoList t)
        {
            toDoListDal.Update(t);  
        }
    }
}
