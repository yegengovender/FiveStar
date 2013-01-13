using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MapsTest4.Models
{
    public class Review
    {
        public int Id { get; set; }
        public PatronFrequency Frequency { get; set; }
        public virtual Venue Venue { get; set; }
    }

    public enum PatronFrequency
    {
        Weekly,
        Monthly,
        Yearly
    }
}