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
    public class AboutManager : IAboutService
    {
        IAboutDal _aboutdal;

        public AboutManager(IAboutDal aboutdal)
        {
            _aboutdal = aboutdal;
        }

        public List<About> GetList()
        {
          return _aboutdal.GetList();
        }

        public void Tadd(About t)
        {
            _aboutdal.Insert(t);
        }

        public void TDelete(About t)
        {
            _aboutdal.Delete(t);
        }

        public About TGetByID(int id)
        {
            return _aboutdal.GetByID(id);
        }

        public List<About> TGetListByFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(About t)
        {
            _aboutdal.Update(t);
        }
    }
}
