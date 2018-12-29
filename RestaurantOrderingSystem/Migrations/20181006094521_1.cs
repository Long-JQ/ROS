using Microsoft.EntityFrameworkCore.Migrations;

namespace RestaurantOrderingSystem.Migrations
{
    public partial class _1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "Bill");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Stores",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OrderCode",
                table: "Orders",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TableNumber",
                table: "Orders",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Img",
                table: "Foods",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Foods",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Price",
                table: "Foods",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Bill",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bill",
                table: "Bill",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Bill",
                table: "Bill");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Stores");

            migrationBuilder.DropColumn(
                name: "OrderCode",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "TableNumber",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Img",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Bill");

            migrationBuilder.RenameTable(
                name: "Bill",
                newName: "Users");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");
        }
    }
}
