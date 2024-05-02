using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CIS_296_Final_Project.Migrations
{
    /// <inheritdoc />
    public partial class InitialD : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OgTypes",
                columns: table => new
                {
                    OgTypeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OgTypes", x => x.OgTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    CharacterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Origin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OgTypeId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.CharacterId);
                    table.ForeignKey(
                        name: "FK_Characters_OgTypes_OgTypeId",
                        column: x => x.OgTypeId,
                        principalTable: "OgTypes",
                        principalColumn: "OgTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "OgTypes",
                columns: new[] { "OgTypeId", "Name" },
                values: new object[,]
                {
                    { "A", "Anime" },
                    { "C", "Comic" },
                    { "F", "Movie" },
                    { "G", "Game" },
                    { "M", "Manga" },
                    { "S", "Cartoon" }
                });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "CharacterId", "Name", "OgTypeId", "Origin", "Year" },
                values: new object[,]
                {
                    { 1, "Sonic the Hedgehog", "G", "Sonic the Hedgehog (1991)", 1991 },
                    { 2, "Miles \"Tails\" Prower", "G", "Sonic the Hedgehog 2", 1992 },
                    { 3, "Knuckles the Echidna", "G", "Sonic the Hedgehog 3", 1993 },
                    { 4, "Amy Rose", "M", "ソニック·ザ·ヘッジホッグ", 1992 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Characters_OgTypeId",
                table: "Characters",
                column: "OgTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropTable(
                name: "OgTypes");
        }
    }
}
