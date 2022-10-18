using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASSETTRACKING.Migrations
{
    public partial class assets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    catagory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    purchaseDate = table.Column<int>(type: "int", nullable: false),
                    office = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    purchasePrice = table.Column<int>(type: "int", nullable: false),
                    currency = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    exchangeRate = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "brand", "catagory", "currency", "exchangeRate", "model", "office", "purchaseDate", "purchasePrice" },
                values: new object[] { 1, "hp", "Computer", "$", 50, "2018", "USA", 1997, 50 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Items");
        }
    }
}
