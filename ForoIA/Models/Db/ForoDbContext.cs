using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace ForoIA.Models.Db {

    public class ForoDbContext : DbContext {

        public ForoDbContext() : base("ForoDb") { }

        public DbSet<Post> Post { get; set; }

        public DbSet<Comment> Comment { get; set; }

        public DbSet<Category> Category { get; set; }

        public DbSet<Test> Test { get; set; }

        public DbSet<Answer> Answer { get; set; }

        public DbSet<Dificulty> Dificulty { get; set; }

        public DbSet<QuestionType> QuestionType { get; set; }

        public DbSet<Topic> Topic { get; set; }

        public DbSet<ConfigurationTest> ConfigurationTest { get; set; }

        public DbSet<TestAnswer> TestAnswer { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {

            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

        }

    }

}