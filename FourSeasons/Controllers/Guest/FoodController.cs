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
    public class FoodController : Controller
    {
        private readonly FourSeasonsContext _context;

        public FoodController(FourSeasonsContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(GetFood());
        }

        private List<Food> GetFood()
        {
            List<Food> foodList = new List<Food>();

            foreach (Food element in _context.FoodSet)
                foodList.Add(element);

            return foodList;
        }
    }
}
