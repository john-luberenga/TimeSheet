namespace TimeSheet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Companies_db_updated : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Companies", "Enabled", c => c.Boolean(nullable: false));
            DropColumn("dbo.AdminLogins", "Disabled");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AdminLogins", "Disabled", c => c.Boolean(nullable: false));
            DropColumn("dbo.Companies", "Enabled");
            RenameTable(name: "dbo.Users1", newName: "Users");
            RenameTable(name: "dbo.Users", newName: "AddUsers");
        }
    }
}
