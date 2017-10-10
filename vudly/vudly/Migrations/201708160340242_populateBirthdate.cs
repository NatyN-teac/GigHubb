namespace vudly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateBirthdate : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET birthdate = '12/2/2007' WHERE Id = 1 ");
           

        }
        
        public override void Down()
        {
        }
    }
}
