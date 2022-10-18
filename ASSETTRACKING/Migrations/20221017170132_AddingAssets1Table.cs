using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASSETTRACKING.Migrations
{
    public partial class AddingAssets1Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "purchasePrice",
                table: "Items",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<decimal>(
                name: "exchangeRate",
                table: "Items",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "Assets1",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assets1", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "brand", "catagory", "currency", "exchangeRate", "model", "office", "purchaseDate", "purchasePrice" },
                values: new object[] { 1, "hp", "Computer", "$", 50m, "2018", "USA", 1997, 50m });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "brand", "catagory", "currency", "exchangeRate", "model", "office", "purchaseDate", "purchasePrice" },
                values: new object[] { 2, "hp", "Computer", "$", 50m, "2018", "USA", 1997, 50m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Assets1");

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AlterColumn<int>(
                name: "purchasePrice",
                table: "Items",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<int>(
                name: "exchangeRate",
                table: "Items",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }
    }
}
