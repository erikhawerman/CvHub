namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedeverythingg : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CVs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Visits = c.Int(nullable: false),
                        Gender = c.String(),
                        BirthDate = c.DateTime(nullable: false),
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
                        CV_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CVs", t => t.CV_Id)
                .Index(t => t.CV_Id);
            
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
                        CV_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CVs", t => t.CV_Id)
                .Index(t => t.CV_Id);
            
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Creator_Id = c.String(maxLength: 128),
                        CV_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.Creator_Id)
                .ForeignKey("dbo.CVs", t => t.CV_Id)
                .Index(t => t.Creator_Id)
                .Index(t => t.CV_Id);
            
            AddColumn("dbo.AspNetUsers", "Project_Id", c => c.Int());
            CreateIndex("dbo.AspNetUsers", "Project_Id");
            AddForeignKey("dbo.AspNetUsers", "Project_Id", "dbo.Projects", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Projects", "CV_Id", "dbo.CVs");
            DropForeignKey("dbo.AspNetUsers", "Project_Id", "dbo.Projects");
            DropForeignKey("dbo.Projects", "Creator_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.PreviousExperiences", "CV_Id", "dbo.CVs");
            DropForeignKey("dbo.Educations", "CV_Id", "dbo.CVs");
            DropIndex("dbo.AspNetUsers", new[] { "Project_Id" });
            DropIndex("dbo.Projects", new[] { "CV_Id" });
            DropIndex("dbo.Projects", new[] { "Creator_Id" });
            DropIndex("dbo.PreviousExperiences", new[] { "CV_Id" });
            DropIndex("dbo.Educations", new[] { "CV_Id" });
            DropColumn("dbo.AspNetUsers", "Project_Id");
            DropTable("dbo.Projects");
            DropTable("dbo.PreviousExperiences");
            DropTable("dbo.Educations");
            DropTable("dbo.CVs");
        }
    }
}
