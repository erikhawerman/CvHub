namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class expandedIdentityUser : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Educations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUser_Id)
                .Index(t => t.ApplicationUser_Id);
            
            CreateTable(
                "dbo.PreviousExperiences",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUser_Id)
                .Index(t => t.ApplicationUser_Id);
            
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUser_Id)
                .Index(t => t.ApplicationUser_Id);
            
            AddColumn("dbo.AspNetUsers", "FirstName", c => c.String());
            AddColumn("dbo.AspNetUsers", "Mail", c => c.String());
            AddColumn("dbo.AspNetUsers", "Visits", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Projects", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.PreviousExperiences", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Educations", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Projects", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.PreviousExperiences", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.Educations", new[] { "ApplicationUser_Id" });
            DropColumn("dbo.AspNetUsers", "Visits");
            DropColumn("dbo.AspNetUsers", "Mail");
            DropColumn("dbo.AspNetUsers", "FirstName");
            DropTable("dbo.Projects");
            DropTable("dbo.PreviousExperiences");
            DropTable("dbo.Educations");
        }
    }
}
