using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASSETTRACKING.Migrations
{
    public partial class AddingAsset1Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "purchasePrice",
                table: "Items",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<double>(
                name: "exchangeRate",
                table: "Items",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "exchangeRate", "purchasePrice" },
                values: new object[] { 50.0, 50.0 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "exchangeRate", "purchasePrice" },
                values: new object[] { 50.0, 50.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "brand", "catagory", "currency", "exchangeRate", "model", "office", "purchaseDate", "purchasePrice" },
                values: new object[] { 3, "Asus", "Computer", "$", 10.0, "W234", "USA", 1993, 1250.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AlterColumn<decimal>(
                name: "purchasePrice",
                table: "Items",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<decimal>(
                name: "exchangeRate",
                table: "Items",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "exchangeRate", "purchasePrice" },
                values: new object[] { 50m, 50m });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "exchangeRate", "purchasePrice" },
                values: new object[] { 50m, 50m });
        }
    }
}
