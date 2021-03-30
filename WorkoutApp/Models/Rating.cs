using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorkoutApp.Models
{
    public class Rating
    {
        public int RatingID { get; set; }
        public int ExertionScore { get; set; }
        public int EnjoymentScore { get; set; }
        public int HeartrateScore { get; set; }
    }
}