using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ForoIA.Models.Db {

    public class ForoDbContext : DbContext {

        public ForoDbContext() : base("ForoDb") { }

        public DbSet<Post> Post { get; set; }

        public DbSet<Comment> Comment { get; set; }

        public DbSet<Category> Category { get; set; }

    }

}