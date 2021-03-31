using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace lab4_3.Models
{
    public class UserContext : DbContext
    {
        public UserContext() : base("name=DefaultConnection")
        {
            
        }
        public DbSet<User> Users { get; set; }
    }
}