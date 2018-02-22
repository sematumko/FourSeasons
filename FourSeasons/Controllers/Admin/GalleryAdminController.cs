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
    public class GalleryAdminController : Controller
    {
        private readonly FourSeasonsContext _context;

        public GalleryAdminController(FourSeasonsContext context)
        {
            _context = context;
        }

        [Route("Admin/Gallery")]
        public IActionResult Index()
        {
            return View(getGallery());
        }

        [HttpPost]
        public ActionResult Delete(GalleryPhoto photo)
        {
            _context.GallerySet.Remove(_context.GallerySet.Find(photo.Id));
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Add(string _imgLink)
        {
            _context.GallerySet.Add(new GalleryPhoto { ImgLink =  _imgLink });
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        private List<GalleryPhoto> getGallery()
        {
            List<GalleryPhoto> galleryList = new List<GalleryPhoto>();

            foreach (GalleryPhoto element in _context.GallerySet)
                galleryList.Add(element);

            galleryList.Reverse();

            return galleryList;
        }


    }
}
