using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramwork;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.Language;

namespace CoreP1.Controllers
{
    public class PortfolioController : Controller
    {
        PortfolioManager portfolioManager = new PortfolioManager(new EFPortfolioDal());
        public IActionResult Index()
        {
            var values=portfolioManager.GetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddPortfolio()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddPortfolio(Portfolio portfolio)
        {
            PortfolioValidator validations=new PortfolioValidator();
            ValidationResult rules = validations.Validate(portfolio);
            if(rules.IsValid)
            {
                portfolioManager.Tadd(portfolio);
                return RedirectToAction("Index");
            }
            else
            {
                foreach(var item in rules.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return RedirectToAction("Index");
        }
        public IActionResult DeletePortfolio(int id)
        {
            var values = portfolioManager.TGetByID(id);
            portfolioManager.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdatePortfolio(int id)
        {
            var values = portfolioManager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdatePortfolio(Portfolio p)
        {
            portfolioManager.TUpdate(p);
            return RedirectToAction("Index");
        }
    }
}
