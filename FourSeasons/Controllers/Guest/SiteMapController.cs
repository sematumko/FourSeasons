using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FourSeasons.Controllers.Guest
{
    public class SiteMapController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}