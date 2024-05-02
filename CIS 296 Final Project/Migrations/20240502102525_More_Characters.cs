using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CIS_296_Final_Project.Migrations
{
    /// <inheritdoc />
    public partial class More_Characters : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "CharacterId", "Name", "OgTypeId", "Origin", "Year" },
                values: new object[,]
                {
                    { 5, "Shadow the Hedgehog", "G", "Sonic Adventure 2", 2001 },
                    { 6, "Silver the Hedgehog", "G", "Sonic the Hedgehog (2006)", 2006 },
                    { 7, "Doctor Ivo \"Eggman\"Robotnik", "G", "Sonic the Hedgehog (1991)", 1991 },
                    { 8, "Charmy Bee", "M", "ソニック·ザ·ヘッジホッグ", 1992 },
                    { 9, "Vector the Crocodile", "C", "Sonic the Hedgehog Story Comic", 1991 },
                    { 10, "Espio the Chameleon", "G", "Knuckles Chaotix", 1995 },
                    { 11, "Big the Cat", "G", "Sonic Adventure", 1998 },
                    { 12, "Metal Sonic", "G", "Sonic the Hedgehog CD", 1993 },
                    { 13, "Froggy", "G", "Sonic Adventure", 1998 },
                    { 14, "Chaos", "G", "Sonic Adventure", 1998 },
                    { 15, "E-100 Alpha \"Zero\"", "G", "Sonic Adventure", 1998 },
                    { 16, "E-102 Gamma", "G", "Sonic Adventure", 1998 },
                    { 17, "E-123 Omega", "G", "Sonic Heroes", 2003 },
                    { 18, "Professor Gerald Robotnik", "G", "Sonic Adventure 2", 2001 },
                    { 19, "Maria Robotnik", "G", "Sonic Adventure 2", 2001 },
                    { 20, "Rouge the Bat", "G", "Sonic Adventure 2", 2001 },
                    { 21, "The President", "G", "Sonic Adventure 2", 2001 },
                    { 22, "Mr. President", "M", "Sonic the Hedgehog: The Movie", 1996 },
                    { 23, "Sara", "M", "Sonic the Hedgehog: The Movie", 1996 },
                    { 24, "Metal Robotnik", "M", "Sonic the Hedgehog: The Movie", 1996 },
                    { 25, "Old Man Owl", "M", "Sonic the Hedgehog: The Movie", 1996 },
                    { 26, "Hyper Metal Sonic", "M", "Sonic the Hedgehog: The Movie", 1996 },
                    { 27, "Shard \"Jack\"the Metal Sonic", "C", "Sonic the Hedgehog #25", 1995 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 27);
        }
    }
}
