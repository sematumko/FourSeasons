using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FourSeasons.Models
{
    public class News
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Header { get; set; }
        [DataType(DataType.MultilineText)]
        public string Content { get; set; }
        public string ImgLink { get; set; }
    }
}