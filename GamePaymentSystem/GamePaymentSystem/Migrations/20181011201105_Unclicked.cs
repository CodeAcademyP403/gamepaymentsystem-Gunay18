using Microsoft.EntityFrameworkCore.Migrations;

namespace GamePaymentSystem.Migrations
{
    public partial class Unclicked : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Clicked",
                table: "Games");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Clicked",
                table: "Games",
                nullable: false,
                defaultValue: false);
        }
    }
}
