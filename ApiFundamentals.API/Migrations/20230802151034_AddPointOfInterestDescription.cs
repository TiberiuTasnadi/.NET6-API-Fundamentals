using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiFundamentals.API.Migrations
{
    /// <inheritdoc />
    public partial class AddPointOfInterestDescription : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "PointOfInterest",
                type: "TEXT",
                maxLength: 200,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "PointOfInterest");
        }
    }
}
