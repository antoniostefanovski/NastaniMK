namespace NastaniMK_2023.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedEmailToOrganizer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Organizers", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Organizers", "Description", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Organizers", "Description", c => c.String());
            DropColumn("dbo.Organizers", "Email");
        }
    }
}
