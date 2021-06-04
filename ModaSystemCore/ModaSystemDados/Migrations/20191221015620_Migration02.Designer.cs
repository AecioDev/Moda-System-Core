﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ModaSystemDados.Contexto;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ModaSystemDados.Migrations
{
    [DbContext(typeof(PSqlContext))]
    [Migration("20191221015620_Migration02")]
    partial class Migration02
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("modacore")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

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
                        .HasName("CidadeId");

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
                        .HasName("CodPaisBacen");

                    b.ToTable("Paises");
                });

            modelBuilder.Entity("ModaSystemDomain.Entidades.Cidade", b =>
                {
                    b.HasOne("ModaSystemDomain.Entidades.Pais", "Pais")
                        .WithMany("Cidades")
                        .HasForeignKey("CidadeCodPais")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
