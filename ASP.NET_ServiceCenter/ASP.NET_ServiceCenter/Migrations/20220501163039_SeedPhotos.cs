using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP.NET_ServiceCenter.Migrations
{
    public partial class SeedPhotos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //Users
            migrationBuilder.Sql(@"
            INSERT INTO [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [FirstName], [LastName], [UserPhoto]) VALUES (N'3f687a55-a95f-420d-842d-5fa38efef752', N'master1@gmail.com', N'MASTER1@GMAIL.COM', N'master1@gmail.com', N'MASTER1@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEBg9z6zJ3sb8ExdaQx0UWRSZ4SmoYTYSf3CZn86tlXj9/MOuOwv1YiwywFSOeVVHTA==', N'EXUG4AXMBFRIPGBMVQ3BQUGQBXSD5SOX', N'9ea5de9f-9219-4853-86fc-0f07b0e76511', NULL, 0, 0, NULL, 1, 0, N'Master', N'First', N'mark.png')
            INSERT INTO [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [FirstName], [LastName], [UserPhoto]) VALUES (N'ac181208-9045-4730-91d0-f9f66100e48f', N'admin@gmail.com', N'ADMIN@GMAIL.COM', N'admin@gmail.com', N'ADMIN@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEA0XZvhPtKZ9YTGVDuRsJKRdM5IkjoNSKL/n0/mhoxhZkn5SDpWdBLcmYAE2DEP2OA==', N'LDVKLPA2BGVLDE4WMOA3VPKUBHHOXPBV', N'63886460-6db6-4231-9142-c3ec8cf49499', NULL, 0, 0, NULL, 1, 0, N'Admin', N'Adminov', N'nolan.png')
            INSERT INTO [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [FirstName], [LastName], [UserPhoto]) VALUES (N'e087dfd3-0fc9-40b4-b925-7827d8b55cbb', N'master2@gmail.com', N'MASTER2@GMAIL.COM', N'master2@gmail.com', N'MASTER2@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEIae0E9vheMzm/Dw2fgN/oBwwuak5vbzHDLvXrVMIVCfW060HwcFTznjcLBZ9ZA0GA==', N'AWR4JVL6OBN34JCTFDSMZWE4QD26HFVD', N'a2e84344-2604-4628-8b00-3b82481dd478', NULL, 0, 0, NULL, 1, 0, N'Master', N'Second', N'debbie.png')
            ");

            //roles
            migrationBuilder.Sql(@"
            INSERT INTO [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'38d37d14-ef06-4047-8e64-35947e43e9f1', N'Admin', N'ADMIN', N'7dc5c1b4-342f-4270-a453-c7f68d092c02')
            ");

            //UserRoles
            migrationBuilder.Sql(@"
            INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'ac181208-9045-4730-91d0-f9f66100e48f', N'38d37d14-ef06-4047-8e64-35947e43e9f1')
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
