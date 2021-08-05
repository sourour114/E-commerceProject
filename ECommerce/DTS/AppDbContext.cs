using ECommerce.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ECommerce.DTS
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("ECommerceDbConnectionString")
        {

        }

        public DbSet<Movie> Movies { get; set; }

        public DbSet<Category> Categories { get; set; }
    }
}