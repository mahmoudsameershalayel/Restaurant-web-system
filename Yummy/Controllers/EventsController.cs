using Microsoft.AspNetCore.Mvc;
using Yummy.Data;

namespace Yummy.Controllers
{
    public class EventsController : Controller
    {
        private readonly ApplicationDbContext _context;
        public EventsController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Events()
        {
            var _events = _context.events.ToList();
            return View(_events);
        }
    }
}

