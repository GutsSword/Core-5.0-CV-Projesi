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
    public class ServiceManager : IServiceService
    {
        IServiceDal _iservicedal;

        public ServiceManager(IServiceDal iservicedal)
        {
            _iservicedal = iservicedal;
        }

        public List<Service> GetList()
        {
            return _iservicedal.GetList();
        }

        public void Tadd(Service t)
        {
            _iservicedal.Insert(t);
        }

        public void TDelete(Service t)
        {
            _iservicedal.Delete(t);
        }

        public Service TGetByID(int id)
        {
            return _iservicedal.GetByID(id);
        }

        public List<Service> TGetListByFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Service t)
        {
            _iservicedal.Update(t);
        }
    }
}
