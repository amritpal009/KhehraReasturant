using KhehraReasturant.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace KhehraReasturant.Data
{
    public class OrdersDbContext : IdentityDbContext
    {
        // Here we add in all the tables we are using.
        public DbSet<Customercs> Customercs { get; set; }
        public DbSet<Menu> Menu { get; set; }
        public DbSet<Order> Order { get; set; }
        // We need 2 constructors, one is empty, and the other injects in DbContextOptions
        public OrdersDbContext(DbContextOptions<OrdersDbContext> options)
        : base(options)
        {
        }
        public OrdersDbContext()
        {
        }
    }
}
