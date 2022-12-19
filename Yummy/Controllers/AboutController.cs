using Microsoft.AspNetCore.Mvc;

namespace Yummy.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult About()
        {
            return View();
        }
    }
}
