namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeduser : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AspNetUsers", "Mail");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "Mail", c => c.String());
        }
    }
}
