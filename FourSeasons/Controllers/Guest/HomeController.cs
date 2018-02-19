using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FourSeasons.Models;
using FourSeasons.dbContexts;

namespace FourSeasons.Controllers.Guest
{
    public class HomeController : Controller
    {

        private readonly FourSeasonsContext _context;

        public HomeController(FourSeasonsContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(getNews());
        }

        private List<News> getNews()
        {
            List<News> newsList = new List<News>();

            foreach (News element in _context.NewsSet)
                newsList.Add(element);

            return newsList;
        }
        
        public IActionResult NewsArchive()
        {
            return View(getNews());
        }

        
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
