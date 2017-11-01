namespace TimeSheet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DateUpdated : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cases", "StartDate", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Cases", "EndDate", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Cases", "EndDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Cases", "StartDate", c => c.DateTime(nullable: false));
        }
    }
}
