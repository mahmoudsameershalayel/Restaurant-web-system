
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Yummy.Data;

namespace Yummy.Areas.Admin.Controllers
{
    public class HomeController : AdminBaseController
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        public HomeController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var ListOfEvent = _context.events.ToList();
            var eventsCount = ListOfEvent.Count;
            var ListOfChefs = await _userManager.Users.Where(x => x.userType == UserType.Chef).ToListAsync();
            var chefsCount = ListOfChefs.Count;
            var admin = await _userManager.FindByEmailAsync("mahmoud@admin.com");
            ViewBag.TotalEvents = eventsCount;
            ViewBag.TotalChefs = chefsCount;
            return View(admin);

        }
        
    }
}
