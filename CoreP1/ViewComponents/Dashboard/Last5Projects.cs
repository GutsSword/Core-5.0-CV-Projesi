using Microsoft.AspNetCore.Mvc;

namespace CoreP1.ViewComponents.Dashboard
{
    public class Last5Projects : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
