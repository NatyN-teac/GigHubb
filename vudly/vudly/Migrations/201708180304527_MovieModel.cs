namespace vudly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MovieModel : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Movies", name: "Genre_Id", newName: "GenreId_Id");
            RenameIndex(table: "dbo.Movies", name: "IX_Genre_Id", newName: "IX_GenreId_Id");
            DropColumn("dbo.Movies", "GenreId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "GenreId", c => c.Byte(nullable: false));
            RenameIndex(table: "dbo.Movies", name: "IX_GenreId_Id", newName: "IX_Genre_Id");
            RenameColumn(table: "dbo.Movies", name: "GenreId_Id", newName: "Genre_Id");
        }
    }
}
