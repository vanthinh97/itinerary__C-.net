using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Lab4.Models;

namespace lab4_3.Models
{
    public class UserContext : DbContext
    {
        public UserContext() : base("name=DefaultConnection")
        {
            Database.SetInitializer<UserContext>(new DropCreateDatabaseAlways<UserContext>());
        }
        public DbSet<User> Users { get; set; }
    }
}