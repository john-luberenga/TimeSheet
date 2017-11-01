namespace TimeSheet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Files_Restored : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AdminUsers", "Companies_id", "dbo.Companies");
            DropIndex("dbo.AdminUsers", new[] { "Companies_id" });
            DropColumn("dbo.AdminUsers", "Company_ID");
            
        }
        
        public override void Down()
        {
            AddColumn("dbo.AdminUsers", "Companies_id", c => c.Int());
            AddColumn("dbo.AdminUsers", "Company_ID", c => c.Int(nullable: false));
            CreateIndex("dbo.AdminUsers", "Companies_id");
            AddForeignKey("dbo.AdminUsers", "Companies_id", "dbo.Companies", "id");
        }
    }
}
