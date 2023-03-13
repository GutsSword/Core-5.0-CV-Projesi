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
    public class UserMessageNewManager : IUserMessageNewService
    {
        IUserMessageNewDal userMessageNewDal;

        public UserMessageNewManager(IUserMessageNewDal userMessageNewDal)
        {
            this.userMessageNewDal = userMessageNewDal;
        }

        public List<UserMessageNew> GetList()
        {
            return userMessageNewDal.GetList(); 
        }

        public List<UserMessageNew> GetListReceiverMessage(string p)
        {
            return userMessageNewDal.GetByFilter(x => x.Receiver == p);
        }

        public List<UserMessageNew> GetListSenderMessage(string p)
        {
            return userMessageNewDal.GetByFilter(x => x.Sender == p);
        }

        public void Tadd(UserMessageNew t)
        {
            userMessageNewDal.Insert(t);
        }

        public void TDelete(UserMessageNew t)
        {
            userMessageNewDal.Delete(t);
        }

        public UserMessageNew TGetByID(int id)
        {
            return userMessageNewDal.GetByID(id);
        }
        public List<UserMessageNew> TGetListByFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(UserMessageNew t)
        {
            userMessageNewDal.Update(t);
        }
    }
}
