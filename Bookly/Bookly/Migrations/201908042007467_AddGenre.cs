namespace Bookly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGenre : DbMigration
    {
        public override void Up()
        {
            Sql("DELETE FROM Books");

            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Books", "GenreId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Books", "GenreId");
            AddForeignKey("dbo.Books", "GenreId", "dbo.Genres", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Books", "GenreId", "dbo.Genres");
            DropIndex("dbo.Books", new[] { "GenreId" });
            DropColumn("dbo.Books", "GenreId");
            DropTable("dbo.Genres");
        }
    }
}
