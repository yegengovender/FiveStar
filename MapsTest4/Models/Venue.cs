using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MapsTest4.Models
{
    public class Venue
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Industry { get; set; }
        public string Comments { get; set; }
        public double XPos { get; set; }
        public double YPos { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }
}