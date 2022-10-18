using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASSETTRACKING.Migrations
{
    public partial class AddingAssetTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.CreateTable(
                name: "Assets",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assets", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "id", "name" },
                values: new object[] { 2, "Company" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "brand", "catagory", "currency", "exchangeRate", "model", "office", "purchaseDate", "purchasePrice" },
                values: new object[] { "apple", "Phone", "SEK", 54.700000000000003, "2022", "Sweden", 1995, 5470.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "brand", "catagory", "currency", "exchangeRate", "model", "office", "purchaseDate", "purchasePrice" },
                values: new object[] { 5, "apple", "Phone", "EUR", 24.699999999999999, "2022", "Spain", 1995, 2470.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Assets");

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "brand", "catagory", "currency", "exchangeRate", "model", "office", "purchaseDate", "purchasePrice" },
                values: new object[] { "hp", "Computer", "$", 50.0, "2018", "USA", 1997, 50.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "brand", "catagory", "currency", "exchangeRate", "model", "office", "purchaseDate", "purchasePrice" },
                values: new object[] { 2, "hp", "Computer", "$", 50.0, "2018", "USA", 1997, 50.0 });
        }
    }
}
