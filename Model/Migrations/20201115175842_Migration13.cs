using Microsoft.EntityFrameworkCore.Migrations;

namespace Model.Migrations
{
    public partial class Migration13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Lng",
                table: "CityCoordinates",
                newName: "lng");

            migrationBuilder.RenameColumn(
                name: "Lat",
                table: "CityCoordinates",
                newName: "lat");

            migrationBuilder.AlterColumn<string>(
                name: "lng",
                table: "CityCoordinates",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "lat",
                table: "CityCoordinates",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "lng",
                table: "CityCoordinates",
                newName: "Lng");

            migrationBuilder.RenameColumn(
                name: "lat",
                table: "CityCoordinates",
                newName: "Lat");

            migrationBuilder.AlterColumn<double>(
                name: "Lng",
                table: "CityCoordinates",
                type: "float",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Lat",
                table: "CityCoordinates",
                type: "float",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
