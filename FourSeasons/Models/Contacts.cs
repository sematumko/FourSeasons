using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FourSeasons.Models
{
    public class Contacts
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string ReceptionPhone { get; set; }
        public string CollaborationPhone { get; set; }
        public string Email { get; set; }
        public string VKLink { get; set; }
        public string FaceBookLink { get; set; }
        public string InstagramLink { get; set; }
    }
}
