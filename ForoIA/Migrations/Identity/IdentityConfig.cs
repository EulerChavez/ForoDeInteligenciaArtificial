namespace ForoIA.Migrations.Identity {

    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class IdentityConfig : DbMigrationsConfiguration<ForoIA.Models.ApplicationDbContext> {

        public IdentityConfig() {

            AutomaticMigrationsEnabled = true;

            MigrationsDirectory = @"Migrations/Identity";

        }

        protected override void Seed(ForoIA.Models.ApplicationDbContext context) {

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
