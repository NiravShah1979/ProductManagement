using Angular3SampleApp.Services.Models;

namespace Angular3SampleApp.Services.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Angular3SampleApp.Services.Models.ProductManagementContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ProductManagementContext context)
        {
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

            context.Categories.AddOrUpdate(new Category() { Id = 1, Name = "Grocery" }, new Category() { Id = 2, Name = "Fruit" });

            context.Products.AddOrUpdate(new Product()
            {
                CategoryId = 1,
                Id = 1,
                IsAvailable = false,
                Name = "Lettuce",
                MfgDate = DateTime.Now,
                Price = 2.79f
            }, new Product()
            {
                CategoryId = 1,
                Id = 2,
                IsAvailable = true,
                Name = "Cucumber",
                MfgDate = DateTime.Now,
                Price = 1.79f
            }
            , new Product()
            {
                CategoryId = 2,
                Id = 3,
                IsAvailable = true,
                Name = "Banana",
                MfgDate = DateTime.Now,
                Price = 0.79f
            }
            , new Product()
            {
                CategoryId = 2,
                Id = 4,
                IsAvailable = false,
                Name = "Apple",
                MfgDate = DateTime.Now,
                Price = 2.49f
            });
        }
    }
}
