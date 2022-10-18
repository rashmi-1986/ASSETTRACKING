using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASSETTRACKING.Migrations
{
    public partial class AddItemTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Assets1");

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                values: new object[] { 3, "Asus", "Computer", "$", 10.0, "W234", "USA", 1993, 1250.0 });
        }
    }
}
