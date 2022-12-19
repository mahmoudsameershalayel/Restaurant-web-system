using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Yummy.Data;
using Yummy.ViewModels;

namespace Yummy.Controllers
{
    public class AuthenticationController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        public AuthenticationController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        [HttpGet]
        [Route("/Login")]
        public IActionResult Login(string? ReturnUrl)
        {
            ViewData["ReturnUrl"] = ReturnUrl;
            return View();
        }
        [HttpPost]
        [Route("/Login")]
        public async Task<IActionResult> Login(LoginVM user)
        {
            var _user = await _userManager.FindByEmailAsync(user.Email);
            if (user == null)
            {
                ModelState.AddModelError(string.Empty, "Invalid login attempt.2");
                return View();
            }
            var result = await _signInManager.PasswordSignInAsync(_user, user.Password, false, false);
            if (result.Succeeded)
            {
                return LocalRedirect(user.ReturnUrl);
            }
            else
            {
                //ViewData["ReturnUrl"] = loginVM.ReturnUrl;
                ModelState.AddModelError(string.Empty, "Invalid login attempt.");
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index" , "Home");  
        }
    }
}
