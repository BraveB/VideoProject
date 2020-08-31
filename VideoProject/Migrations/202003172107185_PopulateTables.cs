namespace VideoProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateTables : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes(Id, SignUpFee, DurationInMonths, DiscountRate, Name) VALUES ( 1, 0, 0, 0, 'Pay as you go')");
            Sql("INSERT INTO MembershipTypes(Id, SignUpFee, DurationInMonths, DiscountRate, Name) VALUES ( 2, 30, 1, 10, 'Monthly')");
            Sql("INSERT INTO MembershipTypes(Id, SignUpFee, DurationInMonths, DiscountRate, Name) VALUES ( 3, 90, 3, 15, 'Quarterly')");
            Sql("INSERT INTO MembershipTypes(Id, SignUpFee, DurationInMonths, DiscountRate, Name) VALUES ( 4, 300, 12, 20, 'Annual')");

            Sql("INSERT INTO Genres(Id, Name) VALUES (1,'Comedy')");
            Sql("INSERT INTO Genres(Id, Name) VALUES (2,'Horror')");
            Sql("INSERT INTO Genres(Id, Name) VALUES (3,'Drama')");
            Sql("INSERT INTO Genres(Id, Name) VALUES (4,'Romance')");
            Sql("INSERT INTO Genres(Id, Name) VALUES (5,'Thriller')");
        }
        
        public override void Down()
        {
        }
    }
}
