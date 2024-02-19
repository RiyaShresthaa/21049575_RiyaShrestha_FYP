using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Flora.Server.Migrations
{
    public partial class ProductSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageURL", "Price", "Title" },
                values: new object[] { 1, "Bursting with Christmas spirit, this lush rose bouquet is accented with candy canes and pine cones for a touch of festive fun.Red roses, white snapdragons, and white cushion spray chrysanthemums are wrapped in a variegated aspidistra leaf and accented with seeded eucalyptus, lemon leaf, flat cedar, white pine, candy canes, and small frosted pinecones. Delivered in a clear glass cylinder vase.", "https://assets.eflorist.com/assets/products/PZM_/TWR14-4A.jpg?impolicy=hero&impolicy=hero", 9.99m, "Festive Pines Bouquet" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageURL", "Price", "Title" },
                values: new object[] { 2, "Free their spirits with this fabulous array of pink flowers in a chic glass cylinder vase. As breezy and fun as a classic Gene Kelly movie, it will brighten their entire week.The lush bouquet includes dark pink hydrangea, pink roses and pink carnations accented with red ti leaves.", "https://assets.eflorist.com/assets/products/PZM_/T553-1A.jpg?impolicy=hero&impolicy=hero", 7.99m, "On The Town" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageURL", "Price", "Title" },
                values: new object[] { 3, "Show impeccable taste when you send this stylish bouquet of hot pink roses, pale pink lilies and mixed blossoms, arranged in a modern glass cube vase. Pretty, posh and perfectly high-class!Hot pink roses and Matsumoto asters, pink LA hybrid lilies and burgundy stock arrive in a clear glass Teleflora cube vase lined with variegated ti leaves.", "https://assets.eflorist.com/assets/products/PZM_/T05N100A.jpg?impolicy=hero&impolicy=hero   ", 8.99m, "Posh Pinks" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Products",
                type: "decimal(18,2",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }
    }
}
