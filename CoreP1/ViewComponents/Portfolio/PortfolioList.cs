using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using Microsoft.AspNetCore.Mvc;

namespace CoreP1.ViewComponents.Portfolio
{
    public class PortfolioList : ViewComponent
    {

        PortfolioManager portfolioManager = new PortfolioManager(new EFPortfolioDal());
        public IViewComponentResult Invoke()
        {
            var values = portfolioManager.GetList();
            return View(values);
        }
    }
}
