using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Agile_Project_Management_Portal.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Defects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", maxLength: 10, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DefectDetails = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    StepsToReproduce = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    Priority = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    DetectedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpectedResolution = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReportedBTesterId = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    AssignedToDeveloperId = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    Severity = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Status = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ProjectCode = table.Column<int>(type: "int", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Defects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Resolutions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", maxLength: 10, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DefectId = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    ResolutionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Resolutionss = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resolutions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Resolutions_Defects_DefectId",
                        column: x => x.DefectId,
                        principalTable: "Defects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Resolutions_DefectId",
                table: "Resolutions",
                column: "DefectId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Resolutions");

            migrationBuilder.DropTable(
                name: "Defects");
        }
    }
}
