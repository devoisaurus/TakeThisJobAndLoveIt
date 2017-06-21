namespace TakeItAndLoveIt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class four : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Interactions", "Company_CompanyId", c => c.Int());
            CreateIndex("dbo.Interactions", "Company_CompanyId");
            AddForeignKey("dbo.Interactions", "Company_CompanyId", "dbo.Companies", "CompanyId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Interactions", "Company_CompanyId", "dbo.Companies");
            DropIndex("dbo.Interactions", new[] { "Company_CompanyId" });
            DropColumn("dbo.Interactions", "Company_CompanyId");
        }
    }
}
