namespace Bookly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateBookClass : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Books", "Genre");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Books", "Genre", c => c.String(nullable: false));
        }
    }
}
