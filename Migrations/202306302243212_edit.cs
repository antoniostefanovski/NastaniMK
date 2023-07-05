namespace NastaniMK_2023.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class edit : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Organizers", "Banner", c => c.String());
            AlterColumn("dbo.Organizers", "Email", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Organizers", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Organizers", "Banner", c => c.String(nullable: false));
        }
    }
}
