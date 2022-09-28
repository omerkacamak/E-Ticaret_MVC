using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class optStok : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductOptStok",
                columns: table => new
                {
                    ProductOptStokID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    OptionValuesID = table.Column<int>(type: "int", nullable: false),
                    stokAdedi = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductOptStok", x => x.ProductOptStokID);
                    table.ForeignKey(
                        name: "FK_ProductOptStok_OptionValues_OptionValuesID",
                        column: x => x.OptionValuesID,
                        principalTable: "OptionValues",
                        principalColumn: "OptionValuesID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductOptStok_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductOptStok_OptionValuesID",
                table: "ProductOptStok",
                column: "OptionValuesID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductOptStok_ProductID",
                table: "ProductOptStok",
                column: "ProductID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductOptStok");
        }
    }
}
