using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorkoutApp.Models
{
    public class WorkoutTarget
    {
        public int WTid { get; set; }
        public string Name { get; set; }
        public int Length { get; set; }
        public string Level { get; set; }
    }
}