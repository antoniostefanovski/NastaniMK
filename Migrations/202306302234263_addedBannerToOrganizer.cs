namespace NastaniMK_2023.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedBannerToOrganizer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Organizers", "Banner", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Organizers", "Banner");
        }
    }
}
