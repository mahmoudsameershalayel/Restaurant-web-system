using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Yummy.Data;

namespace Yummy.Controllers
{
    public class MenuController : Controller
    {
        private readonly ApplicationDbContext _context;
        public MenuController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Menu()
        {
            var meals = _context.meals.Include(x=>x.Category).Include(x=>x.ApplicationUser).ToList();
            return View(meals);
        }
    }
}
