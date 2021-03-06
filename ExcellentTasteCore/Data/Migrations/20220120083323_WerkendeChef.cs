using Microsoft.EntityFrameworkCore.Migrations;

namespace ExcellentTasteCore.Data.Migrations
{
    public partial class WerkendeChef : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ConsumptieItemNaam",
                table: "Bestelling",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConsumptieItemNaam",
                table: "Bestelling");
        }
    }
}
