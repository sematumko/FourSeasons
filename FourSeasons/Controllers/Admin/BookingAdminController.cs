using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FourSeasons.Models;
using FourSeasons.dbContexts;

namespace FourSeasons.Controllers.Admin
{
    public class BookingAdminController : Controller
    {
        private readonly FourSeasonsContext _context;

        public BookingAdminController(FourSeasonsContext context)
        {
            _context = context;
        }

        [Route("Admin/Booking")]
        public IActionResult Index()
        {
            return View(getBooking());
        }

        [HttpPost]
        public ActionResult Delete(Booking booking)
        {
            _context.BookingSet.Remove(_context.BookingSet.Find(booking.Id));
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        private List<Booking> getBooking()
        {
            List<Booking> bookingList = new List<Booking>();

            foreach (Booking element in _context.BookingSet)
                bookingList.Add(element);

            return bookingList;
        }
    }
}
