﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace lab6_1.Models
{
    public class MovieDbContext : DbContext
    {
        public MovieDbContext() : base("name=MovieDbContext") { }
        public DbSet<Movie> Movies { get; set; }
    }
}