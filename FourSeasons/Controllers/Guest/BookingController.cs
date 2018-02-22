using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FourSeasons.Models;
using FourSeasons.dbContexts;

namespace FourSeasons.Controllers.Guest
{
    public class BookingController : Controller
    {
        private readonly FourSeasonsContext _context;
        private BookingVM model;

        public BookingController(FourSeasonsContext context)
        {
            model = new BookingVM();
            _context = context;
        }

        public IActionResult Index()
        {
            model.RoomList = getRooms();
            model.TotalPrice = _context.TotalPriceSet.Find(1).Value;
            _context.TotalPriceSet.Find(1).Value = 0;
            _context.SaveChanges();
            return View(model);
        }


        public IActionResult ChooseAction(Room model, string action, DateTime _startDate, DateTime _finishDate, string _name, string _email)
        {
            if (action == "getCost")
            {
                getCost(model, _startDate, _finishDate);
            }
            else if (action == "Book")
            {
                Book(model, _startDate, _finishDate, _name, _email);
            }

            return RedirectToAction("Index");
        }



        private IActionResult getCost(Room model, DateTime _startDate, DateTime _finishDate)
        {
            _context.TotalPriceSet.Find(1).Value = (int)calculateCost(model, _startDate, _finishDate);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        private double calculateCost(Room model, DateTime _startDate, DateTime _finishDate)
        {
            double cost = 0;
            double seaview = 0;
            double balcon = 0;
            double price = 0;
            double bar = 1500;

            while (!_startDate.Date.Equals(_finishDate.Date))
            {
                switch (model.Type)
                {
                    case "Одноместный": price = 2000; break;
                    case "Двухместный": price = 3500; break;
                    case "Четырехместный": price = 5000; break;
                    case "Мансарда": price = 3000; break;
                }

                if (model.SeaView == true)
                {
                    seaview = price * 0.2;
                }

                if (model.Balcon == true)
                {
                    balcon = price * 0.15;
                }

                cost += price + seaview + balcon;

                _startDate = _startDate.AddDays(1);
            }

            if (model.Bar == true)
            {
                cost += bar;
            }

            return cost;
        }



        private IActionResult Book(Room model, DateTime _startDate, DateTime _finishDate, string _name, string _email)
        {
            _context.BookingSet.Add(new Booking
            {
                Name = _name,
                Email = _email,
                Type = model.Type,
                SeaView = model.SeaView,
                Balcon = model.Balcon,
                Bar = model.Bar,
                TotalPrice = (int)calculateCost(model, _startDate, _finishDate),
                StartDate = _startDate,
                FinishDate = _finishDate
            });

            _context.SaveChanges();
            return RedirectToAction("Index");
        }



        private List<Room> getRooms()
        {
            List<Room> roomsList = new List<Room>();

            foreach (Room element in _context.RoomsSet)
                roomsList.Add(element);

            return roomsList;
        }

        
        
     
    }
}
