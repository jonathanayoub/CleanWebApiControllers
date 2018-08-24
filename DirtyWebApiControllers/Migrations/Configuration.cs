using DirtyWebApiControllers.Models;

namespace DirtyWebApiControllers.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DirtyWebApiControllers.Data.CustomerDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DirtyWebApiControllers.Data.CustomerDbContext context)
        {
            context.Customers.AddOrUpdate(c => c.Id , new Customer
            {
                Id = 1,
                FirstName = "John",
                LastName = "Smith",
                FavoriteIceCream = "Moose Tracks"
            }, new Customer
            {
                Id = 2,
                FirstName = "Paul",
                LastName = "Bunyan",
                FavoriteIceCream = "Chocolate"
            }, new Customer
            {
                Id = 3,
                FirstName = "Jenny",
                LastName = "Parks",
                FavoriteIceCream = "Vanilla"
            });
        }
    }
}
