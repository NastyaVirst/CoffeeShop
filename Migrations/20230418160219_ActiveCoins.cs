using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoffeeShop.Migrations
{
    public partial class ActiveCoins : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "active",
                table: "Coins",
                type: "INTEGER",
                nullable: false,
                defaultValue: true);

            migrationBuilder.UpdateData(
                table: "Coins",
                keyColumn: "id",
                keyValue: 1,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                table: "Coins",
                keyColumn: "id",
                keyValue: 2,
                column: "active",
                value: false);

            migrationBuilder.UpdateData(
                table: "Coins",
                keyColumn: "id",
                keyValue: 3,
                column: "active",
                value: true);

            migrationBuilder.UpdateData(
                table: "Coins",
                keyColumn: "id",
                keyValue: 4,
                column: "active",
                value: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "active",
                table: "Coins");
        }
    }
}
