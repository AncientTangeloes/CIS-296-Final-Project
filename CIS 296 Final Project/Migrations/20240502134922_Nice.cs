using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CIS_296_Final_Project.Migrations
{
    /// <inheritdoc />
    public partial class Nice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "CharacterId", "Name", "OgTypeId", "Origin", "Year" },
                values: new object[,]
                {
                    { 52, "Fang the Sniper", "G", "Sonic the Hedgehog: Triple Trouble", 1994 },
                    { 53, "Mighty the Armadillo", "G", "SegaSonic the Hedgehog", 1993 },
                    { 54, "Ray the Flying Squirrel", "G", "SegaSonic the Hedgehog", 1993 },
                    { 55, "Cream the Rabbit", "G", "Sonic Advance 2", 2002 },
                    { 56, "Cheese", "G", "Sonic Advance 2", 2002 },
                    { 57, "Vanilla the Rabbit", "G", "Sonic Advance 2", 2002 },
                    { 58, "Tikal", "G", "Sonic Adventure", 1998 },
                    { 59, "Omochao", "G", "Sonic Adventure", 1998 },
                    { 60, "Emerl", "C", "Sonic the Hedgehog #271", 2015 },
                    { 61, "Chocola", "G", "Sonic Heroes", 2003 },
                    { 62, "Neo Metal Sonic", "G", "Sonic Heroes", 2003 },
                    { 63, "Maximillian Acorn", "C", "Sonic the Hedgehog #17", 1994 },
                    { 64, "Lady Alicia Acorn", "C", "Sonic Super Special #2", 1997 },
                    { 65, "King Elias Acorn of Mobius", "C", "Knuckles the Echidna #19", 1998 },
                    { 66, "Megan \"Meg\" Acorn", "C", "Sonic the Hedgehog #121", 2003 },
                    { 67, "Alexis Acorn", "C", "Sonic the Hedgehog #121", 2003 },
                    { 68, "Joss", "C", "Sonic the Hedgehog #121", 2003 },
                    { 69, "Horizont-Al", "C", "Sonic the Hedgehog #2", 1992 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 69);
        }
    }
}
