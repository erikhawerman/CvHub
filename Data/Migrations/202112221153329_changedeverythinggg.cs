namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedeverythinggg : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CVs", "Creator", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.CVs", "Creator");
        }
    }
}
