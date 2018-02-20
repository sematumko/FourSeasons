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
    public class CommentsAdminController : Controller
    {
        private readonly FourSeasonsContext _context;

        public CommentsAdminController(FourSeasonsContext context)
        {
            _context = context;
        }

        [Route("Admin/Comments")]
        public IActionResult Index()
        {
            return View(getComments());
        }

        [HttpPost]
        public ActionResult Delete(Comment comment)
        {
            _context.CommentsSet.Remove(_context.CommentsSet.Find(comment.Id));
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Create(string _text)
        {
            _context.CommentsSet.Add(new Comment { AuthorName = "Admin", AuthorEmail = "admin@gmail.com", Text = _text, Date = DateTime.Now });
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        private List<Comment> getComments()
        {
            List<Comment> commentsList = new List<Comment>();

            foreach (Comment element in _context.CommentsSet)
                commentsList.Add(element);

            return commentsList;
        }
    }
}
