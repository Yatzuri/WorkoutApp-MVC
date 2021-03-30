using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WorkoutApp.Models
{
    public class Workout
    {
        public int WorkoutID { get; set; }
        public string WorkoutType { get; set; }
    }

    public class WorkoutDbContext : DbContext
    {
        public DbSet<Workout> Workouts { get; set; }
    }
}