using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlacenameData.Migrations
{
    public partial class Classes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PlacenameCoordinates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OsSheet = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OsGrid10 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OsGbEast = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OsGbNorth = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Easting = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Northing = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Longitude = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Latitude = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlacenameCoordinates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PlacenameNotes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VariationId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlacenameNotes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PlacenameVariations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VariationSpelling = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VariationSource = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VariationSourceDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VariationComments = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlacenameVariations", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlacenameCoordinates");

            migrationBuilder.DropTable(
                name: "PlacenameNotes");

            migrationBuilder.DropTable(
                name: "PlacenameVariations");
        }
    }
}
