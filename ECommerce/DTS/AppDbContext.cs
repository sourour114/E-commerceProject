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

        public DbSet<Users> Users { get; set; }
        public DbSet<Client> Client { get; set; }

        public DbSet<Commande> Commande { get; set; }

        public DbSet<Commercial> Commercial { get; set; }

        public DbSet<Produit> Produit { get; set; }

    }
}