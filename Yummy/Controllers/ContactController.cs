using Microsoft.AspNetCore.Mvc;
using Yummy.Data;
using Yummy.Models;
using Yummy.ViewModels;

namespace Yummy.Controllers
{
    public class ContactController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ContactController(ApplicationDbContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Contact(ContactVM contact)
        {
            if (ModelState.IsValid)
            {
                _context.contacts.Add(
                    new Contact
                    {
                        Name = contact.Name,
                        Message = contact.Message,
                        Email = contact.Email,
                        Subject = contact.Subject
                    });
                _context.SaveChanges(); 
                return RedirectToAction("Index", new { message = "Success" });
            }
            else
            {
                return View();
            }
                
            
        }
    }
}
