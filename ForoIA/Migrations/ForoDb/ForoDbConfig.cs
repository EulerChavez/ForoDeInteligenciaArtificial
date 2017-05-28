namespace ForoIA.Migrations.ForoDb {

    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class ForoDbConfig : DbMigrationsConfiguration<ForoIA.Models.Db.ForoDbContext> {

        public ForoDbConfig() {

            AutomaticMigrationsEnabled = true;

            MigrationsDirectory = @"Migrations/ForoDb";

        }

        protected override void Seed(ForoIA.Models.Db.ForoDbContext context) {

            context.Category.AddOrUpdate(new Models.Db.Category() { Name = "Redes Neuronales" });
            context.Category.AddOrUpdate(new Models.Db.Category() { Name = "Sistemas Expertos" });
            context.Category.AddOrUpdate(new Models.Db.Category() { Name = "Robotica" });
            context.Category.AddOrUpdate(new Models.Db.Category() { Name = "Algoritmos Genéticos" });
            context.Category.AddOrUpdate(new Models.Db.Category() { Name = "VideoJuegos" });
            context.Category.AddOrUpdate(new Models.Db.Category() { Name = "Domótica" });

        }

    }

}
