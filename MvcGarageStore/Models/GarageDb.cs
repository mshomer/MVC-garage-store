using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcGarageStore.Models
{
    public class GarageDb : DbContext
    {
        public GarageDb()
            : base("name=DefaultConnection")
        {

        }
        
        public DbSet<Category> Categories { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }

        public DbSet<Cart> Carts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}