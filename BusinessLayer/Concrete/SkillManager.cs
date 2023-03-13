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
    public class SkillManager : ISkillService
    {
        ISkillDal _skilldal;

        public SkillManager(ISkillDal skilldal)
        {
            _skilldal = skilldal;
        }

        public List<Skill> GetList()
        {
            return _skilldal.GetList();
        }

        public void Tadd(Skill t)
        {
            _skilldal.Insert(t);
        }

        public void TDelete(Skill t)
        {
            _skilldal.Delete(t);    
        }

        public Skill TGetByID(int id)
        {
            return _skilldal.GetByID(id);
        }

        public List<Skill> TGetListByFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Skill t)
        {
            _skilldal.Update(t);
        }
    }
}
