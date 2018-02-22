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
    public class ContactsController : Controller
    {
        private readonly FourSeasonsContext _context;

        public ContactsController(FourSeasonsContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(getContacts());
        }

        private Contacts getContacts()
        {
            Contacts contacts = new Contacts();
            contacts.Id = 1;
            contacts = _context.ContactsSet.Find(contacts.Id);
            return contacts;
        }

        public ActionResult ToMap(int id)
        {
            return RedirectToRoute("Index", new { anchorID = id });

        }
    }
}
