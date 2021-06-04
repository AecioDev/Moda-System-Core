using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ModaSystemDados.Migrations
{
    public partial class Migration07 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AcertoMovResumo",
                schema: "modacore",
                columns: table => new
                {
                    AcertoMovId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    MovValTotEnt = table.Column<decimal>(nullable: false),
                    MovValTotNEnt = table.Column<decimal>(type: "money", nullable: false),
                    MovValTotRSal = table.Column<decimal>(type: "money", nullable: false),
                    MovValTotDev = table.Column<decimal>(type: "money", nullable: false),
                    AcertoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcertoMov", x => x.AcertoMovId);
                    table.ForeignKey(
                        name: "FK_AcertoMovResumo_Acerto_AcertoId",
                        column: x => x.AcertoId,
                        principalSchema: "modacore",
                        principalTable: "Acerto",
                        principalColumn: "AcertoId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AcertoMovResumo_AcertoId",
                schema: "modacore",
                table: "AcertoMovResumo",
                column: "AcertoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IDX_Acerto_AceMov",
                schema: "modacore",
                table: "AcertoMovResumo",
                columns: new[] { "AcertoId", "AcertoMovId" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AcertoMovResumo",
                schema: "modacore");
        }
    }
}
