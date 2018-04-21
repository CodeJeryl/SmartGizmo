using SmartGizmoWebApi.Models;

namespace SmartGizmoWebApi.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SmartGizmoWebApi.Context.HotelContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(SmartGizmoWebApi.Context.HotelContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

             context.Requests.AddOrUpdate(
                  p => p.Id,
                  new Request { Description = "Food Order", DateCreated = DateTime.Now },
                  new Request { Description = "Spa", DateCreated = DateTime.Now },
                  new Request { Description = "Buy me Pasalubong", DateCreated = DateTime.Now }
                );
        }
    }
}
