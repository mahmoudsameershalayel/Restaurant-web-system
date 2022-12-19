using Microsoft.AspNetCore.Mvc;

namespace Yummy.Controllers
{
    public class GalleryController : Controller
    {
        public IActionResult Gallery()
        {
            return View();
        }
    }
}
