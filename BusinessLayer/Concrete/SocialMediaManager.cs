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
    public class SocialMediaManager : ISocialMediaService
    {
        ISocialMediaDal socialMediaDal;

        public SocialMediaManager(ISocialMediaDal socialMediaDal)
        {
            this.socialMediaDal = socialMediaDal;
        }

        public List<SocialMedia> GetList()
        {
            return socialMediaDal.GetList();    
        }

        public void Tadd(SocialMedia t)
        {
            socialMediaDal.Insert(t);
        }

        public void TDelete(SocialMedia t)
        {
            socialMediaDal.Delete(t);
        }

        public SocialMedia TGetByID(int id)
        {
            return socialMediaDal.GetByID(id);
        }

        public List<SocialMedia> TGetListByFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(SocialMedia t)
        {
            socialMediaDal.Update(t);
        }
    }
}
