using Microsoft.AspNetCore.Mvc;
using Yummy.Areas.Admin.ViewModels;
using Yummy.Data;
using Yummy.Models;

namespace Yummy.Areas.Admin.Controllers
{
    public class EventController : AdminBaseController
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _hostingEnvironment;
        public EventController(ApplicationDbContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            _hostingEnvironment = hostEnvironment;
        }
        public IActionResult Index()
        {
            var events = _context.events.ToList();
            return View(events);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(EventsVM eventVM)
        {
            if (ModelState.IsValid)
            {
                Events NewEvent = new Events();
                NewEvent.Title = eventVM.Title;
                NewEvent.Price = eventVM.Price;
                NewEvent.Des = eventVM.Des;
                var uploadFolder = Path.Combine(_hostingEnvironment.WebRootPath, "Images");
                var uniqueName = Guid.NewGuid().ToString() + Path.GetExtension(eventVM.Image.FileName);
                var filePath = Path.Combine(uploadFolder, uniqueName);
                eventVM.Image.CopyTo(new FileStream(filePath, FileMode.Create));
                NewEvent.ImageName = uniqueName;
                NewEvent.EventDate = Convert.ToDateTime(eventVM.EventDate);
                _context.events.Add(NewEvent);
                _context.SaveChanges();
                TempData["message"] = "the event is added succefully";
                return RedirectToAction("Index");
            }
            return View(eventVM);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var events = _context.events.Find(id);
            if (events == null)
                return NotFound();
            EditEventVM editEvent = new EditEventVM();
            editEvent.Title = events.Title;
            editEvent.Price = events.Price;
            editEvent.Des = events.Des;
            editEvent.ImageName = events.ImageName;
            return View(editEvent);
        }
        [HttpPost]
        public IActionResult Edit(int id, EditEventVM editEvent)
        {
            var _event = _context.events.Find(id);
            if (_event == null)
                return NotFound();
            if (ModelState.IsValid)
            {
                _event.Title = editEvent.Title;
                _event.Price = editEvent.Price;
                _event.Des = editEvent.Des;
                if (editEvent.Image != null)
                {
                    var uploadFolder = Path.Combine(_hostingEnvironment.WebRootPath, "Images");
                    var uniqueName = Guid.NewGuid().ToString() + Path.GetExtension(editEvent.Image.FileName);
                    var filePath = Path.Combine(uploadFolder, uniqueName);
                    editEvent.Image.CopyTo(new FileStream(filePath, FileMode.Create));
                    _event.ImageName = uniqueName;
                }
                _event.EventDate = Convert.ToDateTime(editEvent.EventDate);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Details(int id)
        {
            var _event = _context.events.Find(id);
            if (_event == null)
                return NotFound();
            return View(_event);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var _event = _context.events.Find(id);
            if (_event == null)
                return NotFound();
            _context.events.Remove(_event);
            _context.SaveChanges();
            return Json(new { id = id, message = "Deleted Successfully" });
        }
    }
}
