namespace ForoIA.Migrations.ForoDb
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Answers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(nullable: false, maxLength: 1024),
                        QuestionId = c.Int(nullable: false),
                        IsCorrect = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Tests", t => t.QuestionId, cascadeDelete: true)
                .Index(t => t.QuestionId);
            
            CreateTable(
                "dbo.Tests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Question = c.String(nullable: false),
                        DificultId = c.Int(nullable: false),
                        QuestionTypeId = c.Int(nullable: false),
                        TopicId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Dificulties", t => t.DificultId, cascadeDelete: true)
                .ForeignKey("dbo.QuestionTypes", t => t.QuestionTypeId, cascadeDelete: true)
                .ForeignKey("dbo.Topics", t => t.TopicId, cascadeDelete: true)
                .Index(t => t.DificultId)
                .Index(t => t.QuestionTypeId)
                .Index(t => t.TopicId);
            
            CreateTable(
                "dbo.Dificulties",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.QuestionTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Topics",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 50),
                        UserName = c.String(nullable: false, maxLength: 25),
                        Date = c.DateTime(nullable: false),
                        CategoryId = c.Int(nullable: false),
                        Review = c.String(nullable: false, maxLength: 1024),
                        Content = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PostId = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 25),
                        CommentTime = c.DateTime(nullable: false),
                        Content = c.String(nullable: false, maxLength: 1024),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Posts", t => t.PostId, cascadeDelete: true)
                .Index(t => t.PostId);
            
            CreateTable(
                "dbo.ConfigurationTests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        DificultyId = c.Int(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Dificulties", t => t.DificultyId, cascadeDelete: true)
                .Index(t => t.DificultyId);
            
            CreateTable(
                "dbo.TestAnswers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ConfigurationTestId = c.Int(nullable: false),
                        TestId = c.Int(),
                        AnwserIdSelected = c.Int(nullable: false),
                        TextAnswer = c.String(),
                        IsAnswered = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ConfigurationTests", t => t.ConfigurationTestId, cascadeDelete: true)
                .ForeignKey("dbo.Tests", t => t.TestId)
                .Index(t => t.ConfigurationTestId)
                .Index(t => t.TestId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TestAnswers", "TestId", "dbo.Tests");
            DropForeignKey("dbo.TestAnswers", "ConfigurationTestId", "dbo.ConfigurationTests");
            DropForeignKey("dbo.ConfigurationTests", "DificultyId", "dbo.Dificulties");
            DropForeignKey("dbo.Comments", "PostId", "dbo.Posts");
            DropForeignKey("dbo.Posts", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.Tests", "TopicId", "dbo.Topics");
            DropForeignKey("dbo.Tests", "QuestionTypeId", "dbo.QuestionTypes");
            DropForeignKey("dbo.Tests", "DificultId", "dbo.Dificulties");
            DropForeignKey("dbo.Answers", "QuestionId", "dbo.Tests");
            DropIndex("dbo.TestAnswers", new[] { "TestId" });
            DropIndex("dbo.TestAnswers", new[] { "ConfigurationTestId" });
            DropIndex("dbo.ConfigurationTests", new[] { "DificultyId" });
            DropIndex("dbo.Comments", new[] { "PostId" });
            DropIndex("dbo.Posts", new[] { "CategoryId" });
            DropIndex("dbo.Tests", new[] { "TopicId" });
            DropIndex("dbo.Tests", new[] { "QuestionTypeId" });
            DropIndex("dbo.Tests", new[] { "DificultId" });
            DropIndex("dbo.Answers", new[] { "QuestionId" });
            DropTable("dbo.TestAnswers");
            DropTable("dbo.ConfigurationTests");
            DropTable("dbo.Comments");
            DropTable("dbo.Posts");
            DropTable("dbo.Categories");
            DropTable("dbo.Topics");
            DropTable("dbo.QuestionTypes");
            DropTable("dbo.Dificulties");
            DropTable("dbo.Tests");
            DropTable("dbo.Answers");
        }
    }
}
