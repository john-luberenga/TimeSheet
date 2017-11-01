namespace TimeSheet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Roles_added : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AddUsers", "Role", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AddUsers", "Role");
        }
    }
}
