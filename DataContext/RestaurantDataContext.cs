using System;
using Model;
using Microsoft.EntityFrameworkCore;

namespace RestaurantContext
{
    public class RestaurantDataContext: DbContext
    {
        public RestaurantDataContext(DbContextOptions<RestaurantDataContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet<Bill> Bills { get; set; }
    }
}
