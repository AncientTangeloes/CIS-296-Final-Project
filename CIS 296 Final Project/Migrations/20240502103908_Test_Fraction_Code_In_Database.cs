using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CIS_296_Final_Project.Migrations
{
    /// <inheritdoc />
    public partial class Test_Fraction_Code_In_Database : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "CharacterId", "Name", "OgTypeId", "Origin", "Year" },
                values: new object[,]
                {
                    { 28, "President's Aide", "F", "Sonic the Hedgehog: The Movie", 1996 },
                    { 29, "President Michael K.", "A", "ソニックＸ S1E4: Chaos Emerald Chaos", 2003 },
                    { 30, "Sir Dr. Charles the Hedgehog", "C", "Sonic the Hedgehog #0", 1992 },
                    { 31, "Caterkiller", "C", "Sonic the Hedgehog #<sup>1</sup>&frasl;<sub>4</sub>", 1992 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 31);
        }
    }
}
