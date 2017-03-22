namespace Honeydew.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDescription : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ToDoes", "Description", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ToDoes", "Description");
        }
    }
}
