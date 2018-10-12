using Microsoft.EntityFrameworkCore.Migrations;

namespace GamePaymentSystem.Migrations
{
    public partial class Clicked : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Clicked",
                table: "Games",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Clicked",
                table: "Games");
        }
    }
}
