using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FourSeasons.dbContexts;
using FourSeasons.Models;
using Microsoft.AspNetCore.Mvc;

namespace FourSeasons.Controllers.Guest
{
    public class GalleryController : Controller
    {
        private readonly FourSeasonsContext _context;

        public GalleryController(FourSeasonsContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(getPhotoes());
        }

        private List<GalleryPhoto> getPhotoes()
        {
            List<GalleryPhoto> galleryList = new List<GalleryPhoto>();

            foreach (GalleryPhoto element in _context.GallerySet)
                galleryList.Add(element);

            return galleryList;
        }
    }
}