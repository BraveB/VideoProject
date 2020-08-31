namespace VideoProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'7ea2875e-255c-4e81-bbba-24a38760255e', N'guest@vidly.com', 0, N'AN48wbs62mvE05LUwZ5GQZtM3LS3CDkOxzalRjB9QuRUvNtYzAyZhgWovtEhyOEoRA==', N'989281a1-3f93-4433-8a9c-e3588bea06a4', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'c05004da-6b35-4828-996e-df3e70cdc52d', N'admi@vidly.com', 0, N'ANrCDWx5/YHe6O6mM/V2AEQGEq4RodfCV0sdzkMZR9+8YQn3j9s3yD0FQZuLmsd6/g==', N'0dca108f-a583-4b95-a3e0-82b20a719443', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'15ee33a0-5cab-491e-892c-82520535b18b', N'CanManageMovie')
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'c05004da-6b35-4828-996e-df3e70cdc52d', N'15ee33a0-5cab-491e-892c-82520535b18b')
                ");
        }
        
        public override void Down()
        {
        }
    }
}
