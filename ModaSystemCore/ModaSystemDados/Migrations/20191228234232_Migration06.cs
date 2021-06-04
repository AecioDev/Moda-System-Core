using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ModaSystemDados.Migrations
{
    public partial class Migration06 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropPrimaryKey(
            //    name: "VeiculoId",
            //    schema: "modacore",
            //    table: "Veiculos");

            //migrationBuilder.DropPrimaryKey(
            //    name: "TerceiroId",
            //    schema: "modacore",
            //    table: "Terceiros");

            //migrationBuilder.DropPrimaryKey(
            //    name: "SocioId",
            //    schema: "modacore",
            //    table: "Socios");

            //migrationBuilder.DropPrimaryKey(
            //    name: "CodPaisBacen",
            //    schema: "modacore",
            //    table: "Paises");

            //migrationBuilder.DropPrimaryKey(
            //    name: "CidadeId",
            //    schema: "modacore",
            //    table: "Cidades");

            //migrationBuilder.DropPrimaryKey(
            //    name: "AcertoId",
            //    schema: "modacore",
            //    table: "Acerto");

            //migrationBuilder.AddPrimaryKey(
            //    name: "PK_Veiculos",
            //    schema: "modacore",
            //    table: "Veiculos",
            //    column: "VeiculoId");

            //migrationBuilder.AddPrimaryKey(
            //    name: "PK_Terceiros",
            //    schema: "modacore",
            //    table: "Terceiros",
            //    column: "TerceiroId");

            //migrationBuilder.AddPrimaryKey(
            //    name: "PK_Socios",
            //    schema: "modacore",
            //    table: "Socios",
            //    column: "SocioId");

            //migrationBuilder.AddPrimaryKey(
            //    name: "PK_CodPais",
            //    schema: "modacore",
            //    table: "Paises",
            //    column: "CodPaisBacen");

            //migrationBuilder.AddPrimaryKey(
            //    name: "PK_Cidades",
            //    schema: "modacore",
            //    table: "Cidades",
            //    column: "CidadeId");

            //migrationBuilder.AddPrimaryKey(
            //    name: "PK_Acertos",
            //    schema: "modacore",
            //    table: "Acerto",
            //    column: "AcertoId");

            migrationBuilder.CreateTable(
                name: "AcertoDespesas",
                schema: "modacore",
                columns: table => new
                {
                    AcertoDespId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    AcertoId = table.Column<int>(nullable: false),
                    AcertoValDesp = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcertoDespesas", x => x.AcertoDespId);
                    table.ForeignKey(
                        name: "FK_Acerto_Despesas",
                        column: x => x.AcertoId,
                        principalSchema: "modacore",
                        principalTable: "Acerto",
                        principalColumn: "AcertoId");
                });

            migrationBuilder.CreateIndex(
                name: "IDX_Acerto_AceDesp",
                schema: "modacore",
                table: "AcertoDespesas",
                columns: new[] { "AcertoId", "AcertoDespId" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AcertoDespesas",
                schema: "modacore");

            //migrationBuilder.DropPrimaryKey(
            //    name: "PK_Veiculos",
            //    schema: "modacore",
            //    table: "Veiculos");

            //migrationBuilder.DropPrimaryKey(
            //    name: "PK_Terceiros",
            //    schema: "modacore",
            //    table: "Terceiros");

            //migrationBuilder.DropPrimaryKey(
            //    name: "PK_Socios",
            //    schema: "modacore",
            //    table: "Socios");

            //migrationBuilder.DropPrimaryKey(
            //    name: "PK_CodPais",
            //    schema: "modacore",
            //    table: "Paises");

            //migrationBuilder.DropPrimaryKey(
            //    name: "PK_Cidades",
            //    schema: "modacore",
            //    table: "Cidades");

            //migrationBuilder.DropPrimaryKey(
            //    name: "PK_Acertos",
            //    schema: "modacore",
            //    table: "Acerto");

            //migrationBuilder.AddPrimaryKey(
            //    name: "VeiculoId",
            //    schema: "modacore",
            //    table: "Veiculos",
            //    column: "VeiculoId");

            //migrationBuilder.AddPrimaryKey(
            //    name: "TerceiroId",
            //    schema: "modacore",
            //    table: "Terceiros",
            //    column: "TerceiroId");

            //migrationBuilder.AddPrimaryKey(
            //    name: "SocioId",
            //    schema: "modacore",
            //    table: "Socios",
            //    column: "SocioId");

            //migrationBuilder.AddPrimaryKey(
            //    name: "CodPaisBacen",
            //    schema: "modacore",
            //    table: "Paises",
            //    column: "CodPaisBacen");

            //migrationBuilder.AddPrimaryKey(
            //    name: "CidadeId",
            //    schema: "modacore",
            //    table: "Cidades",
            //    column: "CidadeId");

            //migrationBuilder.AddPrimaryKey(
            //    name: "AcertoId",
            //    schema: "modacore",
            //    table: "Acerto",
            //    column: "AcertoId");
        }
    }
}
