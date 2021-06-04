using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ModaSystemDados.Migrations
{
    public partial class Migration05 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Terceiros",
                schema: "modacore",
                columns: table => new
                {
                    TerceiroId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    TerceiroTipo = table.Column<string>(type: "char", maxLength: 1, nullable: true),
                    TerceiroNome = table.Column<string>(maxLength: 100, nullable: true),
                    TerceiroTel = table.Column<string>(maxLength: 15, nullable: true),
                    TerceiroEmail = table.Column<string>(maxLength: 100, nullable: true),
                    TerceiroCep = table.Column<string>(maxLength: 8, nullable: true),
                    TerceiroRua = table.Column<string>(maxLength: 100, nullable: true),
                    TerceiroNum = table.Column<string>(maxLength: 10, nullable: true),
                    TerceiroBairro = table.Column<string>(maxLength: 100, nullable: true),
                    TerceiroComp = table.Column<string>(maxLength: 100, nullable: true),
                    TerceiroCidade = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("TerceiroId", x => x.TerceiroId);
                    table.ForeignKey(
                        name: "FK_Terceiros_Cidades_TerceiroCidade",
                        column: x => x.TerceiroCidade,
                        principalSchema: "modacore",
                        principalTable: "Cidades",
                        principalColumn: "CidadeId");
                });

            migrationBuilder.CreateTable(
                name: "Veiculos",
                schema: "modacore",
                columns: table => new
                {
                    VeiculoId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    VeiculoDesc = table.Column<string>(maxLength: 100, nullable: true),
                    VeiculoMarca = table.Column<int>(nullable: false),
                    VeiculoModelo = table.Column<string>(maxLength: 100, nullable: true),
                    VeiculoAno = table.Column<int>(nullable: false),
                    VeiculoStatus = table.Column<string>(type: "char", maxLength: 1, nullable: true),
                    VeiculoObs = table.Column<string>(maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("VeiculoId", x => x.VeiculoId);
                });

            migrationBuilder.CreateTable(
                name: "Socios",
                schema: "modacore",
                columns: table => new
                {
                    SocioId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    SocioNome = table.Column<string>(maxLength: 100, nullable: true),
                    SocioCell = table.Column<string>(maxLength: 15, nullable: true),
                    SocioPerCom = table.Column<decimal>(type: "money", nullable: false),
                    TotComReceb = table.Column<decimal>(nullable: false),
                    SocioVeiculo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("SocioId", x => x.SocioId);
                    table.ForeignKey(
                        name: "FK_Socios_Veiculos_SocioVeiculo",
                        column: x => x.SocioVeiculo,
                        principalSchema: "modacore",
                        principalTable: "Veiculos",
                        principalColumn: "VeiculoId");
                });

            migrationBuilder.CreateTable(
                name: "Acerto",
                schema: "modacore",
                columns: table => new
                {
                    AcertoId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    AcertoSocio = table.Column<int>(nullable: false),
                    AcertoVeiculo = table.Column<int>(nullable: false),
                    AcertoMes = table.Column<int>(nullable: false),
                    AcertoAno = table.Column<int>(nullable: false),
                    AcertoData = table.Column<DateTime>(nullable: false),
                    AcertoObs = table.Column<string>(maxLength: 1000, nullable: true),
                    QntMercEntregue = table.Column<decimal>(type: "money", nullable: false),
                    ValTotEntregue = table.Column<decimal>(type: "money", nullable: false),
                    ValTotDevolvidas = table.Column<decimal>(type: "money", nullable: false),
                    ValTotVendidas = table.Column<decimal>(type: "money", nullable: false),
                    QntTotFichas = table.Column<decimal>(type: "money", nullable: false),
                    ValTotFichas = table.Column<decimal>(type: "money", nullable: false),
                    ValTotReceitas = table.Column<decimal>(type: "money", nullable: false),
                    ValTotDespesas = table.Column<decimal>(type: "money", nullable: false),
                    ValSaldoFinal = table.Column<decimal>(type: "money", nullable: false),
                    PercPagSocio = table.Column<decimal>(type: "money", nullable: false),
                    ValPagSocio = table.Column<decimal>(type: "money", nullable: false),
                    PercPagEmpresa = table.Column<decimal>(type: "money", nullable: false),
                    ValPagEmpresa = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("AcertoId", x => x.AcertoId);
                    table.ForeignKey(
                        name: "FK_Acerto_Socios_AcertoSocio",
                        column: x => x.AcertoSocio,
                        principalSchema: "modacore",
                        principalTable: "Socios",
                        principalColumn: "SocioId");
                    table.ForeignKey(
                        name: "FK_Acerto_Veiculos_AcertoVeiculo",
                        column: x => x.AcertoVeiculo,
                        principalSchema: "modacore",
                        principalTable: "Veiculos",
                        principalColumn: "VeiculoId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Acerto_AcertoSocio",
                schema: "modacore",
                table: "Acerto",
                column: "AcertoSocio");

            migrationBuilder.CreateIndex(
                name: "IX_Acerto_AcertoVeiculo",
                schema: "modacore",
                table: "Acerto",
                column: "AcertoVeiculo");

            migrationBuilder.CreateIndex(
                name: "IX_Socios_SocioVeiculo",
                schema: "modacore",
                table: "Socios",
                column: "SocioVeiculo");

            migrationBuilder.CreateIndex(
                name: "IX_Terceiros_TerceiroCidade",
                schema: "modacore",
                table: "Terceiros",
                column: "TerceiroCidade");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Acerto",
                schema: "modacore");

            migrationBuilder.DropTable(
                name: "Terceiros",
                schema: "modacore");

            migrationBuilder.DropTable(
                name: "Socios",
                schema: "modacore");

            migrationBuilder.DropTable(
                name: "Veiculos",
                schema: "modacore");
        }
    }
}
