namespace ECommerce.Migrations
{
    using ECommerce.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ECommerce.DTS.AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ECommerce.DTS.AppDbContext context)
        {
           if(context.Movies.Count() == 0)
            {
                context.Movies.Add(new Movie
                {
                    Name = "Titanic",
                    Categories = new List<Category>
                    {
                        new Category
                        {
                            Name = "Romance"
                        },
                        new Category
                        {
                            Name="Drama"
                        }
                    }
                });
                context.SaveChanges();
            }
        }
    }
}
