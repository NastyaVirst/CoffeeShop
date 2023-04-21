using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoffeeShop.Migrations
{
    public partial class AddCoins : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "id", "count", "name", "value" },
                values: new object[] { 1, 10000, "1 Рубль", 1f });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "id", "count", "name", "value" },
                values: new object[] { 2, 10000, "2 Рубля", 2f });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "id", "count", "name", "value" },
                values: new object[] { 3, 10000, "5 Рублей", 5f });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "id", "count", "name", "value" },
                values: new object[] { 4, 10000, "10 Рублей", 10f });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Coins",
                keyColumn: "id",
                keyValue: 4);
        }
    }
}
