using Microsoft.AspNetCore.Mvc;
using Yummy.Data;
using Yummy.Models;
using Yummy.ViewModels;

namespace Yummy.Controllers
{
    public class BookingController : Controller
    {
        private readonly ApplicationDbContext _context;
        public BookingController(ApplicationDbContext context)
        {
            this._context = context;
        }
        [HttpGet]
        public IActionResult BookTable()
        {
            return View();
        }
        [HttpPost]
        public IActionResult BookTable(BookingVM bookingVM)
        {
            if (ModelState.IsValid)
            {
                BookTable booking = new BookTable();
                booking.Name = bookingVM.Name;
                booking.NumberOfPeople = bookingVM.NumberOfPeople;
                booking.Message = bookingVM.Message;
                booking.Time = bookingVM.Time;
                booking.Date = bookingVM.Date;
                booking.Email = bookingVM.Email;
                booking.Phone = bookingVM.Phone;
                _context.Bookings.Add(booking);
                _context.SaveChanges();
                return RedirectToAction("Index" , "Home");
            }
            else
            {
                return View();
            }
        }
    }
}
