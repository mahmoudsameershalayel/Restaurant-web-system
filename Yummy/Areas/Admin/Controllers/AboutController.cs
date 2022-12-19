using Microsoft.AspNetCore.Mvc;
using Yummy.Areas.Admin.ViewModels;
using Yummy.Data;
using Yummy.Models;

namespace Yummy.Areas.Admin.Controllers
{
    public class AboutController : AdminBaseController
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _hostingEnvironment;
        public AboutController(ApplicationDbContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            _hostingEnvironment = hostEnvironment;
        }
        public IActionResult Index()
        {
            var articles = _context.aboutArticle.ToList();
            return View(articles);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Aboutarticle article)
        {
            if (ModelState.IsValid)
            {
                _context.aboutArticle.Add(article);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        
    }
}
