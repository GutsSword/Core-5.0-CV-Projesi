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
    public class UserMessageManager : IUserMessageService
    {
        IUserMessageDal _userMessageDal;

        public UserMessageManager(IUserMessageDal userMessageDal)
        {
            _userMessageDal = userMessageDal;
        }

        public List<UserMessage> GetList()
        {
           return _userMessageDal.GetList();
        }

        public List<UserMessage> GetUserMessageWithUserService()
        {
            return _userMessageDal.GetUserMessagesWithUser();
        }

        public void Tadd(UserMessage t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(UserMessage t)
        {
            throw new NotImplementedException();
        }

        public UserMessage TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<UserMessage> TGetListByFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(UserMessage t)
        {
            throw new NotImplementedException();
        }
    }
}
