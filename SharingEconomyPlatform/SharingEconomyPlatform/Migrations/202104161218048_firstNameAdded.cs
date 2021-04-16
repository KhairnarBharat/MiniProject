namespace SharingEconomyPlatform.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstNameAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "FirstName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "FirstName");
        }
    }
}
