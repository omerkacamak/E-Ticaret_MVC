using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class orderDetailUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Products_ProductID",
                table: "OrderDetails");

            migrationBuilder.RenameColumn(
                name: "ProductID",
                table: "OrderDetails",
                newName: "ProductItemID");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetails_ProductID",
                table: "OrderDetails",
                newName: "IX_OrderDetails_ProductItemID");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_ProductItems_ProductItemID",
                table: "OrderDetails",
                column: "ProductItemID",
                principalTable: "ProductItems",
                principalColumn: "ProductItemID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_ProductItems_ProductItemID",
                table: "OrderDetails");

            migrationBuilder.RenameColumn(
                name: "ProductItemID",
                table: "OrderDetails",
                newName: "ProductID");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetails_ProductItemID",
                table: "OrderDetails",
                newName: "IX_OrderDetails_ProductID");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Products_ProductID",
                table: "OrderDetails",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ProductID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
