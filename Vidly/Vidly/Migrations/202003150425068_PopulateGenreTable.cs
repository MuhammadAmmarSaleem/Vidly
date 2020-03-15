namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenreTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO GENRES (Description) Values('Suspense')");
            Sql("INSERT INTO GENRES (Description) Values('Detective')");
            Sql("INSERT INTO GENRES (Description) Values('War')");
            Sql("INSERT INTO GENRES (Description) Values('Comedy')");
        }
        
        public override void Down()
        {
        }
    }
}
