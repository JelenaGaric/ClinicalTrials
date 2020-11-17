using Microsoft.EntityFrameworkCore.Migrations;

namespace Model.Migrations
{
    public partial class Migration12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "lng",
                table: "CityCoordinates",
                newName: "Lng");

            migrationBuilder.RenameColumn(
                name: "lat",
                table: "CityCoordinates",
                newName: "Lat");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Lng",
                table: "CityCoordinates",
                newName: "lng");

            migrationBuilder.RenameColumn(
                name: "Lat",
                table: "CityCoordinates",
                newName: "lat");
        }
    }
}
