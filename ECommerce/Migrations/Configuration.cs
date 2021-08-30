namespace ECommerce.Migrations
{
    using ECommerce.Models;
    using System;
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
            if (context.Users.Where(x => ((int)x.Role) == 1).Count() == 0)
            {
                Users Admin = new Users()
                {
                    NomPrenom = "Mahdi",
                    LogIn = "mahdi.khardani@gmail.com",
                    Telephone = 26456789,
                    DateNaissance = "1995-12-05",
                    Password = "123123",
                    Role =  Models.Enummeratin.Role.admin 

                };
                context.Users.Add(Admin);
                context.SaveChanges();
            }

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
