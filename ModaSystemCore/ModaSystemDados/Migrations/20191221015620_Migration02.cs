using Microsoft.EntityFrameworkCore.Migrations;

namespace ModaSystemDados.Migrations
{
    public partial class Migration02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Paises_Cidades_CidadeCodPais",
                schema: "modacore",
                table: "Paises");

            migrationBuilder.DropIndex(
                name: "IX_Paises_CidadeCodPais",
                schema: "modacore",
                table: "Paises");

            migrationBuilder.DropColumn(
                name: "CidadeCodPais",
                schema: "modacore",
                table: "Paises");

            migrationBuilder.CreateIndex(
                name: "IX_Cidades_CidadeCodPais",
                schema: "modacore",
                table: "Cidades",
                column: "CidadeCodPais");

            migrationBuilder.AddForeignKey(
                name: "FK_Cidades_Paises_CidadeCodPais",
                schema: "modacore",
                table: "Cidades",
                column: "CidadeCodPais",
                principalSchema: "modacore",
                principalTable: "Paises",
                principalColumn: "CodPaisBacen",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cidades_Paises_CidadeCodPais",
                schema: "modacore",
                table: "Cidades");

            migrationBuilder.DropIndex(
                name: "IX_Cidades_CidadeCodPais",
                schema: "modacore",
                table: "Cidades");

            migrationBuilder.AddColumn<int>(
                name: "CidadeCodPais",
                schema: "modacore",
                table: "Paises",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Paises_CidadeCodPais",
                schema: "modacore",
                table: "Paises",
                column: "CidadeCodPais");

            migrationBuilder.AddForeignKey(
                name: "FK_Paises_Cidades_CidadeCodPais",
                schema: "modacore",
                table: "Paises",
                column: "CidadeCodPais",
                principalSchema: "modacore",
                principalTable: "Cidades",
                principalColumn: "CidadeId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
