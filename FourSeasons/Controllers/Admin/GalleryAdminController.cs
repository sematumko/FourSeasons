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

        public IActionResult Index()
        {
            return View();
        }

        
    }
}
