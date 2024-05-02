using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CIS_296_Final_Project.Migrations
{
    /// <inheritdoc />
    public partial class Fixed_Characters : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 22,
                column: "OgTypeId",
                value: "F");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 23,
                column: "OgTypeId",
                value: "F");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 24,
                column: "OgTypeId",
                value: "F");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 25,
                column: "OgTypeId",
                value: "F");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 26,
                column: "OgTypeId",
                value: "F");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 22,
                column: "OgTypeId",
                value: "M");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 23,
                column: "OgTypeId",
                value: "M");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 24,
                column: "OgTypeId",
                value: "M");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 25,
                column: "OgTypeId",
                value: "M");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 26,
                column: "OgTypeId",
                value: "M");
        }
    }
}
