namespace TimeSheet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdminLoginCreated : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AdminLogins", "Enabled", c => c.Boolean(nullable: false));
            AddColumn("dbo.AdminLogins", "Disabled", c => c.Boolean(nullable: false));
            DropColumn("dbo.AdminLogins", "active");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AdminLogins", "active", c => c.Boolean(nullable: false));
            DropColumn("dbo.AdminLogins", "Disabled");
            DropColumn("dbo.AdminLogins", "Enabled");
        }
    }
}
