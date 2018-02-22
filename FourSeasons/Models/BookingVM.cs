using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FourSeasons.Models
{
    public class BookingVM
    {
        public List<Room> RoomList { get; set; }
        public int TotalPrice { get; set; }

        public BookingVM()
        {
            TotalPrice = 0;
        }
       
    }
}
