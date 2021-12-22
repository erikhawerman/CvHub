namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedeverything : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Educations", "User_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.PreviousExperiences", "User_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Projects", "Creator_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUsers", "Project_Id", "dbo.Projects");
            DropForeignKey("dbo.Projects", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.AspNetUsers", new[] { "Project_Id" });
            DropIndex("dbo.Educations", new[] { "User_Id" });
            DropIndex("dbo.PreviousExperiences", new[] { "User_Id" });
            DropIndex("dbo.Projects", new[] { "Creator_Id" });
            DropIndex("dbo.Projects", new[] { "ApplicationUser_Id" });
            DropColumn("dbo.AspNetUsers", "FirstName");
            DropColumn("dbo.AspNetUsers", "LastName");
            DropColumn("dbo.AspNetUsers", "Visits");
            DropColumn("dbo.AspNetUsers", "BirthDate");
            DropColumn("dbo.AspNetUsers", "Gender");
            DropColumn("dbo.AspNetUsers", "Project_Id");
            DropTable("dbo.Educations");
            DropTable("dbo.PreviousExperiences");
            DropTable("dbo.Projects");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Creator_Id = c.String(maxLength: 128),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PreviousExperiences",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StartYear = c.DateTime(nullable: false),
                        EndYear = c.DateTime(nullable: false),
                        WorkplaceName = c.String(nullable: false),
                        WorkplaceTitle = c.String(nullable: false),
                        Description = c.String(),
                        User_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Educations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StartYear = c.DateTime(nullable: false),
                        EndYear = c.DateTime(nullable: false),
                        SchoolName = c.String(nullable: false),
                        EducationName = c.String(nullable: false),
                        Description = c.String(),
                        User_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.AspNetUsers", "Project_Id", c => c.Int());
            AddColumn("dbo.AspNetUsers", "Gender", c => c.String());
            AddColumn("dbo.AspNetUsers", "BirthDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.AspNetUsers", "Visits", c => c.Int(nullable: false));
            AddColumn("dbo.AspNetUsers", "LastName", c => c.String());
            AddColumn("dbo.AspNetUsers", "FirstName", c => c.String());
            CreateIndex("dbo.Projects", "ApplicationUser_Id");
            CreateIndex("dbo.Projects", "Creator_Id");
            CreateIndex("dbo.PreviousExperiences", "User_Id");
            CreateIndex("dbo.Educations", "User_Id");
            CreateIndex("dbo.AspNetUsers", "Project_Id");
            AddForeignKey("dbo.Projects", "ApplicationUser_Id", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.AspNetUsers", "Project_Id", "dbo.Projects", "Id");
            AddForeignKey("dbo.Projects", "Creator_Id", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.PreviousExperiences", "User_Id", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.Educations", "User_Id", "dbo.AspNetUsers", "Id");
        }
    }
}
