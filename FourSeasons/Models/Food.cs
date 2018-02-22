using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FourSeasons.Models
{
    public class Food
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Consist { get; set; }
        public int ParentId { get; set; }
    }
}
