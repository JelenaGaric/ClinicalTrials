using Microsoft.EntityFrameworkCore.Migrations;

namespace Model.Migrations
{
    public partial class Migration10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "CityCoordinates");

            migrationBuilder.AddColumn<string>(
                name: "LocationCity",
                table: "CityCoordinates",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LocationCity",
                table: "CityCoordinates");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "CityCoordinates",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
