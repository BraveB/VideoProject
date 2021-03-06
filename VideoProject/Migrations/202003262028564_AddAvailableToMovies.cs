namespace VideoProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAvailableToMovies : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Available", c => c.Int(nullable: false));

            Sql("UPDATE Movies SET Available = InStock");
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "Available");
        }
    }
}
