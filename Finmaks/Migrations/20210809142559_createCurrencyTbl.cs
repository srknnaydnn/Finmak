using Microsoft.EntityFrameworkCore.Migrations;

namespace Finmaks.Migrations
{
    public partial class createCurrencyTbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Currencies",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Unit = table.Column<string>(nullable: true),
                    Isim = table.Column<string>(nullable: true),
                    CurrencyName = table.Column<string>(nullable: true),
                    ForexBuying = table.Column<string>(nullable: true),
                    ForexSelling = table.Column<string>(nullable: true),
                    BanknoteBuying = table.Column<string>(nullable: true),
                    BanknoteSelling = table.Column<string>(nullable: true),
                    CrossRateUSD = table.Column<string>(nullable: true),
                    CrossRateOther = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currencies", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Currencies");
        }
    }
}
