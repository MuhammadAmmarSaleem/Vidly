namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateBirthDateInCustomer : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET BirthDate = '1995-03-07 12:13:30 PM' WHERE Id = 1");
            Sql("UPDATE Customers SET BirthDate = '1997-03-07 12:13:30 PM' WHERE Id = 2");
            
        }
        
        public override void Down()
        {
        }
    }
}
