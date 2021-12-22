namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class haha : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Educations", "User_Id", c => c.String(maxLength: 128));
            AddColumn("dbo.PreviousExperiences", "User_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.Educations", "User_Id");
            CreateIndex("dbo.PreviousExperiences", "User_Id");
            AddForeignKey("dbo.Educations", "User_Id", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.PreviousExperiences", "User_Id", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PreviousExperiences", "User_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Educations", "User_Id", "dbo.AspNetUsers");
            DropIndex("dbo.PreviousExperiences", new[] { "User_Id" });
            DropIndex("dbo.Educations", new[] { "User_Id" });
            DropColumn("dbo.PreviousExperiences", "User_Id");
            DropColumn("dbo.Educations", "User_Id");
        }
    }
}
