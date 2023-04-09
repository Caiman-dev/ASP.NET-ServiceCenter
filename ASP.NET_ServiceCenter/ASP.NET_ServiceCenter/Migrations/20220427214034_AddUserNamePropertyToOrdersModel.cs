using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP.NET_ServiceCenter.Migrations
{
    public partial class AddUserNamePropertyToOrdersModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "user_name",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "user_name",
                table: "Orders");
        }
    }
}
