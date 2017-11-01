namespace TimeSheet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class databaseUpdated : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AddUsers",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        Company_ID = c.Int(nullable: false),
                        Password = c.String(),
                        ConfirmPassword = c.String(),
                        Companies_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Companies", t => t.Companies_id)
                .Index(t => t.Companies_id);
            
            DropColumn("dbo.Users", "CompanyName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "CompanyName", c => c.String());
            DropForeignKey("dbo.AddUsers", "Companies_id", "dbo.Companies");
            DropIndex("dbo.AddUsers", new[] { "Companies_id" });
            DropTable("dbo.AddUsers");
        }
    }
}
