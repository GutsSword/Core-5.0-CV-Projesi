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
    public class PortfolioManager : IPortfolioService
    {
        IPortfolioDal portfolioDal;

        public PortfolioManager(IPortfolioDal portfolioDal)
        {
            this.portfolioDal = portfolioDal;
        }

        public List<Portfolio> GetList()
        {
            return portfolioDal.GetList();
        }

        public void Tadd(Portfolio t)
        {
            portfolioDal.Insert(t);
        }

        public void TDelete(Portfolio t)
        {
            portfolioDal.Delete(t);
        }

        public Portfolio TGetByID(int id)
        {
            return portfolioDal.GetByID(id);
        }

        public List<Portfolio> TGetListByFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Portfolio t)
        {
            portfolioDal.Update(t);
        }
    }
}
