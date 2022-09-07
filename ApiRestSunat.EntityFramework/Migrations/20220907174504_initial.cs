using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ApiRestSunat.EntityFramework.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Padron_sunat_10",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Ruc = table.Column<string>(type: "VARCHAR(11)", maxLength: 11, nullable: true),
                    RazonSocial = table.Column<string>(type: "VARCHAR(200)", nullable: true),
                    Estado = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    Condicion = table.Column<string>(type: "VARCHAR(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Padron_sunat_10", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Padron_sunat_15",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Ruc = table.Column<string>(type: "VARCHAR(11)", maxLength: 11, nullable: true),
                    RazonSocial = table.Column<string>(type: "VARCHAR(200)", nullable: true),
                    Estado = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    Condicion = table.Column<string>(type: "VARCHAR(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Padron_sunat_15", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Padron_sunat_17",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Ruc = table.Column<string>(type: "VARCHAR(11)", maxLength: 11, nullable: true),
                    RazonSocial = table.Column<string>(type: "VARCHAR(200)", nullable: true),
                    Estado = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    Condicion = table.Column<string>(type: "VARCHAR(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Padron_sunat_17", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Padron_sunat_20",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Ruc = table.Column<string>(type: "VARCHAR(11)", maxLength: 11, nullable: true),
                    RazonSocial = table.Column<string>(type: "VARCHAR(200)", nullable: true),
                    Estado = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    Condicion = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    Ubigeo = table.Column<string>(type: "VARCHAR(10)", nullable: true),
                    TipoDeVia = table.Column<string>(type: "VARCHAR(20)", nullable: true),
                    NombreDeVia = table.Column<string>(type: "VARCHAR(60)", nullable: true),
                    CodigoDeZona = table.Column<string>(type: "VARCHAR(10)", nullable: true),
                    TipoDeZona = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    Numero = table.Column<string>(type: "VARCHAR(20)", nullable: true),
                    Interior = table.Column<string>(type: "VARCHAR(20)", nullable: true),
                    Lote = table.Column<string>(type: "VARCHAR(20)", nullable: true),
                    Departamento = table.Column<string>(type: "VARCHAR(20)", nullable: true),
                    Manzana = table.Column<string>(type: "VARCHAR(20)", nullable: true),
                    Kilometro = table.Column<string>(type: "VARCHAR(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Padron_sunat_20", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Padron_sunat_dni",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Dni = table.Column<string>(type: "text", nullable: true),
                    Nombres = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Padron_sunat_dni", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ubigeo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Ubigeo_reniec = table.Column<string>(type: "VARCHAR(6)", nullable: true),
                    Ubigeo_inei = table.Column<string>(type: "VARCHAR(6)", nullable: true),
                    Departamento_inei = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    Departamento = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    Provincia_inei = table.Column<string>(type: "VARCHAR(6)", nullable: true),
                    Provincia = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    Distrito = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    Region = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    Macroregion_inei = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    Macroregion_minsa = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    Iso_3166_2 = table.Column<string>(type: "VARCHAR(6)", nullable: true),
                    Fips = table.Column<string>(type: "VARCHAR(4)", nullable: true),
                    Superficie = table.Column<decimal>(type: "numeric(11,2)", nullable: false),
                    Altitud = table.Column<int>(type: "integer", nullable: false),
                    Latitud = table.Column<decimal>(type: "numeric(14,8)", nullable: false),
                    Longitud = table.Column<decimal>(type: "numeric(14,8)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ubigeo", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Padron_sunat_10");

            migrationBuilder.DropTable(
                name: "Padron_sunat_15");

            migrationBuilder.DropTable(
                name: "Padron_sunat_17");

            migrationBuilder.DropTable(
                name: "Padron_sunat_20");

            migrationBuilder.DropTable(
                name: "Padron_sunat_dni");

            migrationBuilder.DropTable(
                name: "Ubigeo");
        }
    }
}
