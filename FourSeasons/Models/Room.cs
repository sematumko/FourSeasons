using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FourSeasons.Models
{
    public class Room
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int Price { get; set; }
        public bool SeaView { get; set; }
        public bool Balcon { get; set; }
        public bool Bar { get; set; }

        public string ImgLink1 { get; set; }
        public string ImgLink2 { get; set; }
        public string ImgLink3 { get; set; }
        public string ImgLink4 { get; set; }
    }
}
