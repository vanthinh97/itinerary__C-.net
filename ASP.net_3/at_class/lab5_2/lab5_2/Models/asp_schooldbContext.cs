using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace lab5_2.Models
{
    public class asp_schooldbContext : DbContext
    {
        public asp_schooldbContext() : base("name=asp_schooldbContext") { }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}