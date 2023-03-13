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
    public class AnnouncementManager : IAnnouncementService
    {
        IAnnouncementDal announcementDal;

        public AnnouncementManager(IAnnouncementDal announcementDal)
        {
            this.announcementDal = announcementDal;
        }

        public List<Announcement> GetList()
        {
            return announcementDal.GetList();
        }

        public void Tadd(Announcement t)
        {
            announcementDal.Insert(t);
        }

        public void TDelete(Announcement t)
        {
            announcementDal.Delete(t);
        }

        public Announcement TGetByID(int id)
        {
           return announcementDal.GetByID(id);
        }

        public List<Announcement> TGetListByFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Announcement t)
        {
            announcementDal.Update(t);
        }
    }
}
