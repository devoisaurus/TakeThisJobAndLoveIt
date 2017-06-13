namespace TakeItAndLoveIt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class New : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        CompanyId = c.Int(nullable: false, identity: true),
                        CompanyName = c.String(),
                        PrimaryContact = c.String(),
                        PrimaryContactEmail = c.String(),
                        PrimaryContactPhone = c.String(),
                    })
                .PrimaryKey(t => t.CompanyId);
            
            CreateTable(
                "dbo.Interactions",
                c => new
                    {
                        InteractionId = c.Int(nullable: false, identity: true),
                        InteractionDate = c.DateTime(nullable: false),
                        InteractionType = c.String(),
                        InteractionNotes = c.String(),
                    })
                .PrimaryKey(t => t.InteractionId);
            
            CreateTable(
                "dbo.UserModels",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Password = c.String(),
                        Email = c.String(),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UserModels");
            DropTable("dbo.Interactions");
            DropTable("dbo.Companies");
        }
    }
}
