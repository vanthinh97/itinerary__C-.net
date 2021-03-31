﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lab5_2.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Title { get; set; }
        public string Credits { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}