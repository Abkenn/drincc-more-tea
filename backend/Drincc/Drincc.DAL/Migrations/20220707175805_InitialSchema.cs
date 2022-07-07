using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Drincc.DAL.Migrations
{
    public partial class InitialSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Teas",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    VendorName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    BrandName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    PricePerGramInUSD = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ShippingPricePerGramInUSD = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AddedTaxesPerUSD = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CurrencyBought = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    UsdТоTwd = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    UsdТоJpy = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    UsdТоGbp = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    UsdТоEur = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    UsdТоCny = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    UsdТоBgn = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TwdТоJpy = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TwdТоGbp = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TwdТоEur = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TwdТоCny = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TwdТоBgn = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    JpyТоGbp = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    JpyТоEur = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    JpyТоCny = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    JpyТоBgn = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    GbpТоEur = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    GbpТоCny = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    GbpТоBgn = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    EurТоCny = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    EurТоBgn = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CnyТоBgn = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SessionNotes",
                columns: table => new
                {
                    TeaId = table.Column<long>(type: "bigint", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Note = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SessionNotes", x => new { x.TeaId, x.Id });
                    table.ForeignKey(
                        name: "FK_SessionNotes_Teas_TeaId",
                        column: x => x.TeaId,
                        principalTable: "Teas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SessionNotes");

            migrationBuilder.DropTable(
                name: "Teas");
        }
    }
}
