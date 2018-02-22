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
    public class NewsAdminController : Controller
    {
        private readonly FourSeasonsContext _context;

        public NewsAdminController(FourSeasonsContext context)
        {
            _context = context;
        }

        [Route ("Admin/News")]
        public IActionResult Index()
        {
            return View(getNews());
        }

        [HttpPost]
        public ActionResult Update(News news)
        {
            _context.Entry(news).State = EntityState.Modified;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Delete(News news)
        {
            _context.NewsSet.Remove(_context.NewsSet.Find(news.Id));
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Add(string _header, string _content, string _imgLink)
        {           
            _context.NewsSet.Add(new News { Header = _header, Content = _content, ImgLink = _imgLink, Date = DateTime.Now});
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        private List<News> getNews()
        {
            List<News> newsList = new List<News>();

            foreach (News element in _context.NewsSet)
                newsList.Add(element);

            return newsList;
        }
    }
}
