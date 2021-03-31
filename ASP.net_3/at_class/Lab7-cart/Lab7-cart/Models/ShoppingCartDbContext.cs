using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Lab7_cart.Models
{
    public class ShoppingCartDbContext : DbContext
    {
        public ShoppingCartDbContext() : base("name=shoppingcart") { }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
    }
}