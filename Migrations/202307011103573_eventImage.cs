namespace NastaniMK_2023.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class eventImage : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Events", "ImageURL", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Events", "ImageURL");
        }
    }
}
