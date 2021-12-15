using Microsoft.EntityFrameworkCore.Migrations;

namespace PhamDuyQuang785.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CompanyPDQ785",
                columns: table => new
                {
                    CompanyID = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    CompanyName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyPDQ785", x => x.CompanyID);
                });

            migrationBuilder.CreateTable(
                name: "PDQ0785",
                columns: table => new
                {
                    PDQid = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    PDQName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    PDQgender = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PDQ0785", x => x.PDQid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompanyPDQ785");

            migrationBuilder.DropTable(
                name: "PDQ0785");
        }
    }
}
