using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Yummy.Data;

namespace Yummy.Controllers
{
    public class ChefsController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        public ChefsController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Chefs()
        {
            var _chefs = await _userManager.Users.Where(x=>x.userType == UserType.Chef).ToListAsync();
            return View(_chefs);
        }
    }
}
