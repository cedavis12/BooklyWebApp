namespace Bookly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'afada4f6-3b55-4680-a3d7-a79ec2a134d1', N'guest@bookly.com', 0, N'ACkGMpoiQdK+pyAPcZhBiI/F9/YQH0UlmumIGpUvvxwKHky/SWmLJAiz21F91Y4j9w==', N'9b093533-94d6-4563-8d0c-48e10af209fe', NULL, 0, 0, NULL, 1, 0, N'guest@bookly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'bb0a1c7f-e39a-4b22-b87c-96fc90239ae5', N'admin@bookly.com', 0, N'ANtBSG3AWoCEcOgEzU7cRA9zmK1b4kKdiVzL+uRpJq1+LZ2mObAWp/0dewAvqLm8xQ==', N'bbc24ce4-24f1-4aff-bb9c-069dcaf03f83', NULL, 0, 0, NULL, 1, 0, N'admin@bookly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'68881616-8527-4361-b3d1-b093efef1291', N'CanManageBooks')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'bb0a1c7f-e39a-4b22-b87c-96fc90239ae5', N'68881616-8527-4361-b3d1-b093efef1291')

");
        }
        
        public override void Down()
        {
        }
    }
}
