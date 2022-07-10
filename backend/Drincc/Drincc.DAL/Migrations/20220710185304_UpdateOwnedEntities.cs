using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Drincc.DAL.Migrations
{
    public partial class UpdateOwnedEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PriceDetails");

            migrationBuilder.AddColumn<decimal>(
                name: "AddedTaxesPerUSD",
                table: "Teas",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "CnyТоBgn",
                table: "Teas",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CurrencyBought",
                table: "Teas",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "EurТоBgn",
                table: "Teas",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "EurТоCny",
                table: "Teas",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "GbpТоBgn",
                table: "Teas",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "GbpТоCny",
                table: "Teas",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "GbpТоEur",
                table: "Teas",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "JpyТоBgn",
                table: "Teas",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "JpyТоCny",
                table: "Teas",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "JpyТоEur",
                table: "Teas",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "JpyТоGbp",
                table: "Teas",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "PricePerGramInUSD",
                table: "Teas",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "ShippingPricePerGramInUSD",
                table: "Teas",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TwdТоBgn",
                table: "Teas",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TwdТоCny",
                table: "Teas",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TwdТоEur",
                table: "Teas",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TwdТоGbp",
                table: "Teas",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TwdТоJpy",
                table: "Teas",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "UsdТоBgn",
                table: "Teas",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "UsdТоCny",
                table: "Teas",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "UsdТоEur",
                table: "Teas",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "UsdТоGbp",
                table: "Teas",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "UsdТоJpy",
                table: "Teas",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "UsdТоTwd",
                table: "Teas",
                type: "decimal(18,2)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddedTaxesPerUSD",
                table: "Teas");

            migrationBuilder.DropColumn(
                name: "CnyТоBgn",
                table: "Teas");

            migrationBuilder.DropColumn(
                name: "CurrencyBought",
                table: "Teas");

            migrationBuilder.DropColumn(
                name: "EurТоBgn",
                table: "Teas");

            migrationBuilder.DropColumn(
                name: "EurТоCny",
                table: "Teas");

            migrationBuilder.DropColumn(
                name: "GbpТоBgn",
                table: "Teas");

            migrationBuilder.DropColumn(
                name: "GbpТоCny",
                table: "Teas");

            migrationBuilder.DropColumn(
                name: "GbpТоEur",
                table: "Teas");

            migrationBuilder.DropColumn(
                name: "JpyТоBgn",
                table: "Teas");

            migrationBuilder.DropColumn(
                name: "JpyТоCny",
                table: "Teas");

            migrationBuilder.DropColumn(
                name: "JpyТоEur",
                table: "Teas");

            migrationBuilder.DropColumn(
                name: "JpyТоGbp",
                table: "Teas");

            migrationBuilder.DropColumn(
                name: "PricePerGramInUSD",
                table: "Teas");

            migrationBuilder.DropColumn(
                name: "ShippingPricePerGramInUSD",
                table: "Teas");

            migrationBuilder.DropColumn(
                name: "TwdТоBgn",
                table: "Teas");

            migrationBuilder.DropColumn(
                name: "TwdТоCny",
                table: "Teas");

            migrationBuilder.DropColumn(
                name: "TwdТоEur",
                table: "Teas");

            migrationBuilder.DropColumn(
                name: "TwdТоGbp",
                table: "Teas");

            migrationBuilder.DropColumn(
                name: "TwdТоJpy",
                table: "Teas");

            migrationBuilder.DropColumn(
                name: "UsdТоBgn",
                table: "Teas");

            migrationBuilder.DropColumn(
                name: "UsdТоCny",
                table: "Teas");

            migrationBuilder.DropColumn(
                name: "UsdТоEur",
                table: "Teas");

            migrationBuilder.DropColumn(
                name: "UsdТоGbp",
                table: "Teas");

            migrationBuilder.DropColumn(
                name: "UsdТоJpy",
                table: "Teas");

            migrationBuilder.DropColumn(
                name: "UsdТоTwd",
                table: "Teas");

            migrationBuilder.CreateTable(
                name: "PriceDetails",
                columns: table => new
                {
                    TeaId = table.Column<long>(type: "bigint", nullable: false),
                    AddedTaxesPerUSD = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CnyТоBgn = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CurrencyBought = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    EurТоBgn = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EurТоCny = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GbpТоBgn = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GbpТоCny = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GbpТоEur = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    JpyТоBgn = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    JpyТоCny = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    JpyТоEur = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    JpyТоGbp = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PricePerGramInUSD = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ShippingPricePerGramInUSD = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TwdТоBgn = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TwdТоCny = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TwdТоEur = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TwdТоGbp = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TwdТоJpy = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UsdТоBgn = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UsdТоCny = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UsdТоEur = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UsdТоGbp = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UsdТоJpy = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UsdТоTwd = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PriceDetails", x => x.TeaId);
                    table.ForeignKey(
                        name: "FK_PriceDetails_Teas_TeaId",
                        column: x => x.TeaId,
                        principalTable: "Teas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }
    }
}
