using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CoreP1.Areas.User.Controllers
{
    [Area("User")]
    
    public class DashboardController : Controller
    {
        private readonly UserManager<UserUser> userManager;

        public DashboardController(UserManager<UserUser> userManager)
        {
            this.userManager = userManager;
        }

        public async Task <IActionResult> Index()
        {
            var values = await userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.username = values.Name + " " + values.Surname;
            //Weather API
            string api = "9132e9515da90230ddfe7e231a702f7a";
            string connection = "https://api.openweathermap.org/data/2.5/weather?q=izmir&mode=xml&lang=tr&units=metric&appid=" + api;
            XDocument document=XDocument.Load(connection);
            ViewBag.a1 = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;

            //statistics
            Context c = new Context();
            ViewBag.v6 = c.UserMessageNews.Where(x => x.Receiver == values.Email).Count();
            ViewBag.v1 = 0;
            ViewBag.v2 = c.Announcements.Count();
            ViewBag.v4 = c.Skills.Count();
            ViewBag.v5 = c.Users.Count();
            return View();
        }

    }
}
