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
    public class FoodAdminController : Controller
    {
        private readonly FourSeasonsContext _context;

        public FoodAdminController(FourSeasonsContext context)
        {
            _context = context;
        }

        [Route("Admin/Food")]
        public IActionResult Index()
        {
            return View(getFood());
        }

        [HttpPost]
        public ActionResult UpdateParent(Food food)
        {
            food.ParentId = 0;
            food.Consist = "";

            _context.Entry(food).State = EntityState.Modified;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult UpdateChild(Food food)
        {
            _context.Entry(food).State = EntityState.Modified;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult DeleteChild(Food food)
        {
            _context.FoodSet.Remove(_context.FoodSet.Find(food.Id));
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult DeleteParent(Food food)
        {
            foreach (Food element in _context.FoodSet)
                if (element.ParentId == food.Id)
                    _context.FoodSet.Remove(_context.FoodSet.Find(element.Id));

            _context.FoodSet.Remove(_context.FoodSet.Find(food.Id));
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Add(Food food)
        {
            _context.FoodSet.Add(food);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        private List<Food> getFood()
        {
            List<Food> foodList = new List<Food>();

            foreach (Food element in _context.FoodSet)
                foodList.Add(element);

            return foodList;
        }
    }
}
