using Microsoft.EntityFrameworkCore.Migrations;

namespace Model.Migrations
{
    public partial class Migration6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_GetStatiscticsSearches",
                table: "GetStatiscticsSearches");

            migrationBuilder.RenameTable(
                name: "GetStatiscticsSearches",
                newName: "StatiscticsSearches");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StatiscticsSearches",
                table: "StatiscticsSearches",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_StatiscticsSearches",
                table: "StatiscticsSearches");

            migrationBuilder.RenameTable(
                name: "StatiscticsSearches",
                newName: "GetStatiscticsSearches");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GetStatiscticsSearches",
                table: "GetStatiscticsSearches",
                column: "Id");
        }
    }
}
