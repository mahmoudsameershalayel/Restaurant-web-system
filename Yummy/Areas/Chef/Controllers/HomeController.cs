


using Microsoft.AspNetCore.Mvc;

namespace Yummy.Areas.Chef.Controllers
{
    public class HomeController : ChefBaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
