﻿// <auto-generated />
using System;
using ApiRestSunat.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ApiRestSunat.EntityFramework.Migrations
{
    [DbContext(typeof(ApiRestDbContext))]
    partial class ApiRestDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ApiRestSunat.Domain.Models.Padron_sunat_10", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Condicion")
                        .HasColumnType("VARCHAR(50)");

                    b.Property<string>("Estado")
                        .HasColumnType("VARCHAR(50)");

                    b.Property<string>("RazonSocial")
                        .HasColumnType("VARCHAR(200)");

                    b.Property<string>("Ruc")
                        .HasMaxLength(11)
                        .HasColumnType("VARCHAR(11)");

                    b.HasKey("Id");

                    b.ToTable("Padron_sunat_10");
                });

            modelBuilder.Entity("ApiRestSunat.Domain.Models.Padron_sunat_15", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Condicion")
                        .HasColumnType("VARCHAR(50)");

                    b.Property<string>("Estado")
                        .HasColumnType("VARCHAR(50)");

                    b.Property<string>("RazonSocial")
                        .HasColumnType("VARCHAR(200)");

                    b.Property<string>("Ruc")
                        .HasMaxLength(11)
                        .HasColumnType("VARCHAR(11)");

                    b.HasKey("Id");

                    b.ToTable("Padron_sunat_15");
                });

            modelBuilder.Entity("ApiRestSunat.Domain.Models.Padron_sunat_17", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Condicion")
                        .HasColumnType("VARCHAR(50)");

                    b.Property<string>("Estado")
                        .HasColumnType("VARCHAR(50)");

                    b.Property<string>("RazonSocial")
                        .HasColumnType("VARCHAR(200)");

                    b.Property<string>("Ruc")
                        .HasMaxLength(11)
                        .HasColumnType("VARCHAR(11)");

                    b.HasKey("Id");

                    b.ToTable("Padron_sunat_17");
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
                        .HasMaxLength(11)
                        .HasColumnType("VARCHAR(11)");

                    b.Property<string>("TipoDeVia")
                        .HasColumnType("VARCHAR(20)");

                    b.Property<string>("TipoDeZona")
                        .HasColumnType("VARCHAR(50)");

                    b.Property<string>("Ubigeo")
                        .HasColumnType("VARCHAR(10)");

                    b.HasKey("Id");

                    b.ToTable("Padron_sunat_20");
                });

            modelBuilder.Entity("ApiRestSunat.Domain.Models.Padron_sunat_dni", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Dni")
                        .HasColumnType("text");

                    b.Property<string>("Nombres")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Padron_sunat_dni");
                });

            modelBuilder.Entity("ApiRestSunat.Domain.Models.Ubigeo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Altitud")
                        .HasColumnType("integer");

                    b.Property<string>("Departamento")
                        .HasColumnType("VARCHAR(50)");

                    b.Property<string>("Departamento_inei")
                        .HasColumnType("VARCHAR(50)");

                    b.Property<string>("Distrito")
                        .HasColumnType("VARCHAR(50)");

                    b.Property<string>("Fips")
                        .HasColumnType("VARCHAR(4)");

                    b.Property<string>("Iso_3166_2")
                        .HasColumnType("VARCHAR(6)");

                    b.Property<decimal>("Latitud")
                        .HasColumnType("numeric(14,8)");

                    b.Property<decimal>("Longitud")
                        .HasColumnType("numeric(14,8)");

                    b.Property<string>("Macroregion_inei")
                        .HasColumnType("VARCHAR(50)");

                    b.Property<string>("Macroregion_minsa")
                        .HasColumnType("VARCHAR(50)");

                    b.Property<string>("Provincia")
                        .HasColumnType("VARCHAR(50)");

                    b.Property<string>("Provincia_inei")
                        .HasColumnType("VARCHAR(6)");

                    b.Property<string>("Region")
                        .HasColumnType("VARCHAR(50)");

                    b.Property<decimal>("Superficie")
                        .HasColumnType("numeric(11,2)");

                    b.Property<string>("Ubigeo_inei")
                        .HasColumnType("VARCHAR(6)");

                    b.Property<string>("Ubigeo_reniec")
                        .HasColumnType("VARCHAR(6)");

                    b.HasKey("Id");

                    b.ToTable("Ubigeo");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
