namespace NastaniMK_2023.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class eventFinal : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Events", "ImageURL", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Events", "ImageURL", c => c.String());
        }
    }
}
