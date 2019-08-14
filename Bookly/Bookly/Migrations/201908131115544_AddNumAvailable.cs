namespace Bookly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNumAvailable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "NumAvailable", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Books", "NumAvailable");
        }
        }
    }
