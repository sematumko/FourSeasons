using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FourSeasons.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string AuthorName { get; set; }
        public string AuthorEmail { get; set; }
        [DataType(DataType.MultilineText)]
        public string Text { get; set; }
        public DateTime Date { get; set; }
    }
}
