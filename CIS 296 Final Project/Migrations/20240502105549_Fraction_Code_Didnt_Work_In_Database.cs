using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CIS_296_Final_Project.Migrations
{
    /// <inheritdoc />
    public partial class Fraction_Code_Didnt_Work_In_Database : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 31,
                column: "Origin",
                value: "Sonic the Hedgehog #1/4");

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "CharacterId", "Name", "OgTypeId", "Origin", "Year" },
                values: new object[,]
                {
                    { 32, "Rotor Walrus", "C", "Sonic the Hedgehog #1/4", 1992 },
                    { 33, "Princess Sally Alicia Acorn", "C", "Sonic the Hedgehog #1/4", 1992 },
                    { 34, "Blaze the Cat", "G", "Sonic Rush", 2005 },
                    { 35, "Eggman Nega", "G", "Sonic Rush", 2005 },
                    { 36, "Sticks the Badger", "S", "Sonic Boom", 2014 },
                    { 37, "Princess Elise III", "G", "Sonic the Hedgehog (2006)", 2006 },
                    { 38, "Duke of Soleanna", "G", "Sonic the Hedgehog (2006)", 2006 },
                    { 39, "Duchess of Soleanna", "G", "Sonic the Hedgehog (2006)", 2006 },
                    { 40, "Iblis", "G", "Sonic the Hedgehog (2006)", 2006 },
                    { 41, "Mephiles the Dark", "G", "Sonic the Hedgehog (2006)", 2006 },
                    { 42, "Lord Regis", "G", "Sonic the Hedgehog (2006)", 2006 },
                    { 43, "Alberto Robert", "G", "Sonic the Hedgehog (2006)", 2006 },
                    { 44, "Alfano", "G", "Sonic the Hedgehog (2006)", 2006 },
                    { 45, "Albert Einstein", "G", "Sonic the Hedgehog (2006)", 2006 },
                    { 46, "Solaris the Sun God", "G", "Sonic the Hedgehog (2006)", 2006 },
                    { 47, "Aristo", "G", "Sonic the Hedgehog (2006)", 2006 },
                    { 48, "Aristotle", "G", "Sonic the Hedgehog (2006)", 2006 },
                    { 49, "Antoine D'Coolette", "C", "Sonic the Hedgehog #1/4", 1992 },
                    { 50, "Bunnie D'Coolette", "C", "Sonic the Hedgehog #1 (miniseries)", 1993 },
                    { 51, "Wang the Impending", "G", "Sonic Unleashed", 2008 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 51);

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 31,
                column: "Origin",
                value: "Sonic the Hedgehog #<sup>1</sup>&frasl;<sub>4</sub>");
        }
    }
}
