namespace vudly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateGenre : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Genres ON");
            Sql("INSERT INTO Genres(Id,GenreName) VALUES (1,'comedy')");
            Sql("INSERT INTO Genres(Id,GenreName) VALUES (2,'Action')");
            Sql("INSERT INTO Genres(Id,GenreName) VALUES (3,'Adventure')");
            Sql("INSERT INTO Genres(Id,GenreName) VALUES (4,'Drama')");
            Sql("INSERT INTO Genres(Id,GenreName) VALUES (5,'romantic')");
        }
        
        public override void Down()
        {
        }
    }
}
