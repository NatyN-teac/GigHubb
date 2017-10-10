namespace vudly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUpdateMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql(" UPDATE MembershipTypes SET Name = 'Pay as you go' WHERE Id = 1 ");
            Sql(" UPDATE MembershipTypes SET Name = 'Monthly' WHERE Id = 2 ");
            Sql(" UPDATE MembershipTypes SET Name = 'Annually' WHERE Id = 3 ");
        }
        
        public override void Down()
        {
        }
    }
}
