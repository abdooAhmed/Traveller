using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace travel.Models.DB
{
    public class post
    {
        public int postId { get; set; }
        public string TripTitle { get; set; }
        public string Tripdetails { get; set; }
        public DateTime PostDate { get; set; }
        public string TripDate { get; set; }
        public string TripDestination { get; set; }
        public string TripImage { get; set; }
        public int personId { get; set; }

        public virtual person person { get; set; }



    }
}