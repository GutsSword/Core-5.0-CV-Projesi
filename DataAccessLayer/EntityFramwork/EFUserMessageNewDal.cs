using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramwork
{
    public class EFUserMessageNewDal : GenericRepository<UserMessageNew>, IUserMessageNewDal
    {
        public List<UserMessageNew> GetByFilter()
        {
            throw new NotImplementedException();
        }
    }
}
