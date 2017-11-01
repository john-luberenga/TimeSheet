namespace TimeSheet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SomeTablesChanged : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.AddUsers", newName: "AdminUsers");
            RenameTable(name: "dbo.Users", newName: "CompanyUsers");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.CompanyUsers", newName: "Users1");
            RenameTable(name: "dbo.AdminUsers", newName: "Users");
        }
    }
}
