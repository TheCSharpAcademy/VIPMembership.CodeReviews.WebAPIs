using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CyclingAPI.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CyclingTrips",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    StartingLocation = table.Column<string>(type: "TEXT", nullable: false),
                    EndLocation = table.Column<string>(type: "TEXT", nullable: false),
                    Distance = table.Column<int>(type: "INTEGER", nullable: false),
                    Duration = table.Column<TimeSpan>(type: "TEXT", nullable: false),
                    AvarageSpeed = table.Column<double>(type: "REAL", nullable: false),
                    AltitudeMeters = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CyclingTrips", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CyclingTrips");
        }
    }
}
