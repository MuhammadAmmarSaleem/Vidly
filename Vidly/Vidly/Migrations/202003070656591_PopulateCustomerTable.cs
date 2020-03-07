namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCustomerTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Customers (Name, IsSubscribedToNewsLetter, MemberShipTypeId) Values ('Ammar', 1, 1)");
            Sql("INSERT INTO Customers (Name, IsSubscribedToNewsLetter, MemberShipTypeId) Values ('Umer', 0, 2)");
            Sql("INSERT INTO Customers (Name, IsSubscribedToNewsLetter, MemberShipTypeId) Values ('Yahya', 1, 3)");
            Sql("INSERT INTO Customers (Name, IsSubscribedToNewsLetter, MemberShipTypeId) Values ('Tariq', 0, 4)");

        }
        
        public override void Down()
        {
        }
    }
}
