using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class WriterManager : IWriterService
    {
        IWriterDal writerDal;

        public WriterManager(IWriterDal writerDal)
        {
            this.writerDal = writerDal;
        }

        public List<UserUser> GetList()
        {
         return writerDal.GetList();
        }

        public void Tadd(UserUser t)
        {
            writerDal.Insert(t);
        }

        public void TDelete(UserUser t)
        {
            writerDal.Delete(t);
        }

        public UserUser TGetByID(int id)
        {
           return writerDal.GetByID(id);
        }

        public List<UserUser> TGetListByFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(UserUser t)
        {
            writerDal.Update(t);
        }
    }
}
