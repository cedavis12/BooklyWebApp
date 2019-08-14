namespace Bookly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetSQLValues : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Books SET NumAvailable = NumInStock");
        }
        
        public override void Down()
        {
        }
    }
}
