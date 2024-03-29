﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ModaSystemDados.Contexto;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ModaSystemDados.Migrations
{
    [DbContext(typeof(PSqlContext))]
    [Migration("20200122020517_Migration08")]
    partial class Migration08
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("modacore")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("ModaSystemDomain.Entidades.Acerto", b =>
                {
                    b.Property<int>("AcertoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("AcertoId")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

                    b.Property<int>("AcertoAno")
                        .HasColumnName("AcertoAno")
                        .HasColumnType("integer");

                    b.Property<DateTime>("AcertoData")
                        .HasColumnName("AcertoData")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("AcertoMes")
                        .HasColumnName("AcertoMes")
                        .HasColumnType("integer");

                    b.Property<string>("AcertoObs")
                        .HasColumnName("AcertoObs")
                        .HasColumnType("character varying(1000)")
                        .HasMaxLength(1000);

                    b.Property<int>("AcertoSocio")
                        .HasColumnName("AcertoSocio")
                        .HasColumnType("integer");

                    b.Property<int>("AcertoVeiculo")
                        .HasColumnName("AcertoVeiculo")
                        .HasColumnType("integer");

                    b.Property<decimal>("PercPagEmpresa")
                        .HasColumnName("PercPagEmpresa")
                        .HasColumnType("money");

                    b.Property<decimal>("PercPagSocio")
                        .HasColumnName("PercPagSocio")
                        .HasColumnType("money");

                    b.Property<decimal>("QntMercEntregue")
                        .HasColumnName("QntMercEntregue")
                        .HasColumnType("money");

                    b.Property<decimal>("QntTotFichas")
                        .HasColumnName("QntTotFichas")
                        .HasColumnType("money");

                    b.Property<decimal>("ValPagEmpresa")
                        .HasColumnName("ValPagEmpresa")
                        .HasColumnType("money");

                    b.Property<decimal>("ValPagSocio")
                        .HasColumnName("ValPagSocio")
                        .HasColumnType("money");

                    b.Property<decimal>("ValSaldoFinal")
                        .HasColumnName("ValSaldoFinal")
                        .HasColumnType("money");

                    b.Property<decimal>("ValTotDespesas")
                        .HasColumnName("ValTotDespesas")
                        .HasColumnType("money");

                    b.Property<decimal>("ValTotDevolvidas")
                        .HasColumnName("ValTotDevolvidas")
                        .HasColumnType("money");

                    b.Property<decimal>("ValTotEntregue")
                        .HasColumnName("ValTotEntregue")
                        .HasColumnType("money");

                    b.Property<decimal>("ValTotFichas")
                        .HasColumnName("ValTotFichas")
                        .HasColumnType("money");

                    b.Property<decimal>("ValTotReceitas")
                        .HasColumnName("ValTotReceitas")
                        .HasColumnType("money");

                    b.Property<decimal>("ValTotVendidas")
                        .HasColumnName("ValTotVendidas")
                        .HasColumnType("money");

                    b.HasKey("AcertoId")
                        .HasName("PK_Acertos");

                    b.HasIndex("AcertoSocio");

                    b.HasIndex("AcertoVeiculo");

                    b.ToTable("Acerto");
                });

            modelBuilder.Entity("ModaSystemDomain.Entidades.AcertoDespesas", b =>
                {
                    b.Property<int>("AcertoDespId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("AcertoDespId")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

                    b.Property<int>("AcertoDespId1")
                        .HasColumnType("integer");

                    b.Property<int>("AcertoId")
                        .HasColumnName("AcertoId")
                        .HasColumnType("integer");

                    b.Property<decimal>("AcertoValDesp")
                        .HasColumnName("AcertoValDesp")
                        .HasColumnType("money");

                    b.Property<int>("CodDespesa")
                        .HasColumnType("integer");

                    b.HasKey("AcertoDespId")
                        .HasName("PK_AcertoDespesas");

                    b.HasIndex("AcertoDespId1");

                    b.HasIndex("AcertoId", "AcertoDespId")
                        .IsUnique()
                        .HasName("IDX_Acerto_AceDesp");

                    b.ToTable("AcertoDespesas");
                });

            modelBuilder.Entity("ModaSystemDomain.Entidades.AcertoMovResumo", b =>
                {
                    b.Property<int>("AcertoMovId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("AcertoMovId")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

                    b.Property<int>("AcertoId")
                        .HasColumnName("AcertoId")
                        .HasColumnType("integer");

                    b.Property<decimal>("MovValTotDev")
                        .HasColumnName("MovValTotDev")
                        .HasColumnType("money");

                    b.Property<decimal>("MovValTotEnt")
                        .HasColumnType("numeric");

                    b.Property<decimal>("MovValTotNEnt")
                        .HasColumnName("MovValTotNEnt")
                        .HasColumnType("money");

                    b.Property<decimal>("MovValTotRSal")
                        .HasColumnName("MovValTotRSal")
                        .HasColumnType("money");

                    b.HasKey("AcertoMovId")
                        .HasName("PK_AcertoMov");

                    b.HasIndex("AcertoId")
                        .IsUnique();

                    b.HasIndex("AcertoId", "AcertoMovId")
                        .IsUnique()
                        .HasName("IDX_Acerto_AceMov");

                    b.ToTable("AcertoMovResumo");
                });

            modelBuilder.Entity("ModaSystemDomain.Entidades.Cidade", b =>
                {
                    b.Property<int>("CidadeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("CidadeId")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

                    b.Property<int>("CidadeCodPais")
                        .HasColumnName("CidadeCodPais")
                        .HasColumnType("integer");

                    b.Property<string>("CidadeEstado")
                        .HasColumnName("CidadeEstado")
                        .HasColumnType("character varying(50)")
                        .HasMaxLength(50);

                    b.Property<int>("CidadeIBGE")
                        .HasColumnName("CidadeIBGE")
                        .HasColumnType("integer");

                    b.Property<string>("CidadeNome")
                        .HasColumnName("CidadeNome")
                        .HasColumnType("character varying(100)")
                        .HasMaxLength(100);

                    b.HasKey("CidadeId")
                        .HasName("PK_Cidades");

                    b.HasIndex("CidadeCodPais");

                    b.ToTable("Cidades");
                });

            modelBuilder.Entity("ModaSystemDomain.Entidades.Pais", b =>
                {
                    b.Property<int>("CodPaisBacen")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("CodPaisBacen")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

                    b.Property<string>("NomePaisBacen")
                        .HasColumnName("NomePaisBacen")
                        .HasColumnType("character varying(40)")
                        .HasMaxLength(40);

                    b.HasKey("CodPaisBacen")
                        .HasName("PK_CodPais");

                    b.ToTable("Paises");
                });

            modelBuilder.Entity("ModaSystemDomain.Entidades.Socios", b =>
                {
                    b.Property<int>("SocioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("SocioId")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

                    b.Property<string>("SocioCell")
                        .HasColumnName("SocioCell")
                        .HasColumnType("character varying(15)")
                        .HasMaxLength(15);

                    b.Property<string>("SocioNome")
                        .HasColumnName("SocioNome")
                        .HasColumnType("character varying(100)")
                        .HasMaxLength(100);

                    b.Property<decimal>("SocioPerCom")
                        .HasColumnName("SocioPerCom")
                        .HasColumnType("money");

                    b.Property<int>("SocioVeiculo")
                        .HasColumnName("SocioVeiculo")
                        .HasColumnType("integer");

                    b.Property<decimal>("TotComReceb")
                        .HasColumnType("numeric");

                    b.HasKey("SocioId")
                        .HasName("PK_Socios");

                    b.HasIndex("SocioVeiculo");

                    b.ToTable("Socios");
                });

            modelBuilder.Entity("ModaSystemDomain.Entidades.Terceiro", b =>
                {
                    b.Property<int>("TerceiroId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("TerceiroId")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

                    b.Property<string>("TerceiroBairro")
                        .HasColumnName("TerceiroBairro")
                        .HasColumnType("character varying(100)")
                        .HasMaxLength(100);

                    b.Property<string>("TerceiroCep")
                        .HasColumnName("TerceiroCep")
                        .HasColumnType("character varying(8)")
                        .HasMaxLength(8);

                    b.Property<int>("TerceiroCidade")
                        .HasColumnName("TerceiroCidade")
                        .HasColumnType("integer");

                    b.Property<string>("TerceiroComp")
                        .HasColumnName("TerceiroComp")
                        .HasColumnType("character varying(100)")
                        .HasMaxLength(100);

                    b.Property<string>("TerceiroEmail")
                        .HasColumnName("TerceiroEmail")
                        .HasColumnType("character varying(100)")
                        .HasMaxLength(100);

                    b.Property<string>("TerceiroNome")
                        .HasColumnName("TerceiroNome")
                        .HasColumnType("character varying(100)")
                        .HasMaxLength(100);

                    b.Property<string>("TerceiroNum")
                        .HasColumnName("TerceiroNum")
                        .HasColumnType("character varying(10)")
                        .HasMaxLength(10);

                    b.Property<string>("TerceiroRua")
                        .HasColumnName("TerceiroRua")
                        .HasColumnType("character varying(100)")
                        .HasMaxLength(100);

                    b.Property<string>("TerceiroTel")
                        .HasColumnName("TerceiroTel")
                        .HasColumnType("character varying(15)")
                        .HasMaxLength(15);

                    b.Property<string>("TerceiroTipo")
                        .HasColumnName("TerceiroTipo")
                        .HasColumnType("char")
                        .HasMaxLength(1);

                    b.HasKey("TerceiroId")
                        .HasName("PK_Terceiros");

                    b.HasIndex("TerceiroCidade");

                    b.ToTable("Terceiros");
                });

            modelBuilder.Entity("ModaSystemDomain.Entidades.Veiculo", b =>
                {
                    b.Property<int>("VeiculoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("VeiculoId")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

                    b.Property<int>("VeiculoAno")
                        .HasColumnName("VeiculoAno")
                        .HasColumnType("integer");

                    b.Property<string>("VeiculoDesc")
                        .HasColumnName("VeiculoDesc")
                        .HasColumnType("character varying(100)")
                        .HasMaxLength(100);

                    b.Property<int>("VeiculoMarca")
                        .HasColumnName("VeiculoMarca")
                        .HasColumnType("integer");

                    b.Property<string>("VeiculoModelo")
                        .HasColumnName("VeiculoModelo")
                        .HasColumnType("character varying(100)")
                        .HasMaxLength(100);

                    b.Property<string>("VeiculoObs")
                        .HasColumnName("VeiculoObs")
                        .HasColumnType("character varying(1000)")
                        .HasMaxLength(1000);

                    b.Property<string>("VeiculoStatus")
                        .HasColumnName("VeiculoStatus")
                        .HasColumnType("char")
                        .HasMaxLength(1);

                    b.HasKey("VeiculoId")
                        .HasName("PK_Veiculos");

                    b.ToTable("Veiculos");
                });

            modelBuilder.Entity("ModaSystemDomain.Entidades.Acerto", b =>
                {
                    b.HasOne("ModaSystemDomain.Entidades.Socios", "Socios")
                        .WithMany("Acerto")
                        .HasForeignKey("AcertoSocio")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("ModaSystemDomain.Entidades.Veiculo", "Veiculo")
                        .WithMany("Acerto")
                        .HasForeignKey("AcertoVeiculo")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("ModaSystemDomain.Entidades.AcertoDespesas", b =>
                {
                    b.HasOne("ModaSystemDomain.Entidades.AcertoDespesas", "AcertoDesp")
                        .WithMany()
                        .HasForeignKey("AcertoDespId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ModaSystemDomain.Entidades.Acerto", "Acerto")
                        .WithMany("AcertoDespesas")
                        .HasForeignKey("AcertoId")
                        .HasConstraintName("FK_Acerto_Despesas")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("ModaSystemDomain.Entidades.AcertoMovResumo", b =>
                {
                    b.HasOne("ModaSystemDomain.Entidades.Acerto", "Acerto")
                        .WithOne("AcertoResumo")
                        .HasForeignKey("ModaSystemDomain.Entidades.AcertoMovResumo", "AcertoId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("ModaSystemDomain.Entidades.Cidade", b =>
                {
                    b.HasOne("ModaSystemDomain.Entidades.Pais", "Pais")
                        .WithMany("Cidades")
                        .HasForeignKey("CidadeCodPais")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("ModaSystemDomain.Entidades.Socios", b =>
                {
                    b.HasOne("ModaSystemDomain.Entidades.Veiculo", "Veiculo")
                        .WithMany("Socios")
                        .HasForeignKey("SocioVeiculo")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("ModaSystemDomain.Entidades.Terceiro", b =>
                {
                    b.HasOne("ModaSystemDomain.Entidades.Cidade", "Cidade")
                        .WithMany("Terceiro")
                        .HasForeignKey("TerceiroCidade")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
