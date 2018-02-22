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
    public class ComfortController : Controller
    {
        private readonly FourSeasonsContext _context;

        public ComfortController(FourSeasonsContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(getComforts());
        }

        private List<Comfort> getComforts()
        {
            List<Comfort> comfortsList = new List<Comfort>();

            foreach (Comfort element in _context.ComfortsSet)
                comfortsList.Add(element);

            return comfortsList;
        }

    }
}
