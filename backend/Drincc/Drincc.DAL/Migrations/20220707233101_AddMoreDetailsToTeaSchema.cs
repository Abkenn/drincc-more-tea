using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Drincc.DAL.Migrations
{
    public partial class AddMoreDetailsToTeaSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Cultivar",
                table: "Teas",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MyRating",
                table: "Teas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfReviews",
                table: "Teas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Oxidation",
                table: "Teas",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PlaceOfOrigin",
                table: "Teas",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "QuantityInGrams",
                table: "Teas",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<string>(
                name: "Rating",
                table: "Teas",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Roast",
                table: "Teas",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "SessionNotes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cultivar",
                table: "Teas");

            migrationBuilder.DropColumn(
                name: "MyRating",
                table: "Teas");

            migrationBuilder.DropColumn(
                name: "NumberOfReviews",
                table: "Teas");

            migrationBuilder.DropColumn(
                name: "Oxidation",
                table: "Teas");

            migrationBuilder.DropColumn(
                name: "PlaceOfOrigin",
                table: "Teas");

            migrationBuilder.DropColumn(
                name: "QuantityInGrams",
                table: "Teas");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Teas");

            migrationBuilder.DropColumn(
                name: "Roast",
                table: "Teas");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "SessionNotes");
        }
    }
}
