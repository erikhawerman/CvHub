namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedmodels : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Educations", name: "ApplicationUser_Id", newName: "User_Id");
            RenameColumn(table: "dbo.PreviousExperiences", name: "ApplicationUser_Id", newName: "User_Id");
            RenameIndex(table: "dbo.Educations", name: "IX_ApplicationUser_Id", newName: "IX_User_Id");
            RenameIndex(table: "dbo.PreviousExperiences", name: "IX_ApplicationUser_Id", newName: "IX_User_Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.PreviousExperiences", name: "IX_User_Id", newName: "IX_ApplicationUser_Id");
            RenameIndex(table: "dbo.Educations", name: "IX_User_Id", newName: "IX_ApplicationUser_Id");
            RenameColumn(table: "dbo.PreviousExperiences", name: "User_Id", newName: "ApplicationUser_Id");
            RenameColumn(table: "dbo.Educations", name: "User_Id", newName: "ApplicationUser_Id");
        }
    }
}
