namespace TimeSheet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Admin_company_parameters_changed : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AdminLogins", "Companies_id", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AdminLogins", "Companies_id", c => c.Int(nullable: false));
        }
    }
}
