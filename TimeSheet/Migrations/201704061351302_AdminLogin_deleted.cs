namespace TimeSheet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdminLogin_deleted : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AdminLogins", "Companies_id1", "dbo.Companies");
            DropIndex("dbo.AdminLogins", new[] { "Companies_id1" });
            DropTable("dbo.AdminLogins");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.AdminLogins",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Companies_id = c.String(),
                        Enabled = c.Boolean(nullable: false),
                        Companies_id1 = c.Int(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateIndex("dbo.AdminLogins", "Companies_id1");
            AddForeignKey("dbo.AdminLogins", "Companies_id1", "dbo.Companies", "id");
        }
    }
}
