using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoffeeShop.Migrations
{
    public partial class AddCoffeInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Coffees",
                columns: new[] { "id", "count", "descr", "img", "name", "price" },
                values: new object[] { 1, 100, "готовится как двойная порция эспрессо, две закладки кофе и два объема воды.", "1.jpg", "Доппио", 130f });

            migrationBuilder.InsertData(
                table: "Coffees",
                columns: new[] { "id", "count", "descr", "img", "name", "price" },
                values: new object[] { 2, 100, "эспрессо обычный или двойной, в который после приготовления добавили (30–470 мл) горячей воды.", "2.jpg", "Американо", 80f });

            migrationBuilder.InsertData(
                table: "Coffees",
                columns: new[] { "id", "count", "descr", "img", "name", "price" },
                values: new object[] { 3, 100, "спрессо заваренный из того же количества кофе и за то же время экстракции, но с использованием вдвое меньшего количества воды.", "3.jpg", "Ристретто", 180f });

            migrationBuilder.InsertData(
                table: "Coffees",
                columns: new[] { "id", "count", "descr", "img", "name", "price" },
                values: new object[] { 4, 100, "похож на Американо по пропорции воды к кофе. Однако, этот объем воды используется при заваривании (пропускается через кофе), в противоположность Американо, где вода заливается в готовый эспрессо.", "4.jpg", "Лунго", 160f });

            migrationBuilder.InsertData(
                table: "Coffees",
                columns: new[] { "id", "count", "descr", "img", "name", "price" },
                values: new object[] { 5, 100, " еще более длинный Лунго. До 50-х годов caffe crema называли эспрессо.", "5.jpg", "Кафе крема", 200f });

            migrationBuilder.InsertData(
                table: "Coffees",
                columns: new[] { "id", "count", "descr", "img", "name", "price" },
                values: new object[] { 6, 100, "напиток приготовленный с помощью рожковой эспрессо-машины. Принципиальные различия во вкусе достигаются благодаря более длительному времени экстракции", "6.jpg", "Эспресс", 150f });

            migrationBuilder.UpdateData(
                table: "Coins",
                keyColumn: "id",
                keyValue: 2,
                column: "active",
                value: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Coffees",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Coffees",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Coffees",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Coffees",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Coffees",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Coffees",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Coins",
                keyColumn: "id",
                keyValue: 2,
                column: "active",
                value: true);
        }
    }
}
