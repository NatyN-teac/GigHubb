namespace Vidlly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'9944a6ab-5b47-4144-8bdd-ef49b656d3a0', N'nathenael@gmail.com', 0, N'AJThdFMvwS6AM3qrgJgLjx3AvwtrBbzMPKUL+OlHvIVJ329Qg0SIcWnz61jGyQIb6A==', N'e429c7a6-d81b-4d91-9411-2ffeafd9bc50', NULL, 0, 0, NULL, 1, 0, N'nathenael@gmail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'edb417c9-543c-48bd-bfe8-9b6710599875', N'admin@vidly.com', 0, N'AJR4zM7M7jSWQW5pDhGrqqsS+1JNFDKYg2ql2kSuEBzm6wPUa85iq4jQC+bCD6xOsA==', N'68ef4d5a-7735-4a9b-9abf-9ed0d1430434', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'51ee7f26-0f43-4185-a0ad-f94f19bdaac5', N'CanManageMovie')

");
        }
        
        public override void Down()
        {
        }
    }
}
