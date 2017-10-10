namespace Vidlly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateGenre : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Genres ON");
            Sql("INSERT INTO Genres(Id,GenreName) VALUES(1,'Romance')");
            Sql("INSERT INTO Genres(Id,GenreName) VALUES(2,'Action')");
            Sql("INSERT INTO Genres(Id,GenreName) VALUES(3,'Horror')");
            Sql("INSERT INTO Genres(Id,GenreName) VALUES(4,'Adventure')");
        }
        
        public override void Down()
        {
        }
    }
}
