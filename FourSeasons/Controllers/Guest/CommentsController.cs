using System;
using System.Collections.Generic;
using FourSeasons.dbContexts;
using FourSeasons.Models;
using Microsoft.AspNetCore.Mvc;

namespace FourSeasons.Controllers.Guest
{
    public class CommentsController : Controller
    {
        private readonly FourSeasonsContext _context;

        public CommentsController(FourSeasonsContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(getComments());
        }

        [HttpPost]
        public IActionResult Create(string _authorName, string _authorEmail, string _text)
        {
            _context.CommentsSet.Add(new Comment { AuthorName = _authorName, AuthorEmail = _authorEmail, Text = _text, Date = DateTime.Now});
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
