namespace TakeItAndLoveIt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Third : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Interactions", "InteractionType", c => c.String(nullable: false));
            AlterColumn("dbo.UserModels", "Username", c => c.String());
            AlterColumn("dbo.UserModels", "Password", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.UserModels", "Password", c => c.String(nullable: false));
            AlterColumn("dbo.UserModels", "Username", c => c.String(nullable: false));
            AlterColumn("dbo.Interactions", "InteractionType", c => c.String());
        }
    }
}
