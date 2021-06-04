using Microsoft.EntityFrameworkCore.Migrations;

namespace ModaSystemDados.Migrations
{
    public partial class Migration08 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AcertoDespId1",
                schema: "modacore",
                table: "AcertoDespesas",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CodDespesa",
                schema: "modacore",
                table: "AcertoDespesas",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_AcertoDespesas_AcertoDespId1",
                schema: "modacore",
                table: "AcertoDespesas",
                column: "AcertoDespId1");

            migrationBuilder.AddForeignKey(
                name: "FK_AcertoDespesas_AcertoDespesas_AcertoDespId1",
                schema: "modacore",
                table: "AcertoDespesas",
                column: "AcertoDespId1",
                principalSchema: "modacore",
                principalTable: "AcertoDespesas",
                principalColumn: "AcertoDespId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AcertoDespesas_AcertoDespesas_AcertoDespId1",
                schema: "modacore",
                table: "AcertoDespesas");

            migrationBuilder.DropIndex(
                name: "IX_AcertoDespesas_AcertoDespId1",
                schema: "modacore",
                table: "AcertoDespesas");

            migrationBuilder.DropColumn(
                name: "AcertoDespId1",
                schema: "modacore",
                table: "AcertoDespesas");

            migrationBuilder.DropColumn(
                name: "CodDespesa",
                schema: "modacore",
                table: "AcertoDespesas");
        }
    }
}
