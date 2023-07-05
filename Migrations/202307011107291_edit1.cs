namespace NastaniMK_2023.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class edit1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Events", "ImageURL", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Events", "ImageURL", c => c.String(nullable: false));
        }
    }
}
