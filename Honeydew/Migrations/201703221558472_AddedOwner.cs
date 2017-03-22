namespace Honeydew.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedOwner : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ToDoes", "OwnerId", c => c.String(maxLength: 128));
            CreateIndex("dbo.ToDoes", "OwnerId");
            AddForeignKey("dbo.ToDoes", "OwnerId", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ToDoes", "OwnerId", "dbo.AspNetUsers");
            DropIndex("dbo.ToDoes", new[] { "OwnerId" });
            DropColumn("dbo.ToDoes", "OwnerId");
        }
    }
}
