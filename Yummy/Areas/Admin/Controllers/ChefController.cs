using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;
using Yummy.Areas.Admin.ViewModels;
using Yummy.Areas.Chef.ViewModels;
using Yummy.Data;
using Yummy.Models;

namespace Yummy.Areas.Admin.Controllers
{
    public class ChefController : AdminBaseController
    {

        private readonly IWebHostEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IStringLocalizer<ChefController> _localizer;
        public ChefController(IWebHostEnvironment hostEnvironment, UserManager<ApplicationUser> userManager, IStringLocalizer<ChefController> localizer)
        {
            _hostingEnvironment = hostEnvironment;
            _userManager = userManager;
            _localizer = localizer;
        }

        public async Task<IActionResult> Index(int pg = 1)
        {
            var _chefs = await _userManager.Users
                .Where(x => x.userType == UserType.Chef)
                .ToListAsync();
            const int pageSize = 5;
            if (pg < 1)
            {
                pg = 1;
            }
            int _chefsCount = _chefs.Count;
            var pager = new Pager(_chefsCount, pg, pageSize);
            int _chefSkip = (pg - 1) * pageSize;
            var data = _chefs.Skip(_chefSkip).Take(pager.PageSize).ToList();
            ViewBag.Pager = pager;
            return View(data);
        }
        [HttpGet]
        public IActionResult Add()
        {
            ViewData["addChef"] = _localizer["Add Chef"].Value;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(ChefVM chef)
        {

            if (ModelState.IsValid)
            {
                ApplicationUser _chef = new ApplicationUser();
                _chef.FirstName = chef.FirstName;
                _chef.LastName = chef.LastName;
                _chef.JopTitle = chef.JopTitle;
                _chef.Description = chef.Description;
                var uploadFolder = Path.Combine(_hostingEnvironment.WebRootPath, "Images");
                var uniqueName = Guid.NewGuid().ToString() + Path.GetExtension(chef.Image.FileName);
                var filePath = Path.Combine(uploadFolder, uniqueName);
                chef.Image.CopyTo(new FileStream(filePath, FileMode.Create));
                _chef.ImageName = uniqueName;
                _chef.Email = chef.Email;
                _chef.userType = UserType.Chef;
                _chef.UserName = chef.UserName;
                var result = await _userManager.CreateAsync(_chef, chef.Password);
                /*
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }*/
                if (result.Succeeded)
                {
                    var result2 = await _userManager.AddToRoleAsync(_chef, "Chef");
                    return RedirectToAction("Index");
                }
            }
            return View(chef);
        }
        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
                return NotFound();
            EditChefVM editChef = new EditChefVM();
            editChef.FirstName = user.FirstName;
            editChef.LastName = user.LastName;
            editChef.Email = user.Email;
            editChef.UserName = user.UserName;
            editChef.JopTitle = user.JopTitle;
            editChef.Description = user.Description;
            editChef.ImageName = user.ImageName;
            return View(editChef);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(String id, EditChefVM editChef)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
                return NotFound();
            if (ModelState.IsValid)
            {
                user.FirstName = editChef.FirstName;
                user.LastName = editChef.LastName;
                user.Email = editChef.Email;
                user.UserName = editChef.UserName;
                user.JopTitle = editChef.JopTitle;
                user.Description = editChef.Description;
                user.userType = UserType.Chef;
                if (editChef.Image != null)
                {
                    var uploadFolder = Path.Combine(_hostingEnvironment.WebRootPath, "Images");
                    var uniqueName = Guid.NewGuid().ToString() + Path.GetExtension(editChef.Image.FileName);
                    var filePath = Path.Combine(uploadFolder, uniqueName);
                    editChef.Image.CopyTo(new FileStream(filePath, FileMode.Create));
                    user.ImageName = uniqueName;
                }
                var result = await _userManager.UpdateAsync(user);
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Details(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            return View(user);
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            var userd = await _userManager.DeleteAsync(user);
            if (userd.Succeeded)
            {
                return Json(new { id = id, message = "Deleted Successfully" });
            }
            return BadRequest();
        }
    }
}
