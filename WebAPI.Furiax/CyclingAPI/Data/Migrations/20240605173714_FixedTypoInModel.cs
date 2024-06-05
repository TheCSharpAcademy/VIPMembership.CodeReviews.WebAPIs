using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CyclingAPI.Data.Migrations
{
    /// <inheritdoc />
    public partial class FixedTypoInModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AvarageSpeed",
                table: "CyclingTrips",
                newName: "AverageSpeed");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AverageSpeed",
                table: "CyclingTrips",
                newName: "AvarageSpeed");
        }
    }
}
