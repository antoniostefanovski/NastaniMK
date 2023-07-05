namespace NastaniMK_2023.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class eventModelEdit : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Events", "Date", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Events", "Date", c => c.DateTime(nullable: false));
        }
    }
}
