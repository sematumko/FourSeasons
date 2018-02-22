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
    public class ComfortAdminController : Controller
    {
        private readonly FourSeasonsContext _context;

        public ComfortAdminController(FourSeasonsContext context)
        {
            _context = context;
        }

        [Route("Admin/Comfort")]
        public IActionResult Index()
        {
            return View(getComforts());
        }

        [HttpPost]
        public ActionResult Update(Comfort comfort)
        {
            _context.Entry(comfort).State = EntityState.Modified;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Delete(Comfort comfort)
        {
            _context.ComfortsSet.Remove(_context.ComfortsSet.Find(comfort.Id));
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Add(string _header, string _content, string _imgLink)
        {
            _context.ComfortsSet.Add(new Comfort { Header = _header, Content = _content, ImgLink =  _imgLink, Date = DateTime.Now });
            _context.SaveChanges();
            return RedirectToAction("Index");
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
