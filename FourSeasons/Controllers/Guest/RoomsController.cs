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
    public class RoomsController : Controller
    {
        private readonly FourSeasonsContext _context;

        public RoomsController(FourSeasonsContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(getRooms());
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
