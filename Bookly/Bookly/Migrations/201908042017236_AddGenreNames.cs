namespace Bookly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGenreNames : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) VALUES (1, 'Fiction')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (2, 'Non-Fiction')");
        }
        
        public override void Down()
        {
        }
    }
}
