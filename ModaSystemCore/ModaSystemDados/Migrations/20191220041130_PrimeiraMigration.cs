using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ModaSystemDados.Migrations
{
    public partial class PrimeiraMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "modacore");

            migrationBuilder.CreateTable(
                name: "Cidades",
                schema: "modacore",
                columns: table => new
                {
                    CidadeId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CidadeIBGE = table.Column<int>(nullable: false),
                    CidadeNome = table.Column<string>(maxLength: 100, nullable: true),
                    CidadeEstado = table.Column<string>(maxLength: 50, nullable: true),
                    CidadeCodPais = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CidadeId", x => x.CidadeId);
                });

            migrationBuilder.CreateTable(
                name: "Paises",
                schema: "modacore",
                columns: table => new
                {
                    CodPaisBacen = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NomePaisBacen = table.Column<string>(maxLength: 40, nullable: true),
                    CidadeCodPais = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CodPaisBacen", x => x.CodPaisBacen);
                    table.ForeignKey(
                        name: "FK_Paises_Cidades_CidadeCodPais",
                        column: x => x.CidadeCodPais,
                        principalSchema: "modacore",
                        principalTable: "Cidades",
                        principalColumn: "CidadeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Paises_CidadeCodPais",
                schema: "modacore",
                table: "Paises",
                column: "CidadeCodPais");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Paises",
                schema: "modacore");

            migrationBuilder.DropTable(
                name: "Cidades",
                schema: "modacore");
        }
    }
}
