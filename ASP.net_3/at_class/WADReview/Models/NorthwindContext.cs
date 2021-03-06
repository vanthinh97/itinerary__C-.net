using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WADReview.Models
{
    public class NorthwindContext:DbContext
    {
        public NorthwindContext():base("name=DefaultConnection")
        { 
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}