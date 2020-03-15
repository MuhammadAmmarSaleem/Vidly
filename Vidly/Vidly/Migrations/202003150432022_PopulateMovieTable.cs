namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovieTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MOVIES (Name, GenreId, ReleaseDate,DateTimeCreated, DateTimeModified, NumberInStock ) Values" +
                "('Sherk', '1', '2020-02-12 03:00:00 PM', '2020-02-20 03:00:00 PM', '2020-02-20 03:00:00 PM', 10000)");

            Sql("INSERT INTO MOVIES (Name, GenreId, ReleaseDate,DateTimeCreated, DateTimeModified, NumberInStock ) Values" +
                "('Jurasic Park', '2', '2020-02-13 03:00:00 PM', '2020-03-20 03:00:00 PM', '2020-03-20 03:00:00 PM', 20000)");

            Sql("INSERT INTO MOVIES (Name, GenreId, ReleaseDate,DateTimeCreated, DateTimeModified, NumberInStock ) Values" +
                    "('Jurasic Park', '3', '2020-03-13 03:00:00 PM', '2020-04-20 03:00:00 PM', '2020-04-20 03:00:00 PM', 30000)");
        }
        
        public override void Down()
        {
        }
    }
}
