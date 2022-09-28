using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class deleteOption2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           
            migrationBuilder.DropTable(
               name: "ProductOptions");
            
            migrationBuilder.DropTable(
               name: "OptionValues");
           
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
