namespace Vidlly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET Name = 'Pay As you Go' where id= 1");
            Sql("UPDATE MembershipTypes SET Name = 'Monthly' where id= 2");
            Sql("UPDATE MembershipTypes SET Name = 'quarterly' where id= 3");
            Sql("UPDATE MembershipTypes SET Name = 'Annually' where id= 4");
        }
        
        public override void Down()
        {
        }
    }
}
