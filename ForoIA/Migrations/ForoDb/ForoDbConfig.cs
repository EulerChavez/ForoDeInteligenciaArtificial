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

            context.Dificulty.AddOrUpdate(new Models.Db.Dificulty() { Name = "Facil" });
            context.Dificulty.AddOrUpdate(new Models.Db.Dificulty() { Name = "Medio" });
            context.Dificulty.AddOrUpdate(new Models.Db.Dificulty() { Name = "Dificl" });
            context.Dificulty.AddOrUpdate(new Models.Db.Dificulty() { Name = "Un poco de todo" });

            context.QuestionType.AddOrUpdate(new Models.Db.QuestionType() { Description = "Abierta" });
            context.QuestionType.AddOrUpdate(new Models.Db.QuestionType() { Description = "Cerrada" });

            context.Topic.AddOrUpdate(new Models.Db.Topic() { Description = "Unidad 1. " });
            context.Topic.AddOrUpdate(new Models.Db.Topic() { Description = "Unidad 2. " });
            context.Topic.AddOrUpdate(new Models.Db.Topic() { Description = "Unidad 3. " });
            context.Topic.AddOrUpdate(new Models.Db.Topic() { Description = "Unidad 4. " });
            context.Topic.AddOrUpdate(new Models.Db.Topic() { Description = "Unidad 5. " });

        }

    }

}
