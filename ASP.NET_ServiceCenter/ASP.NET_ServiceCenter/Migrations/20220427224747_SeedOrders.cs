using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP.NET_ServiceCenter.Migrations
{
    public partial class SeedOrders : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //Orders
            migrationBuilder.Sql(@"
            SET IDENTITY_INSERT [dbo].[Orders] ON
            INSERT INTO [dbo].[Orders] ([id], [product_id], [user_id], [client_id], [date_start], [date_end], [price], [user_name]) VALUES (2, 1, N'3f687a55-a95f-420d-842d-5fa38efef752', 1, N'2022-04-15 00:00:00', N'2022-04-30 00:00:00', 100, N'master1@gmail.com')
            INSERT INTO [dbo].[Orders] ([id], [product_id], [user_id], [client_id], [date_start], [date_end], [price], [user_name]) VALUES (3, 2, N'3f687a55-a95f-420d-842d-5fa38efef752', 2, N'2022-04-15 00:00:00', N'2022-04-30 00:00:00', 200, N'master1@gmail.com')
            INSERT INTO [dbo].[Orders] ([id], [product_id], [user_id], [client_id], [date_start], [date_end], [price], [user_name]) VALUES (4, 3, N'e087dfd3-0fc9-40b4-b925-7827d8b55cbb', 3, N'2022-05-01 00:00:00', N'2022-05-30 00:00:00', 300, N'')
            SET IDENTITY_INSERT [dbo].[Orders] OFF
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
