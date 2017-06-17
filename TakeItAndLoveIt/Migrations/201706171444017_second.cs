namespace TakeItAndLoveIt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class second : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.UserModels", "Username", c => c.String(nullable: false));
            AlterColumn("dbo.UserModels", "Password", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.UserModels", "Password", c => c.String());
            AlterColumn("dbo.UserModels", "Username", c => c.String());
        }
    }
}
