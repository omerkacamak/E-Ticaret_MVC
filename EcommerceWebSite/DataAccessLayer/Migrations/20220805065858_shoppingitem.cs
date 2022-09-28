using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class shoppingitem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCartItems_Products_ProductID",
                table: "ShoppingCartItems");

            migrationBuilder.RenameColumn(
                name: "ProductID",
                table: "ShoppingCartItems",
                newName: "ProductItemID");

            migrationBuilder.RenameIndex(
                name: "IX_ShoppingCartItems_ProductID",
                table: "ShoppingCartItems",
                newName: "IX_ShoppingCartItems_ProductItemID");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCartItems_ProductItems_ProductItemID",
                table: "ShoppingCartItems",
                column: "ProductItemID",
                principalTable: "ProductItems",
                principalColumn: "ProductItemID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCartItems_ProductItems_ProductItemID",
                table: "ShoppingCartItems");

            migrationBuilder.RenameColumn(
                name: "ProductItemID",
                table: "ShoppingCartItems",
                newName: "ProductID");

            migrationBuilder.RenameIndex(
                name: "IX_ShoppingCartItems_ProductItemID",
                table: "ShoppingCartItems",
                newName: "IX_ShoppingCartItems_ProductID");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCartItems_Products_ProductID",
                table: "ShoppingCartItems",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ProductID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
