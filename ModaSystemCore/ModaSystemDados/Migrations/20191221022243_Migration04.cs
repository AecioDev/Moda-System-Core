using Microsoft.EntityFrameworkCore.Migrations;

namespace ModaSystemDados.Migrations
{
    public partial class Migration04 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cidades_Paises_CidadeCodPais",
                schema: "modacore",
                table: "Cidades");

            migrationBuilder.AddForeignKey(
                name: "FK_Cidades_Paises_CidadeCodPais",
                schema: "modacore",
                table: "Cidades",
                column: "CidadeCodPais",
                principalSchema: "modacore",
                principalTable: "Paises",
                principalColumn: "CodPaisBacen");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cidades_Paises_CidadeCodPais",
                schema: "modacore",
                table: "Cidades");

            migrationBuilder.AddForeignKey(
                name: "FK_Cidades_Paises_CidadeCodPais",
                schema: "modacore",
                table: "Cidades",
                column: "CidadeCodPais",
                principalSchema: "modacore",
                principalTable: "Paises",
                principalColumn: "CodPaisBacen",
                onDelete: ReferentialAction.SetNull);
        }
    }
}
