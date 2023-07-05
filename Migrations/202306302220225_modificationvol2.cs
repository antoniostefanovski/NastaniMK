namespace NastaniMK_2023.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modificationvol2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Events", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Events", "Time", c => c.String(nullable: false));
            AlterColumn("dbo.Events", "Location", c => c.String(nullable: false));
            AlterColumn("dbo.Events", "City", c => c.String(nullable: false));
            AlterColumn("dbo.Events", "Tickets", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Events", "Tickets", c => c.String());
            AlterColumn("dbo.Events", "City", c => c.String());
            AlterColumn("dbo.Events", "Location", c => c.String());
            AlterColumn("dbo.Events", "Time", c => c.String());
            AlterColumn("dbo.Events", "Name", c => c.String());
        }
    }
}
