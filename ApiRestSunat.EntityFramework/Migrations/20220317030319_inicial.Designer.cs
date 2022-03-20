﻿// <auto-generated />
using ApiRestSunat.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ApiRestSunat.EntityFramework.Migrations
{
    [DbContext(typeof(ApiRestDbContext))]
    [Migration("20220317030319_inicial")]
    partial class inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ApiRestSunat.Domain.Models.Padron_sunat_10", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CodigoDeZona")
                        .HasColumnType("VARCHAR(10)");

                    b.Property<string>("Condicion")
                        .HasColumnType("VARCHAR(50)");

                    b.Property<string>("Departamento")
                        .HasColumnType("VARCHAR(20)");

                    b.Property<string>("Estado")
                        .HasColumnType("VARCHAR(50)");

                    b.Property<string>("Interior")
                        .HasColumnType("VARCHAR(20)");

                    b.Property<string>("Kilometro")
                        .HasColumnType("VARCHAR(20)");

                    b.Property<string>("Lote")
                        .HasColumnType("VARCHAR(20)");

                    b.Property<string>("Manzana")
                        .HasColumnType("VARCHAR(20)");

                    b.Property<string>("NombreDeVia")
                        .HasColumnType("VARCHAR(60)");

                    b.Property<string>("Numero")
                        .HasColumnType("VARCHAR(20)");

                    b.Property<string>("RazonSocial")
                        .HasColumnType("VARCHAR(200)");

                    b.Property<string>("Ruc")
                        .HasColumnType("VARCHAR(15)");

                    b.Property<string>("TipoDeVia")
                        .HasColumnType("VARCHAR(20)");

                    b.Property<string>("TipoDeZona")
                        .HasColumnType("VARCHAR(50)");

                    b.Property<string>("Ubigeo")
                        .HasColumnType("VARCHAR(10)");

                    b.HasKey("Id");

                    b.ToTable("Padron_sunat_10");
                });

            modelBuilder.Entity("ApiRestSunat.Domain.Models.Padron_sunat_20", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CodigoDeZona")
                        .HasColumnType("VARCHAR(10)");

                    b.Property<string>("Condicion")
                        .HasColumnType("VARCHAR(50)");

                    b.Property<string>("Departamento")
                        .HasColumnType("VARCHAR(20)");

                    b.Property<string>("Estado")
                        .HasColumnType("VARCHAR(50)");

                    b.Property<string>("Interior")
                        .HasColumnType("VARCHAR(20)");

                    b.Property<string>("Kilometro")
                        .HasColumnType("VARCHAR(20)");

                    b.Property<string>("Lote")
                        .HasColumnType("VARCHAR(20)");

                    b.Property<string>("Manzana")
                        .HasColumnType("VARCHAR(20)");

                    b.Property<string>("NombreDeVia")
                        .HasColumnType("VARCHAR(60)");

                    b.Property<string>("Numero")
                        .HasColumnType("VARCHAR(20)");

                    b.Property<string>("RazonSocial")
                        .HasColumnType("VARCHAR(200)");

                    b.Property<string>("Ruc")
                        .HasColumnType("VARCHAR(15)");

                    b.Property<string>("TipoDeVia")
                        .HasColumnType("VARCHAR(20)");

                    b.Property<string>("TipoDeZona")
                        .HasColumnType("VARCHAR(50)");

                    b.Property<string>("Ubigeo")
                        .HasColumnType("VARCHAR(10)");

                    b.HasKey("Id");

                    b.ToTable("Padron_sunat_20");
                });
#pragma warning restore 612, 618
        }
    }
}