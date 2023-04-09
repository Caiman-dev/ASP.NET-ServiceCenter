using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP.NET_ServiceCenter.Migrations
{
    public partial class AddDataToTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //Clients
            migrationBuilder.Sql(@"
            SET IDENTITY_INSERT [dbo].[Clients] ON
            INSERT INTO [dbo].[Clients] ([id], [passport], [name], [address], [phone], [birthdate]) VALUES (1, N'123456789', N'Nolan Grayson', N'Viltrum', N'+711111111111', N'2022-05-01 00:00:00')
            INSERT INTO [dbo].[Clients] ([id], [passport], [name], [address], [phone], [birthdate]) VALUES (2, N'321654987', N'Mark Grayson', N'Viltrum', N'+777777777777', N'2022-08-01 00:00:00')
            INSERT INTO [dbo].[Clients] ([id], [passport], [name], [address], [phone], [birthdate]) VALUES (3, N'123789456', N'Debbie Grayson', N'Viltrum', N'+712313212311', N'2022-06-01 00:00:00')
            SET IDENTITY_INSERT [dbo].[Clients] OFF
            ");

            //Products
            migrationBuilder.Sql(@"
            SET IDENTITY_INSERT [dbo].[Products] ON
            INSERT INTO [dbo].[Products] ([id], [cat_id], [serial], [price], [year], [brand], [model]) VALUES (1, 1, N'111222333', 100000, N'2021', N'iPhone', N'iPhone 11')
            INSERT INTO [dbo].[Products] ([id], [cat_id], [serial], [price], [year], [brand], [model]) VALUES (2, 2, N'444555666', 150000, N'2020', N'Lenovo', N'SuperPC')
            INSERT INTO [dbo].[Products] ([id], [cat_id], [serial], [price], [year], [brand], [model]) VALUES (3, 3, N'777888999', 200000, N'2022', N'MacBook', N'MacBook Pro M1')
            SET IDENTITY_INSERT [dbo].[Products] OFF
            ");

            //Categories
            migrationBuilder.Sql(@"
            SET IDENTITY_INSERT [dbo].[Categories] ON
            INSERT INTO [dbo].[Categories] ([id], [cat_name]) VALUES (1, N'mobile')
            INSERT INTO [dbo].[Categories] ([id], [cat_name]) VALUES (2, N'pc')
            INSERT INTO [dbo].[Categories] ([id], [cat_name]) VALUES (3, N'laptop')
            SET IDENTITY_INSERT [dbo].[Categories] OFF
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
