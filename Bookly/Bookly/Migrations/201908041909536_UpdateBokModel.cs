namespace Bookly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateBokModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "Genre", c => c.String(nullable: false));
            AddColumn("dbo.Books", "ReleaseDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Books", "DateAdded", c => c.DateTime(nullable: false));
            AddColumn("dbo.Books", "NumInStock", c => c.Byte(nullable: false));
            AlterColumn("dbo.Books", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Books", "Name", c => c.String());
            DropColumn("dbo.Books", "NumInStock");
            DropColumn("dbo.Books", "DateAdded");
            DropColumn("dbo.Books", "ReleaseDate");
            DropColumn("dbo.Books", "Genre");
        }
    }
}
