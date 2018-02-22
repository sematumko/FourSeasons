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
    public class ContactsAdminController : Controller
    {
        private readonly FourSeasonsContext _context;

        public ContactsAdminController(FourSeasonsContext context)
        {
            _context = context;
        }

        [Route("Admin/Contacts")]
        public IActionResult Index()
        {
            return View(getContacts());
        }

        [HttpPost]
        public ActionResult Update(Contacts contacts)
        {
            _context.Entry(contacts).State = EntityState.Modified;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        private Contacts getContacts()
        {
            Contacts contacts = new Contacts();
            contacts.Id = 1;
            contacts = _context.ContactsSet.Find(contacts.Id);
            return contacts;
        }
    }
}
